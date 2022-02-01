using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCsharp
{
    internal class Grade
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Percentage");
            int percent = Convert.ToInt32(Console.ReadLine());
            if (percent >= 0 && percent <= 100)
            {
                if (percent >= 75)
                    Console.WriteLine("First Class");
                else if (percent >= 60)
                    Console.WriteLine("Second class");
                else if (percent >= 50)
                    Console.WriteLine("Pass");
                else
                    Console.WriteLine("Fail");


            }
            else
                Console.WriteLine("Invalid Percentage");
        }
    }



    class special
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num>=0 && num<=100)
            {
                int first = num / 10;
                int last = num % 10;
                int total = first * last + first + last;
                if (total==num)
                {
                    Console.WriteLine("Special");
                }
                else
                {
                    Console.WriteLine("Not Special");
                }
            }
            else
            {
                Console.WriteLine("Not Special Number");
            }
        }
    }
}
