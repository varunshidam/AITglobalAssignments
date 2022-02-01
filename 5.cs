using System;


namespace DemoOops
{
    class Student
    {
        int id;
        string name, designation;

        public Student()
        {
            Console.WriteLine("In Default Constructor");
        }

        public Student(int id, string name, string d)
        {
            this.id = id;
            this.name = name;
            this.designation = d;
        }

        public void Print()
        {
            Console.WriteLine("id= {0} name={1} Designation={2}", id, name, designation);
        }
    }
    class Class4
    {

        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student(101, "Varun", "Enginer");
            //s1.Print();
            s2.Print();
        }
    }
}
