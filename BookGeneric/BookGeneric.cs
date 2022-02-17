using System;
using System.Collections.Generic;

namespace BookGeneric
{
    public class Book
    {
        int bId;
        string bName;
        String aName;

        public Book(int bId, string bName, string aName)
        {
            this.bId = bId;
            this.bName = bName;
            this.aName = aName;
        }
        public override string ToString()
        {
            return  bId+","+bName+","+aName+".";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> list = new List<Book>();
            list.Add(new Book(1,"MATH","MR.VARUN"));
            list.Add(new Book(2, "PHYSICS", "MR.SANJAY"));
            list.Add(new Book(3, "CHEMISTRY", "MR.SHISHIR"));

            //Console.WriteLine(list);

            foreach (Book B in list)
            {
                Console.WriteLine(B);
            }

        }
    }
}
