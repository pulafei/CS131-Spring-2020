using System;

namespace NumericOperators
{
    class NumericOperators
    {
        static void Main(string[] args)
        {
            // initializing values
            int num1 = 20;
            int num2 = 77;
            float num3 = 5.2f;

            float sum = num1 + num2 + num3; // calculating the sum of the 3 numbers
            int subtract = num2 - num1; // calculating the difference between num2 and num1
            int multiply = num1 * num2; // calculating the product between num1 and num2
            float divide = num1 / num3; // calculating the quotient of num1 and num3
            int modulus = num2 % num1; // calculating the remainder of num2 and num1

            // printing outputs of the operations
            Console.WriteLine("Sum of 3 numbers is: " + sum);
            Console.WriteLine("77 - 20 is: " + subtract);
            Console.WriteLine("20 * 77 is: " + multiply);
            Console.WriteLine("20 / 5.2 is: " + divide);
            Console.WriteLine("77 % 20 is: " + modulus);
        }
    }
}
