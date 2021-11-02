using System;
using CalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class SubtractUnitTest
    {
        //unit test methods for subtraction.

        [TestMethod]
        public void SubtractMethodMustSubtract()
        {
            var result = Calculator.Subtract(2, 1);
            Assert.AreEqual(1, result);

        }

        [DataTestMethod]
        [DataRow(11, 2, 9)]
        [DataRow(40, 24, 16)]
        [DataRow(20, 100, -80)]
       

        public void SubtractTwoPositiveNumbers(double num1, double num2, double expected)
        {
            var result = Calculator.Subtract(num1, num2);
            Assert.AreEqual(expected, result);

        }

        [DataTestMethod]
        [DataRow(-1, -2, 1)]
        [DataRow(-11, -24, 13)]
        [DataRow(-120, -180, 60)]
      

        public void SubtractTwoNegativeNumbers(double num1, double num2, double expected)
        {
            var result = Calculator.Subtract(num1, num2);
            Assert.AreEqual(expected, result);

        }

        [DataTestMethod]
        [DataRow(-1, 3, -4)]
        [DataRow(-11, 24, -35)]
        [DataRow(-120, 80, -200)]
      

        public void SubtractFirstNegativeAndSecondPositiveNumber(double num1, double num2, double expected)
        {
            var result = Calculator.Subtract(num1, num2);
            Assert.AreEqual(expected, result);

        }
        [DataTestMethod]
        [DataRow(1, -3, 4)]
        [DataRow(14, -33, 47)]
        [DataRow(551, -300, 851)]

        public void SubtractFirstPositiveAndSecondNegativeNumber(double num1, double num2, double expected)
        {
            var result = Calculator.Subtract(num1, num2);
            Assert.AreEqual(expected, result);

        }


        [DataTestMethod]
        [DataRow(2, -1.7, 3.70)]
        [DataRow(14, 3.0, 11.00)]
        [DataRow(50, 35.6, 14.40)]

        public void SubtractFirstIntegerAndSecondDecimalNumber(int num1, double num2, double expected)
        {
            var result = Calculator.Subtract(num1, num2);
            Assert.AreEqual(expected, result);

        }
        [DataTestMethod]
        [DataRow(2.0, -2, 4.00)]
        [DataRow(12.5, 3, 9.50)]
        [DataRow(11.10, 3, 8.10)]

        public void SubtractFirstDecimalAndSecondIntegerNumber(double num1, int num2, double expected)
        {
            var result = Calculator.Subtract(num1, num2);
            Assert.AreEqual(expected, result);

        }

    }
}
