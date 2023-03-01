using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class DEPOSIT : Form
    {
        public DEPOSIT()
        {
            InitializeComponent();
        }
      
        SqlConnection Con = new SqlConnection(@"Data Source=BALAMI\SQLEXPRESS;Initial Catalog=ATMDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        string Acc = login.AccNumber;
        private void AddTransation()
        {
            string TrType = "Deposit";
            try
            {
                Con.Open();
                string query = "insert into tbl_Transaction values('" + Acc + "','" + TrType + "'," + depositamtfield.Text + ",'" + DateTime.Today.Date.ToString() +"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                login log = new login();
                log.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (depositamtfield.Text == "" || Convert.ToInt32(depositamtfield.Text) <= 0) 
            {
                MessageBox.Show("Enter Amount to deposit");
            }
            else
            {
              
                newbalance = oldbalance + Convert.ToInt32(depositamtfield.Text);
                try
                {
                  Con.Open();
                    string query="Update Account set Balance="+newbalance+"where AccNum='"+Acc+"'";
                    SqlCommand  cmd =new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Amount is Successfully Deposited");
                    Con.Close();
                    AddTransation();
                    Home home= new Home();  
                    home.Show();    
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
            Home home= new Home();
            home.Show();    
            this.Hide();
        }
        int oldbalance;
        int newbalance;
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Balance from account where AccNum='" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldbalance = Convert.ToInt32 (dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void DEPOSIT_Load(object sender, EventArgs e)
        {
            getbalance();

        }
    }
}
