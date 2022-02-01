using System;
namespace Enumeration
{
    enum days
    {
        sunday,monday,tuesday,wednesday,thursday,friday,saturday
    }

    class Program
    {

        static void Main(string[] args)
        {

 
            Console.WriteLine("The value of Sunday " +
                              "enum is " + (int)days.sunday);
            Console.WriteLine("The value of Monday " +
                             "enum is " + (int)days.monday);
            Console.WriteLine("The value of tuesday " +
                             "enum is " + (int)days.tuesday);
            Console.WriteLine("The value of wednesday " +
                             "enum is " + (int)days.wednesday);
            Console.WriteLine("The value of thursday " +
                             "enum is " + (int)days.thursday);
            Console.WriteLine("The value of friday " +
                             "enum is " + (int)days.friday);
            Console.WriteLine("The value of saturday " +
                 "enum is " + (int)days.saturday);

        }
    }
}