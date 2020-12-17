using System;
using System.Data;
using System.Data.SqlClient;

namespace ProductManagementSystem
{
    public class ProductManagement
    {
        SqlConnection Con; 
        public ProductManagement(string connectionString)
        {
            Con = new SqlConnection(connectionString);
            Con.Open();
        }
        public string Insert(int pId, string pName, string pDesc, int stock, int price) 
        {
            string sql = "INSERT INTO Product VALUES (@pId, @pName, @pDesc, @stock, @price)";
            SqlCommand cmd = new SqlCommand(sql, Con);
            
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@pId",pId));
            cmd.Parameters.Add(new SqlParameter("@pName",pName));
            cmd.Parameters.Add(new SqlParameter("@pDesc", pDesc));
            cmd.Parameters.Add(new SqlParameter("@stock", stock));
            cmd.Parameters.Add(new SqlParameter("@price", price));

            return cmd.ExecuteNonQuery().ToString() + " Row Affacted.";
        }

        public string DeleteProduct(string columnName, string columnValue)
        {
            if (columnName.ToLower() == "pname" || columnName.ToLower() == "pdesc")
            {
                return DeleteByString(columnName, columnValue);
            }
            else
            {
                return DeleteByInt(columnName, int.Parse(columnValue));
            }
        }
        public string DeleteByInt(string columnName, int columnValue)
        {
            string sql = "DELETE FROM Product WHERE " + columnName + " = @columnValue";
            SqlCommand cmd = new SqlCommand(sql, Con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@columnValue",columnValue));
            return cmd.ExecuteNonQuery().ToString() + " Rows Deleted.";
        }
        public string DeleteByString(string columnName, string columnValue)
        {
            string sql = "DELETE FROM Product WHERE "+columnName+" LIKE @columnValue";
            SqlCommand cmd = new SqlCommand(sql, Con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@columnValue", columnValue));
            return cmd.ExecuteNonQuery().ToString() + " Rows Deleted.";
        }
        public string UpdateProduct(string columnName, string newValue, string conditionalColumn, string conditionalValue)
        {
            string sql;
            
            if (conditionalColumn.ToLower() == "pname" || conditionalColumn.ToLower() == "pdesc")
                sql = "UPDATE Product set " + columnName + " = @newValue WHERE " + conditionalColumn + " LIKE @conditionalValue";
            else
                sql = "UPDATE Product set " + columnName + " = @newValue WHERE " + conditionalColumn + " = @conditionalValue";

            SqlCommand cmd = new SqlCommand(sql, Con);
            cmd.CommandType = CommandType.Text;
            if ((columnName.ToLower() == "pname" || columnName.ToLower() == "pdesc") && (conditionalColumn.ToLower() == "pname" || conditionalColumn.ToLower() == "pdesc"))
            {
                cmd.Parameters.Add(new SqlParameter("@newValue", newValue));
                cmd.Parameters.Add(new SqlParameter("@conditionalValue", conditionalValue));
            }
            else if ((columnName.ToLower() != "pname" || columnName.ToLower() != "pdesc") && (conditionalColumn.ToLower() == "pname" || conditionalColumn.ToLower() == "pdesc"))
            {
                cmd.Parameters.Add(new SqlParameter("@newValue", int.Parse(newValue)));
                cmd.Parameters.Add(new SqlParameter("@conditionalValue", conditionalValue));
            }
            else if ((columnName.ToLower() == "pname" || columnName.ToLower() == "pdesc") && (conditionalColumn.ToLower() != "pname" || conditionalColumn.ToLower() != "pdesc"))
            {
                cmd.Parameters.Add(new SqlParameter("@newValue", newValue));
                cmd.Parameters.Add(new SqlParameter("@conditionalValue", int.Parse(conditionalValue)));
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@newValue", int.Parse(newValue)));
                cmd.Parameters.Add(new SqlParameter("@conditionalValue", int.Parse(conditionalValue)));
            }

            Console.WriteLine(sql);
            return cmd.ExecuteNonQuery() + " Rows are Updated";

        }
        public SqlDataReader ShowAllProducts()
        {
            string sql = "SELECT * FROM Product";
            SqlCommand cmd = new SqlCommand(sql, Con);

            SqlDataReader dataReader = cmd.ExecuteReader();

            return dataReader;
        }
        public SqlDataReader SearchProduct(string columnName, string columnValue)
        {
            string sql;
            if(columnName.ToLower() =="pname" || columnName.ToLower() == "pdesc")
            {
                sql = "SELECT * FROM Product WHERE "+columnName+" LIKE @columnValue";
                SqlCommand cmd = new SqlCommand(sql,Con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@columnValue", columnValue));
                return cmd.ExecuteReader();
            }
            else
            {
                sql = "SELECT * FROM Product WHERE " + columnName + " = @columnValue";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@columnValue", int.Parse(columnValue)));
                return cmd.ExecuteReader();
            }
        }
        public void CompleteTransaction()
        {
            Con.Close();
            Con.Dispose();
        }
    }
}
