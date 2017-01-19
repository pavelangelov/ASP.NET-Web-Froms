using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01.ASP.NET_MVC_application.Models
{
    public class CalculatorModel
    {
        public double FirstNumber { get; set; }

        public double SecondNumber { get; set; }

        public string Sum
        {
            get
            {
                return (this.FirstNumber + this.SecondNumber).ToString();
            }
        }

        public bool ShowResult { get; set; }
    }
}