using System;
using System.Data.SqlClient;

namespace Display
{
    class Program
    {
        static void Main(string[] args)
        {
            var conString = "Data Source=RAVIMAKWANA;Initial Catalog=StudentRecords;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string sql = "SELECT * FROM STUDENT";
            SqlCommand cmd = new SqlCommand(sql,con);
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine(String.Format("{0, -10} | {1, -20} | {2, -30}","Roll No","Name","Department"));
            Console.WriteLine("--------------------------------------------------------");
            while(reader.Read())
            {
                Console.WriteLine(String.Format("{0, -10} | {1, -20} | {2, -30}", reader["rollno"], reader["name"], reader["department"]));
            }
            reader.Close();
            con.Close();
            Console.ReadKey();
        }
    }
}
