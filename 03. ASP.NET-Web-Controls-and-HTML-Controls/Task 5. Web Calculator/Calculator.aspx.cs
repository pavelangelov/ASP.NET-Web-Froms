using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Task_5.Web_Calculator.Utils;

namespace Task_5.Web_Calculator
{
    public partial class Calculator : System.Web.UI.Page
    {
        private CalculationHelper helper;

        public Calculator()
        {
            this.helper = new CalculationHelper();
        }

        private string Operator { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void FillNumber(object sender, EventArgs e)
        {
            var clickedButton = sender as Button;
            if (Session["newOperation"] != null)
            {
                this.result.InnerText = clickedButton.Text;
                Session.Remove("newOperation");
            }
            else
            {
                this.result.InnerText += clickedButton.Text;
            }

        }

        protected void Reset(object sender, EventArgs e)
        {
            this.result.InnerText = "";
            this.Operator = null;
            Session.Remove("firstNumber");
            Session["newOperation"] = true;
        }

        protected void Sqrt(object sender, EventArgs e)
        {
            var numberStr = this.result.InnerText;
            double number;
            if (double.TryParse(numberStr, out number))
            {
                this.result.InnerText = Math.Sqrt(number).ToString();
            }
        }

        protected void SetOperator(object sender, EventArgs e)
        {
            var clickedButton = sender as Button;
            double number;
            if (double.TryParse(this.result.InnerText, out number))
            {
                Session["operator"] = clickedButton.Text;
                Session["firstNumber"] = number;
                this.result.InnerText = "";
            }
        }

        protected void Calculate(object sender, EventArgs e)
        {
            if (Session["firstNumber"] != null && Session["operator"] != null)
            {
                double firstNumber = double.Parse(Session["firstNumber"].ToString());
                double secondNumber;
                if (double.TryParse(this.result.InnerText, out secondNumber))
                {
                    var calcResult = this.helper.Calculate(firstNumber, secondNumber, Session["operator"].ToString());
                    Session["firstNumber"] = calcResult;
                    Session["newOperation"] = true;
                    this.result.InnerText = calcResult.ToString();
                }
            }
        }
    }
}