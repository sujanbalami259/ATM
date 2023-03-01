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
    public partial class FashCash : Form
    {
        public FashCash()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=BALAMI\SQLEXPRESS;Initial Catalog=ATMDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        string Acc = login.AccNumber;
        int bal;
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Balance from account where AccNum='" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            balancetb.Text = "Balance Rs :" + dt.Rows[0][0].ToString();
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
       
            private void FashCash_Load_1(object sender, EventArgs e)
        {
            getbalance();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void label3_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }
        private void AddTransation()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into tbl_Transaction values('" + Acc + "','" + TrType + "'," + 500 + ",'" + DateTime.Today.Date.ToString() + "')";
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
        private void button4_Click(object sender, EventArgs e)
        {

            if (bal < 500)
            {
                MessageBox.Show("Low Balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int newbalance = bal - 500;
                try
                {
                    Con.Open();
                    string query = "Update Account set Balance=" + newbalance + "where AccNum='" + Acc + "'";
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

        }
        private void AddTransation1()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into tbl_Transaction values('" + Acc + "','" + TrType + "'," + 1000 + ",'" + DateTime.Today.Date.ToString() + "')";
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
        private void button2_Click(object sender, EventArgs e)
        {

            if (bal < 1000)
            {
                MessageBox.Show("Low Balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int newbalance = bal - 1000;
                try
                {
                    Con.Open();
                    string query = "Update Account set Balance=" + newbalance + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Amount is Successfully Withdraw");
                        Con.Close();
                    AddTransation1();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                 
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void AddTransation2()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into tbl_Transaction values('" + Acc + "','" + TrType + "'," + 2000 + ",'" + DateTime.Today.Date.ToString() + "')";
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
        private void button5_Click(object sender, EventArgs e)
        {

            if (bal < 2000)
            {
                MessageBox.Show("Low Balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int newbalance = bal - 2000;
                try
                {
                    Con.Open();
                    string query = "Update Account set Balance=" + newbalance + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Amount is Successfully Withdraw");
                    Con.Close();
                    AddTransation2();   
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void AddTransation3()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into tbl_Transaction values('" + Acc + "','" + TrType + "'," + 3000 + ",'" + DateTime.Today.Date.ToString() + "')";
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
            if (bal < 3000)
            {
                MessageBox.Show("Low Balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int newbalance = bal - 3000;
                try
                {
                    Con.Open();
                    string query = "Update Account set Balance=" + newbalance + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Amount is Successfully Withdraw");
                    Con.Close();
                    AddTransation3();   
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }
        private void AddTransation4()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into tbl_Transaction values('" + Acc + "','" + TrType + "'," + 4000 + ",'" + DateTime.Today.Date.ToString() + "')";
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
        private void button3_Click(object sender, EventArgs e)
        {
            if (bal < 4000)
            {
                MessageBox.Show("Low Balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int newbalance = bal - 4000;
                try
                {
                    Con.Open();
                    string query = "Update Account set Balance=" + newbalance + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Amount is Successfully Withdraw");
                    Con.Close();    
                    AddTransation4();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void AddTransation5()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into tbl_Transaction values('" + Acc + "','" + TrType + "'," + 5000 + ",'" + DateTime.Today.Date.ToString() + "')";
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
        private void button6_Click(object sender, EventArgs e)
        {
            if (bal < 5000)
            {
                MessageBox.Show("Low Balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int newbalance = bal - 5000;
                try
                {
                    Con.Open();
                    string query = "Update Account set Balance=" + newbalance + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Amount is Successfully Withdraw");
                    Con.Close();
                    AddTransation5();   
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Home hm= new Home();
            hm.Show();  
            this.Hide();
        }
    }
}