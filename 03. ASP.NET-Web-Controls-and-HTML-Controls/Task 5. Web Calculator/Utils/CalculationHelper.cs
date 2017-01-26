using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task_5.Web_Calculator.Utils
{
    public class CalculationHelper
    {
        public double Calculate(double firstNumber, double secondNumber, string operation)
        {
            switch (operation)
            {
                case "+":
                    return firstNumber + secondNumber;
                case "-":
                    return firstNumber - secondNumber;
                case "X":
                    return firstNumber * secondNumber;
                case "/":
                    if (firstNumber == 0 || secondNumber == 0)
                    {
                        return 0;
                    }

                    return firstNumber / secondNumber;
                default:
                    throw new ArgumentException("Invalid operator");
            }
        }
    }
}