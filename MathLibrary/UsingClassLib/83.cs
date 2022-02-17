using System;
using MathLibrary;

namespace UsingClassLib
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass obj = new MathClass();
            Console.WriteLine(obj.add(5, 6));
            Console.WriteLine(obj.Subtract(5, 6));
            Console.WriteLine(obj.Multiply(5, 6));
            Console.WriteLine(obj.Divide(6, 2));
            Console.ReadLine();
        }
    }
}
