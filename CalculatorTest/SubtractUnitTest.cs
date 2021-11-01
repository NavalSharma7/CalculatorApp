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
        [DataRow(-1, -2, 1)]
        [DataRow(-11, -24, 13)]
        [DataRow(-120, -180, 60)]
        [DataRow(-1.33, -2.33, 1)]

        public void SubtractTwoNegativeNumbers(double num1, double num2, double expected)
        {
            var result = Calculator.Subtract(num1, num2);
            Assert.AreEqual(expected, result);

        }
    }
}
