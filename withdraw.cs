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

namespace ATM
{
    public partial class withdraw : Form
    {
        public withdraw()
        {
            InitializeComponent();
        }
       SqlConnection Con = new SqlConnection(@"Data Source=BALAMI\SQLEXPRESS;Initial Catalog=ATMDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
       string Acc = login.AccNumber;
        int bal;
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Balance from account where AccNum='" +Acc+ "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            balancetb.Text = " BalanceRs" + dt.Rows[0][0].ToString();
            bal= Convert.ToInt32(dt.Rows[0][0].ToString()); 
            Con.Close();
        }
        private void AddTransation()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into tbl_Transaction values('" + Acc + "','" + TrType + "'," + amtfield.Text + ",'" + DateTime.Today.Date.ToString() + "')";
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
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Home hm= new Home();
            hm.Show();
            this.Close();
        }
        int newbalance;
        private void button1_Click(object sender, EventArgs e)
        {
            if (amtfield.Text == "")
            {
                MessageBox.Show("Enter amount to withdraw", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(amtfield.Text) <= 0)
            {
                MessageBox.Show("Please Enter valid amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(amtfield.Text) > bal)

            {
                MessageBox.Show("Insufficient balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    newbalance = bal - Convert.ToInt32(amtfield.Text);
                    try
                    {
                        Con.Open();
                        string query = "Update Account set Balance=" + newbalance + " where AccNum='" + Acc + "'";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Amount is Successfully Withdraw");
                        Con.Close();
                        AddTransation();
                        Home home = new Home();
                        home.Show();
                        this.Hide();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }   
            }
        }

        private void withdraw_Load(object sender, EventArgs e)
        {
            getbalance();
        }

        private void amtfield_TextChanged(object sender, EventArgs e)
        {

        }
    }
 }

