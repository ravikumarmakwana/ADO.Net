using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginModule
{
    public partial class UserControl2 : UserControl
    {
        private string conString = "Data Source=RAVIMAKWANA;Initial Catalog=UserAccounts;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection con = null;

        public UserControl2()
        {
            InitializeComponent();
            con = new SqlConnection(conString);
            con.Open();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO USERS (name, username, password) VALUES (@name, @username, @password)";
            SqlCommand cmd = new SqlCommand(sql, con);
            
            cmd.CommandType = CommandType.Text;
            
            cmd.Parameters.Add(new SqlParameter("@name",name.Text));
            cmd.Parameters.Add(new SqlParameter("@username",username.Text));
            cmd.Parameters.Add(new SqlParameter("@password",password.Text));

            if (cmd.ExecuteNonQuery() == 1)
                result.Text = "Sign In Successful !";
            else
                result.Text = "Sign In Failed !";

        }
    }
}
