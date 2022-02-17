using System;

namespace AbstractClassShape
{
    abstract class Shape
    {
        public abstract void CalArea();
    }
    class Circle : Shape
    {
        float r;
       // float area;

        public Circle(float r)
        {
            this.r = r;
        }
        public override void CalArea()
        {
            // area = 3.14 * r * r;
            Console.WriteLine("Area Of circle : "+3.14 * r * r);

        }
    }
    class Rectangle : Shape
    {
        float l;
        float b;

        public Rectangle(float l, float b)
        {
            this.l = l;
            this.b = b;
        }

        public override void CalArea()
        {
            Console.WriteLine("Area of Reactangle : "+l*b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle C = new Circle(10);
            C.CalArea();

            Rectangle R = new Rectangle(10f, 10f);
            R.CalArea();
        }
    }
}
