using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delete
{
    class Program
    {
        static void Main(string[] args)
        {
            int rollno;
            Console.Write("Please enter the rollno : ");
            rollno = int.Parse(Console.ReadLine());

            string conString = "Data Source=RAVIMAKWANA;Initial Catalog=StudentRecords;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection con = new SqlConnection(conString);

            string sql = "DELETE FROM STUDENT WHERE rollno = @rollno";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = new SqlCommand(sql, con);
            adapter.DeleteCommand.Parameters.Add(new SqlParameter("@rollno", rollno));

            con.Open();
            Console.WriteLine("Deleted Rows : "+adapter.DeleteCommand.ExecuteNonQuery());
            con.Close();

            Console.ReadKey();
        }
    }
}
