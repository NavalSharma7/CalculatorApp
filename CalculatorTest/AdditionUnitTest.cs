using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;

namespace UnitTest
{
    [TestClass]
    public class AdditionUnitTest
    {

        //unit test methods for addition.

        [TestMethod]
        public void AddMethodMustAdd()
        {
            var result = Calculator.Add(1, 1);
            Assert.AreEqual(2, result);

        }

        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(11, 24, 35)]
        [DataRow(120, 180, 300)]
        [DataRow(1.33, 2.33, 3.66)]

        public void AddTwoPositiveNumbers(double num1, double num2, double expected)
        {
            var result = Calculator.Add(num1, num2);
            Assert.AreEqual(expected, result);

        }

        [DataTestMethod]
        [DataRow(-1, -2, -3)]
        [DataRow(-11, -24, -35)]
        [DataRow(-120, -180, -300)]
        [DataRow(-1.33, -2.33, -3.66)]

        public void AddTwoNegativeNumbers(double num1, double num2, double expected)
        {
            var result = Calculator.Add(num1, num2);
            Assert.AreEqual(expected, result);

        }

        [DataTestMethod]
        [DataRow(-1, 3, 2)]
        [DataRow(-11, 24, 13)]
        [DataRow(-120, 80, -40)]
        [DataRow(-1.30, 2.90, 1.60)]

        public void AddFirstNegativeAndSecondPositiveNumber(double num1, double num2, double expected)
        {
            var result = Calculator.Add(num1, num2);
            Assert.AreEqual(expected, result);

        }
        [DataTestMethod]
        [DataRow(1, -3, -2)]
        [DataRow(14, -33, -19)]
        [DataRow(551, -300, 251)]

        public void AddFirstPositiveAndSecondNegativeNumber(double num1, double num2, double expected)
        {
            var result = Calculator.Add(num1, num2);
            Assert.AreEqual(expected, result);

        }


        [DataTestMethod]
        [DataRow(1, 3.14, 4.14)]
        [DataRow(14, 3.3, 17.3)]
        [DataRow(551, 3.6, 554.6)]
        public void AddIntegerAndDecimalNumber(int num1, double num2, double expected)
        {
            var result = Calculator.Add(num1, num2);
            Assert.AreEqual(expected, result);
        }


    }
}
