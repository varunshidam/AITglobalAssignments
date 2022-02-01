using System;
using System.Collections.Generic;
using System.Text;

namespace Oopss
{
    class Demo
    {
        public int a = 11;
        public static int b = 22;
        public void increment()
        {
            a++;
            b++;
        }

        public void print()
        {
            Console.WriteLine("value of a after inc.." + a);
            Console.WriteLine("value of b after inc.." + b);
        }
        static void Main(string[] args)
        {
            Demo d1 = new Demo();
            d1.increment();
            d1.print();
            Console.WriteLine("*****************");
            Demo d2 = new Demo();
            d2.increment();
            d1.print();
        }
    }



}
