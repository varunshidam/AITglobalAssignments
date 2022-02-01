using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class stud
    {
        int rollNo;
        string sName;
        int age;

        public stud(int rollNo, string sName, int age)
        {
            this.rollNo = rollNo;
            this.sName = sName;
            this.age = age;
        }

        public stud()
        {
        }

        public override string ToString()
        {
            return rollNo + " , " + sName + " , " + age + ". ";
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            List<stud> ls = new  List<stud>();
            ls.Add(new stud(101, "varun", 22));
            ls.Add(new stud(102, "vivek", 23));
            ls.Add(new stud(103, "vishal", 24));
            Console.WriteLine("Student Elements are : ");
            foreach(stud ss in ls)
            {
                Console.WriteLine(ss);
            }
           
        }
    }
}
