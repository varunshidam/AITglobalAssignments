using System;
using System.Data;
using System.Data.SqlClient;

namespace ConnectedArch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Create connection
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=LAPTOP-ASUSVIVO\\SQLEXPRESS;database=database1;trusted_connection=true";

                //Creare command
                SqlCommand cmd = new SqlCommand();
                char continueornot = 'Y';
                SqlDataReader reader;
                int no;
                while (continueornot == 'Y')
                {
                    Console.WriteLine("Enter Correct Choice From Following: ");
                    Console.WriteLine("1.Select  ALL Book Details");
                    Console.WriteLine("2.Select Book Using Book ID");
                    Console.WriteLine("3.Insert Book");
                    Console.WriteLine("4.Update Book");
                    Console.WriteLine("5.Delete Book");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            connection.Open();
                            cmd.CommandText = "GetBookData";
                            cmd.Connection = connection;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Clear();
                            reader = cmd.ExecuteReader();
                            Console.WriteLine("select all Book Details.......");
                            while (reader.Read())
                            {
                                Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2] + "\t" + reader[3]);
                            }
                            Console.WriteLine("_____________________________________");
                            connection.Close();
                            break;

                        case 2:
                            connection.Open();
                            cmd.CommandText = "GetBook";
                            cmd.Connection = connection;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Clear();
                            Console.WriteLine("Enter Book Id: ");
                            int bookId = Convert.ToInt32(Console.ReadLine());

                            cmd.Parameters.AddWithValue("bookId", bookId);
                            no = cmd.ExecuteNonQuery();

                            reader = cmd.ExecuteReader();
                            Console.WriteLine("Book Detail.......");
                            while (reader.Read())
                            {
                                Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2] + "\t" + reader[3]);
                            }
                            Console.WriteLine("_____________________________________");
                            connection.Close();
                            break;

                        case 3:
                            connection.Open();
                            cmd.CommandText = "InsertBook";
                            cmd.Connection = connection;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Clear();

                            Console.WriteLine("Enter Book Id");
                            int bId1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Book price");
                            int bPrice = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Book Name");
                            String bName = Console.ReadLine();

                            Console.WriteLine("Enter Book Auther Name");
                            String bAName = Console.ReadLine();

                            cmd.Parameters.AddWithValue("bookId", bId1);
                            cmd.Parameters.AddWithValue("bookPrice", bPrice);
                            cmd.Parameters.AddWithValue("bookName", bName);
                            cmd.Parameters.AddWithValue("bookAutName", bAName);
                            

                            no = cmd.ExecuteNonQuery();
                            Console.WriteLine("Book Details Inserted Successfully!!");
                            Console.WriteLine("_____________________________________");
                            connection.Close();
                            break;

                        case 4:
                            connection.Open();
                            cmd.CommandText = "UpdateBook";
                            cmd.Connection = connection;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Clear();

                            Console.WriteLine("Enter Book Id");
                            int bId2 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Book price");
                            int bPrice2 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Book Name");
                            String bName2 = Console.ReadLine();

                            Console.WriteLine("Enter Book Auther Name");
                            String bAName2 = Console.ReadLine();

                            cmd.Parameters.AddWithValue("bookId", bId2);
                            cmd.Parameters.AddWithValue("bookPrice", bPrice2);
                            cmd.Parameters.AddWithValue("bookName", bName2);
                            cmd.Parameters.AddWithValue("bookAutName", bAName2);
                            

                            no = cmd.ExecuteNonQuery();
                            Console.WriteLine("Book Details Updated Successfully!!");
                            Console.WriteLine("_____________________________________");
                            connection.Close();
                            break;

                        case 5:
                            connection.Open();
                            cmd.CommandText = "DeleteBook";
                            cmd.Connection = connection;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Clear();

                            Console.WriteLine("Enter Book Id to be deleted"); ;
                            int bId3 = Convert.ToInt32(Console.ReadLine());

                            cmd.Parameters.AddWithValue("bookId", bId3);

                            no = cmd.ExecuteNonQuery();
                            Console.WriteLine("Book Details Deleted Successfully!!");
                            Console.WriteLine("_____________________________________");
                            connection.Close();
                            break;
                        default:
                            Console.WriteLine("Please Enter Valid Choice");
                            break;
                    }
                    Console.WriteLine("Do You Want To Continue Again Y/N");
                    continueornot = Convert.ToChar(Console.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}


