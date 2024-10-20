namespace Cafe_Management_System
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox2 = new PictureBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            mCont = new TextBox();
            label2 = new Label();
            mExp = new TextBox();
            label1 = new Label();
            mPass = new TextBox();
            label4 = new Label();
            mEmail = new TextBox();
            label5 = new Label();
            Lname = new TextBox();
            label6 = new Label();
            Fname = new TextBox();
            label7 = new Label();
            ManID = new TextBox();
            mID = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(441, 76);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(239, 241);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(498, 334);
            label3.Name = "label3";
            label3.Size = new Size(142, 40);
            label3.TabIndex = 9;
            label3.Text = "My Cafe";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(344, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(424, 541);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Tw Cen MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.SaddleBrown;
            button1.Location = new Point(158, 340);
            button1.Name = "button1";
            button1.Size = new Size(97, 39);
            button1.TabIndex = 15;
            button1.Text = "Sign up";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // mCont
            // 
            mCont.ForeColor = Color.SaddleBrown;
            mCont.Location = new Point(113, 302);
            mCont.Name = "mCont";
            mCont.Size = new Size(181, 23);
            mCont.TabIndex = 14;
            mCont.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 300);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 13;
            label2.Text = "Contact";
            // 
            // mExp
            // 
            mExp.ForeColor = Color.SaddleBrown;
            mExp.Location = new Point(113, 264);
            mExp.Name = "mExp";
            mExp.Size = new Size(181, 23);
            mExp.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 264);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 11;
            label1.Text = "Experience";
            label1.Click += label1_Click;
            // 
            // mPass
            // 
            mPass.ForeColor = Color.SaddleBrown;
            mPass.Location = new Point(113, 227);
            mPass.Name = "mPass";
            mPass.PasswordChar = '*';
            mPass.Size = new Size(181, 23);
            mPass.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 227);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 18;
            label4.Text = "Password";
            // 
            // mEmail
            // 
            mEmail.ForeColor = Color.SaddleBrown;
            mEmail.Location = new Point(113, 186);
            mEmail.Name = "mEmail";
            mEmail.Size = new Size(181, 23);
            mEmail.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(31, 186);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 16;
            label5.Text = "Email";
            // 
            // Lname
            // 
            Lname.ForeColor = Color.SaddleBrown;
            Lname.Location = new Point(113, 145);
            Lname.Name = "Lname";
            Lname.Size = new Size(181, 23);
            Lname.TabIndex = 23;
            Lname.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(21, 145);
            label6.Name = "label6";
            label6.Size = new Size(81, 21);
            label6.TabIndex = 22;
            label6.Text = "Last name";
            label6.Click += label6_Click;
            // 
            // Fname
            // 
            Fname.ForeColor = Color.SaddleBrown;
            Fname.Location = new Point(113, 104);
            Fname.Name = "Fname";
            Fname.Size = new Size(181, 23);
            Fname.TabIndex = 21;
            Fname.TextChanged += textBox6_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(21, 104);
            label7.Name = "label7";
            label7.Size = new Size(86, 21);
            label7.TabIndex = 20;
            label7.Text = "First Name";
            label7.Click += label7_Click;
            // 
            // ManID
            // 
            ManID.ForeColor = Color.SaddleBrown;
            ManID.Location = new Point(113, 65);
            ManID.Name = "ManID";
            ManID.Size = new Size(181, 23);
            ManID.TabIndex = 25;
            // 
            // mID
            // 
            mID.AutoSize = true;
            mID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mID.Location = new Point(40, 67);
            mID.Name = "mID";
            mID.Size = new Size(25, 21);
            mID.TabIndex = 24;
            mID.Text = "ID";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 543);
            Controls.Add(ManID);
            Controls.Add(mID);
            Controls.Add(Lname);
            Controls.Add(label6);
            Controls.Add(Fname);
            Controls.Add(label7);
            Controls.Add(mPass);
            Controls.Add(label4);
            Controls.Add(mEmail);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(mCont);
            Controls.Add(label2);
            Controls.Add(mExp);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "Sign up";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox mCont;
        private Label label2;
        private TextBox mExp;
        private Label label1;
        private TextBox mPass;
        private Label label4;
        private TextBox mEmail;
        private Label label5;
        private TextBox Lname;
        private Label label6;
        private TextBox Fname;
        private Label label7;
        private TextBox ManID;
        private Label mID;
    }
}