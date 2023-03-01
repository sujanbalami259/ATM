namespace ATM
{
    partial class withdraw
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Atm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Label();
            this.withdrawtb = new System.Windows.Forms.Button();
            this.amtfield = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.balancetb = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Atm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 72);
            this.panel1.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(499, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(650, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "X";
            // 
            // Atm
            // 
            this.Atm.AutoSize = true;
            this.Atm.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Atm.ForeColor = System.Drawing.Color.White;
            this.Atm.Location = new System.Drawing.Point(51, 20);
            this.Atm.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Atm.Name = "Atm";
            this.Atm.Size = new System.Drawing.Size(395, 28);
            this.Atm.TabIndex = 1;
            this.Atm.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(267, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 33);
            this.label1.TabIndex = 44;
            this.label1.Text = "Withdraw";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(0, 337);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 17);
            this.panel2.TabIndex = 43;
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.back.Location = new System.Drawing.Point(306, 295);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(71, 28);
            this.back.TabIndex = 42;
            this.back.Text = "Back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // withdrawtb
            // 
            this.withdrawtb.BackColor = System.Drawing.Color.DarkSlateGray;
            this.withdrawtb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.withdrawtb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.withdrawtb.ForeColor = System.Drawing.Color.White;
            this.withdrawtb.Location = new System.Drawing.Point(229, 237);
            this.withdrawtb.Name = "withdrawtb";
            this.withdrawtb.Size = new System.Drawing.Size(230, 39);
            this.withdrawtb.TabIndex = 41;
            this.withdrawtb.Text = "Withdraw Amount";
            this.withdrawtb.UseVisualStyleBackColor = false;
            this.withdrawtb.Click += new System.EventHandler(this.button1_Click);
            // 
            // amtfield
            // 
            this.amtfield.Location = new System.Drawing.Point(229, 187);
            this.amtfield.Multiline = true;
            this.amtfield.Name = "amtfield";
            this.amtfield.Size = new System.Drawing.Size(230, 31);
            this.amtfield.TabIndex = 40;
            this.amtfield.TextChanged += new System.EventHandler(this.amtfield_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(41, 189);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 28);
            this.label7.TabIndex = 39;
            this.label7.Text = "AMOUNT:";
            // 
            // balancetb
            // 
            this.balancetb.AutoSize = true;
            this.balancetb.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.balancetb.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.balancetb.Location = new System.Drawing.Point(46, 133);
            this.balancetb.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.balancetb.Name = "balancetb";
            this.balancetb.Size = new System.Drawing.Size(259, 33);
            this.balancetb.TabIndex = 45;
            this.balancetb.Text = "AvailableBalance";
            // 
            // withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 352);
            this.Controls.Add(this.balancetb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.back);
            this.Controls.Add(this.withdrawtb);
            this.Controls.Add(this.amtfield);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "withdraw";
            this.Load += new System.EventHandler(this.withdraw_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label2;
        private Label Atm;
        private Label label1;
        private Panel panel2;
        private Label back;
        private Button withdrawtb;
        private TextBox amtfield;
        private Label label7;
        private Label balancetb;
    }
}