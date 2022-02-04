using System;
using System.Data;
using System.Data.SqlClient;


namespace ADOExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=LAPTOP-ASUSVIVO\\SQLEXPRESS;database=HRMSDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "GetDepatData";
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Console.WriteLine("Enter Location Id and get Information 10/20/30/...270 : ");
                int did = Convert.ToInt32(Console.ReadLine());
                cmd.Parameters.AddWithValue("dno", did);


                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("Department Info through id");
                reader.Read();
                Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2] + "\t" + reader[3]);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
