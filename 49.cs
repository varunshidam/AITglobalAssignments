using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCollection
{
    class Class1
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(11);
            s.Push(22);
            s.Push(33);
            s.Push(44);
            s.Push(55);
            Console.WriteLine("Stack Elements Are :");
            foreach(int i in s)
            {
                Console.WriteLine(i);
            }

        }
    }
}
