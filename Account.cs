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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=BALAMI\SQLEXPRESS;Initial Catalog=ATMDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
     
        private void button1_Click_1(object sender, EventArgs e)
        {
            int balance = 0;
            if (AccNumtb.Text == "" || Nametb.Text == "" || FNametb.Text == "" || Phonetb.Text == "" || Addresstb.Text == "" || Occuptiontb.Text == "" || Pintb.Text == "") 
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into Account values('"+AccNumtb.Text+ "','"+Nametb.Text+ "','"+FNametb.Text+ "','"+Datetb.Value.Date+ "','"+ Phonetb.Text + "','"+ Addresstb.Text + "','" + Educationcb.SelectedItem.ToString()+ "','"+ Occuptiontb.Text + "',"+Pintb.Text+","+balance+")";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Account is created Successfully");
                    Con.Close();
                    login log = new login();
                    log.Show();
                    this.Hide();
                }
                catch(Exception Ex) 
                { 
                    MessageBox.Show(Ex.Message);    
                }
               
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Addresstb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Account_Load(object sender, EventArgs e)
        {

        }
    }
}
