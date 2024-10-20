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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Xml.Linq;
using TheArtOfDevHtmlRenderer.Adapters;

namespace Cafe_Management_System
{
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True");
        private void itemAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True"))
                {
                    Con.Open();

                    string query = "insert into Menu values('" + itemID.Text + "','" + itemName.Text + "', '" + itemDesc.Text + "' , '" + itemCat.Text + "' , '" + itemPrice.Text + "' , '" + itemAller.Text + "' , '" + itemCal.Text + "' , '" + itemNut.Text + "')";
                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    string query1 = "insert into Inventory values('" + itemID.Text + "','" + itemName.Text + "', '" + amount.Text + "' , '" + null + "' , '" + itemID.Text + "')";
                    using (SqlCommand cmd1 = new SqlCommand(query1, Con))
                    {
                        cmd1.ExecuteNonQuery();
                    }

                    MessageBox.Show("Item Added.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding item: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }

            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
        }


        private void menuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
