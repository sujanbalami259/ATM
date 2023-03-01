using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=BALAMI\SQLEXPRESS;Initial Catalog=ATMDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Balance from account where AccNum='" + accnum.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            balanceinrs.Text = "Rs"+dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void Balance_Load(object sender, EventArgs e)
        {
            accnum.Text = Home.AccNumber;
            getbalance();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            this.Hide();
            hm.Show();
        }

        //private void balanceinrs_Click(object sender, EventArgs e)
        //{

        //}
    }
}
