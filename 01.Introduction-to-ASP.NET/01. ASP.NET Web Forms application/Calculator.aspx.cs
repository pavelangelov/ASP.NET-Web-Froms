using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.ASP.NET_Web_Forms_application
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CalculateSum(object sender, EventArgs e)
        {
            var result = double.Parse(this.firstNumber.Value) + double.Parse(this.secondNumber.Value);
            this.result.InnerText = $"Sum: {result}";
        }
    }
}