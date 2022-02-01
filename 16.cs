using System;

namespace InterfaceExample
{

    interface IFlyer
    {
        void takeoff();
        void fly();
        void land();
    }

    class Bird : IFlyer
    {
        public void takeoff()
        {
            Console.WriteLine("Takeoff - Bird");
        }

        public void fly()
        {
            Console.WriteLine("Fly - Bird");
        }

        public void land()
        {
            Console.WriteLine("Land - Bird");
        }
    }

    class Airplane : IFlyer
    {
        public void takeoff()
        {
            Console.WriteLine("Takeoff - Airplane");
        }

        public void fly()
        {
            Console.WriteLine("Fly - Airplane");
        }

        public void land()
        {
            Console.WriteLine("Land - Airplane");
        }
    }

    class Superman : IFlyer
    {
        public void takeoff()
        {
            Console.WriteLine("Takeoff - Superman");
        }

        public void fly()
        {
            Console.WriteLine("Fly - Superman");
        }

        public void land()
        {
            Console.WriteLine("Land - Superman");
        }
    }
    class Program
    {
        public void CallFlyer(IFlyer f)
        {
            f.takeoff();
            f.fly();
            f.land();
        }
        static void Main(string[] args)
        {
            Bird b = new Bird();
            Airplane a = new Airplane();
            Superman s = new Superman();
            Program p = new Program();
            p.CallFlyer(b);
            p.CallFlyer(a);
            p.CallFlyer(s);
        }
    }
}
