using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderClassForADO
{
    class Program
    {
        /**
         *
         *  Author : Ravikumar Makwana
         *  Aim : To Perform Insert, Update, Delete  SqlCommandBuilder
         *
         */
        static void Main(string[] args)
        {
            string sql = "SELECT * FROM USERS";
            string conString = "Data Source=RAVIMAKWANA;Initial Catalog=UserAccounts;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con=new SqlConnection(conString))
            {
                using (SqlDataAdapter adapter=new SqlDataAdapter(sql, con))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    
                    using(SqlCommandBuilder builder = new SqlCommandBuilder(adapter))
                    {
                        Console.WriteLine(builder.GetInsertCommand(true).CommandText);
                        Console.WriteLine();
                        Console.WriteLine(builder.GetDeleteCommand(true).CommandText);
                        Console.WriteLine();
                        Console.WriteLine(builder.GetUpdateCommand(true).CommandText);
                    
                        // To Insert Data .....
                        using (SqlCommand cmd= builder.GetInsertCommand(true))
                        {
                            cmd.Connection = con;
                            cmd.Parameters["@name"].Value = "A";
                            cmd.Parameters["@username"].Value = "B" ;
                            cmd.Parameters["@password"].Value = "C";
                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
