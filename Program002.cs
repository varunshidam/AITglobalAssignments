using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
//using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
[Serializable]
public class Student
{
    //  [XmlElement]
    public int id;
    //    [XmlElement]
    public string name;
    public Student() { }

    public Student(int id, string name)
    {
        this.id = id;
        this.name = name;
    }
    public override string ToString()
    {
        return "Student Id : " + id + " Student Name :" + name;
    }
}

public class SerializableClass
{
    static void Main(string[] args)
    {
        FileStream fs = new FileStream("Student01.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        BinaryFormatter formatter = new BinaryFormatter();
        //Student s = new Student(101, "varun");
        //formatter.Serialize(fs, s);
        //Console.WriteLine("Data Format in Binaryy Format");
        //Console.ReadLine();
        Student obj = (Student)formatter.Deserialize(fs);
        Console.WriteLine(obj);
        Console.ReadLine();



    }
}
