using System;

namespace Increment_Decrement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output 0 to 10");
            for (int a = 0; a <= 10; a++)          // if a <= 10 , a++.
            {
                Console.WriteLine(a);              // output a and make a new line
            }
            Console.WriteLine();                   // make a new line
            Console.WriteLine("Output 15 to 1");  
            for(int b = 15; b > 0; --b)            // if b > 0 , --b
            {
                Console.WriteLine(b);              // output b and make a new line
            }
            Console.ReadKey();                     // finish
        }
    }
}
