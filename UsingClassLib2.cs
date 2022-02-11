using ClassLibrary1;
using System;
using UsingClassLib;

namespace UsingClassLib2
{
    class Program
    {
        static void Main(string[] args)
        {
            MarhLibrary obj = new MarhLibrary();
            obj.CalSquare(2);

            MarhLibrary obj2 = new MarhLibrary();
            obj2.calCube(2);

            //Console.WriteLine(obj.calCube(2));

            Console.ReadLine();
        }

    }
}
