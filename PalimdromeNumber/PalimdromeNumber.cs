using System;
public class PalimdromeNumber
{
    public static void Main(string[] args)
    {
        int no, temp = 0, t, rev;
        Console.Write("Please provide the no: ");
        no = int.Parse(Console.ReadLine());
        t = no;
        while (no > 0)
        {
            rev = no % 10;
            temp = (temp * 10) + rev;
            no = no / 10;
        }
        if (t == temp)
            Console.Write(" number is Palindrome.");
        else
            Console.Write("is not Palindrome");
    }
}