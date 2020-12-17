using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOWithDisconnectedClasses
{
    class Program
    {
        /**
         *
         *  Author : Ravikumar Makwana
         *  Aim : To perform Insert, Update, Delete and Select command with help of ADO.NET Disconnected Architecture  
         *
         */
        static void Main(string[] args)
        {
            var connectToDB = new ConnectToDB(); // Connect To Database

            string name, username, password, column, value, columnName, columnValue; ;
            while(true)
            {
                Console.WriteLine("1. INSERT");
                Console.WriteLine("2. DELETE");
                Console.WriteLine("3. UPDATE");
                Console.WriteLine("4. SELECT");
                Console.WriteLine("5. EXIT");
                Console.Write("Please enter the choice : ");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("--- INSERT ---");
                        Console.WriteLine();

                        Console.Write("Please enter the name : ");
                        name = Console.ReadLine();
                        Console.Write("Please enter the username : ");
                        username = Console.ReadLine();
                        Console.Write("Please enter the password : ");
                        password = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine(connectToDB.Insert(name,username,password));

                        break;

                    case 2:
                        Console.WriteLine("--- DELETE ---");
                        Console.WriteLine();

                        Console.WriteLine("DELETE FROM USERS\nWHERE column = value");
                        Console.WriteLine();
                        Console.WriteLine("Please enter the values of column and value");
                        Console.Write("Column : ");
                        column = Console.ReadLine();
                        Console.Write("Value : ");
                        value = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine(connectToDB.Delete(column, value));

                        break;

                    case 3:
                        Console.WriteLine("--- UPDATE ---");
                        Console.WriteLine();

                        Console.WriteLine("Update USERS\nSET\nColumn = NewValue\nWHERE ColumnName = ColumnValue //Condition");
                        Console.WriteLine();
                        Console.WriteLine("Please enter the following values in order to perform update operation.");
                        Console.Write("Please entert the  Column : ");
                        column = Console.ReadLine();
                        Console.Write("Please entert the  NewValue : ");
                        value = Console.ReadLine();
                        Console.Write("Please entert the  ColumnName : ");
                        columnName = Console.ReadLine();
                        Console.Write("Please entert the  ColumnValue : ");
                        columnValue = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine(connectToDB.Update(column, value, columnName, columnValue));

                        break;

                    case 4:
                        Console.WriteLine("--- SELECT ---");
                        Console.WriteLine();

                        DataSet dataSet = connectToDB.Select();
                        Console.WriteLine("-----------------------------------------------------------------------------------");
                        Console.WriteLine(String.Format("| {0, -10} | {1, -20} | {2, -20} | {3, -20} | ","UserId","Name","UserName","Password"));
                        Console.WriteLine("-----------------------------------------------------------------------------------");
                        for(int i=0;i<dataSet.Tables[0].Rows.Count;i++)
                        {
                            Console.WriteLine(
                                String.Format("| {0, -10} | {1, -20} | {2, -20} | {3, -20} | ", dataSet.Tables[0].Rows[i].ItemArray)
                                );
                        }
                        Console.WriteLine("-----------------------------------------------------------------------------------");
                        break;

                    case 5:
                        Console.WriteLine("--- EXIT ---");
                        Console.WriteLine();
                        
                        connectToDB.CloseConnection();
                        Console.WriteLine("Click any key to exit program");
                        Console.ReadKey();
                        Environment.Exit(0);
                        
                        break;

                    default:
                        Console.WriteLine("Wrong Choice !!!");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
