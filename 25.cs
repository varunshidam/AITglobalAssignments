using System;

namespace Employee10
{
    class Program
    {

        public int id;
        public String name;
        public int age;


        public Program(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public Program()
        {
        }

        public void Display()
        {
            Console.WriteLine("Employee ID : " + id + " Employee Name : " + name + " Employee Age : " + age);
        }

        public override string ToString()
        {
            return ("Employee ID : " + id + " Employee Name : " + name + " Employee Age : " + age);
        }
        public override bool Equals(object obj)
        {
            return obj is Program program &&
                   id == program.id &&
                   name == program.name &&
                   age == program.age;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, name, age);
        }


        static void Main(string[] args)
        {
            Program e1 = new Program(101, "varun", 21);
            Program e2 = new Program(101, "varun", 21);
            e1.Display(); e2.Display();
            e1.ToString();
            e2.ToString();




            //if (e1 == e2)
            //{
            //    Console.WriteLine("obj is same");
            //}
            //else
            //{
            //    Console.WriteLine("obj is different");
            //}
            if (e1.Equals(e2))
            {
                Console.WriteLine("obj is same");
            }
            else
            {
                Console.WriteLine("obj is different");
            }





        }

    }
}
