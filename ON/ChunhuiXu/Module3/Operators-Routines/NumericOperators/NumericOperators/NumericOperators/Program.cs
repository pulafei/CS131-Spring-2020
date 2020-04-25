using System;
using System.Globalization;

namespace NumericOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20;                                   // input data of num1,2,3
            int num2 = 77;
            float num3 = 5.2f;

            float sum = num1 + num2 + num3;                  // Addition
            int subtract = num2 - num1;                      // Subtraction
            int multiply = num1 * num2;                      // Multiplication
            float divide = num1 / num3;                      // Division
            int modulus = num2 % num1;                       // Remainder

            Console.WriteLine("Sum if 3 numbers is : " + sum);    // output the results
            Console.WriteLine("{0} - {1} is : {2}", num2, num1, subtract);
            Console.WriteLine("{0} * {1} is : {2}", num1, num2, multiply);
            Console.WriteLine("{0} / {1} is : {2}", num1, num3, divide);
            Console.WriteLine("{0} % {1} is : {2}", num2, num1, modulus);
            Console.ReadKey();                                    // Finish
        }
    }
}
