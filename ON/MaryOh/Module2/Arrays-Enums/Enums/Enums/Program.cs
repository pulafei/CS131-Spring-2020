using System;

namespace Enums
{
    enum Gender {Male, Female, Other };
    enum Age { Young, Middle, Old };
    enum Hair { Long, Short, Bald };
    enum Height { Tall, Short };
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am a " + Gender.Female);
            Console.WriteLine("My age is " + Age.Young);
            Console.WriteLine("My hair is " + Hair.Long);
            Console.WriteLine("My height is " + Height.Short);
        }
    }
}
