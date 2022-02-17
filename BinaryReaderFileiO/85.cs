using System;
using System.IO;
namespace BinaryReaerWriterEx
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("BinaryData.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(fs);
            Console.WriteLine("Empid " + reader.ReadInt32());
            Console.WriteLine("Ename " + reader.ReadString());
            Console.ReadLine();     

        }
    }
}
