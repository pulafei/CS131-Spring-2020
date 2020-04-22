using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace _2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int columns = 3;

            int[,] table = new int[rows, columns];    //Creating a 2D Array - 3 rows and 3 columns
            table[0, 0] = 1;                         // Assigning values to each array element
            table[0, 1] = 2;                         
            table[0, 2] = 3;
            table[1, 1] = 5;
            table[2, 1] = 8;

            for (int x = 0; x < rows; x++)         //Loop to print the 2D Array
            {
                for (int y = 0; y < columns; y++)
                { 
                Console.Write(table[x,y]);
                }
                Console.WriteLine();              //to create a new line after each row           
            }
            
        }
    }
}
