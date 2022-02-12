using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1102
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
          
            Console.WriteLine("1.Print Names from user  ");
            Console.WriteLine("2.Print Names in Reverse order  ");
            Console.WriteLine("3.Print last 3 Names ");
            Console.WriteLine("4.Print 2nd  Name");
            Console.WriteLine("5.Sort Names");
            Console.WriteLine("6.Show duplicate if present ");
            Console.WriteLine("7.Occourance of Names");
            Console.WriteLine("8.Print values with vowels only \n");


            Console.WriteLine("Enter Your choice");
            choice = Convert.ToInt32(Console.ReadLine());
          
            
            switch (choice)
            {

                case 1:
                    Console.WriteLine("Enter 5 Names");
                    String[] s = new String[5];

                    for (int i = 0; i < s.Length; i++)
                    {
                        s[i] = Console.ReadLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine("array of String");
                    foreach (String item in s)
                    {
                        Console.WriteLine(item);
                    }
                    break;

                case 2 :
                    Console.WriteLine("Enter 5 Names");
                    String[] s1 = new String[5];

                    for (int i = 0; i < s1.Length; i++)
                    {
                        s1[i] = Console.ReadLine();
                    }
                    Console.WriteLine();
                    string[] newString = new string[s1.Length];
                    for (int i = 0, j = s1.Length - 1; i < s1.Length && j >= 0; i++, j--)
                    {
                        newString[j] = s1[i];
                    }
                    Console.WriteLine("Input Names In reverse order ");
                    foreach (String item in newString)
                    {
                        Console.WriteLine(item);
                    }
                    break;

                case 3:
                    Console.WriteLine("Enter 5 Names");
                    String[] s3 = new String[5];

                    for (int i = 0; i < s3.Length; i++)
                    {
                        s3[i] = Console.ReadLine();
                    }
                    Console.WriteLine("Display last 3 names");
                    for (int i=2; i < s3.Length; i++)
                    {
                        Console.WriteLine(s3[i]);

                    }
                    break;

                case 4:
                    Console.WriteLine("Enter 5 Names");
                    String[] s4 = new String[5];

                    for (int i = 0; i < s4.Length; i++)
                    {
                        s4[i] = Console.ReadLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine("Display 2nd name");
                    for (int i = 1; i < s4.Length-3; i++)
                    {
                        Console.WriteLine(s4[i]);
                    }
                    break;
                case 5:
                    Console.WriteLine("Enter 5 Names");
                    String[] s5 = new String[5];

                    for (int i = 0; i < s5.Length; i++)
                    {
                        s5[i] = Console.ReadLine();
                    }
                    Console.WriteLine();
                    Array.Sort(s5);
                    Console.WriteLine("After Sort Names");
                    foreach (String item in s5)
                    {
                        Console.WriteLine(item);
                    }
                    break;

                case 6:
                    Console.WriteLine("Enter 5 Names");
                    String[] s6 = new String[5];

                    for (int i = 0; i < s6.Length; i++)
                    {
                        s6[i] = Console.ReadLine();
                    }
                    Console.WriteLine();

                    for (int i = 0; i < s6.Length; i++)
                    {
                        int count = 0;
                        for (int j = 0; j < s6.Length; j++)
                        {

                            if (s6[i] == s6[j])
                                count = count + 1;
                        }
                        if(count>1)
                        {
                            Console.WriteLine(s6[i]);
                        }
                      
                    }
                   
                    break;
                case 7:

                    Console.WriteLine("Enter 5 Names");
                    String[] s7 = new String[5];

                    for (int i = 0; i < s7.Length; i++)
                    {
                        s7[i] = Console.ReadLine();
                    }
                    Console.WriteLine();

                    for (int i = 0; i < s7.Length; i++)
                    {
                        int count = 0;
                        for (int j = 0; j < s7.Length; j++)
                        {

                            if (s7[i] == s7[j])
                                count = count + 1;
                        }
                       
                         Console.WriteLine(s7[i] + " occurs  : " + count + " times");
                    }
                    break;
                case 8:

                    string[] vowels = new string[] { "A", "E", "I", "O", "U" };


                    Console.WriteLine("Enter 5 Names");
                    String[] names = new String[5];

                    for (int i = 0; i < names.Length; i++)
                    {
                        names[i] = Console.ReadLine();
                    }
                    Console.WriteLine();

                    for (int i = 0; i < names.Length; i++)
                    {
                        foreach (var v in vowels)
                        {

                            if (names[i].ToString().ToUpper().Contains(v.ToString()))
                            {
                               // Console.WriteLine(names[i]);
                                names[i] = names[i].ToString().ToUpper().Replace(v.ToString(), "");
                               // Console.WriteLine("The output is: " + names[i].ToString().ToLower());
                            }
                            else
                            {
                                Console.WriteLine(names[i]);

                                Console.WriteLine("The output is: " + names[i].ToString().ToLower());
                            }
                        }
                    }

                    Console.ReadLine();

                    break;



                default:
                    Console.WriteLine("No match found");
                    break;
            }
           

        }

       
    }
}
