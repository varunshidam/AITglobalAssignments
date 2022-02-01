using System;

namespace SealedWorkingCode
{
     class Grandparent
    {
        public virtual void Property()
        {
            Console.WriteLine("Gold || Land ");
        }
        public virtual void Marriage()
        {
            Console.WriteLine(" By his Own Choice ");
        }

    }

    class Parent : Grandparent
    {
        public  override void Property()
        {
            Console.WriteLine("Gold || Land || Diamond ");
        }
        public sealed override void Marriage()
        {
            Console.WriteLine("Arrange Marrage");
        }

    }

    class Child : Grandparent
    {
        public override void Property()
        {
            Console.WriteLine("Gold || Land || Diamond || Flat || Hotel");
        }
        public override void Marriage()
        {
            Console.WriteLine("Love Marriage");
        }

    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.Marriage();
        }
    }
}
