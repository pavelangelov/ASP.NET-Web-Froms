using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace _01_ASP.NET_Single_Page_application.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
