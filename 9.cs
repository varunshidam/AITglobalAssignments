using System;

namespace ExceptionHandle
{
	class YoungerAgeException : Exception
	{
		YoungerAgeException(String msg)
	{
			base(msg);
		}
	}
	class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter youre Age");
            int age = Convert.ToInt32(Console.ReadLine());
			try
			{
				if (age < 18)
				{
					throw new YoungerAgeException("Not eligible for voting");
				}
				else
				{
                    Console.WriteLine("Eligible for voting");
				}
			}
			catch (Exception e)
			{
                Console.WriteLine(e.Message);
			}
            Console.WriteLine("END");

		}

    }
}
