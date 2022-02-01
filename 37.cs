using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCsharp
{
    internal class SwitchCase
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter 2 Number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your choice 1,2,3,4");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {

                case 1:
                    Console.WriteLine("Adition :" +(a+b));
                    break;

                case 2:
                    Console.WriteLine("Substraction : "+(a-b));
                    break;

                case 3:
                    Console.WriteLine("Multiplication :"+(a*b));
                    break;

                case 4:
                    Console.WriteLine("Division :" + (a / b));
                    break;

                default:
                    Console.WriteLine("No match found");
                    break;
            }
        }
    }
}
