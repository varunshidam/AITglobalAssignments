using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoArray
{
    internal class Class11
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            Console.WriteLine("Enter an element 3*3");
            for (int i = 0; i <3; i++)
            {
                Console.WriteLine("Enterr Elements for row");
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                 }
            }
            Console.WriteLine("Array Elements are : ");
           for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

