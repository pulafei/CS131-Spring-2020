using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentence = new string[4]; //creating a new array of type integer named 'numbers'
            sentence [0] = "This";
            sentence [1] = "is";
            sentence [2] = "a";
            sentence [3] = "string";
            
            foreach (string word in sentence)
            {
                Console.Write(word + " ");            
            }
            Console.WriteLine();
        }
    }
}
