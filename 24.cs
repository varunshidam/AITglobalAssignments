using System;

namespace OperatorOverloading
{
    class Program
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public double add(double a, double b)
        {
            return a + b;
        }
        public double add(double a, int b)
        {
            return a + b;
        }

        public double add(int a, double b)
        {
            return a + b;
        }
        public string add(string a, string b)
        {
            return a + "," + b;
        }

        public double add(double a)
        {
            return a + a;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.add(10, 20));
            Console.WriteLine(p.add(11.11, 33.44));
            Console.WriteLine(p.add(56, 22.22));
            Console.WriteLine(p.add(99.77, 11));
            Console.WriteLine(p.add(98));
        }
    }
}
