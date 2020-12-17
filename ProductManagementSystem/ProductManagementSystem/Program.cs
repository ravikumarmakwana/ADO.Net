using System;
using System.Data.SqlClient;

namespace ProductManagementSystem
{
    class Program
    {
        /**
         * 
         * Author : Ravikumar Makwana
         * Aim : Perform 100% Insert, Update & Delete Commands
         * 
         */

        static void Main(string[] args)
        {
            Console.WriteLine("*** Product Management System ***");
            Console.WriteLine();
            ProductManagement productManagement = new ProductManagement("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=G:\\C# Programming\\ProductManagementSystem\\ProductManagementSystem\\Products.mdf;Integrated Security=True");
            int choice;
            string pName, pDesc;
            int pId, price, stock;
            
            while(true)
            {
                Console.WriteLine("1. Insert New Product");
                Console.WriteLine("2. Delete Product");
                Console.WriteLine("3. Update Product");
                Console.WriteLine("4. Search Product");
                Console.WriteLine("5. Show All Products");
                Console.WriteLine("6. Complete Transaction");
                Console.Write("Please enter the your choice : ");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                try
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("--- Insert New Product ---");
                            Console.Write("Please enter the Product Id : ");
                            pId = int.Parse(Console.ReadLine());
                            Console.Write("Please enter the Product Name : ");
                            pName = Console.ReadLine();
                            Console.Write("Please enter the Product Description : ");
                            pDesc = Console.ReadLine();
                            Console.Write("Please enter the Product Stock : ");
                            stock = int.Parse(Console.ReadLine());
                            Console.Write("Please enter the Product Price : ");
                            price = int.Parse(Console.ReadLine());

                            Console.WriteLine(productManagement.Insert(pId, pName, pDesc, stock, price));
                            break;

                        case 2:
                            Console.WriteLine("--- Delete Product ---");
                            Console.Write("Delete By (Column name): ");
                            string columnName = Console.ReadLine();
                            Console.Write("Please enter the keyword that you want to delete data : ");
                            string columnValue = Console.ReadLine();

                            Console.WriteLine(productManagement.DeleteProduct(columnName, columnValue));
                            break;

                        case 3:
                            Console.WriteLine("--- Update Product ---");
                            Console.Write("Enter the column name that you want to update : ");
                            string newColumnName = Console.ReadLine();
                            Console.Write("Enter the new value : ");
                            string newColumnValue = Console.ReadLine();
                            Console.Write("Enter the Conditional ColumnName : ");
                            string conditionalColumn = Console.ReadLine();
                            Console.Write("Enter the Conditional ColumnValue : ");
                            string conditionalValue = Console.ReadLine();

                            Console.WriteLine(productManagement.UpdateProduct(newColumnName,newColumnValue, conditionalColumn, conditionalValue));
                            break;

                        case 4:
                            Console.WriteLine("--- Search Product ---");
                            Console.Write("Enter the column name that you want to search : ");
                            string searchColumnName = Console.ReadLine();
                            Console.Write("Enter the search text : ");
                            string searchColumnValue = Console.ReadLine();
                            SqlDataReader dataReader = productManagement.SearchProduct(searchColumnName,searchColumnValue);
                            Console.WriteLine(String.Format("{0, 10} | {1, 20} | {2, 20} | {3, 10} | {4, 10}", "PID", "PNAME", "PDESC", "STOCK", "PRICE"));
                            while (dataReader.Read())
                            {
                                Console.WriteLine(String.Format("{0, 10} | {1, 20} | {2, 20} | {3, 10} | {4, 10}", dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString()));
                            }
                            dataReader.Close();
                            break;

                        case 5:
                            Console.WriteLine("--- Show All Products ---");
                            SqlDataReader reader = productManagement.ShowAllProducts();
                            Console.WriteLine(String.Format("{0, 10} | {1, 20} | {2, 20} | {3, 10} | {4, 10}", "PID", "PNAME", "PDESC", "STOCK", "PRICE"));
                            while (reader.Read())
                            {
                                Console.WriteLine(String.Format("{0, 10} | {1, 20} | {2, 20} | {3, 10} | {4, 10}", reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString()));
                            }
                            reader.Close();
                            break;

                        case 6:
                            productManagement.CompleteTransaction();
                            Console.WriteLine("Transaction Completed !!!");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Wrong Choice");
                            break;
                    }
                }
                catch(Exception exception)
                {
                    var color = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Exception  : "+exception.Message);
                    Console.ForegroundColor = color;
                }
                
                Console.WriteLine();
            }
        }
    }
}
