using System;

namespace SwitchCase
{
    class Program
    {
        public static void Main(String[] args)
        {

            Console.WriteLine("Enter your choice 1-12 for Months");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {

                case 1:
                    Console.WriteLine("jan");
                    break;

                case 2:
                    Console.WriteLine("feb");
                    break;

                case 3:
                    Console.WriteLine("march");
                    break;

                case 4:
                    Console.WriteLine("April");
                    break;

                case 5:
                    Console.WriteLine("may");
                    break;

                case 6:
                    Console.WriteLine("june");

                    break;

                case 7:
                    Console.WriteLine("july");
                    break;


                case 8:
                    Console.WriteLine("Aug");
                    break;


                case 9:
                    Console.WriteLine("Sep");
                    break;

                case 10:
                    Console.WriteLine("Oct");
                    break;

                case 11:
                    Console.WriteLine("Nov");
                    break;

                case 12:
                    Console.WriteLine("Dec");
                    break;

                default:
                    Console.WriteLine("No match found");
                    break;
            }

        }
    }
}
