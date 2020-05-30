using System;

namespace Class_Object
{
    class Shapes  //Create class named Shapes with below properties
    {
        public double length;
        public double width;
        public double radius;

        private double CalArea(double l, double w)
        {
            length = l;
            width = w;
            double Area = w * l;
            return Area;
        }

        //CHELLENGE
        //create CalCircleArea
        public double CalCireclaArea(double r)
        {
            double Area = 3.14159 * r * r;
            return Area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double RecWidth = 7;
            double RecLength = 8;
            double SqWidth = 2;

            Shapes Rectangle = new Shapes(); //Create instance/object of class Shapes, named Rectangle
            Shapes Square = new Shapes(); //Create instance/object of class Shapes, named Square

            //use Object Rectagle to call method CalArea of class Shapes
            Console.WriteLine("Area of Rectangle is " + Rectangle.CalArea(RecLength, RecWidth));

            //use Object Square to call method CalArea of class Shapes
            Console.WriteLine("Area of square is " + Square.CalArea(SqWidth, SqWidth));

            //CHALLENGE
            double CirRedius = 3;
            Shapes Circle = new Shapes();
            //use Object Circle to call method CalCircleArea of class Shapes
            Console.WriteLine("Area of Circle is " + Circle.CalCireclaArea(CirRedius));
        }
    }
}
