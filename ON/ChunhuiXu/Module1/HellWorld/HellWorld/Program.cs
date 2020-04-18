using System;                    // an existing code library

namespace HellWorld              // a logical qrouping of classws
{
    class Program                 // Classes provide logical groupings of data and method routines.
    {
        // Methods group instructions to complete a task. C# console applications begin in the Main() method.
        static void Main(string[] args)       
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("");

            Console.WriteLine("    /|");
            Console.WriteLine("   / |");
            Console.WriteLine("  /  |");
            Console.WriteLine(" /   |");
            Console.WriteLine("/____|");          // make a trangle
            Console.WriteLine("");                // "enter" in word

            String Name = "Chunhui Xu";
            int Age = 23;
            bool isFemale = false;               // myself

            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(isFemale);
            Console.WriteLine("");                // output my information

            double MyFloat = 10.1;
            Console.WriteLine(MyFloat);            // make a double

            string output = "HelloWorld";           // the homework
            Console.WriteLine(output);             // output "Helloworld"
            Console.ReadLine();



        
        }
    }
}
