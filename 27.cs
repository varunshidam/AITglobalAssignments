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
            int avg = 0;
            foreach (int i in nums)
            {
            
                avg = (total + i) + nums.Length;
            }
            return avg;
        }

        static void Main(string[] args)
        {
           

            int result = 0;


            result = Add(10, 10, 10);
            Console.WriteLine("Average for 3 Prameter :{0}", result);


            result = Add(10, 10, 10, 10);

            Console.WriteLine("Average for 4 Prameter :{0}", result);


            result = Add(10, 10, 10, 10, 10);

            Console.WriteLine("Average for 5 Prameter :{0}", result);


         
        }
    }
}
