﻿using _01.ASP.NET_MVC_application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01.ASP.NET_MVC_application.Controllers
{
    public class SumController : Controller
    {
        // GET: Sum
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Sum(CalculatorModel calc)
        {
            var result = calc.Sum;
            return View("Index", calc);
        }
    }
}