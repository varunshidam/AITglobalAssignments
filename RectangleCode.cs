using System;

namespace RectangleCode
{
    public class Rectangle
    {
        public void Calculate(float length,float breadth,out float area,out float perimeter)
        {
            area = length * breadth;
            perimeter = 2 * length + 2 * breadth;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            float area;
            float perimeter;
            Console.WriteLine("Enter length and breadth of reactangle : ");
            float length = float.Parse(Console.ReadLine());
            float breadth = float.Parse(Console.ReadLine());

            Rectangle r1 = new Rectangle();
            r1.Calculate(length,breadth,out area,out perimeter);

            Console.WriteLine("Area Of Rectangle = "+area+
                               " perimeter of Rectangle : "+perimeter);

        }
    }
}
