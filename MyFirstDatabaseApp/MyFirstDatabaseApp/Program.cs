using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;

namespace MyFirstDatabaseApp
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=G:\\C# Programming\\MyFirstDatabaseApp\\MyFirstDatabaseApp\\Employee.mdf;Integrated Security=True");
            string sql = "INSERT INTO emp VALUES (@empno, @ename, @job, @mgr, @hiredate, @sal, @comm, @deptno)";
            con.Open();
            
            StreamReader reader = new StreamReader("EmployeeData.csv");
            reader.ReadLine();
            string line;
            while((line=reader.ReadLine())!=null)
            {
                var part = line.Split(',');
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@empno", int.Parse(part[0])));
                cmd.Parameters.Add(new SqlParameter("@ename", part[1]));
                cmd.Parameters.Add(new SqlParameter("@job", part[2]));
                cmd.Parameters.Add(new SqlParameter("@mgr", int.Parse(part[3])));
                cmd.Parameters.Add(new SqlParameter("@hiredate", DateTime.Parse(part[4])));
                cmd.Parameters.Add(new SqlParameter("@sal", int.Parse(part[5])));
                cmd.Parameters.Add(new SqlParameter("@comm", int.Parse(part[6])));
                cmd.Parameters.Add(new SqlParameter("@deptno", int.Parse(part[7])));

                cmd.ExecuteNonQuery();
            }

            reader.Close();
            con.Close();
            con.Dispose();
            Console.ReadKey();
        }
    }
}
