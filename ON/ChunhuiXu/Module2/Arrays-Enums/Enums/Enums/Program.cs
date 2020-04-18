using System;

namespace Enums
{
    class Program
    {
        enum Gender { Male, Female, Other};
        enum Age { Young, Middle, Old};
        enum Hair { Long, Short, Bald};
        enum Height { Tall, Short};
        static void Main(string[] args)
        {
            Console.WriteLine("I am a " + Gender.Male);
            Console.WriteLine("My age is " + Age.Young);
            Console.WriteLine("My hair is " + Hair.Short);
            Console.WriteLine("My height is " + Height.Tall);
            Console.ReadKey();


        }
    }
}
