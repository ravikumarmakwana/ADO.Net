using System;
using System.Collections.Generic;
using System.Data;
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
            var conString = "Data Source=RAVIMAKWANA;Initial Catalog=StudentRecords;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string name, department;
            int rollNo;

            Console.Write("Please enter the Roll Number : ");
            rollNo = int.Parse(Console.ReadLine());
            Console.Write("Please enter the Name : ");
            name = Console.ReadLine();
            Console.Write("Please enter the Department : ");
            department = Console.ReadLine();

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string sql = "INSERT INTO STUDENT VALUES (@rollNo, @name, @department)";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@rollNo",rollNo));
            cmd.Parameters.Add(new SqlParameter("@name",name));
            cmd.Parameters.Add(new SqlParameter("@department",department));
            
            if(cmd.ExecuteNonQuery()==1)
                Console.WriteLine("Successfully Data is Inserted.");
            else
                Console.WriteLine("Data is not Inserted");
            
            con.Close();
            Console.ReadKey();
        }
    }
}
