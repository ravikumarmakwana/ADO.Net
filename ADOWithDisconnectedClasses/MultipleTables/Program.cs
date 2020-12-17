using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTables
{
    class Program
    {
        static void Main(string[] args)
        {
            string conString = "Data Source=RAVIMAKWANA;Initial Catalog=UserAccounts;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sql = "SELECT * FROM USERS;SELECT * FROM JOBS;";
            using(SqlConnection con=new SqlConnection(conString))
            {
                using (SqlCommand cmd=new SqlCommand(sql, con))
                {
                    using(SqlDataAdapter adapter= new SqlDataAdapter(cmd))
                    {
                        DataSet dataSet = new DataSet(); 
                        adapter.Fill(dataSet);
                        Console.WriteLine(dataSet.Tables[0].Rows.Count);
                        Console.WriteLine(dataSet.Tables[1].Rows.Count);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
