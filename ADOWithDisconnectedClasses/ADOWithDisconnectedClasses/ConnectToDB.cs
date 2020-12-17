using System;
using System.Data;
using System.Data.SqlClient;

namespace ADOWithDisconnectedClasses
{
    class ConnectToDB
    {
        string conString = "Data Source=RAVIMAKWANA;Initial Catalog=UserAccounts;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection con = null;
        public ConnectToDB()
        {
            con = new SqlConnection(conString);
            con.Open(); //Open Connection to DataSource
        }
        public void CloseConnection()
        {
            con.Close();
            con.Dispose();
        }
        public string Insert(string name, string username, string password)
        {
            string sql = "INSERT INTO users (name, username, password) VALUES (@name, @username, @password)";
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.InsertCommand = new SqlCommand(sql, con);
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@name",name));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@username",username));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@password",password));

            int row = adapter.InsertCommand.ExecuteNonQuery();
            return row +" row affected. ";
        }
        public DataSet Select()
        {
            string sql = "SELECT * FROM users";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            
            return dataSet;
        }
        public string Delete(string column, string value)
        {
            string sql = "DELETE FROM users WHERE "+column+" = @value ";
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.DeleteCommand = new SqlCommand(sql, con);
            adapter.DeleteCommand.Parameters.Add(new SqlParameter("@value", value));

            int row = adapter.DeleteCommand.ExecuteNonQuery();
            return row + " row Deleted. ";
        }
        public string Update(string column, string newValue, string columnName, String columnValue)
        {
            string sql = "UPDATE USERS SET "+column+" = @NewValue WHERE "+columnName+" = @ColumnValue ";
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.UpdateCommand = new SqlCommand(sql, con);
            adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NewValue",newValue));
            adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ColumnValue",columnValue));
            
            int row = adapter.UpdateCommand.ExecuteNonQuery();
            return row + " row Updated.";
        }
    }
}
