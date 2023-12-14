using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TrudVsemReportsDownloader
{
    internal class TrudVsemWebClient
    {
        internal static string _defaultDestinationFolder { get; } = $@"F:\загрузки\";
        private static string _defaultVacansyReportLink { get; } = "https://opendata.trudvsem.ru/csv/";
        private static string _defaultVacansyReportFilename { get; } = "vacancy_9.csv";
        internal string DestinationFolder { get; set; } = _defaultDestinationFolder;
        internal string DestinationFilename { get; set; } = _defaultDestinationFolder+ _defaultVacansyReportFilename;
        internal string VacansyReportLink { get; set; } = _defaultVacansyReportLink;
        internal string VacansyReportFilename { get; set; } = _defaultVacansyReportFilename;
        internal bool error { get; set; }
        internal string json { get; set; } = "";
        internal long received { get; set; } = 0;
        internal bool cont { get; set; } = false;
        internal Uri Uri { get; set; }
        private HttpClient httpClient;
        private HttpClientHandler httpHandler;
        private HttpResponseMessage response;
        private CookieContainer cookieContainer;
        //------------------------------------------------------------------------------------------------------
        private async Task<string> SendGet(string uri)
        {
            error = false;

            var req = new HttpRequestMessage
            {
                RequestUri = new Uri(uri),
                Method = HttpMethod.Get
            };

            //AddRefer(req);
            //AddAuthHeader(req);

            response = await httpClient.SendAsync(req, HttpCompletionOption.ResponseHeadersRead);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                //GetCookies(response);
                return await response.Content.ReadAsStringAsync();
            }
            else return "";
        }
        private async Task<string> SendPost(string uri, string body)
        {
            error = false;
            StringContent data = new StringContent(body, Encoding.UTF8, "application/json");
            var req = new HttpRequestMessage
            {
                RequestUri = new Uri(uri),
                Method = HttpMethod.Post,
                Content = data
            };

            //AddRefer(req);
            //AddAuthHeader(req);

            response = await httpClient.SendAsync(req, HttpCompletionOption.ResponseHeadersRead);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                //GetCookies(response);
                return await response.Content.ReadAsStringAsync();
            }
            else return "";
        }
        //------------------------------------------------------------------------------------------------------
        internal async Task<bool> GetFile()
        {
            cont = true;
            using (var client = new WebClient())
            {
                var sum = 0L;
                long prev = 0;

                client.DownloadProgressChanged += (sender, args) =>
                {
                    var diff = args.BytesReceived - prev;
                    sum += diff;
                    prev = args.BytesReceived;
                    received = prev;

                    Console.WriteLine($"BytesReceived: {args.BytesReceived} (diff: {diff})");
                };

                await client.DownloadFileTaskAsync(Uri, DestinationFilename);

                Console.WriteLine($"SUM :{sum}");
                Console.WriteLine($"Bytes should be: {new FileInfo(DestinationFolder).Length}");
            }
            cont=false;
            return true;
        }
        internal int GetFileSize(Uri uriPath)
        {
            var webRequest = HttpWebRequest.Create(uriPath);
            webRequest.Method = "HEAD";

            using (var webResponse = webRequest.GetResponse())
            {
                return Convert.ToInt32(Math.Round(Convert.ToDouble(webResponse.Headers.Get("Content-Length")) / 1024.0 / 1024.0, 0));
            }
        }
        /*internal void GetFile()
        {
            using (var client = new WebClient())
            {
                var sum = 0L;
                long prev = 0;

                client.DownloadProgressChanged += (sender, args) =>
                {
                    var diff = args.BytesReceived - prev;
                    sum += diff;
                    prev = args.BytesReceived;

                    Console.WriteLine($"BytesReceived: {args.BytesReceived} (diff: {diff})");
                };

                await client.DownloadFileTaskAsync(
                    new Uri("http://spatialkeydocs.s3.amazonaws.com/FL_insurance_sample.csv.zip"),
                    @"D:\temp\sample");

                Console.WriteLine($"SUM :{sum}");
                Console.WriteLine($"Bytes should be: {new FileInfo(@"D:\temp\sample").Length}");
            }
        }*/
        /*public TrudVsemWebClient(string destinationFolder, string vacansyReportLink, string vacansyReportFilename, bool error, string json, Uri uri, HttpClient httpClient, HttpClientHandler httpHandler, HttpResponseMessage response, CookieContainer cookieContainer)
        {
            DestinationFolder = destinationFolder;
            VacansyReportLink = vacansyReportLink;
            VacansyReportFilename = vacansyReportFilename;
            this.error = error;
            this.json = json;
            Uri = uri;
            this.httpClient = httpClient;
            this.httpHandler = httpHandler;
            this.response = response;
            this.cookieContainer = cookieContainer;
        }*/
        public TrudVsemWebClient()
        {
            Uri = new Uri(VacansyReportLink + VacansyReportFilename);
        }
    }
}
