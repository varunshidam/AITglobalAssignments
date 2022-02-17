using System;
using System.IO;

namespace DirectoryCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("D:\\New_folder\\MyDir");
            Console.WriteLine(Directory.GetCreationTime("D:\\New_folder\\MyDir"));
            Console.WriteLine("Directory Created");

            DirectoryInfo di = new DirectoryInfo("D:\\New_folder\\NewDir");
            if (di.Exists)
            {
                Console.WriteLine("Directory Exists");
                Console.WriteLine(di.FullName);
                Console.WriteLine(di.CreationTime);
                Console.WriteLine(di.LastAccessTime);
                //di.CreateSubdirectory("Subdir");
                File.Create("D:\\New_folder\\NewDir\\DemoFile.txt");
                Console.WriteLine("File Created");


            }
            else
            {
                di.Create();
                Console.WriteLine("Directory Created");
            }
        }
    }
}
