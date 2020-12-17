using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingTables
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable table = new DataTable();
            DataColumn column;

            // Method 1 Useing Add() Method 
            table.Columns.Add("ProductId", typeof(int));

            //Method 2 Using DataColumn Object
            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "ProductName"
            };
            table.Columns.Add(column);

            //Method 3 Using DataColumn object in Add() Method
            table.Columns.Add(
                new DataColumn
                {
                    DataType = typeof(string),
                    ColumnName = "ProductDescription"
                }
            );
            table.Columns.Add("Stock", typeof(int));
            table.Columns.Add("Price", typeof(int));

            table.Rows.Add(1, "Redmi 5", "Smart Android Phone",10, 10000);
            table.Rows.Add(2, "Mouse", "Wireless", 50, 900);
            table.Rows.Add(3, "HP Laptop", "8GB RAM", 5, 100000);
            table.Rows.Add(4, "Apple Watch", "Smart Watch", 10, 23000);

            table.AcceptChanges();
            Console.WriteLine(String.Format("{0, -5} | {1, -20} | {2, -20} | {3, -10} | {4, -10}", "PID","PANME","PDESC","STOCK","PRICE"));
            for (int i=0;i<table.Rows.Count;i++)
            {
                Console.WriteLine(String.Format("{0, -5} | {1, -20} | {2, -20} | {3, -10} | {4, -10}",table.Rows[i].ItemArray));
            }

            Console.WriteLine("--------------------------------");

            DataRow[] rows = table.Select("Price <= 10000");
            Console.WriteLine("Price <= 10000");
            foreach (var row in rows)
            {
                Console.WriteLine(String.Format("{0, -5} | {1, -20} | {2, -20} | {3, -10} | {4, -10}",row.ItemArray));
            }

            /*
             Clone Table means Copy Whole Structure of table &
             Copy Table means Copy Structure as well as Data.
             */
            Console.WriteLine("_---------------------------");

            DataTable newTable = table.Select("Price <= 10000").CopyToDataTable();
            
            Console.WriteLine("New Table ");
            for (int i = 0; i < newTable.Rows.Count; i++)
            {
                Console.WriteLine(String.Format("{0, -5} | {1, -20} | {2, -20} | {3, -10} | {4, -10}", newTable.Rows[i].ItemArray));
            }
            
            Console.ReadKey();
        }
    }
}
