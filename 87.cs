using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("Demo.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Console.WriteLine("Data in the file is");
            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine((int)fs.ReadByte());
            //}
            // Console.ReadKey();
            for (int i = 1; i <= 20; i++)
            {
                fs.WriteByte((byte)i);
            }
            fs.Flush();
            Console.WriteLine("Data Written to the file");
        }
    }
}
