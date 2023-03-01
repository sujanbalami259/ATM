using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ATM
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Account acc= new Account();
            acc.Show();
            this.Hide();
        }
        public static String AccNumber;
        SqlConnection Con = new SqlConnection(@"Data Source=BALAMI\SQLEXPRESS;Initial Catalog=ATMDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda= new SqlDataAdapter("Select count(*) from Account Where  AccNum='"+ACCNUM.Text+"'and Pin='"+PINCODE.Text+"'",Con);    
            DataTable dt= new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                AccNumber = ACCNUM.Text;
                Home Hme = new Home(); 
                Hme.Show();
                this.Hide();
                Con.Close();
            }
            else
            {
                MessageBox.Show("Invalid login please check Account Number  or PinCode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void ACCNUM_Enter(object sender, EventArgs e)
        {
           
            
        }

        private void ACCNUM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                PINCODE.Focus();
            }
        }
    }
}