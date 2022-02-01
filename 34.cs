using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCsharp
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            String name = Console.ReadLine();
            Console.WriteLine("Welcome "+name);
            Console.WriteLine("Enter 2 number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());    
               
            Console.WriteLine("Addition :"+(a+b));
            Console.WriteLine("Substraction :"+(a-b));

		}
	}
}
