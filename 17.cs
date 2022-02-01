using System;

namespace InterfaceEg2
{

    interface Printable
    {
        void print();
    }
    interface Showable
    {
        void print();
    }
    class TestInterface : Printable,Showable
    {
     

        void Printable.print()
        {
            Console.WriteLine("Hello Printable");
        }

        void Showable.print()
        {
            Console.WriteLine("Hello Showable");
        }
    }


    class Program
    {
        public void PrintDetails(Printable obj)
        {
            obj.print();
        }
        static void Main(string[] args)
        {
            TestInterface obj = new TestInterface();
            obj.print(obj);
        }
    }
}
