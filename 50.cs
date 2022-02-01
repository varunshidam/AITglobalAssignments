using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCollection
{
    class Class2
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(44);
            q.Enqueue(33);
            q.Enqueue(22);
            q.Enqueue(11);
            Console.WriteLine("Queue Elements Are :");
            foreach (int i in q)
            {
                Console.WriteLine(i);
            }

        }
    }
}
