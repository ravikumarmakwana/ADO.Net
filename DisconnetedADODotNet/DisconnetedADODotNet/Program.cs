using System;
using System.Data;
using System.Data.SqlClient;

namespace Display
{
    class Program
    {
        static void Main(string[] args)
        {
            string conString = "Data Source=RAVIMAKWANA;Initial Catalog=StudentRecords;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sql = "SELECT * FROM STUDENT";
            
            SqlConnection con = new SqlConnection(conString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sql,con);

            DataTable table = new DataTable();
            adapter.Fill(table);

            for(int i=0;i<table.Rows.Count;i++)
                Console.WriteLine(table.Rows[i]["rollno"]+" "+ table.Rows[i]["name"] + " " + table.Rows[i]["department"]);
            Console.ReadKey();
        }
    }
}
