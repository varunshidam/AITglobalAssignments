using System;
using System.Collections;
using System.Collections.Generic;

namespace QueueNonGenericCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(12);
            q.Enqueue("nikita");
            q.Enqueue(45.7f);
            q.Enqueue('g');

            foreach (object o in q)
            {
                Console.WriteLine(o);
            }

            q.Dequeue();
            q.Dequeue();

            Console.WriteLine("eements after deque");
            foreach (object o in q)
            {
                Console.WriteLine(o);
            }
        }
    }
}
