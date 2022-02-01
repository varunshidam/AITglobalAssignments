using System;
using System.Collections;
using System.Collections.Generic;

namespace DictionaryCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dd = new Dictionary<int, string>();
            dd.Add(1, "varun");
            dd.Add(2, "sanjay");
            dd.Add(3, "kalpana");
            dd.Add(4, "sanjana");
            foreach(KeyValuePair<int,string> kvp in dd)
            {
                Console.WriteLine(kvp.Key+"==>"+kvp.Value);
            }
        }
    }
}
