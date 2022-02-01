using System;

namespace InheritanceDemo
{
    public class Employee
    {
        protected int empno;
        protected string ename, designation;

        public Employee(int empno, string ename, string designation)
        {
            this.empno = empno;
            this.ename = ename;
            this.designation = designation;
        }

        public void PrintData()
        {
            Console.WriteLine("Empno " + empno + " ename " + ename + " designation " + designation);
        }
    }

    class Permanent_Emp : Employee
    {
        double basic_sal;

        public Permanent_Emp(int empno, string ename, string designation, double basic_sal) : base(empno, ename, designation)
        {
            this.basic_sal = basic_sal;
        }

        public void calculatesalary()
        {
            double HRA = 40 * basic_sal / 100;
            double DA = 30 * basic_sal / 100;
            double gross = basic_sal + HRA + DA;
            base.PrintData();
            Console.WriteLine("Total Salary is " + gross);
        }
    }

    class Waged_Emp : Employee
    {
        double hourly_pay, no_of_hours;
        public Waged_Emp(int empno, string ename, string designation, double hourly_pay, double no_of_hours) : base(empno, ename, designation)
        {
            this.hourly_pay = hourly_pay;
            this.no_of_hours = no_of_hours;
        }

        public void calcuatesalary()
        {
            double total_sal = hourly_pay * no_of_hours;
            base.PrintData();
            Console.WriteLine("Total Salary is " + total_sal);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Permanent_Emp obj = new Permanent_Emp(101, "varun", "Manager", 99999);
            obj.calculatesalary();

            Waged_Emp obj2 = new Waged_Emp(102, "Sanjay", "Accountant", 500, 200);
            obj2.calcuatesalary();

            Console.ReadLine();
        }
    }
}


