using System;

namespace GenericType
{
    class Program
    {
        /*
        class StoreInt   //class StoreInt has 2 integers, with set and get functions set to each variable
        {
            public int num1 { set; get; }
            public int num2 { set; get; }
        }
        class StoreString //class StoreString has 2 strings, with set and get functions set to each variable
        {
            public string strg1 { set; get; }
            public string strg2 { set; get; }
        }
        class StoreAnything<T> //declare class StoreAnything using generic type
        {
            public T var1 { set; get; }
        }
        */
        class StoreAnything<T, U, X> //declare class StoreAnything using generic type
        {
            public T var1 { set; get; }
            public U var2 { set; get; }
            public X var3 { set; get; }
        }
        static void Main(string[] args)
        {
            /*
            StoreInt MyInt = new StoreInt { num1 = 1, num2 = 3 }; //create new object of StoreInt class
            StoreString MyStrg = new StoreString { strg1 = "CS", strg2 = "131" }; //create new object of StoreString class

            Console.WriteLine(MyInt.num1 + "," + MyInt.num2); //print new values
            Console.WriteLine(MyStrg.strg1 + " " + MyStrg.strg2); //print new valus
            
            //create new object of StoreAnything class, passing string type
            StoreAnything<string> MyVar1 = new StoreAnything<string> { var1 = "CS" };

            //create another new object of StoreAnything class, passing int type
            StoreAnything<int> MyVar2 = new StoreAnything<int> { var1 = 131 };

            Console.WriteLine(MyVar1.var1 + " " + MyVar2.var1);//print new values of var1
            */

            //create new object of StoreAnything class, passing string and int type
            StoreAnything<string, int, string> MyVar1 = new StoreAnything<string, int, string> { var1 = "CS", var2 = 131, var3 = "!" };

            Console.WriteLine(MyVar1.var1 + MyVar1.var2 + MyVar1.var3); //print new values of var1 2 3
        }
    }
}
