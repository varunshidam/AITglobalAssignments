using System;
using System.IO;

// the Customer class gives us something to serialize
[Serializable]
class Customer
{
    // some private data members
    private int CustomerNumber;
    private string CustomerName;
    private string CustomerCountry;

    // the WriteCustomer method formats info to the screen
    public void WriteCustomer()
    {
        Console.WriteLine("Customer Number: " + this.CustomerNumber);
        Console.WriteLine("Customer Name: " + this.CustomerName);
        Console.WriteLine("Customer Country: " + this.CustomerCountry);
    }

    // the constructor accepts all the info to create a customer
    public Customer(
      int newCustomerNumber,
      string newCustomerName,
      string newCustomerCountry)
    {
        this.CustomerNumber = newCustomerNumber;
        this.CustomerName = newCustomerName;
        this.CustomerCountry = newCustomerCountry;
    }
}

public class Example15_20
{

    public static void Main()
    {

        // create a new customer and dump to screen
        Customer MyCustomer = new Customer(1, "varun sidam", "India");
        MyCustomer.WriteCustomer();
        Console.ReadLine();

        // Create a FileStream to hold the serialized customer
        FileStream serializeStream = new FileStream("c:\\MyCustomer.xml",
          FileMode.Create);

        // use SOAP formatting
        SoapFormatter sf = new SoapFormatter();

        // serialize the object
        sf.Serialize(serializeStream, MyCustomer);
        serializeStream.Flush();
        serializeStream.Close();

        // retrieve the serialized version to a second object and dump that
        FileStream retrieveStream = new FileStream("c:\\MyCustomer.xml",
          FileMode.Open);
        Customer NewCustomer = (Customer)sf.Serialize(retrieveStream);
        NewCustomer.WriteCustomer();
    }

}

internal class SoapFormatter
{
    public SoapFormatter()
    {
    }

    internal void Serialize(FileStream serializeStream, Customer myCustomer)
    {
        throw new NotImplementedException();
    }

    internal Customer Serialize(FileStream retrieveStream)
    {
        throw new NotImplementedException();
    }
}