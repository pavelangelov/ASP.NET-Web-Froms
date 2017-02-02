using System;

namespace WebClient.Models
{
    public class FileDownloader
    {
        public void DownloadRss(string rssUrl, string filePath)
        {
            var webClient = new System.Net.WebClient();
            webClient.DownloadFile(rssUrl, filePath);
        }
    }
}