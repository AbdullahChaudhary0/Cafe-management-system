namespace Cafe_Management_System
{
    partial class CashierForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            orders = new Button();
            logout = new Button();
            orderPanel = new Panel();
            orderProceed = new Button();
            orderID = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            ordersGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            orderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordersGrid).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-7, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 540);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(70, 19);
            label3.Name = "label3";
            label3.Size = new Size(122, 40);
            label3.TabIndex = 7;
            label3.Text = "Cashier";
            // 
            // orders
            // 
            orders.FlatStyle = FlatStyle.Popup;
            orders.Font = new Font("Tw Cen MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            orders.ForeColor = Color.SaddleBrown;
            orders.Location = new Point(81, 218);
            orders.Name = "orders";
            orders.Size = new Size(97, 39);
            orders.TabIndex = 8;
            orders.Text = "Order";
            orders.UseMnemonic = false;
            orders.UseVisualStyleBackColor = true;
            orders.Click += orders_Click;
            // 
            // logout
            // 
            logout.FlatStyle = FlatStyle.Popup;
            logout.Font = new Font("Tw Cen MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            logout.ForeColor = Color.SaddleBrown;
            logout.Location = new Point(81, 463);
            logout.Name = "logout";
            logout.Size = new Size(97, 39);
            logout.TabIndex = 9;
            logout.Text = "Logout";
            logout.UseMnemonic = false;
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // orderPanel
            // 
            orderPanel.Controls.Add(orderProceed);
            orderPanel.Controls.Add(orderID);
            orderPanel.Controls.Add(label2);
            orderPanel.Controls.Add(ordersGrid);
            orderPanel.Controls.Add(label1);
            orderPanel.Location = new Point(313, 50);
            orderPanel.Name = "orderPanel";
            orderPanel.Size = new Size(396, 402);
            orderPanel.TabIndex = 10;
            // 
            // orderProceed
            // 
            orderProceed.FlatStyle = FlatStyle.Popup;
            orderProceed.Font = new Font("Tw Cen MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            orderProceed.ForeColor = Color.SaddleBrown;
            orderProceed.Location = new Point(270, 338);
            orderProceed.Name = "orderProceed";
            orderProceed.Size = new Size(97, 43);
            orderProceed.TabIndex = 11;
            orderProceed.Text = "Proceed";
            orderProceed.UseMnemonic = false;
            orderProceed.UseVisualStyleBackColor = true;
            orderProceed.Click += orderProceed_Click;
            // 
            // orderID
            // 
            orderID.BorderRadius = 10;
            orderID.CustomizableEdges = customizableEdges1;
            orderID.DefaultText = "";
            orderID.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            orderID.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            orderID.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            orderID.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            orderID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            orderID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            orderID.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            orderID.Location = new Point(200, 345);
            orderID.Name = "orderID";
            orderID.PasswordChar = '\0';
            orderID.PlaceholderText = "";
            orderID.SelectedText = "";
            orderID.ShadowDecoration.CustomizableEdges = customizableEdges2;
            orderID.Size = new Size(48, 27);
            orderID.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(159, 349);
            label2.Name = "label2";
            label2.Size = new Size(35, 19);
            label2.TabIndex = 11;
            label2.Text = "ID:  ";
            // 
            // ordersGrid
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            ordersGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ordersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ordersGrid.ColumnHeadersHeight = 4;
            ordersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ordersGrid.DefaultCellStyle = dataGridViewCellStyle3;
            ordersGrid.GridColor = Color.FromArgb(231, 229, 255);
            ordersGrid.Location = new Point(19, 53);
            ordersGrid.Name = "ordersGrid";
            ordersGrid.RowHeadersVisible = false;
            ordersGrid.RowTemplate.Height = 25;
            ordersGrid.Size = new Size(359, 263);
            ordersGrid.TabIndex = 12;
            ordersGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ordersGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            ordersGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ordersGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ordersGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ordersGrid.ThemeStyle.BackColor = Color.White;
            ordersGrid.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            ordersGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            ordersGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ordersGrid.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ordersGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ordersGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ordersGrid.ThemeStyle.HeaderStyle.Height = 4;
            ordersGrid.ThemeStyle.ReadOnly = false;
            ordersGrid.ThemeStyle.RowsStyle.BackColor = Color.White;
            ordersGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ordersGrid.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ordersGrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ordersGrid.ThemeStyle.RowsStyle.Height = 25;
            ordersGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ordersGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            ordersGrid.CellContentClick += ordersGrid_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(138, 10);
            label1.Name = "label1";
            label1.Size = new Size(122, 40);
            label1.TabIndex = 11;
            label1.Text = "Cashier";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // CashierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 536);
            Controls.Add(orderPanel);
            Controls.Add(logout);
            Controls.Add(orders);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Name = "CashierForm";
            Text = "CashierForm";
            Load += CashierForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            orderPanel.ResumeLayout(false);
            orderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ordersGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label3;
        private Button orders;
        private Button logout;
        private Panel orderPanel;
        private Guna.UI2.WinForms.Guna2DataGridView ordersGrid;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button orderProceed;
        private Guna.UI2.WinForms.Guna2TextBox orderID;
        private Label label2;
    }
}