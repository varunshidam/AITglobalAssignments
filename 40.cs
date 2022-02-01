using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCsharp
{
    internal class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int n = 20;
            bool isPrime = true;
            for (int i = 2; i < n/2; i++)
            {
                if (n%i==0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
                Console.WriteLine("is prime");
            else
                Console.WriteLine("Not Prime");
        }
    }
}
