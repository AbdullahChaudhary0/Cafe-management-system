namespace Cafe_Management_System
{
    partial class PaymentProceed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentProceed));
            pictureBox1 = new PictureBox();
            label4 = new Label();
            generateReceipt = new Button();
            label1 = new Label();
            Amount = new TextBox();
            label2 = new Label();
            amountPaid = new TextBox();
            label3 = new Label();
            Name = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(166, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(448, 540);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(339, 35);
            label4.Name = "label4";
            label4.Size = new Size(95, 33);
            label4.TabIndex = 9;
            label4.Text = "Cashier";
            // 
            // generateReceipt
            // 
            generateReceipt.FlatStyle = FlatStyle.Popup;
            generateReceipt.Font = new Font("Tw Cen MT Condensed", 20.75F, FontStyle.Regular, GraphicsUnit.Point);
            generateReceipt.ForeColor = Color.SaddleBrown;
            generateReceipt.Location = new Point(310, 436);
            generateReceipt.Name = "generateReceipt";
            generateReceipt.Size = new Size(181, 39);
            generateReceipt.TabIndex = 10;
            generateReceipt.Text = "Generate Receipt";
            generateReceipt.UseMnemonic = false;
            generateReceipt.UseVisualStyleBackColor = true;
            generateReceipt.Click += generateReceipt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(283, 176);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 11;
            label1.Text = "Total Amount: ";
            // 
            // Amount
            // 
            Amount.Location = new Point(412, 174);
            Amount.Name = "Amount";
            Amount.Size = new Size(107, 23);
            Amount.TabIndex = 12;
            Amount.TextChanged += Amount_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(214, 219);
            label2.Name = "label2";
            label2.Size = new Size(182, 21);
            label2.TabIndex = 13;
            label2.Text = "Amount Customer Paid: ";
            // 
            // amountPaid
            // 
            amountPaid.Location = new Point(412, 217);
            amountPaid.Name = "amountPaid";
            amountPaid.Size = new Size(107, 23);
            amountPaid.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(339, 130);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 15;
            label3.Text = "Name:";
            // 
            // Name
            // 
            Name.Location = new Point(412, 128);
            Name.Name = "Name";
            Name.Size = new Size(107, 23);
            Name.TabIndex = 16;
            // 
            // PaymentProceed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 536);
            Controls.Add(Name);
            Controls.Add(label3);
            Controls.Add(amountPaid);
            Controls.Add(label2);
            Controls.Add(Amount);
            Controls.Add(label1);
            Controls.Add(generateReceipt);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            //Name = "PaymentProceed";
            Text = "PaymentProceed";
            Load += PaymentProceed_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label4;
        private Button generateReceipt;
        private Label label1;
        private TextBox Amount;
        private Label label2;
        private TextBox amountPaid;
        private Label label3;
        private TextBox Name;
    }
}