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
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-9QPU007\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True");
        private void RegisterCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True"))
                {
                    Con.Open();

                    // Insert a new row into Loyalty_Program table
                    int id = int.Parse(customID.Text);
                    string insertLoyaltyQuery = "INSERT INTO Loyalty_Program (ID, Tier_Level, Points, Expiry_Date) VALUES (@id, 'Bronze', 0, NULL);";

                    using (SqlCommand loyaltyCmd = new SqlCommand(insertLoyaltyQuery, Con))
                    {
                        loyaltyCmd.Parameters.AddWithValue("@id", id);
                        loyaltyCmd.ExecuteNonQuery();
                    }

                    // Insert into Registered_Customer table
                    string customerQuery = "INSERT INTO Registered_Customer (ID, Name, Contact_Info, Username, Password, LoyaltyProgram_ID) " +
                        "VALUES (@customerID, @Name, @Contact, @Username, @Password, @LoyaltyProgramID)";

                    using (SqlCommand customerCmd = new SqlCommand(customerQuery, Con))
                    {
                        customerCmd.Parameters.AddWithValue("@customerID", id);
                        customerCmd.Parameters.AddWithValue("@Name", customName.Text);
                        customerCmd.Parameters.AddWithValue("@Contact", customContact.Text);
                        customerCmd.Parameters.AddWithValue("@Username", customUsername.Text);
                        customerCmd.Parameters.AddWithValue("@Password", customPassword.Text);
                        customerCmd.Parameters.AddWithValue("@LoyaltyProgramID", id);

                        customerCmd.ExecuteNonQuery();
                        MessageBox.Show("Customer Registered.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registering customer: " + ex.Message);
            }
        }










        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string username = customLogin.Text;
                string cpass = loginPassword.Text;

                string query = "SELECT ID, Username, Password FROM Registered_Customer WHERE Username = @username AND Password = @cpass";

                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@cpass", cpass);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Check if there is data to read
                        {
                            int customerID = reader.GetInt32(reader.GetOrdinal("ID"));

                            // Now you can use the customerID value
                            MessageBox.Show("Credentials Matched. Customer ID: " + customerID);

                            // Creating Customer Form
                            RegisteredCustomerMenu registeredCustomerMenu = new RegisteredCustomerMenu(customerID);
                            this.Hide();
                            registeredCustomerMenu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Data not matched.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error logging in: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void CustomerLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
