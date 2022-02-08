using System;
using System.Data;
using System.Data.SqlClient;

namespace ExecuteScalarExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=LAPTOP-ASUSVIVO\\SQLEXPRESS;database=HRMSDB;trusted_connection=true";
            con.Open();

            SqlCommand cmd1 = new SqlCommand(" select sum(salary) as TotalSal from employees", con);
            cmd1.CommandType = CommandType.Text;

            decimal TotalSal = (decimal)cmd1.ExecuteScalar();

            Console.WriteLine("Total Salary is : " +TotalSal);

            con.Close();
        }
    }
}
