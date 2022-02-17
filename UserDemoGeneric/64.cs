using System;
using System.Collections.Generic;
using System.Text;

namespace UserDemoGeneric
{
    class mathClass<T>
    {
        public void Swap(ref T a,ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            mathClass<int> obj1 = new mathClass<int>();
            int x = 100;
            int y = 200;
            Console.WriteLine("Values Before Swapping x={0},y={1}", x,y);
            obj1.Swap(ref x, ref y);
            Console.WriteLine("Values After Swapping x={0},y={1}", x, y);
            Console.WriteLine("*************");
            mathClass<string> obj2 = new mathClass<string>();
            string a = "varun";
            string b = "sanjay";
            Console.WriteLine("Values Before Swapping a={0},b={1}", a, b);
            obj2.Swap(ref a, ref b);
            Console.WriteLine("Values After Swapping a={0},b={1}", a, b);

        }
    }
}
