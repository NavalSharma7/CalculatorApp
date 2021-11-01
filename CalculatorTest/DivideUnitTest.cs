using System;
using CalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTest
{
    public class DivideUnitTest
    {
        //unit test methods for division.

        [TestMethod]
        public void DivideMethodMustDivide()
        {
            var result = Calculator.Divide(10, 2);
            Assert.AreEqual(5, result);

        }


        [DataTestMethod]
        [DataRow(-1, -2, 0.5)]
        [DataRow(-12, -24, 0.5)]
        [DataRow(-120, -180, 0.67)]
        [DataRow(-1.5, -2.5, 0.6)]

        public void DivideTwoNegativeNumbers(double num1, double num2, double expected)
        {
            var result = Calculator.Divide(num1, num2);
            Assert.AreEqual(expected, result);

        }

        [DataTestMethod]
        [DataRow(-1, 0, -1)]
        [DataRow(0, 24, -1)]
        [DataRow(0, 0, -1)]
        public void DivideWithZero(double num1, double num2, double expected)
        {
            var result = Calculator.Divide(num1, num2);
            Assert.AreEqual(expected, result);
        }

    }
}

