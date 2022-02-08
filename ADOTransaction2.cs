using System;
using System.Data;
using System.Data.SqlClient;

namespace ADOTransaction2
{
    class Program
    {
        static void Main(string[] args)
        {


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=LAPTOP-ASUSVIVO\\SQLEXPRESS;database=HRMSDB;trusted_connection=true";
            con.Open();

            SqlTransaction trans = con.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into DEPARTMENTS values(5000,'HR',200,1700)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Transaction = trans;
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand("insert into DEPARTMENTS values(5001,'IT',300,1800)", con);
                cmd1.CommandType = CommandType.Text;
                cmd1.Transaction = trans;
                cmd1.ExecuteNonQuery();

                trans.Commit();
                Console.WriteLine("Trans... Done ");
            }
            catch (SqlException e)
            {
                trans.Rollback();
                Console.WriteLine("Trans... is Rollback");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
