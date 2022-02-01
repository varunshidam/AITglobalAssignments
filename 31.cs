using System;

namespace SwappingValues
{
    class Program
    {
        static void SwapNum(ref int x, ref int y)
        {

            int temp= x;
            x = y;
            y = temp;

        }
        static void Main(string[] args)
        {
            int a = 100;
            int b = 500;

            Console.WriteLine("Value of a and b before sawapping");
            Console.WriteLine();
            Console.WriteLine("a=" + " " + a);
            Console.WriteLine("b=" + " " + b);
            SwapNum(ref a, ref b);
            Console.WriteLine();
            Console.WriteLine("Value of a and b after sawapping");
            Console.WriteLine();
            Console.WriteLine("a=" + " " + a);
            Console.WriteLine("b=" + " " + b);
            Console.ReadLine();

        }
    }
}