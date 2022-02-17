using System;
using System.IO;

namespace DriveInfoCode
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo di = new DriveInfo("D:\\");
            Console.WriteLine(di.Name);
            Console.WriteLine(di.DriveFormat);
            Console.WriteLine(di.VolumeLabel);
            Console.WriteLine(di.AvailableFreeSpace);
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine(Path.GetDirectoryName("D:\\New_folder\\NewDir\\Mock3.txt"));
            Console.WriteLine(Path.GetFileName("D:\\New_folder\\NewDir\\Mock3.txt"));
            Console.WriteLine(Path.GetExtension("D:\\New_folder\\NewDir\\Mock3.txt"));
            Console.WriteLine(Path.DirectorySeparatorChar);
        }
    }
}
