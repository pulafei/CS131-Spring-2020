using System;

namespace Inheritance
{
    class Program
    {
        class Shapes  //Create class named Shapes with below properties
        {
            public double length;
            public double width;
            public double radius;
            //challenge
            public void ShowBaseData()
            {
                Console.WriteLine("Base length is " + length);
                Console.WriteLine("Base width is " + width);
                Console.WriteLine("Base radius is " + radius);
                Console.WriteLine("\n"); //jumping to next line
            }
        }

        class Rectangle : Shapes  //Rectangle class derived from Shapes base class
        {
            public void CalArea(double l, double w)
            {
                length = l;
                width = w;
                double RecArea = l * w;
                Console.WriteLine("Rectangle length is: " + length);
                Console.WriteLine("Rectangle width is: " + width);
                Console.WriteLine("Rectangle Area is: " + RecArea);
            }
        }

        class Square : Shapes  //Square class derived from Shapes base class
        {
            public void CalArea(double a)
            {
                length = a;
                double SqArea = a * a;
                Console.WriteLine("Square side length is: " + a);
                Console.WriteLine("Square Area is: " + SqArea);
            }
        }

        class Circle : Shapes  //Circle class derived from Shapes base class
        {
            public void CalArea(double r)
            {
                radius = r;
                double CirArea = 3.15 * r;
                Console.WriteLine("Circle radius is: " + radius);
                Console.WriteLine("Circle Area is: " + CirArea);
            }
        }
        static void Main(string[] args)
        {
            Rectangle MyRec = new Rectangle(); //object MyRec of class Rectangle
            Circle MyCir = new Circle();  //object MyCir of class Circle
            Square MySq = new Square();  //object MySq of class Square

            //using objects to call properties of is class. Since all Rectangle, Square and Circle classes
            //are dervied from base class Shapes, all of those classes have access to Shapes' Properties
            //making their objects also able to access
            //length, width and radius, which are the properties of base class Shapes
            /*
            Console.WriteLine("Base length is " + MyRec.length);
            Console.WriteLine("Base width is " + MyRec.width);
            Console.WriteLine("Base radius is " + MyCir.radius);
            Console.WriteLine("\n"); //jumping to next line
            */
            //challenge
            Shapes ShowData = new Shapes(); //object ShowData of class Shapes
            ShowData.ShowBaseData();

            MyRec.CalArea(3, 4);
            Console.WriteLine("\n");  //jumping to next line

            MySq.CalArea(10);
            Console.WriteLine("\n");  //jumping to next line

            MyCir.CalArea(8);
        }
    }
}
