using System;
using System.IO;

namespace FileInfoCode
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fi = new FileInfo("D:\\New_folder\\NewDir\\Mock3.txt");
            if (fi.Exists)
            {
                Console.WriteLine(fi.FullName);
                Console.WriteLine(fi.Length);
                Console.WriteLine(fi.Extension);
                Console.WriteLine(fi.CreationTime);
            }
            else
            {
                fi.Create();
                Console.WriteLine("File Created");
            }
        }
    }
}
