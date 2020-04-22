using System;

namespace _2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int colums = 3;

            int[,] table = new int[rows, colums]; // create a 2d array that is 3x3 ( 3 rows and 3 colums)
            table[0, 0] = 1; // assign values to each array element, no specific value is provided, by default it's 0
            table[0, 1] = 2;
            table[0, 2] = 3;

            //loop through and print the whole 2D array
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < colums; y++) 
                {
                    Console.WriteLine(table[x, y]);
                }
                Console.WriteLine(); //a new line is created after each row is iterated
            }
        }
    }
}
