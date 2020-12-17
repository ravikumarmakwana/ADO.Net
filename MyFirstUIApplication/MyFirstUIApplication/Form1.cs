using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstUIApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            SqlConnection con=null;
            try {

                string conString = "Data Source=RAVIMAKWANA;Initial Catalog=Employee;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                con = new SqlConnection(conString);
                con.Open();
                string sql = "INSERT INTO emp (empno, ename, job, mgr, hiredate, sal, comm, deptno) VALUES (@empno, @ename, @job, @mgr, @hiredate, @sal, @comm, @deptno)";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.Add(new SqlParameter("@empno", int.Parse(empno.Text)));
                cmd.Parameters.Add(new SqlParameter("@ename", ename.Text));
                cmd.Parameters.Add(new SqlParameter("@job", job.Text));
                cmd.Parameters.Add(new SqlParameter("@mgr", int.Parse(mgr.Text)));
                cmd.Parameters.Add(new SqlParameter("@hiredate", DateTime.Parse(hiredate.Text)));
                cmd.Parameters.Add(new SqlParameter("@sal", int.Parse(sal.Text)));
                cmd.Parameters.Add(new SqlParameter("@comm", int.Parse(comm.Text)));
                cmd.Parameters.Add(new SqlParameter("@deptno", int.Parse(deptno.Text)));

                if (cmd.ExecuteNonQuery() != 0)
                    result.Text = "Data Inserted Successfully !";
                else
                    result.Text = "Some Errors !";

            }
            catch(SqlException sqlEx)
            {
                result.Text = sqlEx.Message;
            }
            catch(Exception ex)
            {
                result.Text = ex.Message;
            }
            finally
            {
                con.Close();
                ename.Text = empno.Text = job.Text = hiredate.Text = comm.Text = sal.Text = deptno.Text = mgr.Text = "";
            }
        }
    }
}
