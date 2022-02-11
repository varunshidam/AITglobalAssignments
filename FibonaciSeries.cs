using System;

namespace FibonaciSeries
{
    class Program
    {
        public void fibboSeries()
        {
            int a = 0;
            int b = 1;
            int sum;
            for (int i=0;i<10;i++)
            {
                Console.WriteLine(a+" ");
                sum = a + b;
                a = b;
                b = sum;
            }
        }
        static void Main(string[] args)
        {
            new Program().fibboSeries();
        }
    }
}
