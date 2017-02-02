using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebClient.Models;
using WebClient.Views;
using WebFormsMvp;

namespace WebClient.Presenters
{
    public class TreeViewPresenter : Presenter<ITreeView>
    {
        private FileDownloader fileDownloader;
        private readonly string rssUrl = "http://www.w3schools.com/xml/simple.xml";

        public TreeViewPresenter(ITreeView view, FileDownloader fileDownloader) 
            : base(view)
        {
            this.View.PageLoad += View_PageLoad;
            this.fileDownloader = fileDownloader;
        }

        private void View_PageLoad(object sender, EventArgs e)
        {
            var filePath = Server.MapPath("~/App_Data") + "/simple.xml";
            this.fileDownloader.DownloadRss(this.rssUrl, filePath);

            this.View.Model.XmlFilePath = filePath;
        }
    }
}