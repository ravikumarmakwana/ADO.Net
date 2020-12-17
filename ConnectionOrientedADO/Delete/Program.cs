using System;
using System.Collections.Generic;
using System.Data;
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
            var conString = "Data Source=RAVIMAKWANA;Initial Catalog=StudentRecords;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection con = new SqlConnection(conString);
            con.Open();

            Console.Write("Please enter the Roll No. : ");
            int rollno = int.Parse(Console.ReadLine());

            string sql = "DELETE FROM STUDENT WHERE rollno = @rollno";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@rollno", rollno));

            if (cmd.ExecuteNonQuery() == 1)
                Console.WriteLine("Deleted Successful");
            else
                Console.WriteLine("Errors");

            con.Close();
            Console.ReadKey();
        }
    }
}