using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrudVsemReportsDownloader
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }
        private string AppendDirectorySeparator(string path)
        {
            char lastChar = path[path.Length - 1];
            if (path == null) return path;
            if (path.IndexOf(Path.DirectorySeparatorChar) > -1)
            {
                if (lastChar != Path.DirectorySeparatorChar) { return path + Path.DirectorySeparatorChar; }
                else return path;
            }
            else
            {
                if (lastChar != Path.AltDirectorySeparatorChar) { return path + Path.AltDirectorySeparatorChar; }
                else return path;
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------
        private void SaveInfo()
        {
            if (tbDownloadFolderPath.Text.Length > 0) Properties.Settings.Default._destinationFolder=AppendDirectorySeparator(tbDownloadFolderPath.Text);
            /*if ((tbDownloadFolderPath.Text.Length>0)&(tbDownloadFolderPath.Text[tbDownloadFolderPath.Text.Length - 1] == Path.DirectorySeparatorChar))
            {
                Properties.Settings.Default._destinationFolder = tbDownloadFolderPath.Text;
            }
            else { Properties.Settings.Default._destinationFolder = tbDownloadFolderPath.Text+ Path.DirectorySeparatorChar; }*/
            if (tbResultsFolderPath.Text.Length > 0) Properties.Settings.Default._resultsFolder = AppendDirectorySeparator(tbResultsFolderPath.Text);
            /*if ((tbResultsFolderPath.Text.Length>0)&(tbResultsFolderPath.Text[tbResultsFolderPath.Text.Length - 1] == Path.DirectorySeparatorChar))
            {
                Properties.Settings.Default._resultsFolder = tbResultsFolderPath.Text;
            }
            else { Properties.Settings.Default._resultsFolder = tbResultsFolderPath.Text+ Path.DirectorySeparatorChar; }*/
            if (tbDownloadLink.Text.Length > 0)
            {
                Properties.Settings.Default._link=tbDownloadLink.Text;
            }
            if (tbResultsFilename.Text.Length > 0)
            {
                Properties.Settings.Default._resultsFilename=tbResultsFilename.Text;
            }
            if (tbCSVDelimiter.Text.Length > 0)
            {
                Properties.Settings.Default._csvDelimiter= tbCSVDelimiter.Text;
            }
            if (tbFilterField.Text.Length > 0)
            {
                Properties.Settings.Default._csvDelimiter= tbCSVDelimiter.Text;
            }
            if (tbINNList.Text.Length > 0)
            {
                Properties.Settings.Default._companyesInn = tbINNList.Text;
            }
            if (tbFilterValue.Text.Length > 0)
            {
                Properties.Settings.Default._csvDelimiter= tbCSVDelimiter.Text;
            }
            Properties.Settings.Default._resultFilenameAppendDate = cbAppendDate.Checked;

            Properties.Settings.Default.Save();
        }
        private void BrowseFolder(TextBox textBox)
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = folderDialog.SelectedPath;
            }
        }
        private void ExploreFolder(TextBox textBox)
        {
            if (textBox.Text.Length > 0) { Process.Start(textBox.Text); }
        }
        private void bSave_Click(object sender, EventArgs e)
        {
            SaveInfo();
            MainWindow.mainWindow.PresetDefaulVariables();
            bExit_Click(sender, e);
        }
        //----------------------------------------------------------------------------------------------------------------------------------
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            tbDownloadFolderPath.Text = Properties.Settings.Default._destinationFolder;
            tbResultsFolderPath.Text = Properties.Settings.Default._resultsFolder;
            tbDownloadLink.Text = Properties.Settings.Default._link;
            tbResultsFilename.Text = Properties.Settings.Default._resultsFilename;
            tbCSVDelimiter.Text = Properties.Settings.Default._csvDelimiter;
            tbFilterField.Text = Properties.Settings.Default._filterColumn;
            tbINNList.Text = Properties.Settings.Default._companyesInn;
            tbFilterValue.Text = Properties.Settings.Default._filterValue;
            cbAppendDate.Checked = Properties.Settings.Default._resultFilenameAppendDate;
        }
        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void bBrowseDownloadFolder_Click(object sender, EventArgs e)
        {
            BrowseFolder(tbDownloadFolderPath);
        }
        private void bBrowseResultsFolder_Click(object sender, EventArgs e)
        {
            BrowseFolder(tbResultsFolderPath);
        }
        private void bExploreDownloadFolder_Click(object sender, EventArgs e)
        {
            ExploreFolder(tbDownloadFolderPath);
        }
        private void bExploreResultsFolder_Click(object sender, EventArgs e)
        {
            ExploreFolder(tbResultsFolderPath);
        }
    }
}
