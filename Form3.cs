using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cafe_Management_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-9QPU007\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into Manager values('" + ManID.Text + "','" + Fname.Text + "', '" + Lname.Text + "' , '" + mEmail.Text + "' , '" + mPass.Text + "' , '" + mExp.Text + "' , '" + mCont.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Manager Created.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating manager: " + ex.Message);
            }
            finally
            {
                Con.Close();
                Form1 secondForm = new Form1();
                this.Hide();
                secondForm.ShowDialog();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
