using Guna.UI2.WinForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cafe_Management_System
{
    public partial class PaymentProceed : Form
    {
        int orderID = 0;
        public PaymentProceed(int ID)
        {
            orderID = ID;
            InitializeComponent();
            populateAmount(orderID);


        }

        private void PaymentProceed_Load(object sender, EventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True");



        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Amount_TextChanged(object sender, EventArgs e)
        {

        }


        void populateAmount(int orderID)
        {
            try
            {
                Con.Open();

                string query = "SELECT Total_Amount FROM Ordertbl WHERE ID = @orderID";

                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.Parameters.AddWithValue("@orderID", orderID);

                    // Execute the query
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        // Handle the result, e.g., display it in a TextBox
                        Amount.Text = result.ToString();
                    }
                    else
                    {
                        // Handle the case where no matching order is found
                        Amount.Text = "-";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating amount: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void generateReceipt_Click(object sender, EventArgs e)
        {
            int amountP;

            // Parse amountP with int.TryParse to handle potential format issues
            if (int.TryParse(amountPaid.Text, out amountP))
            {
                try
                {
                    // Select the current Total_Amount
                    string selectQuery = @"
            SELECT Total_Amount
            FROM Ordertbl
            WHERE ID = @orderID;
        ";

                    using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True"))
                    {
                        connection.Open();

                        // Execute the select query to get the current Total_Amount
                        using (SqlCommand selectCmd = new SqlCommand(selectQuery, connection))
                        {
                            selectCmd.Parameters.AddWithValue("@orderID", orderID);

                            // Get the current Total_Amount
                            int currentTotalAmount = (int)selectCmd.ExecuteScalar();

                            // Calculate the remaining amount
                            int remainingAmount = amountP - currentTotalAmount;

                            // Show message based on the remaining amount
                            if (remainingAmount >= 0)
                            {
                                MessageBox.Show($"Amount returned: {remainingAmount:C}");

                                // Update the status to 'Complete' in Ordertbl
                                string updateStatusQuery = @"
                        UPDATE Ordertbl
                        SET Status = 'Complete'
                        WHERE ID = @orderID;
                    ";

                                using (SqlCommand updateStatusCmd = new SqlCommand(updateStatusQuery, connection))
                                {
                                    updateStatusCmd.Parameters.AddWithValue("@orderID", orderID);
                                    updateStatusCmd.ExecuteNonQuery();
                                }
                                CashierForm cashierForm = new CashierForm();
                                this.Hide();
                                cashierForm.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Insufficient funds.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating receipt: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Invalid amount format.");
            }
        }



    }
}
