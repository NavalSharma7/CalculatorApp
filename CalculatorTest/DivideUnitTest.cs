using System;
using CalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTest
{
    [TestClass]
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
        [DataRow(12, 2, 6)]
        [DataRow(40, 4, 10)]
        [DataRow(20, 1, 20)]
        [DataRow(2.66, 2, 1.33)]

        public void DivideTwoPositiveNumbers(double num1, double num2, double expected)
        {
            var result = Calculator.Divide(num1, num2);
            Assert.AreEqual(expected, result);

        }

        [DataTestMethod]
        [DataRow(-2, -1, 2)]
        [DataRow(-12, -2, 6)]
        [DataRow(-120, -10, 12)]
        [DataRow(-2.66, -2, 1.33)]

        public void DivideTwoNegativeNumbers(double num1, double num2, double expected)
        {
            var result = Calculator.Divide(num1, num2);
            Assert.AreEqual(expected, result);

        }

        [DataTestMethod]
        [DataRow(-6, 3, -2)]
        [DataRow(-12, 2, -6)]
        [DataRow(-120, 4, -30)]
        [DataRow(-1.80, 2.0, -0.90)]

        public void DivideFirstNegativeAndSecondPositiveNumber(double num1, double num2, double expected)
        {
            var result = Calculator.Divide(num1, num2);
            Assert.AreEqual(expected, result);

        }
        [DataTestMethod]
        [DataRow(10, -2, -5)]
        [DataRow(15, -3, -5)]
        [DataRow(150, -30, -5)]

        public void DivideFirstPositiveAndSecondNegativeNumber(double num1, double num2, double expected)
        {
            var result = Calculator.Divide(num1, num2);
            Assert.AreEqual(expected, result);

        }

        [DataTestMethod]
        [DataRow(200, -0.5, -400.00)]
        [DataRow(14, 2.0, 7.00)]
        [DataRow(50, 20.0, 2.50)]

        public void DivideFirstIntegerAndSecondDecimalNumber(int num1, double num2, double expected)
        {
            var result = Calculator.Divide(num1, num2);
            Assert.AreEqual(expected, result);

        }
        [DataTestMethod]
        [DataRow(21.0, -3, -7.00)]
        [DataRow(21.6, 3, 7.20)]
        [DataRow(33.33, 3, 11.11)]

        public void DivideFirstDecimalAndSecondIntegerNumber(double num1, int num2, double expected)
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

