using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, department;
            int rollno;

            Console.Write("Please enter the rollno : ");
            rollno = int.Parse(Console.ReadLine());
            Console.Write("Please enter the name : ");
            name = Console.ReadLine();
            Console.Write("Please enter the department : ");
            department = Console.ReadLine();
            
            string conString = "Data Source=RAVIMAKWANA;Initial Catalog=StudentRecords;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            
            SqlConnection con = new SqlConnection(conString);
            string sql = "INSERT INTO STUDENT (rollno, name, department) VALUES (@rollno, @name, @department)";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.InsertCommand = new SqlCommand(sql, con);
            
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@rollno", rollno));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", name));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@department", department));
            
            con.Open();
            Console.WriteLine("Affacted Rows : "+adapter.InsertCommand.ExecuteNonQuery());
            con.Close();
            
            Console.ReadKey();
        }
    }
}
