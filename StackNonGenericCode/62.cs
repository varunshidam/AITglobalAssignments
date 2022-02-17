using System;
using System.Collections;

namespace StackNonGenericCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(34);
            s.Push(67);
            s.Push("tq");
            s.Push(true);

            foreach (object o in s)
            {
                Console.WriteLine(o);
            }

            s.Pop();
            s.Pop();
            Console.WriteLine("Data after popped elements");

            foreach (object o in s)
            {
                Console.WriteLine(o);
            }
        }
    }
}
