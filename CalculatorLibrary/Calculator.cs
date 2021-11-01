using System;

namespace CalculatorLibrary
{
    public static class Calculator
    {


        // add functions for addition, subtraction, multiplication and division

        public static double Add(double num1, double num2) {
            return num1 + num2;
        }

        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Divide(double num1, double num2)
        {
            if (num1 == 0 && num2 == 0)
            {
                return 0;
            }
            else if (num1 == 0 || num2 == 0) {

                return -1;
            }


            return num1 / num2;
        }
        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }



    }
}
