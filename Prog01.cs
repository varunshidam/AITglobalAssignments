using System;
using System.Threading;


namespace ThreadCommunication
{
    class ThreadClass
    {
        public void ThreadMethod()
        {
            lock (this)
            {
                for (int i = 0; i <= 100; i++)
                {
                    Console.WriteLine(System.Threading.Thread.CurrentThread.Name + i);
                    Thread.Sleep(100);
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ThreadClass tc = new ThreadClass();
            ThreadStart ts1 = new ThreadStart(tc.ThreadMethod);
            ThreadStart ts2 = new ThreadStart(tc.ThreadMethod);
            Thread t1 = new Thread(ts1);
            t1.Name = "First Thread : ";
            t1.Name = "Second Thread : ";

            Thread t2 = new Thread(ts2);

            t1.Start();
            t2.Start();
        }
    }
}
