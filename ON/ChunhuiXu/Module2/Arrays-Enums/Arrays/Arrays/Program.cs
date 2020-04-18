using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];  // create a array
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            Console.WriteLine(numbers[1]);
            Console.WriteLine();

            //print out all the numbers

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            foreach(int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            string[] Sentence = new string[4];
            Sentence[0] = "This";
            Sentence[1] = "is";
            Sentence[2] = "a";
            Sentence[3] = "string";
            foreach(string word in Sentence)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine(".");
            Console.ReadKey();

        }
    }
}
