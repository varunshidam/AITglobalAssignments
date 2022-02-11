using System;

namespace IprintableInterface
{
    interface iPrintable
    {
        void print();
    }
    public class Employee : iPrintable
    {
        int eId;
        string eName;
        int age;

        public Employee(int eId, string eName, int age)
        {
            this.eId = eId;
            this.eName = eName;
            this.age = age;
        }
        public void print()
        {
            Console.WriteLine(eId +","+eName+","+age+".");
        }
    }
    public class Student : iPrintable
    {
        int sId;
        string sName;
        int sage;

        public Student(int sId, string sName, int sage)
        {
            this.sId = sId;
            this.sName = sName;
            this.sage = sage;
        }

        public void print()
        {
            Console.WriteLine(sId + "," + sName + "," + sage + ".");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Employee E = new Employee(1,"varun",22);
            E.print();

            Student S = new Student(2, "sanjay", 50);
            S.print();
        }
    }
}
