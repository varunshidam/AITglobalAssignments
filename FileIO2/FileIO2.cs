using System;
using System.IO;

namespace FileIO2
{
    class Program
    {
        static void Main(string[] args)
        {
           try
            {
                FileStream fs = new FileStream("Demo1.text", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                Console.WriteLine("Enter String ");
                string ss = Console.ReadLine();

                sw.WriteLine(ss);
                sw.Flush();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Operation succes...");
            }

            

        }
    }
}
