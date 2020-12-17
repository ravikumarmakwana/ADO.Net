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
    public partial class UserControl3 : UserControl
    {
        private string conString = "Data Source=RAVIMAKWANA;Initial Catalog=UserAccounts;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection con = null;
        public UserControl3()
        {
            InitializeComponent();
            con = new SqlConnection(conString);
            con.Open();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM USERS WHERE username = @username AND password = @password";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@username", lusername.Text));
            cmd.Parameters.Add(new SqlParameter("@password", lpassword.Text)) ;

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
                lresult.Text = "Login Successful !";
            else
                lresult.Text = "Login Failed";
            reader.Close();
        }
    }
}
