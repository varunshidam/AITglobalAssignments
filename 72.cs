using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoArray
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Console.WriteLine("Enter an element");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array Elements are :");
            foreach (int val in a)
            {
                Console.WriteLine(val);
            }
        }

    }

    class ArrayString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String Elements");
            String[] s = new String[5];

            for (int i = 0; i < s.Length; i++)
            {
                s[i] = Console.ReadLine();
            }
            Console.WriteLine("array of String");
            foreach (String item in s)
            {
                Console.WriteLine(item);
            }
        }
    }

    class MaxArray
    {
        static void Main(string[] args)
        {
            int[] a = new int[3];
            Console.WriteLine("Enter an element");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if(max<a[i])
                    max = a[i];
            }
            Console.WriteLine("Maximum Element from Array is : "+max);
        }
    }
}
