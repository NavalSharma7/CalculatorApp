using System;
using CalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTest
{
    public class MultiplyUnitTest
    {
        //unit test methods for multiplication.

        [TestMethod]
        public void MultiplyMethodMustMultiply()
        {
            var result = Calculator.Multiply(1, 5);
            Assert.AreEqual(5, result);

        }


        

        [DataTestMethod]
        [DataRow(11, 2, 22)]
        [DataRow(40, 4, 160)]
        [DataRow(20, 19, 380)]
        [DataRow(2.33, 2, 4.66)]

        public void MultiplyTwoPositiveNumbers(double num1, double num2, double expected)
        {
            var result = Calculator.Multiply(num1, num2);
            Assert.AreEqual(expected, result);

        }

        [DataTestMethod]
        [DataRow(-1, -2, 2)]
        [DataRow(-11, -2, 22)]
        [DataRow(-120, -10, 1200)]
        [DataRow(-1.33, -2, 2.66)]

        public void MultiplyTwoNegativeNumbers(double num1, double num2, double expected)
        {
            var result = Calculator.Multiply(num1, num2);
            Assert.AreEqual(expected, result);

        }

        [DataTestMethod]
        [DataRow(-1, 3, -3)]
        [DataRow(-11, 2, -22)]
        [DataRow(-120, 4, -480)]
        [DataRow(-1.30, 2.0, -2.60)]

        public void MultiplyFirstNegativeAndSecondPositiveNumber(double num1, double num2, double expected)
        {
            var result = Calculator.Multiply(num1, num2);
            Assert.AreEqual(expected, result);

        }
        [DataTestMethod]
        [DataRow(1, -3, -3)]
        [DataRow(14, -3, -52)]
        [DataRow(50, -30, -1500)]

        public void MultiplyFirstPositiveAndSecondNegativeNumber(double num1, double num2, double expected)
        {
            var result = Calculator.Multiply(num1, num2);
            Assert.AreEqual(expected, result);

        }

    }
}
