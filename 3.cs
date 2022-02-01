using System;


namespace DemoOops
{

    class Circle
    {
        public void Calculate(double r, out double area, out double circumference)
        {
            area = (3.14 * r * r);
            circumference = (2 * 3.14 * r);

        }
    }
    class Class2
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            double r, area, circumference;
            Console.WriteLine("Enter Radius:");
            r = Convert.ToDouble(Console.ReadLine());
            c.Calculate(r, out area, out circumference);
            Console.WriteLine("Area of Circle:" + area);
            Console.WriteLine("circumference of Circle:" + circumference);
        }
    }
}
