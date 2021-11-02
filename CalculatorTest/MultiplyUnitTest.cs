using System;
using CalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTest
{
    [TestClass]
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
        

        public void MultiplyTwoPositiveNumbers(double num1, double num2, double expected)
        {
            var result = Calculator.Multiply(num1, num2);
            Assert.AreEqual(expected, result);

        }

        [DataTestMethod]
        [DataRow(-1, -2, 2)]
        [DataRow(-11, -2, 22)]
        [DataRow(-120, -10, 1200)]
        
        public void MultiplyTwoNegativeNumbers(double num1, double num2, double expected)
        {
            var result = Calculator.Multiply(num1, num2);
            Assert.AreEqual(expected, result);

        }

        [DataTestMethod]
        [DataRow(-1, 3, -3)]
        [DataRow(-11, 2, -22)]
        [DataRow(-120, 4, -480)]
        

        public void MultiplyFirstNegativeAndSecondPositiveNumber(double num1, double num2, double expected)
        {
            var result = Calculator.Multiply(num1, num2);
            Assert.AreEqual(expected, result);

        }
        [DataTestMethod]
        [DataRow(1, -3, -3)]
        [DataRow(14, -3, -42)]
        [DataRow(50, -30, -1500)]

        public void MultiplyFirstPositiveAndSecondNegativeNumber(double num1, double num2, double expected)
        {
            var result = Calculator.Multiply(num1, num2);
            Assert.AreEqual(expected, result);

        }

        [DataTestMethod]
        [DataRow(2, -3.7, -7.40)]
        [DataRow(14, 3.0, 42.00)]
        [DataRow(50, 30.0, 1500.00)]

        public void MultiplyFirstIntegerAndSecondDecimalNumber(int num1, double num2, double expected)
        {
            var result = Calculator.Multiply(num1, num2);
            Assert.AreEqual(expected, result);

        }
        [DataTestMethod]
        [DataRow(2.0, -37, -74.00)]
        [DataRow(12.5, 3, 37.50)]
        [DataRow(11.10, 3, 33.30)]

        public void MultiplyFirstDecimalAndSecondIntegerNumber(double num1, int num2, double expected)
        {
            var result = Calculator.Multiply(num1, num2);
            Assert.AreEqual(expected, result);

        }

        [DataTestMethod]
        [DataRow(1, 0, 0)]
        [DataRow(0, -3, 0)]
        [DataRow(0, 0, 0)]
        public void MultiplyByZero(double num1, double num2, double expected) {
            var result = Calculator.Multiply(num1, num2);
            Assert.AreEqual(expected,result);
        }

    }
}
