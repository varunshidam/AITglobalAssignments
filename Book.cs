using System;

namespace ConsoleApp1
{
    public class Book
    {
        public int bookId;
        public string bookName;
        public string autherName;
        public float price;

        public Book(int bookId, string bookName, string autherName, float price)
        {
            this.bookId = bookId;
            this.bookName = bookName;
            this.autherName = autherName;
            this.price = price;
        }
        

        public void getDiscount()
        {
            price = price - (price * 10 / 100);
            Console.WriteLine(price);

        }
        public override string ToString()
        {
            return "BOOK ID : " + bookId + " BOOK NAME : " + bookName + " AUTHER NAME :" + autherName + " PRICE " + price;
        }
    
    
        static void Main(string[] args)
        {
            Book b1 = new Book(1,"Physics","verma",500f);
            Console.WriteLine(b1);
            b1.getDiscount();
            //Console.WriteLine(b1.getDiscount());
        }
    }
}
