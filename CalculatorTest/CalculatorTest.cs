using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {

        //unit test methods for addition.

        [TestMethod]
        public void AddMethodMustAdd()
        { 
            var result = Calculator.Add(1, 1);
            Assert.AreEqual(2, result);

        }


        [DataTestMethod]
        [DataRow(-1,-2,-3)]
        [DataRow(-11, -24, -35)]
        [DataRow(-120, -180, -300)]
        [DataRow(-1.33, -2.33, -3.66)]

        public void AddTwoNegativeNumbers(double num1, double num2,double expected)
        {
            var result = Calculator.Add(num1, num2);
            Assert.AreEqual(expected, result);

        }

        [DataTestMethod]
        [DataRow(-1, 3, 2)]
        [DataRow(-11, 24, 13)]
        [DataRow(-120, 80, -40)]
        [DataRow(-1.3, 2.9, 1.6)]

        public void AddNegativeAndPositiveNumbers(double num1, double num2, double expected)
        {
            var result = Calculator.Add(num1, num2);
            Assert.AreEqual(expected, result);

        }

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
        //unit test methods for division.

    }
}
