using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class1
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (j == i)
                    {
                        Console.WriteLine(i);
                    }
                    if (i % j == 0)
                    {
                        break;
                    }
                }
            }


        }
    }
}
