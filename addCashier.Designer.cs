namespace Cafe_Management_System
{
    partial class addCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addCashier));
            pictureBox1 = new PictureBox();
            label3 = new Label();
            mID = new Label();
            ID = new TextBox();
            fname = new TextBox();
            label1 = new Label();
            password = new TextBox();
            label2 = new Label();
            salary = new TextBox();
            label4 = new Label();
            cont = new TextBox();
            label5 = new Label();
            hiredate = new TextBox();
            label6 = new Label();
            button1 = new Button();
            email = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(344, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(424, 541);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(465, 42);
            label3.Name = "label3";
            label3.Size = new Size(187, 42);
            label3.TabIndex = 10;
            label3.Text = "Add Cashier";
            // 
            // mID
            // 
            mID.AutoSize = true;
            mID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mID.Location = new Point(83, 100);
            mID.Name = "mID";
            mID.Size = new Size(25, 21);
            mID.TabIndex = 25;
            mID.Text = "ID";
            // 
            // ID
            // 
            ID.Location = new Point(127, 100);
            ID.Name = "ID";
            ID.Size = new Size(120, 23);
            ID.TabIndex = 26;
            // 
            // fname
            // 
            fname.Location = new Point(127, 141);
            fname.Name = "fname";
            fname.Size = new Size(120, 23);
            fname.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 143);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 27;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // password
            // 
            password.Location = new Point(127, 182);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(120, 23);
            password.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 184);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 29;
            label2.Text = "Password";
            // 
            // salary
            // 
            salary.Location = new Point(127, 270);
            salary.Name = "salary";
            salary.Size = new Size(120, 23);
            salary.TabIndex = 32;
            salary.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(55, 268);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 31;
            label4.Text = "Salary";
            label4.Click += label4_Click;
            // 
            // cont
            // 
            cont.Location = new Point(127, 309);
            cont.Name = "cont";
            cont.Size = new Size(120, 23);
            cont.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(43, 311);
            label5.Name = "label5";
            label5.Size = new Size(63, 21);
            label5.TabIndex = 33;
            label5.Text = "Contact";
            // 
            // hiredate
            // 
            hiredate.Location = new Point(127, 349);
            hiredate.Name = "hiredate";
            hiredate.Size = new Size(120, 23);
            hiredate.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(33, 351);
            label6.Name = "label6";
            label6.Size = new Size(75, 21);
            label6.TabIndex = 35;
            label6.Text = "Hire Date";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Tw Cen MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.SaddleBrown;
            button1.Location = new Point(127, 398);
            button1.Name = "button1";
            button1.Size = new Size(97, 39);
            button1.TabIndex = 37;
            button1.Text = "Sign up";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // email
            // 
            email.Location = new Point(127, 228);
            email.Name = "email";
            email.Size = new Size(120, 23);
            email.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(55, 230);
            label7.Name = "label7";
            label7.Size = new Size(48, 21);
            label7.TabIndex = 38;
            label7.Text = "Email";
            label7.Click += label7_Click;
            // 
            // addCashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 543);
            Controls.Add(email);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(hiredate);
            Controls.Add(label6);
            Controls.Add(cont);
            Controls.Add(label5);
            Controls.Add(salary);
            Controls.Add(label4);
            Controls.Add(password);
            Controls.Add(label2);
            Controls.Add(fname);
            Controls.Add(label1);
            Controls.Add(ID);
            Controls.Add(mID);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Name = "addCashier";
            Text = "addCashier";
            Load += addCashier_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label3;
        private Label mID;
        private TextBox ID;
        private TextBox fname;
        private Label label1;
        private TextBox password;
        private Label label2;
        private TextBox salary;
        private Label label4;
        private TextBox cont;
        private Label label5;
        private TextBox hiredate;
        private Label label6;
        private Button button1;
        private TextBox email;
        private Label label7;
    }
}