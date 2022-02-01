using System;

namespace Oopss
{
    class Student
    {
        int id;
        string sname;
        int age;

        public void Accept()
        {
            Console.WriteLine("Enter ID,Student Name,Age");
            id = int.Parse(Console.ReadLine());
            sname = Console.ReadLine();
            age = int.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Id : " + id + " Student Name : " + sname + " Age : " + age);
        }

        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Accept();
            s1.Display();
        }
    }
}
