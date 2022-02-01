using System;
using System.Collections.Generic;
using System.Text;

namespace Oopss
{
    class Class3
    {
        static int Add(params int[] nums)
        {
            int total = 0;
            foreach (int i in nums)
            {
                total = total + i;
            }
            return total;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Parameter Array Function Testing ...");

            int result = 0;

            
            result = Add(10, 10, 10);
            Console.WriteLine("Result for 3 Prameter :{0}", result);

            
            result = Add(10, 10, 10, 10);

            Console.WriteLine("Result for 4 Prameter :{0}", result);

            
            result = Add(10, 10, 10, 10, 10);

            Console.WriteLine("Result for 5 Prameter :{0}", result);

           
            int[] x = { 10, 10, 10, 10, 10, 10, 10, 10 };

            Console.ForegroundColor = ConsoleColor.Red;
            result = Add(x);
            Console.WriteLine("Result for Array Summation Prameter :{0}", result);

            Console.ReadKey();
        }
    }
}