using DataServices;
using DataServices.Contracts;
using DataServices.Data;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClient.App_Start.CustomModules
{
    public class EmployeesNinjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<NORTHWNDEntities>().ToSelf();
            this.Bind<IEmployeeDbContext>().To<EmployeesService>();
        }
    }
}