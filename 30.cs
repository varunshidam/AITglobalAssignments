using System;

namespace StructDemo
{


    struct Book
    {
        public int bookid;
        public string bookname;
        

        public Book(int bid, string bnm)
        {
            bookid = bid;
            bookname = bnm;
        }

        public void Print()
        {
            Console.WriteLine("Bookid =" + bookid + " Book Name = " + bookname);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Book b= new Book(101, "C# black book");
            b.Print();



        }
    }
}
