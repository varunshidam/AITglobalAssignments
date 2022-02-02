using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
[Serializable]
public class Student
{
  [XmlElement]
    public int id;
      [XmlElement]
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
        FileStream fs = new FileStream("Student01.xml",FileMode.OpenOrCreate,FileAccess.ReadWrite);
        XmlSerializer xs = new XmlSerializer(typeof(Student));
        //Student s = new Student(101, "varun");
        //xs.Serialize(fs, s);
        //fs.Close();
        Console.WriteLine("Data Format in Xml Format");
        Student obj = (Student)xs.Deserialize(fs);
        Console.WriteLine(obj);
        Console.ReadLine();


    }
}
