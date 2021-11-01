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
        [DataRow(-1, -2, 2)]
        [DataRow(-11, -4, 44)]
        [DataRow(-100, -180, 18000)]
        [DataRow(-1.1, -2.0, 2.2)]

        public void MultiplyTwoNegativeNumbers(double num1, double num2, double expected)
        {
            var result = Calculator.Multiply(num1, num2);
            Assert.AreEqual(expected, result);

        }
    }
}
