using System;
using System.Collections;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            //create Array List using built in library
            ArrayList myArrList = new ArrayList();

            //Add values to Array List using Add()
            myArrList.Add(10);
            myArrList.Add(11.5);
            myArrList.Add("This is a string");

            //Add values to Array Lisst using AddRange()
            myArrList.AddRange(new ArrayList() { 20, 17.7, "This is another string" });

            //remove elements using RemoveRange() and RemoveAt() and remove()
            myArrList.Remove(10); //remove elements with value of 10
            //now this arraylist has 5 elements

            myArrList.RemoveAt(0); //remove element at index 0, which is now 11.5
            //now this arraylist has 4 elements

            myArrList.RemoveRange(1, 2);//remove elements from index 1 to before 2

            //print each value in the array list using foreach()
            foreach(var value in myArrList)
            {
                Console.WriteLine(value);
            }
        }
    }
}
