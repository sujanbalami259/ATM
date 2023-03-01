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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        } 
        SqlConnection Con = new SqlConnection(@"Data Source=BALAMI\SQLEXPRESS;Initial Catalog=ATMDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        string Acc = login.AccNumber;
        private void ChangePin_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pinfield.Text == "" || confirmpinfield.Text == "")
            {
                MessageBox.Show("Enter new pin and confirm pin");
            }
            else if (confirmpinfield.Text != pinfield.Text)
            {
                MessageBox.Show("New PIN CODE and Confirm Pin doesnot match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Update Account set Pin=" + pinfield.Text + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your PIN CODE is Successfully Changed");
                    login lg = new login();
                    lg.Show();
                    this.Hide();
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();    
            this.Hide();
        }
    }
}
