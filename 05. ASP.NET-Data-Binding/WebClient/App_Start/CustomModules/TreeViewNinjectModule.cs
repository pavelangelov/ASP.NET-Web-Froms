using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebClient.Models;

namespace WebClient.App_Start.CustomModules
{
    public class TreeViewNinjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<FileDownloader>().ToSelf();
        }
    }
}