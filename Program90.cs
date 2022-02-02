using System;
using System.Threading;
namespace ThreadProject
{
    class ThreadClass
    {
        public void ThreadMethod()
        {   //for synchronized
            Monitor.Enter(this);
            for(int i=0;i<=100;i++)
            {
                Console.WriteLine(System.Threading.Thread.CurrentThread.Name +i);
                Thread.Sleep(100);
            }
            Monitor.Exit(this);
        }

    }
    class Program90
    {
        static void Main(string[] args)
        {
            ThreadClass tc = new ThreadClass();
            //  tc.ThreadMethod();
            //  tc.ThreadMethod();
            ThreadStart ts1 = new ThreadStart(tc.ThreadMethod);
            ThreadStart ts2 = new ThreadStart(tc.ThreadMethod);
            Thread t1 = new Thread(ts1);
            Thread t2 = new Thread(ts2);

            t1.Start();
            t2.Start();


        }
    }
}
