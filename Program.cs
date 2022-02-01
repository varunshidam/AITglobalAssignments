using System;

namespace UserGenericSwapEmployeeClass
{
    class Employee
    {
        int empno;
        string ename, designation;

        public Employee(int eno, string enm, string desig)
        {
            empno = eno;
            ename = enm;
            designation = desig;
        }

        public override string ToString()
        {
            return empno + "," + ename + "," + designation;
        }

    }
    class MathClass<T>
    {
        public void Swap(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee e1 = new Employee(1, "smith", "manager");
            Employee e2 = new Employee(2, "allaen", "salesman");
            MathClass<Employee> obj3 = new MathClass<Employee>();
            Console.WriteLine("Values before swapping e1={0}\te2={1}", e1, e2);
            obj3.Swap(ref e1, ref e2);
            Console.WriteLine("Values after swapping e1={0}\te2={1}", e1, e2);
        }
    }
}
