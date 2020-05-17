using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string Welcome = "Welcome to ";
            string CourseName = "CS131";
            string message = Welcome + CourseName; //concatenate strings
            string message1 = string.Concat(Welcome, CourseName); //concatenate string using concat()
            string message2 = $"Priting the strings for the second time: {Welcome} {CourseName}"; //concat string by substitutes values of variables into placeholders in a string
            string message3 = Welcome.ToUpper() + CourseName.ToLower();//concatenate strings

            Console.WriteLine(message);
            Console.WriteLine(message1);
            Console.WriteLine(message2);
            Console.WriteLine(message3);
            Console.WriteLine(message1.Length);//counts the numbers of characters in string "message1", including space

            Console.WriteLine(Welcome[0]); //print the character at index 0
            Console.WriteLine(CourseName.Substring(CourseName.Length - 1)); //get and print the last character

            //the index starts at 0 and keeps iterating, as long as its in range of "message"
            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine(message[i]); //prints the value at the index of "message", starting at index 0
            }

            // print all the character at even index of string "message"
            for (int j = 0; j < message.Length; j += 2)
            {
                Console.Write(message[j]);
            }
        }
    }
}
