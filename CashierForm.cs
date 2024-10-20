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
    public partial class CashierForm : Form
    {
        List<Panel> listpanel = new List<Panel>();
        int index = 0;
        public CashierForm()
        {
            InitializeComponent();
            populateordersGrid();

            List<Panel> listpanel = new List<Panel>();
            int index = 0;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }

        private void ordersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True");
        private void populateordersGrid()
        {
            try
            {
                Con.Open();
                string query = $"SELECT I.ID, I.Status, I.Special_Instruction, I.Total_Amount, " +
                    $"COALESCE(R.Name, U.Name) AS CustomerName " +
                    $"FROM Ordertbl I " +
                    $"LEFT JOIN Registered_Customer R ON I.RCustomer_ID = R.ID " +
                    $"LEFT JOIN Guest_Customer U ON I.Ucustomer_ID = U.ID";

                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    ordersGrid.DataSource = dt;
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating orders grid: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            populateordersGrid();
        }

        private void orders_Click(object sender, EventArgs e)
        {
            index = 0;
            listpanel[index].BringToFront();
        }

        private bool IsOrderIDValid(int orderID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Ordertbl WHERE ID = @orderID", Con))
                {
                    cmd.Parameters.AddWithValue("@orderID", orderID);

                    Con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking order ID validity: " + ex.Message);
                return false;
            }
            finally
            {
                Con.Close();
            }
        }

        private bool IsOrderComplete(int orderID)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True"))
                {
                    Con.Open();

                    string query = "SELECT Status FROM Ordertbl WHERE ID = @orderID";
                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@orderID", orderID);
                        object status = cmd.ExecuteScalar();
                        return status != null && status.ToString() == "Complete";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking order completion: " + ex.Message);
                return false;
            }
            finally
            {
                Con.Close();
            }
        }

        private void orderProceed_Click(object sender, EventArgs e)
        {
            int orderIDValue;

            if (int.TryParse(orderID.Text, out orderIDValue))
            {
                // Check if the ID is present in the Ordertbl
                if (IsOrderIDValid(orderIDValue))
                {
                    // Check if the status is not already 'Complete'
                    if (!IsOrderComplete(orderIDValue))
                    {
                        // Proceed to the next form
                        PaymentProceed paymentProceed = new PaymentProceed(orderIDValue);
                        this.Hide();
                        paymentProceed.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Order has already been completed.");
                    }
                }
                else
                {
                    MessageBox.Show("Order ID not found in Ordertbl. Please enter a valid Order ID.");
                }
            }
            else
            {
                MessageBox.Show("Invalid Order ID format.");
            }
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {

        }
    }
}
