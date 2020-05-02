using System;
using System.Reflection.Metadata.Ecma335;

namespace Methods
{
    class Program
    {
        // this is a method called "PrintSorthing"
        public static void PrintSomething()
        {
            Console.WriteLine("Hello World!");
        }

        // a method called "Adding"
        public static int Adding(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;   // make a sum and return
        }
        // Challenge
        // a method called "Mod"
        public static double Mod(double a, double b = 1)
        {
            double div = a / b;
            return div;        // after a/b, return div
        }
        // this is a method called "Main"
        static void Main(string[] args)
        {
            // PrintSomething();  // method "PrintSomething" 
            Console.WriteLine(Adding(10, 20));  // output the result of "Adding"


            Console.WriteLine(Mod(20, 13));  // output the result of "Mod"
            Console.ReadKey();      // finish
           

        }
    }
}
