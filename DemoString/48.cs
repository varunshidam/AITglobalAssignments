using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoString
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Name");
            string name = Console.ReadLine();
            int v = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if(name[i] =='u' || name[i] == 'o' || name[i] == 'i' || name[i] == 'e' || name[i] == 'a' )
                    v++;
            }
            Console.WriteLine("vowels : "+v);   
        }
    }


    class Class2
    {
        static void Main(string[] args)
        {

            String s = "varun sanjay sidam";
            string[] sarry = s.Split(" ");
            foreach (String  val in sarry)
            {
                Console.WriteLine(val);
            }
        }
    }

    class Class3
    {
        static void Main(string[] args)
        {
            string ss = "varun";
            char[] ch = ss.Split("");
            foreach (char val in ch)
            {
                Console.WriteLine(val);
            }
        }
    }
}
