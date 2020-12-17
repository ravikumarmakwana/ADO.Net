using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace ResultManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Result> results = new List<Result>();

            //------------------- With ADO

            string conString = "Data Source=RAVIMAKWANA;Initial Catalog=StudentRecords;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(conString))
            {
                string sql1 = "SELECT * FROM STUDENT";
              
                SqlDataAdapter adapter1 = new SqlDataAdapter(sql1,con);
                DataTable table1 = new DataTable();
                adapter1.Fill(table1);

                string sql2 = "SELECT * FROM EXAM";

                SqlDataAdapter adapter2 = new SqlDataAdapter(sql2, con);
                DataTable table2 = new DataTable();
                adapter2.Fill(table2);
                DataView view2 = table2.DefaultView;
                
                string sql3 = "SELECT * FROM ACTIVITY";

                SqlDataAdapter adapter3 = new SqlDataAdapter(sql3, con);
                DataTable table3 = new DataTable();
                adapter3.Fill(table3);
                DataView view3 = table3.DefaultView;

                for(int i=0;i<table1.Rows.Count;i++)
                {
                    var studentInfo = table1.Rows[i].ItemArray;
                    view2.RowFilter = "rollno = " + studentInfo[0];
                    var subjectDetails = view2.ToTable().Rows[0].ItemArray;

                    view3.RowFilter = "rollno = " + studentInfo[0];
                    var activity = view3.ToTable().Rows[0].ItemArray;

                    results.Add(new Result(int.Parse(studentInfo[0].ToString()), studentInfo[1].ToString(), studentInfo[2].ToString(), int.Parse(subjectDetails[1].ToString()), int.Parse(subjectDetails[2].ToString()), int.Parse(subjectDetails[3].ToString()), int.Parse(subjectDetails[4].ToString()), int.Parse(subjectDetails[5].ToString()), int.Parse(activity[1].ToString()), int.Parse(activity[2].ToString()), int.Parse(activity[3].ToString()), int.Parse(activity[4].ToString())));
                }

            }

            //------------------- With File System

            //StreamReader reader = new StreamReader("Database.csv");
            //string headerLine = reader.ReadLine();
            //string line = null;

            //while((line=reader.ReadLine())!=null)
            //{
            //    var parts = line.Split(',');
            //    results.Add(new Result(int.Parse(parts[0]), parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]), int.Parse(parts[8]), int.Parse(parts[9]), int.Parse(parts[10]), int.Parse(parts[11])));
            //}


            for (int i = 0; i < results.Count; i++)
            {
                results[i].ExamMarksEntry();
                results[i].SportMarksEntry();
                results[i].TechnicalMarksEntry();
                results[i].NonTechnicalMarksEntry();
                results[i].AptitudeMarksEntry();
                results[i].ComputeFinalResult();
            }
            Console.WriteLine("*** Final Result ***");
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(String.Format("| {0, 10} | {1, -20} | {2, -20} | {3, 20} | {4, 20}  | {5, 20} |", "Roll No.", "Name", "Department", "Total Marks", "Result", "Comment"));
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");

            for (int i = 0; i < results.Count; i++)
                results[i].ShowResult();

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");

            Console.ReadKey();
        }
    }
}
