namespace Cafe_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            Customer = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-6, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(784, 582);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Snow;
            label1.Font = new Font("Tw Cen MT", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(255, 34);
            label1.Name = "label1";
            label1.Size = new Size(248, 31);
            label1.TabIndex = 1;
            label1.Text = "Welcome to our Cafe";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Tw Cen MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.SaddleBrown;
            button2.Location = new Point(57, 498);
            button2.Name = "button2";
            button2.Size = new Size(123, 45);
            button2.TabIndex = 3;
            button2.Text = "Sign up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Tw Cen MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.SaddleBrown;
            button1.Location = new Point(57, 430);
            button1.Name = "button1";
            button1.Size = new Size(123, 45);
            button1.TabIndex = 5;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Customer
            // 
            Customer.BackColor = SystemColors.ButtonFace;
            Customer.Cursor = Cursors.Hand;
            Customer.FlatStyle = FlatStyle.Popup;
            Customer.Font = new Font("Tw Cen MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Customer.ForeColor = Color.SaddleBrown;
            Customer.Location = new Point(606, 498);
            Customer.Name = "Customer";
            Customer.Size = new Size(123, 45);
            Customer.TabIndex = 6;
            Customer.Text = "Customer";
            Customer.UseVisualStyleBackColor = false;
            Customer.Click += Customer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 575);
            Controls.Add(Customer);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Cafe Management System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button2;
        private Button button1;
        private Button Customer;
    }
}