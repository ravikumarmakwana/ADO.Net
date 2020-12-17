using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Update
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, department;
            int rollno;

            Console.Write("Please enter the rollno : ");
            rollno = int.Parse(Console.ReadLine());
            Console.Write("Please enter the new name : ");
            name = Console.ReadLine();
            Console.Write("Please enter the new department : ");
            department = Console.ReadLine();

            string conString = "Data Source=RAVIMAKWANA;Initial Catalog=StudentRecords;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection con = new SqlConnection(conString);
            string sql = "UPDATE STUDENT SET name = @name, department = @department WHERE rollno = @rollno";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = new SqlCommand(sql, con);
            
            adapter.UpdateCommand.Parameters.Add(new SqlParameter("@rollno", rollno));
            adapter.UpdateCommand.Parameters.Add(new SqlParameter("@name", name));
            adapter.UpdateCommand.Parameters.Add(new SqlParameter("@department", department));

            con.Open();
            Console.WriteLine("Result : "+adapter.UpdateCommand.ExecuteNonQuery());
            con.Close();
            
            Console.ReadKey();
        }
    }
}
