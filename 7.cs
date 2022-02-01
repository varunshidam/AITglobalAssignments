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

        public void Display()
        {
            Console.WriteLine("Employee ID : "+id+" Employee Name : "+name+" Employee Age : "+age);
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
            Program e1 = new Program(101,"varun",21);
            Program e2 = new Program(101, "varun", 21);
            e1.Display(); e2.Display();
            Program e3 = new Program(103, "vikrat", 23);
            Program e4 = new Program(104, "vijay", 24);
            Program e5 = new Program(105, "vivek", 25);
            Program e6 = new Program(106, "viren", 26);
            Program e7 = new Program(107, "vilas", 27);
            Program e8 = new Program(108, "virendra", 28);
            Program e9 = new Program(109, "vijaya", 29);
            Program e10 = new Program(110, "vinaya", 30);
            e3.Display(); e4.Display(); e5.Display(); e6.Display(); e7.Display();
            e8.Display(); e9.Display(); e10.Display();

            if (e1 == e2)
            {
                Console.WriteLine("obj is same");
            }
            else
            {
                Console.WriteLine("obj is different");
            }
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
