using System;
using System.Data;
using System.Data.SqlClient;

namespace ADOExample3
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
                con.ConnectionString = "Server=LAPTOP-ASUSVIVO\\SQLEXPRESS;database=HRMSDB;trusted_connection=true";

                SqlCommand cmd = new SqlCommand("GetDepatData", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();

                adapter.Fill(ds, "DEPARTMENTS");

                DataTable tab = ds.Tables["DEPARTMENTS"];

                Console.WriteLine("1.Select  ALL Department");
                Console.WriteLine("2.Select Department Using Department ID");
                Console.WriteLine("3.Insert Department");
                Console.WriteLine("4.Update Department");
                Console.WriteLine("5.Delete Department");

                Console.WriteLine("Enter Your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Department Information");
                        foreach (DataRow row in tab.Rows)
                        {
                            Console.WriteLine(row[0] + "\t" + row[1] + "\t" + row[2] + "\t" + row[3]);
                        }
                        Console.WriteLine(ds.GetXml());
                        break;
                    case 2:
                        Console.WriteLine("Enter Department ID to be selected");
                        int dno = Convert.ToInt32(Console.ReadLine());

                        DataRow[] selrow = tab.Select("Department_id=" + dno);

                        foreach (DataRow row in selrow)
                        {
                            Console.WriteLine(row[0] + "\t" + row[1] + "\t" + row[2] + "\t" + row[3]);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter Department Id");
                        int dno1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Department Name");
                        string dname1 = Console.ReadLine();

                        Console.WriteLine("Enter Manager Id");
                        int mgerid1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Location Id");
                        int locid1 = Convert.ToInt32(Console.ReadLine());

                        DataRow newrow = tab.NewRow();

                        newrow["DEPARTMENT_ID"] = dno1;
                        newrow["DEPARTMENT_NAME"] = dname1;
                        newrow["MANAGER_ID"] = mgerid1;
                        newrow["LOCATION_ID"] = locid1;

                        tab.Rows.Add(newrow);
                        adapter.Update(ds.Tables[0]);
                        Console.WriteLine("Data Inserted");
                        break;
                    case 4:
                        Console.WriteLine("Enter Department Id");
                        int dno2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Department Name");
                        string dname2 = Console.ReadLine();

                        Console.WriteLine("Enter Manager Id");
                        int mgerid2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Location Id");
                        int locid2 = Convert.ToInt32(Console.ReadLine());

                        DataRow[] updater = tab.Select("DEPARTMENT_ID=" + dno2);

                        DataRow updaterow = updater[0];

                        updaterow["DEPARTMENT_ID"] = dno2;
                        updaterow["DEPARTMENT_NAME"] = dname2;
                        updaterow["MANAGER_ID"] = mgerid2;
                        updaterow["LOCATION_ID"] = locid2;

                        adapter.Update(ds.Tables[0]);

                        break;
                    case 5:
                        Console.WriteLine("Enter Department No to be deleted"); ;
                        int dno3 = Convert.ToInt32(Console.ReadLine());


                        DataRow[] delr = tab.Select("DEPARTMENT_ID=" + dno3);

                        DataRow delrow = delr[0];


                        delrow.Delete();

                        //ds.Tables[0].AcceptChanges();

                        adapter.Update(ds, "DEPARTMENTS");

                        Console.WriteLine("Department Deleted");

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