using System;
using System.Collections;

namespace HashTableNonGenericCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1,"varun");
            ht.Add(2, "sanjay");
            ht.Add(3, "kalpana");
            ht.Add(4, "sanjana");
            foreach(DictionaryEntry de in ht)
            {
                Console.WriteLine(de.Key+"==>"+de.Value);
            }

        }
    }

    
}
