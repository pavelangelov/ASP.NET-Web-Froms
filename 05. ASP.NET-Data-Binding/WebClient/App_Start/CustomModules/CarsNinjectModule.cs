using DataServices;
using DataServices.Contracts;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClient.App_Start.CustomModules
{
    public class CarsNinjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<ICarService>().To<CarsService>();
        }
    }
}