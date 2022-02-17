using System;
using System.Runtime.Serialization;
namespace Example_Serialization
{
    [Serializable]
    public class Employee : ISerializable
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(“EmpId”, EmpId);
            info.AddValue(“EmpName”, EmpName);
        }
        public Employee(SerializationInfo info, StreamingContext context)
        {
            EmpId = (int)info.GetValue(“EmpId”, typeof(int));
            EmpName = (string)info.GetValue(“EmpName”, typeof(string));
        }

        public Employee()
        {
        }
    }
}

//In the above class  [Serializable] attribute should be applied. Serializable attribute tell compiler that all public and private properties should be serialized.If we don’t want to serialize some properties then simply apply[NonSerialized] attribute. Some times we need more customization, in that case we implements ISerializable interface. It override serializations process.It has a method named GetObjectData which actually serialize the object. And for desrialization we use a constructor where we write our deserialization code.
//Now we can serialize and deserialize our employee class. Below code snippet will explain how to serialize our employee class using SOAP serialization.
//using System;
//using System.IO;
//using System.Runtime.Serialization.Formatters.Soap;

namespace Example_Serialization
{
    class SOAPSerialization
    {
        public void SerializeObj()
        {
            Console.WriteLine(“SOAP Serialization starting”);
            Employee emp = new Employee() { EmpId = 1, EmpName = “Hriday Ranjan Dutta” };
            Stream stream = File.Open(“SOAPemployee.txt”, FileMode.OpenOrCreate);
            SoapFormatter bformatter = new SoapFormatter();
            bformatter.Serialize(stream, emp);
            stream.Close();
            Console.WriteLine(“SOAP Serialization done”);
            Console.ReadLine();
        }
        public void DeserializeObj()
        {
            Console.WriteLine(“SOAP Deserialization starting”);
            Stream stream = File.Open(“SOAPemployee.txt”, FileMode.Open);
            SoapFormatter bformatter = new SoapFormatter();
            Employee emp = (Employee)bformatter.Deserialize(stream);
            stream.Close();
            Console.WriteLine(“Employee ID: { 0}, Employee Name : { 1}”,emp.EmpId.ToString(),emp.EmpName);
            Console.WriteLine(“SOAP Deserialization done”);
            Console.ReadLine();
        }
    }
}