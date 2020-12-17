using System;
using System.Collections.Generic;
using System.Data;
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
            var conString = "Data Source=RAVIMAKWANA;Initial Catalog=StudentRecords;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            Console.Write("Please enter the Roll No. : ");
            int rollNo = int.Parse(Console.ReadLine());
            Console.Write("Please enter the New Name : ");
            string name = Console.ReadLine();


            SqlConnection con = new SqlConnection(conString);
            con.Open();
            
            string sql = "UPDATE STUDENT SET name = @name WHERE rollno = @rollno";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add(new SqlParameter("@rollno", rollNo));
            cmd.Parameters.Add(new SqlParameter("@name", name));

            if(cmd.ExecuteNonQuery()!=0)
                Console.WriteLine("Update Successful");
            else
                Console.WriteLine("Update Failed");

            con.Close();
            Console.ReadKey();
        }
    }
}
