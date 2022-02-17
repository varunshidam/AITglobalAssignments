using System;
using System.Threading;

namespace priorityExample
{   
   public class MyThreadClass
    {
        public void Thread1()
        {
            Thread t =  Thread.CurrentThread;
            Console.WriteLine(t.Name + " is Running ");
        }
    }

   public  class Program
    {
        static void Main(string[] args)
        {
            MyThreadClass mt = new MyThreadClass();
            Thread t1 = new Thread(mt.Thread1);
            Thread t2 = new Thread(mt.Thread1);
            Thread t3 = new Thread(mt.Thread1);

            t1.Name = "Player 1";
            t2.Name = "Player 2";
            t3.Name = "Player 3";

            t3.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Normal;
            t1.Priority = ThreadPriority.Lowest;

            t2.Start();
            t1.Start();
            t3.Start();

            Console.ReadLine();
        }
    }
}
