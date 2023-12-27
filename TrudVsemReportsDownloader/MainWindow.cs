using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.VisualBasic.FileIO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Linq;

namespace TrudVsemReportsDownloader
{
    public partial class MainWindow : Form
    {
        internal static MainWindow mainWindow;
        private static readonly HttpClient _client = new HttpClient();
        private CancellationTokenSource _cts;
        private string _csvDelimiter;
        private string _link;
        private string _downloadFilename;
        private string _resultsFilename;
        private string _destinationFolder;
        private string _resultsFolder;
        private string _filterColumn;
        private string _resultedColumns;
        private string _filterValue;
        private string[] _defaultHeaderRow;
        private string _defaultXLSDelimiter;
        private string _innColumnName;
        private long[] _companyesInn;
        private int _filterColumnPos = 0;
        private int[] _resultColWidth;
        private bool _resultsFilenameAppendDate;
        public MainWindow()
        {
            mainWindow = this;
            InitializeComponent();
            InitializeSettings();
        }
        private void InitializeSettings()
        {
            PresetDefaulVariables();
            if ((!CheckFolderExists(_destinationFolder))||(_companyesInn==null))
            {
                tsmiSettings_Click(null,null);
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------
        private bool CheckFolderExists(string folder)
        {
            return Directory.Exists(folder);
        }
        internal void PresetDefaulVariables()
        {
            _csvDelimiter = Properties.Settings.Default._csvDelimiter;
            _link = Properties.Settings.Default._link;
            _downloadFilename = Path.GetFileName(Properties.Settings.Default._link);
            _resultsFilename = Properties.Settings.Default._resultsFilename;
            _resultsFilenameAppendDate = Properties.Settings.Default._resultFilenameAppendDate;
            if (_resultsFilenameAppendDate)
            {
                string ext=Path.GetExtension(Properties.Settings.Default._resultsFilename);
                string name=Path.GetFileNameWithoutExtension(Properties.Settings.Default._resultsFilename);

                _resultsFilename = string.Concat(name," ", DateTime.Now.ToShortDateString(), ext);
            }
            _destinationFolder = Properties.Settings.Default._destinationFolder;
            _resultsFolder = Properties.Settings.Default._resultsFolder;
            _filterColumn = Properties.Settings.Default._filterColumn;
            _resultedColumns = Properties.Settings.Default._resultedColumns;
            _filterValue = Properties.Settings.Default._filterValue;
            _defaultHeaderRow = Properties.Settings.Default._defaultHeaderRow.Split(',');
            _defaultXLSDelimiter = Properties.Settings.Default._defaultXLSDelimiter;
            _innColumnName = Properties.Settings.Default._innColumnName;
            _resultsFilenameAppendDate = Properties.Settings.Default._resultFilenameAppendDate;
            _companyesInn = null;
            if (Properties.Settings.Default._companyesInn.Length > 0)
            {
                string[] temp = Properties.Settings.Default._companyesInn.Split(',');
                _companyesInn = new long[temp.Length];
                int i = 0;
                foreach (string s in temp)
                {
                    _companyesInn[i++] = Convert.ToInt64(s);
                }
            }
            _resultColWidth = null;
            if (Properties.Settings.Default._defaultResultColWidth.Length > 0)
            {
                string[] temp = Properties.Settings.Default._defaultResultColWidth.Split(',');
                _resultColWidth = new int[temp.Length];
                int i = 0;
                foreach (string s in temp)
                {
                    _resultColWidth[i++] = Convert.ToInt32(s);
                }
            }
        }
        private long GetFreeSpace(string drive)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                if (d.Name == drive) { return d.AvailableFreeSpace; }
            }
            return 0;
        }
        internal long GetFileSize(Uri uriPath)
        {
            var webRequest = HttpWebRequest.Create(uriPath);
            webRequest.Method = "HEAD";

            using (var webResponse = webRequest.GetResponse())
            {
                return Convert.ToInt64(webResponse.Headers.Get("Content-Length"));
            }
        }
        private bool CheckFreeSpace(long avail,long filesize)
        {
            return avail > filesize;
        }
        //----------------------------------------------------------------------------------------------------------------------------------
        private void InitStatus(bool isVisible = true, int max = 0)
        {
            pbStatus.Visible = isVisible;
            pbStatus.Maximum = max;
            lStatus.Visible = isVisible;
        }
        private void InitStatusAsync(bool isVisible=true, int max = 0)
        {
            pbStatus.Invoke(new Action(() => pbStatus.Visible = isVisible));
            pbStatus.Invoke(new Action(() => pbStatus.Maximum = max));
            lStatus.Invoke(new Action(() => lStatus.Visible = isVisible));
        }
        private void UpdateStatus(int v,string status="") 
        {
            pbStatus.Value = v;
            lStatus.Text=status;
        }
        private void UpdateStatusAsync(int v, string status = "")
        {
            pbStatus.Invoke(new Action(() => pbStatus.Value = v));
            lStatus.Invoke(new Action(() => lStatus.Text = status));
        }
        private void InitInfoLabelAsync(Label label,bool init=true)
        {
            label.Invoke(new Action(() => label.Visible = init));
        }
        private void ShowInfoAsync(Label label,string info)
        {
            label.Invoke(new Action(() => label.Text = info));
        }
        private void ResultMessage(string message)
        {
            MessageBox.Show(message);
        }
        //----------------------------------------------------------------------------------------------------------------------------------
        private long GetCSVSize(string csv)
        {
            UpdateStatusAsync(0, $@"Чтение файла");
            long count = File.ReadAllLines(csv).Length;
            UpdateStatusAsync(0);
            return count;
        }
        private int GetFilterColumnPosition(string[] columns)
        {
            return Array.IndexOf(columns, _filterColumn);
        }
        private async Task<bool> CheckCSVField(string[] fields)
        {
            if (fields[_filterColumnPos] != _filterValue) return false;
            return true;
        }
        private int[] GetColumnsOrder(string[] columns, string[] order)
        {
            int[] newOrder= new int[order.Length];

            for(int i=0; i < columns.Length; i++)
            {
                if (order.Contains(columns[i]))
                {
                    newOrder[Array.IndexOf(order, columns[i])] = i;
                }
            }

            return newOrder;
        }
        private string[] ConvertFieldsToNewOrder(string[] fields, int[] order)
        {
            if (order == null) return null;
            string[] newFields = new string[order.Length];
            for (int i = 0; i < newFields.Length; i++)
            {
                newFields[i]= fields[order[i]];
            }
            return newFields;
        }
        private async Task CreateTempCSV(string csv,string resultFile)
        {
            using (var parser = new TextFieldParser(csv))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(_csvDelimiter);
                long csvSize = GetCSVSize(csv);

                int i = 0;
                int filtredRows = 0;
                int progress = -1;
                int oldProgress;

                using (var w = new StreamWriter(resultFile))
                {
                    InitInfoLabelAsync(lInfo1);
                    ShowInfoAsync(lInfo1, $@"Всего строк в файле {csvSize}");

                    InitInfoLabelAsync(lInfo2);
                    InitInfoLabelAsync(lInfo3);
                    ShowInfoAsync(lInfo2, "");
                    ShowInfoAsync(lInfo3, "");

                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();
                        if (i == 0)
                        {
                            //обработка строки заголовков
                            _filterColumnPos = GetFilterColumnPosition(fields);
                            w.WriteLine(string.Join(_csvDelimiter, fields));
                        }
                        else
                        {
                            if (await CheckCSVField(fields))
                            {
                                w.WriteLine(string.Join(_csvDelimiter, fields));
                                ShowInfoAsync(lInfo3, $@"Найдено подходящих строк {++filtredRows}");
                            }
                        }
                        i++;
                        ShowInfoAsync(lInfo2, $@"Обрабатываемая строка {i}/{csvSize}");
                        w.FlushAsync().Wait();

                        oldProgress = progress;
                        progress = (int)(i * 100 / csvSize);
                        // так как значение от 0 до 100, нет особого смысла повторно обновлять интерфейс, если значение не изменилось.
                        if (oldProgress != progress)
                        {
                            UpdateStatusAsync(progress, $@"Обработка файла {progress}%");
                        }
                    }
                }
                //InitInfoLabelAsync(lInfo1, false);
                ShowInfoAsync(lInfo2, $@"Всего найдено {filtredRows} строк удовлетворяющих условиям.");
                InitInfoLabelAsync(lInfo2, false);
                InitInfoLabelAsync(lInfo3, false);
            }
        }
        private async Task ConvertToXLSX(string csv, string resultXLSX)
        {
            using (var parser = new TextFieldParser(csv))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.HasFieldsEnclosedInQuotes = false;
                parser.SetDelimiters(_csvDelimiter);
                long csvSize = GetCSVSize(csv);

                int i = 0;
                
                int progress = -1;
                int oldProgress;

                Excel.Application excel = new Excel.Application();
                excel.SheetsInNewWorkbook = 1;
                Excel.Workbook workBook = excel.Workbooks.Add(Type.Missing);
                excel.DisplayAlerts = false;
                Excel.Worksheet sheet = (Excel.Worksheet)excel.Worksheets.get_Item(1);
                sheet.Name = "Вакансии";
                //заполняем первую строку
                sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, _defaultHeaderRow.Length]].Value2 = _defaultHeaderRow;
                sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, _defaultHeaderRow.Length]].Cells.Font.Bold = true;
                sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, _defaultHeaderRow.Length]].VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, _defaultHeaderRow.Length]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                InitInfoLabelAsync(lInfo1);
                ShowInfoAsync(lInfo1, $@"Всего строк в файле {csvSize}");

                InitInfoLabelAsync(lInfo2);
                InitInfoLabelAsync(lInfo3);
                ShowInfoAsync(lInfo2, "");
                ShowInfoAsync(lInfo3, "");

                int[] columnsOrder = null;
                int columnINN = -1;
                int filtredRows = 2;

                while (!parser.EndOfData)
                {
                    string[] fields = null;
                    try
                    {
                        fields = parser.ReadFields();
                    }
                    catch (MalformedLineException e) { UpdateStatusAsync(progress, $@"Ошибка чтения файла {e.Message}"); }
                    if (i == 0)
                    {
                        columnsOrder = GetColumnsOrder(fields, _resultedColumns.Split(','));
                        columnINN = Array.IndexOf(fields, _innColumnName);
                    }
                    else
                    {
                        if ((columnINN != -1) & (_companyesInn.Contains(Convert.ToInt64(fields[columnINN]))))
                        {
                            string[] newFields = ConvertFieldsToNewOrder(fields, columnsOrder);
                            SaveToXLS(newFields, ref sheet, filtredRows++, 1);
                            //w.WriteLine(string.Join(_defaultXLSDelimiter, newFields));
                        }
                    }

                    i++;
                    ShowInfoAsync(lInfo2, $@"Обрабатываемая строка {i}/{csvSize}");
                    //w.FlushAsync().Wait();

                    oldProgress = progress;
                    progress = (int)(i * 100 / csvSize);
                    // так как значение от 0 до 100, нет особого смысла повторно обновлять интерфейс, если значение не изменилось.
                    if (oldProgress != progress)
                    {
                        UpdateStatusAsync(progress, $@"Обработка файла {progress}%");
                    }

                    ShowInfoAsync(lInfo3, $@"Всего найдено {filtredRows} строк.");
                }

                ShowInfoAsync(lInfo1, $@"Всего найдено {filtredRows} строк.");

                InitInfoLabelAsync(lInfo2, false);
                InitInfoLabelAsync(lInfo3, false);

                UpdateStatusAsync(0,"Форматирование текста...");

                //выставляем ширину столбцов
                int j = 0;
                foreach (int k in _resultColWidth){
                    sheet.Columns[++j].ColumnWidth = k;
                }
                //выставляем высоту
                sheet.Range[sheet.Cells[1, 1], sheet.Cells[--filtredRows, _defaultHeaderRow.Length]].EntireRow.AutoFit();
                //выставляем рамки вокруг таблицы
                sheet.Range[sheet.Cells[1, 1], sheet.Cells[filtredRows, _defaultHeaderRow.Length]].Borders.Weight = Excel.XlBorderWeight.xlThin;
                sheet.Range[sheet.Cells[1, 1], sheet.Cells[filtredRows, _defaultHeaderRow.Length]].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                sheet.Range[sheet.Cells[1, 1], sheet.Cells[filtredRows, _defaultHeaderRow.Length]].Borders.ColorIndex = 0;
                
                sheet.Range[sheet.Cells[2, 1], sheet.Cells[filtredRows, _defaultHeaderRow.Length]].VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                sheet.Range[sheet.Cells[2, 1], sheet.Cells[filtredRows, _defaultHeaderRow.Length]].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                //перенос по словам
                sheet.Range[sheet.Cells[1, 1], sheet.Cells[filtredRows, _defaultHeaderRow.Length]].WrapText = true;
                //сохраняем
                UpdateStatusAsync(0, "Сохранение...");
                excel.Application.ActiveWorkbook.SaveAs(resultXLSX);
                excel.Application.ActiveWorkbook.Close();

                InitStatusAsync(false, 0);
            }
        }
        private void SaveToXLS(string[] fields,ref Excel.Worksheet sheet,int startRow,int startCol)
        {
            sheet.Range[sheet.Cells[startRow,startCol], sheet.Cells[startRow, startCol+ fields.Length-1]].Value2= fields;
        }
        //----------------------------------------------------------------------------------------------------------------------------------
        private async Task DownloadFileAsync(string url, string path, IProgress<int> status, CancellationToken token)
        {
            const int bufferLength = 8192;
            long currentPosition = File.Exists(path) ? new FileInfo(path).Length : 0;

            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url))
            {
                request.Headers.Range = new RangeHeaderValue(currentPosition, null);
                using (HttpResponseMessage response = await _client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, token).ConfigureAwait(false))
                {
                    response.EnsureSuccessStatusCode();
                    using (Stream responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                    using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.None))
                    {
                        long contentLength = currentPosition + response.Content.Headers.ContentLength ?? 0;
                        int progress = -1;
                        int oldProgress;
                        byte[] buffer = new byte[bufferLength];
                        int bytesReceived;
                        while ((bytesReceived = await responseStream.ReadAsync(buffer, 0, bufferLength, token).ConfigureAwait(false)) > 0)
                        {
                            await fs.WriteAsync(buffer, 0, bytesReceived, token).ConfigureAwait(false);

                            currentPosition += bytesReceived;
                            oldProgress = progress;
                            progress = (int)(currentPosition * 100 / contentLength);
                            // так как значение от 0 до 100, нет особого смысла повторно обновлять интерфейс, если значение не изменилось.
                            if (oldProgress != progress)
                            {
                                status?.Report(progress);
                            }
                        }
                    }
                }
            }
        }
        private async Task ParseCSV(string csv,string resultFile)
        {
            if (File.Exists(resultFile)) { File.Delete(resultFile); }
            await CreateTempCSV(csv, Path.Combine(_resultsFolder, "temp.csv"));
            await ConvertToXLSX(Path.Combine(_resultsFolder, "temp.csv"), resultFile);
            File.Delete(Path.Combine(_resultsFolder, "temp.csv"));

            //Process.Start(Path.GetFullPath(resultFile));
        }
        //----------------------------------------------------------------------------------------------------------------------------------
        private async void bDownload_Click(object sender, EventArgs e)
        {
            if (_cts != null) return;
            if (File.Exists(Path.Combine(_resultsFolder, _downloadFilename))) { File.Delete(Path.Combine(_resultsFolder, _downloadFilename)); }
            using (_cts = new CancellationTokenSource())
            {
                if (!CheckFreeSpace(GetFreeSpace(Path.GetPathRoot(_destinationFolder)), GetFileSize(new Uri(_link)))) return;
                InitStatusAsync(true, 100);
                try
                {
                    // укажите здесь нужный URL и путь к файлу
                    // обратите внимение на new Progress<int>(v => progressBar1.Value = v) - оно и меняет значение прогресс бара во время загрузки
                    await DownloadFileAsync(_link, _destinationFolder+ _downloadFilename, new Progress<int>(v => UpdateStatus(v,$@"Загрузка файла {v}%")), _cts.Token);
                    bParse.Enabled = true;
                }
                catch (OperationCanceledException) { }
                catch (HttpRequestException ex)
                {
                    if (ex.Message.Contains("416")) // 416 (Requested Range Not Satisfiable)
                    {
                        MessageBox.Show("Файл уже закачан");
                    }
                    else
                    {
                        MessageBox.Show(ex.ToString(), "HttpRequestException");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), ex.GetType().Name);
                }
            }
            _cts = null;
            InitStatusAsync(false, 0);
        }

        private void tsmiSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(_resultsFolder, _downloadFilename))) { bParse.Enabled = true; }
        }

        private void bParse_Click(object sender, EventArgs e)
        {
            Thread parseThread = new Thread(() =>
            {
                InitStatusAsync(true,100);
                ParseCSV(Path.Combine(_destinationFolder, _downloadFilename),Path.Combine(_resultsFolder, _resultsFilename));
                InitStatusAsync(false,0);
            });

            parseThread.IsBackground = true; // this makes sure the thread will be stopped after the gui is closed
            parseThread.Start();
            
        }
    }
}
