﻿using System.Web;
using System.Web.Mvc;

namespace _01.ASP.NET_MVC_application
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
