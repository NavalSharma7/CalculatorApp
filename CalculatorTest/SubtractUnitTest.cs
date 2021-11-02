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
        [DataRow(2.33, 1.33, 1.00)]

        public void SubtractTwoPositiveNumbers(double num1, double num2, double expected)
        {
            var result = Calculator.Subtract(num1, num2);
            Assert.AreEqual(expected, result);

        }

        [DataTestMethod]
        [DataRow(-1, -2, 1)]
        [DataRow(-11, -24, 13)]
        [DataRow(-120, -180, 60)]
        [DataRow(-1.33, -2.33, 1)]

        public void SubtractTwoNegativeNumbers(double num1, double num2, double expected)
        {
            var result = Calculator.Subtract(num1, num2);
            Assert.AreEqual(expected, result);

        }

        [DataTestMethod]
        [DataRow(-1, 3, -4)]
        [DataRow(-11, 24, -35)]
        [DataRow(-120, 80, -200)]
        [DataRow(-1.30, 2.30,-3.60 )]

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

         

       
    }
}
