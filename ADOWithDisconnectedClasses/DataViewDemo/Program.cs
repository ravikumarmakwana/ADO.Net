using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string conString = "Data Source=RAVIMAKWANA;Initial Catalog=UserAccounts;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sql = "SELECT * FROM USERS";
            DataView dataView = null;

            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        //Set DefaultView
                        dataView = dataTable.DefaultView;

                        dataView.Sort = "userId DESC";

                        dataView.RowFilter = "username is NOT NULL";
                        //dataView.RowFilter = "name = Ravikumar Makwana and username = Ravi";


                        DataTable newTable = dataView.ToTable();

                        for(int i=0;i<newTable.Rows.Count;i++)
                        {
                            Console.WriteLine(String.Join(" ",newTable.Rows[i].ItemArray));
                        }

                    }
                }
            }
            Console.ReadKey();
        }
    }
}
