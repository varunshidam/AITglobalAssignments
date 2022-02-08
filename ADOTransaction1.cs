using System;
using System.Data;
using System.Data.SqlClient;

namespace ADOTransaction1
{
    class Program
    {
        static void Main(string[] args)
        {

           
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=LAPTOP-ASUSVIVO\\SQLEXPRESS;database=HRMSDB;trusted_connection=true";
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into DEPARTMENTS values(4005,'HR',200,1700)", con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand("insert into DEPARTMENTS values(4006,'IT',300,1800)", con);
                cmd1.CommandType = CommandType.Text;
                cmd1.ExecuteNonQuery();
                Console.WriteLine("command Done ");
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
