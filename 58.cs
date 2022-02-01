using System;
using System.Collections;

namespace HashTableNonGenericCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "nikita");
            ht.Add("two", "Jayshree");
            ht.Add(3.3, "aaa");
            ht.Add(34, "zzzz");

            string val = (string)ht[34];
            Console.WriteLine(val);
        }
    }
}
