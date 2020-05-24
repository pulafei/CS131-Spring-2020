using System;

namespace Date_Time
{
    class Program
    {
        void ShowTime()
        {
            DateTime currentDate = DateTime.Now;
            bool leapTear = DateTime.IsLeapYear(2020);

            Console.WriteLine(currentDate);
            Console.Write("2020 is a leapYear: ");
            Console.WriteLine(leapTear);
        }
        void GetPersonalInfo()
        {
            Console.WriteLine("Enter Your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("What year were you born?: ");
            int brithYear = Convert.ToInt32(Console.ReadLine());

            int age = (Convert.ToInt32(DateTime.Now.Year) - brithYear);

            Console.WriteLine("Here are what we know from your inputs: ");
            Console.WriteLine("Your name: " + name);
            Console.WriteLine("Today is: " + DateTime.Now.ToShortTimeString());
            Console.WriteLine("Your age: " + age);
        }
        static void Main(string[] args)
        {
            // create an object of class Program,
            // to access a method of that class,
            //in this case, is the ShowTime() method
            Program MyProgram = new Program();

            MyProgram.ShowTime();

            Program MyProgram2 = new Program();

            MyProgram2.GetPersonalInfo();

            //Challenge
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
        }
    }
}
