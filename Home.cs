using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            login hm= new login();    
            hm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Balance bl= new Balance();
            this.Hide();
            bl.Show();  
   
        }
        public static string AccNumber;
        private void Home_Load(object sender, EventArgs e)
        {
            AccountNumbertb.Text = "Account Number:"+login.AccNumber;
            AccNumber=login.AccNumber;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DEPOSIT DEPO=new DEPOSIT();
            DEPO.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangePin cgpin=new ChangePin();
            cgpin.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            withdraw with=new withdraw();
            with.Show();
            this.Hide();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FashCash fash=new FashCash();   
            fash.Show(); 
            this.Hide();    
        }
    }
}
