using System;

namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int userInput = Convert.ToInt32(Console.ReadLine()); // input value
            while (true)
            {
                if (userInput > 10 || userInput < 1)
                {
                    Console.Write("Number must be between 1 - 10. Guess again: ");
                    userInput = Convert.ToInt32(Console.ReadLine()); // input new value. I prefer they are in same line.
                }
                else if (userInput != num)
                {
                    Console.Write("You guessed wrong. Guess again: ");
                    userInput = Convert.ToInt32(Console.ReadLine());  // input new value. I prefer they are in same line.
                }
                else if (userInput == num)
                {
                    Console.WriteLine("Your guess was correct!");
                    break;
                }
            }
        }
    }
}
