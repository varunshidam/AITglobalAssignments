using System;

namespace ParamArrayCode
{
    class MathClass
    {
        public void Average(params double[] no)
        {
            double total = 0;
            double avg = 0;

            for (int i = 0; i < no.Length; i++)
            {
                total = total + no[i];
            }

            avg = total / no.Length;

            Console.WriteLine("Average is " + avg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MathClass obj = new MathClass();

            obj.Average(34, 66, 77, 43, 22, 57, 99, 66, 89);
            obj.Average(43, 77, 44);
            obj.Average(34, 556, 77, 78, 8, 8, 9, 4, 3, 3, 56, 7, 5, 66, 3, 7, 7, 7, 7);
        }
    }
}
