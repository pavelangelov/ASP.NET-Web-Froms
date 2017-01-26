using System;
using NUnit.Framework;
using Task_5.Web_Calculator.Utils;

namespace Task_5.Web_Calculator.Tests
{
    [TestFixture]
    public class CalculationHelper_CalculateShould_
    {
        [Test]
        [TestCase(1, 2, "")]
        [TestCase(1, 2, "!")]
        [TestCase(1, 2, "a")]
        [TestCase(1, 2, "add")]
        [TestCase(1, 2, null)]
        public void ThrowAgumentException_IfPassedOperator_IsNotValid(double firstNumber, double secondNumber, string invalidOperator)
        {
            var helper = new CalculationHelper();

            var message = Assert.Throws<ArgumentException>(() => helper.Calculate(firstNumber, secondNumber, invalidOperator)).Message;

            Assert.IsTrue(message.Contains("operator"));
        }

        [Test]
        [TestCase(4, 2, "+", 6)]
        [TestCase(4, 2, "-", 2)]
        [TestCase(4, 2, "X", 8)]
        [TestCase(4, 2, "/", 2)]
        public void NotToThrow_IfPassedOperator_IsValid_AndReturnCorrectValue(double firstNumber, double secondNumber, string validOperator, double result)
        {
            var helper = new CalculationHelper();

            var number = helper.Calculate(firstNumber, secondNumber, validOperator);

            Assert.AreEqual(result, number);
        }

        [Test]
        [TestCase(1, 0, "/")]
        [TestCase(1, 0, "X")]
        public void NotToThrow_IfMultiplyOrDivide_ByZero_AndToReturnZero(double firstNumber, double secondNumber, string validOperator)
        {
            var helper = new CalculationHelper();

            var result = helper.Calculate(firstNumber, secondNumber, validOperator);

            Assert.IsTrue(result == 0);
        }
    }
}
