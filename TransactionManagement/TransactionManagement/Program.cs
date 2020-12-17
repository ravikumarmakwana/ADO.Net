using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, department;
            int rollno;

            string conString = "Data Source=RAVIMAKWANA;Initial Catalog=StudentRecords;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            // Begin Transaction
            SqlTransaction transaction = con.BeginTransaction();

            try
            {
                // First Operation
                Console.WriteLine("Insert Data");

                Console.Write("Please enter the rollno : ");
                rollno = int.Parse(Console.ReadLine());
                Console.Write("Please enter the name : ");
                name = Console.ReadLine();
                Console.Write("Please enter the department : ");
                department = Console.ReadLine();

                string sql1 = "INSERT INTO STUDENT (rollno, name, department) VALUES (@rollno, @name, @department)";
                SqlCommand cmd1 = new SqlCommand(sql1, con, transaction);
                
                cmd1.Parameters.Add(new SqlParameter("@rollno", rollno));
                cmd1.Parameters.Add(new SqlParameter("@name", name));
                cmd1.Parameters.Add(new SqlParameter("@department", department));

                if (cmd1.ExecuteNonQuery() == 1)
                    Console.WriteLine("Data Inserted Successfully");
                else
                    Console.WriteLine("Errors");

                // Second Operation
                Console.WriteLine("Update Data");

                Console.Write("Please enter the rollno : ");
                rollno = int.Parse(Console.ReadLine());
                Console.Write("Please enter new the name : ");
                name = Console.ReadLine();
                Console.Write("Please enter new the department : ");
                department = Console.ReadLine();

                string sql2 = "UPDATE STUDENT SET name = @name, department = @department WHERE rollno = @rollno";
                SqlCommand cmd2 = new SqlCommand(sql2, con);

                cmd2.Transaction = transaction;
                cmd2.Parameters.Add(new SqlParameter("@rollno", rollno));
                cmd2.Parameters.Add(new SqlParameter("@name", name));
                cmd2.Parameters.Add(new SqlParameter("@department", department));

                if (cmd2.ExecuteNonQuery() == 1)
                    Console.WriteLine("Data Updated Successfully");
                else
                    Console.WriteLine("Errors");

                // Third Operation
                Console.WriteLine("Delete Data");

                Console.Write("Please enter the rollno : ");
                rollno = int.Parse(Console.ReadLine());

                string sql3 = "DELETE STUDENT rollno = @rollno";
                SqlCommand cmd3 = new SqlCommand(sql3, con);

                cmd3.Transaction = transaction;
                cmd3.Parameters.Add(new SqlParameter("@rollno", rollno));

                if (cmd3.ExecuteNonQuery() == 1)
                    Console.WriteLine("Data Deleted Successfully");
                else
                    Console.WriteLine("Errors");

                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
                Console.WriteLine("Errros Occured.");
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }

            Console.ReadKey();
        }
    }
}
