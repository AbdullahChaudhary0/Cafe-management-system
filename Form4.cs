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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Diagnostics;
using System.Management;

namespace Cafe_Management_System
{
    public partial class Form4 : Form
    {
        List<Panel> listpanel = new List<Panel>();
        int index = 0;
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True");
        private void populateData()
        {
            try
            {
                SqlConnection Con = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True");
                Con.Open();
                string query = $"SELECT * FROM Cashier";
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    CashierData.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating data: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            listpanel.Add(panel2);
            listpanel.Add(panel3);
            listpanel.Add(panel4);
            listpanel.Add(panel5);
            listpanel.Add(panel1);
            listpanel[index].BringToFront();
            populateData();
            populateDataMenu();
            populateInventory();
            populateFeedback();
            timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Click(object sender, EventArgs e)
        {
            index = 0;
            listpanel[index].BringToFront();

        }

        private void addCashier_Click(object sender, EventArgs e)
        {
            index = 1;
            listpanel[index].BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = 2;
            listpanel[index].BringToFront();
        }

        private void feedback_Click(object sender, EventArgs e)
        {
            index = 3;
            listpanel[index].BringToFront();
        }

        private void Report_Click(object sender, EventArgs e)
        {
            index = 4;
            listpanel[index].BringToFront();
        }

        private void firstScreen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void addC_Click(object sender, EventArgs e)
        {
            addCashier newForm = new addCashier();
            this.Hide();
            newForm.ShowDialog();
        }

        /*public void RefreshRig()
        {
            SqlConnection Con = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True");
            string sqlstm = "SELECT * FROM Cashier";
            SqlDataAdapter SDA = new SqlDataAdapter(sqlstm, Con);
            DataSet DS =  new System.Data.DataSet();
            SDA.Fill(DS, "Cashier");
            dgv.DataSource
        }*/

        private void delID_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            populateData();
            populateDataMenu();
            populateInventory();
            populateFeedback();
            timer1.Start();
        }

        private void Delc_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Con = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True");
                Con.Open();
                string id = delID.Text;

                string query = "SELECT cashierID FROM Cashier WHERE cashierID = @id";

                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader1 = cmd.ExecuteReader();

                    if (reader1.HasRows)
                    {
                        reader1.Close();
                        string deleteQuery = "DELETE FROM Cashier WHERE cashierID = @id";

                        using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, Con))
                        {
                            deleteCmd.Parameters.AddWithValue("@id", id);
                            deleteCmd.ExecuteNonQuery();
                            MessageBox.Show("Row deleted successfully.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Cashier with this ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting cashier: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void populateDataMenu()
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True"))
                {
                    Con.Open();
                    string query = $"SELECT * FROM Menu";
                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        menuItemGrid.DataSource = dt;
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating menu data: " + ex.Message);
            }
        }

        void populateFeedback()
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True"))
                {
                    Con.Open();
                    string query = $"SELECT rc.Name, fb.Comment, fb.Rating, fb.Date_Submitted FROM Registered_Customer rc JOIN Feedback fb ON fb.Customer_ID = rc.ID ORDER BY fb.Rating DESC";
                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        FeedbackGrid.DataSource = dt;
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating feedback data: " + ex.Message);
            }
        }

        void populateInventory()
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True"))
                {
                    Con.Open();
                    string query = $"SELECT ID, Item_name, Quantity FROM Inventory";
                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        inventoryGrid.DataSource = dt;
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating inventory data: " + ex.Message);
            }
        }




        private void CashierData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuItemGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateID_Click(object sender, EventArgs e)
        {

        }

        private void addItem_Click(object sender, EventArgs e)
        {
            menuForm menuForm = new menuForm();
            this.Hide();
            menuForm.ShowDialog();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True"))
                {
                    Con.Open();

                    string id = updateID.Text;
                    string price = priceUpdate.Text;

                    // Check if the ID exists in the MENU table
                    string selectQuery = "SELECT ID " +
                   "FROM MENU " +
                   "WHERE ID = @id AND ID IN (SELECT ID FROM Inventory)";


                    using (SqlCommand selectCmd = new SqlCommand(selectQuery, Con))
                    {
                        selectCmd.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = selectCmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Close();

                                // Update the price in the MENU table
                                string updateQuery = "UPDATE MENU SET Price = @price WHERE ID = @id";

                                using (SqlCommand updateCmd = new SqlCommand(updateQuery, Con))
                                {
                                    updateCmd.Parameters.AddWithValue("@id", id);
                                    updateCmd.Parameters.AddWithValue("@price", price);

                                    int rowsAffected = updateCmd.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Price updated successfully.");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No item found with this ID.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating menu item: " + ex.Message);
            }
        }


        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inventoryUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True"))
                {
                    Con.Open();

                    string id = invenIDupdate.Text;
                    string amount = inventAmountText.Text;
                    string selectQuery = "SELECT ID FROM Inventory WHERE ID = @id";
                    using (SqlCommand selectCmd = new SqlCommand(selectQuery, Con))
                    {
                        selectCmd.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = selectCmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Close();

                                // Update the price in the MENU table
                                string updateQuery = "UPDATE Inventory SET Quantity = @amount WHERE ID = @id";

                                using (SqlCommand updateCmd = new SqlCommand(updateQuery, Con))
                                {
                                    updateCmd.Parameters.AddWithValue("@id", id);
                                    updateCmd.Parameters.AddWithValue("@amount", amount);

                                    int rowsAffected = updateCmd.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Amount updated successfully.");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No item found with this ID.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating inventory: " + ex.Message);
            }
        }


        private void inventoryRemove_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True"))
                {
                    Con.Open();
                    string id = inventoryRemoveText.Text;

                    string query = "SELECT ID FROM Menu WHERE ID = @id";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        SqlDataReader reader1 = cmd.ExecuteReader();

                        if (reader1.HasRows)
                        {
                            reader1.Close();
                            string deleteQuery = "DELETE FROM Menu WHERE ID = @id";

                            using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, Con))
                            {
                                deleteCmd.Parameters.AddWithValue("@id", id);
                                deleteCmd.ExecuteNonQuery();
                                MessageBox.Show("Row deleted successfully.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No Item with this ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting item: " + ex.Message);
            }
        }


        private void inventoryRemoveText_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        void populateReport()
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True"))
                {
                    Con.Open();

                    // Calculate total number of orders
                    string ordersQuery = "SELECT COUNT(*) FROM Ordertbl";
                    using (SqlCommand ordersCmd = new SqlCommand(ordersQuery, Con))
                    {
                        int totalOrde = (int)ordersCmd.ExecuteScalar();
                        totalOrders.Text = totalOrde.ToString();
                    }

                    // Calculate total sales
                    string salesQuery = "SELECT SUM(CAST(Total_Amount AS DECIMAL(18, 2))) FROM Ordertbl";
                    using (SqlCommand salesCmd = new SqlCommand(salesQuery, Con))
                    {
                        object totalSalesObj = salesCmd.ExecuteScalar();

                        if (totalSalesObj != DBNull.Value)
                        {
                            decimal totalSal = (decimal)totalSalesObj;
                            totalSales.Text = totalSal.ToString("C");
                        }
                        else
                        {
                            totalSales.Text = "0.00"; // Set to default if null
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating report: " + ex.Message);
            }
        }



        private void generateButton_Click(object sender, EventArgs e)
        {
            try
            {
                populateReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message);
            }
        }
    }
}
