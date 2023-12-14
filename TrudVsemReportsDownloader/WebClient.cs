using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TrudVsemReportsDownloader
{
    internal class WebClient1
    {
        private string Uri { get; set; }
        private string reportName { get; set; }
        private string dest { get; set; }
        private WebClient client { get; set; }
        //------------------------------------------------------------------------------------------------
        internal void Download(string url)
        {
            //client.DownloadFile(Uri + reportName, dest);
        }
        //------------------------------------------------------------------------------------------------
        public WebClient(string uri) 
        {
            Uri = uri;
            client = new WebClient(Uri);
        }
        public void Destroy()
        {
            Uri = "";
            client = null;
        }
    }
}
