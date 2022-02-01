using System;
class DivByZero : Exception
{

    public DivByZero()
    {
        Console.Write("Exception has occurred : ");
    }
}

class Program
{

    public double DivisionOperation(double numerator, double denominator)
    {
        
        if (denominator == 0)
            throw new DivByZero();
        return numerator / denominator;
    }


    static void Main(string[] args)
    {
        Program obj = new Program();
        double num = 9, den = 0, quotient;
        try
        {
           
            quotient = obj.DivisionOperation(num, den);
            Console.WriteLine("Quotient = {0}", quotient);
        }
       
        catch (Exception e)
        {
           
            Console.Write(e.Message);
        }
        finally
        {
            Console.WriteLine("END");
        }
    }
}