using System;
using System.Collections.Generic;

namespace ListGenericCode
{
    class Program
    {
        static void Main(string[] args)
        {
            
             List<int> list = new List<int>();
             list.Add(45);
             list.Add(78);
             list.Add(23);
             list.Add(33);

             foreach(int i in list)
             {
                 Console.WriteLine(i);
             }
         
        }
    }
}
