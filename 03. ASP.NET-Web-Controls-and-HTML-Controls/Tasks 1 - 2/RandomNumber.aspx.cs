using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tasks_1___2.Utils;

namespace Tasks_1___2
{

    public partial class RandomNumber : System.Web.UI.Page
    {
        private string InvalidInputMessage = "Min value cannot be greater than Max value!";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GenerateRandomNumber(object sender, EventArgs e)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            if (!int.TryParse(this.FirstNumber.Text, out firstNumber) || !int.TryParse(this.SecondNumber.Text, out secondNumber))
            {
                this.Result.Text = $"Please enter only real numbers, less than {int.MaxValue}";
                return;
            }

            if (firstNumber > secondNumber)
            {
                this.Result.Text = this.InvalidInputMessage;
            }
            else
            {
                var rand = new RandomGenerator();
                var number = rand.RandomNumber(firstNumber, secondNumber);
                this.Result.Text = $"Generated number in range[{firstNumber} - {secondNumber}] is: {number}";
            }
        }
    }
}