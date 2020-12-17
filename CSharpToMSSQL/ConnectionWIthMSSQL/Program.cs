using System;
using System.Data.SqlClient;

namespace ConnectionWIthMSSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            string conString = "Data Source=RAVIMAKWANA;Initial Catalog=Employee;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string sql = "SELECT * FROM EMP";
            SqlCommand cmd = new SqlCommand(sql, con);
            
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("|----------------------------------------------------------------------------------------------------------------------|");
            Console.WriteLine(String.Format("| {0, -5} | {1, -20} | {2, -20} | {3, -5} | {4, -20} | {5, -10} | {6, -5} | {7, -10} |","EMPNO", "ENAME", "JOB","MGR", "HIREDATE", "SAL", "COMM", "DEPTNO"));
            Console.WriteLine("|----------------------------------------------------------------------------------------------------------------------|");
            while(reader.Read())
            {
                Console.WriteLine(String.Format("| {0, -5} | {1, -20} | {2, -20} | {3, -5} | {4, -20} | {5, -10} | {6, -5} | {7, -10" +
                    "} |",reader["EMPNO"], reader["ENAME"], reader["JOB"], reader["MGR"], DateTime.Parse(reader["HIREDATE"].ToString()).ToString("MMMM d, yyyy"), reader["SAL"], reader["COMM"], reader["DEPTNO"]));
            }
            Console.WriteLine("|----------------------------------------------------------------------------------------------------------------------|");
            con.Close();
            con.Dispose();
            Console.ReadKey();
        }
    }
}
