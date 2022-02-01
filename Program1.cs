using System;

namespace Abstractbank
{
    abstract class Account
    {
        public abstract void CalculateIntrest();
      
    }

    class saving : Account
    {
        public override void CalculateIntrest()
        {
            Console.WriteLine("Welcome to Saving Account");
        }
    }
    class Current : Account
    {
        public override void CalculateIntrest()
        {
            Console.WriteLine("welcome to Current Account");
        }
    }
    class fixDeposite : Account
    {
        public override void CalculateIntrest()
        {
            Console.WriteLine("Welcome to Fixed Deposite Account");
        }
    }


    class Program
    {
        
        static void Main(string[] args)
        {
            saving s = new saving();
            s.CalculateIntrest();

       
            Current c = new Current();
            c.CalculateIntrest();

            fixDeposite fd = new fixDeposite();
            fd.CalculateIntrest();



        }
    }
}
