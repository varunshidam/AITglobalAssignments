using System;
using System.IO;

namespace DirectoryInfoCodee
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo("D:\\New_folder\\NewDir");
            if (di.Exists)
            {
                FileInfo[] flist = di.GetFiles();
                foreach (FileInfo fi in flist)
                {
                    Console.WriteLine(fi.FullName);
                    Console.WriteLine(fi.Length);
                    Console.WriteLine(fi.Extension);
                    Console.WriteLine(fi.CreationTime);
                    Console.WriteLine("**************************************************************");

                }
            }
        }
    }
}
