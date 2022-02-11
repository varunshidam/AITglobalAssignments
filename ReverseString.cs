using System;

namespace AssignmentProject0922
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string s;
            string revs = "";
            Console.WriteLine(" Enter string ");
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)   
            {
                revs = revs+ s[i].ToString();
            }
            if (revs == s) 
            {
                Console.WriteLine("String is Palindrome");
            }
            else
            {
                Console.WriteLine("String is not Palindrome");
            }
            Console.ReadKey();


        }
    }

}
