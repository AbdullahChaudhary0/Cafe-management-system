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

namespace Cafe_Management_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True");
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Parent = pictureBox2;
            label3.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string email = loginEmail.Text;
                string pass = loginPass.Text;

                // Query for Manager table
                string managerQuery = "SELECT memail, mpass FROM Manager WHERE memail = @Email AND mpass = @Password";

                using (SqlCommand managerCmd = new SqlCommand(managerQuery, Con))
                {
                    managerCmd.Parameters.AddWithValue("@Email", email);
                    managerCmd.Parameters.AddWithValue("@Password", pass);

                    using (SqlDataReader managerReader = managerCmd.ExecuteReader())
                    {
                        if (managerReader.HasRows)
                        {
                            MessageBox.Show("Manager Credentials Matched.");
                            // Creating second form for Manager
                            Form4 fourthForm = new Form4();
                            this.Hide();
                            fourthForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Credentials for Manager.");
                        }
                    }
                }

                // Query for Cashier table
                string cashierQuery = "SELECT Email, pass FROM Cashier WHERE Email = @Email AND pass = @Password";

                using (SqlCommand cashierCmd = new SqlCommand(cashierQuery, Con))
                {
                    cashierCmd.Parameters.AddWithValue("@Email", email);
                    cashierCmd.Parameters.AddWithValue("@Password", pass);

                    using (SqlDataReader cashierReader = cashierCmd.ExecuteReader())
                    {
                        if (cashierReader.HasRows)
                        {
                            MessageBox.Show("Cashier Credentials Matched.");
                            CashierForm cashierForm = new CashierForm();
                            this.Hide();
                            cashierForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Credentials for Cashier.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing SQL queries: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
