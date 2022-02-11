using System;
using System.Data;
using System.Data.SqlClient;


namespace DissconnectedArch
{
    class Program
    {
        static void Main(string[] args)
        {
            Char cont;
            int choice;
            do
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=LAPTOP-ASUSVIVO\\SQLEXPRESS;database=database1;trusted_connection=true";

                SqlCommand cmd = new SqlCommand("Select * from Book", con);
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();

                adapter.Fill(ds, "Book");

                DataTable tab = ds.Tables["Book"];

                Console.WriteLine("1.Select  ALL Book Details");
                Console.WriteLine("2.Select Book Using Book ID");
                Console.WriteLine("3.Insert Book");
                Console.WriteLine("4.Update Book");
                Console.WriteLine("5.Delete Book");

                Console.WriteLine("Enter Your choice");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Book Information");
                        foreach (DataRow row in tab.Rows)
                        {
                            Console.WriteLine(row[0] + "\t" + row[1] + "\t" + row[2] + "\t" + row[3]);
                        }
                        Console.WriteLine(ds.GetXml());
                        break;
                    case 2:
                        Console.WriteLine("Enter Book ID to be selected");
                        int bookId = Convert.ToInt32(Console.ReadLine());

                        DataRow[] selrow = tab.Select("bookId=" + bookId);

                        foreach (DataRow row in selrow)
                        {
                            Console.WriteLine(row[0] + "\t" + row[1] + "\t" + row[2] + "\t" + row[3]);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter Book Id");
                        int bId1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Book price");
                        int bPrice = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Book Name");
                        String bName = Console.ReadLine();

                        Console.WriteLine("Enter Book Auther Name");
                        String bAName = Console.ReadLine();

                        DataRow newrow = tab.NewRow();

                        newrow["bookId"] = bId1;
                        newrow["bookPrice"] = bPrice;
                        newrow["bookName"] = bName;
                        newrow["bookAutName"] = bAName;

                        tab.Rows.Add(newrow);
                        adapter.Update(ds.Tables[0]);
                        Console.WriteLine("Data Inserted succ...");
                        break;
                    case 4:
                        Console.WriteLine("Enter Book Id");
                        int bId2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Book price");
                        int bPrice2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Book Name");
                        String bName2 = Console.ReadLine();

                        Console.WriteLine("Enter Book Auther Name");
                        String bAName2 = Console.ReadLine();

                        DataRow[] updater = tab.Select("bookId=" + bId2);

                        DataRow updaterow = updater[0];

                        updaterow["bookId"] = bId2;
                        updaterow["bookPrice"] = bPrice2;
                        updaterow["bookName"] = bName2;
                        updaterow["bookAutName"] = bAName2;

                        adapter.Update(ds.Tables[0]);

                        break;
                    case 5:
                        Console.WriteLine("Enter Book Id to be deleted"); ;
                        int bId3 = Convert.ToInt32(Console.ReadLine());


                        DataRow[] delr = tab.Select("bookId=" + bId3);

                        DataRow delrow = delr[0];
                        delrow.Delete();
                        adapter.Update(ds, "Book");

                        Console.WriteLine("Book Deleted");

                        break;
                    default:
                        Console.WriteLine("Invalid case");
                        break;
                }
                Console.WriteLine("Enter Y to continue");
                cont = Convert.ToChar(Console.ReadLine());
            }
            while (cont == 'Y');
            Console.ReadLine();

        }

    }
}
