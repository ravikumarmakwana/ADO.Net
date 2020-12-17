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

namespace LoginModule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            userControl11.Show();
            userControl11.BringToFront();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Show();
            userControl21.BringToFront();
            userControl31.Hide();
            userControl41.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Show();
            userControl31.BringToFront();
            userControl41.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl11.BringToFront();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Show();
            userControl41.BringToFront();
        }
    }
}
