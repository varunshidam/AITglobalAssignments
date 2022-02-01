using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a, b, c;
            //Console.WriteLine("Enter 2 nos");
            //a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToInt32(Console.ReadLine());
            //c = a + b;
            //Console.WriteLine("addition of {0} and {1} is {2}", a, b, c);

            double marks;

            Console.WriteLine("Enter your grade");
            //marks = Convert.ToDouble(Console.ReadLine());
            char grade = Convert.ToChar(Console.ReadLine());

            if (marks >= 75)
            {
                Console.WriteLine("Distinction");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("First Class");
            }
            else if (marks >= 45)
            {
                Console.WriteLine("Second Class");
            }
            else if (marks >= 35)
            {
                Console.WriteLine("Pass Class");
            }
            else
            {
                Console.WriteLine("Fail");
            }



        }
    }
}
