using System;
using System.Collections;

namespace ArrayListNonGenericCode
{
    class Program
    {
        static void Main(string[] args)
        {
           ArrayList list = new ArrayList();
           list.Add(67);
           list.Add(45.7);
           list.Add("hello");
           list.Add('c');
           list.Add(true);
           list.Insert(2, "NewVal");


           foreach(object o in list)
           {
               Console.WriteLine(o);
           }
        }
    }
}
