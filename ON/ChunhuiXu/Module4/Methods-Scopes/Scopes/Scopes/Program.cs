using System;

namespace Scopes
{
    class Program
    {
        public static string Str2; // "Str2" is null
        static void ReturnString(string Str1)
        {
        
            string Str2 = "Programming in C#";
            Console.Write(Str1);
            Console.WriteLine(Str2);
        }
        static void Main(string[] args)
        {
            ReturnString("CS131 ");
            Console.WriteLine(Str2);
        }
    }
}
