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
using System.Xml.Linq;
using System.Security.AccessControl;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cafe_Management_System
{
    public partial class RegisteredCustomerMenu : Form
    {
        int customID = 0;
        List<Panel> listpanel = new List<Panel>();
        int index = 0;
        public RegisteredCustomerMenu(int customerID)
        {
            InitializeComponent();
            customID = customerID;
        }

        private void RegisteredCustomerMenu_Load(object sender, EventArgs e)
        {
            listpanel.Add(menuPanel);
            listpanel.Add(cartPanel);
            listpanel.Add(feedbackPanel);
            listpanel.Add(Lplanel);

            listpanel[index].BringToFront();

            populateCartGrid();
            populatecustomerMenu();
            timer1.Start();
        }
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True");
        void populatecustomerMenu()
        {
            try
            {
                SqlConnection Con = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True");
                Con.Open();
                string query = $"SELECT* FROM Menu";
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    menuGrid.DataSource = dt;
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating customer menu: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        void populateCartGrid()
        {
            try
            {
                SqlConnection Con = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True");
                Con.Open();
                string query = $"SELECT ID, Items, Items_Quantity AS TotalQuantity FROM Order_Items";
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    cartGrid.DataSource = dt;
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating cart grid: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }


        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            populatecustomerMenu();
            populateCartGrid();
            timer1.Start();
        }

        private void addtoCart_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True"))
                {
                    Con.Open();
                    string ID = itemID.Text;
                    string quantity = itemAmount.Text;

                    // Check if the Item ID exists in the MENU table
                    string selectQuery = "SELECT ID, Item_Name, Quantity FROM Inventory WHERE ID = @id";

                    using (SqlCommand selectCmd = new SqlCommand(selectQuery, Con))
                    {
                        selectCmd.Parameters.AddWithValue("@id", ID);

                        using (SqlDataReader reader = selectCmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                string itemName = reader.GetString(reader.GetOrdinal("Item_Name"));
                                int invenQuantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
                                reader.Close();

                                // Check if the requested quantity is less than or equal to the available quantity in the menu
                                if (invenQuantity >= int.Parse(quantity) && invenQuantity != 0)
                                {
                                    // Add item to Order_Items table
                                    string insertQuery = "INSERT INTO Order_Items (Items, Items_Quantity) VALUES (@itemName, @quantity)";
                                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, Con))
                                    {
                                        insertCmd.Parameters.AddWithValue("@itemName", itemName);
                                        insertCmd.Parameters.AddWithValue("@quantity", quantity);

                                        insertCmd.ExecuteNonQuery();
                                        MessageBox.Show("Item added to the cart.");

                                        // Deduct quantity from the Inventory table
                                        string updateQuery = "UPDATE Inventory SET Quantity = Quantity - @quantity " +
                                        "WHERE ID IN (SELECT ID FROM MENU WHERE ID = @ID)";
                                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, Con))
                                        {
                                            updateCmd.Parameters.AddWithValue("@ID", ID);
                                            updateCmd.Parameters.AddWithValue("@quantity", quantity);

                                            updateCmd.ExecuteNonQuery();
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(invenQuantity + " quantity left in the inventory.");
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
                MessageBox.Show("Error adding item to cart: " + ex.Message);
            }
        }


        private void Menu_Click(object sender, EventArgs e)
        {
            index = 0;
            listpanel[index].BringToFront();
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            index = 1;
            listpanel[index].BringToFront();
        }

        private void feedbackButton_Click(object sender, EventArgs e)
        {
            index = 2;
            listpanel[index].BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = 3;
            listpanel[index].BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True"))
                {
                    Con.Open();

                    string ID = removalID.Text;

                    // Check if the OrderItem ID exists in the Order_Items table
                    string selectOrderItemQuery = "SELECT ID, Items, Items_Quantity FROM Order_Items WHERE ID = @ID";

                    using (SqlCommand selectOrderItemCmd = new SqlCommand(selectOrderItemQuery, Con))
                    {
                        selectOrderItemCmd.Parameters.AddWithValue("@ID", ID);

                        using (SqlDataReader orderItemReader = selectOrderItemCmd.ExecuteReader())
                        {
                            if (orderItemReader.HasRows)
                            {
                                orderItemReader.Read();
                                string itemName = orderItemReader.GetString(orderItemReader.GetOrdinal("Items"));
                                int orderItemQuantity = orderItemReader.GetInt32(orderItemReader.GetOrdinal("Items_Quantity"));
                                orderItemReader.Close();

                                // Delete the row from Order_Items table
                                string deleteOrderItemQuery = "DELETE FROM Order_Items WHERE ID = @ID";
                                using (SqlCommand deleteOrderItemCmd = new SqlCommand(deleteOrderItemQuery, Con))
                                {
                                    deleteOrderItemCmd.Parameters.AddWithValue("@ID", ID);
                                    deleteOrderItemCmd.ExecuteNonQuery();
                                }

                                // Add the quantity back to the Inventory table
                                string updateInventoryQuery = "UPDATE Inventory SET Quantity = Quantity + @orderItemQuantity WHERE Item_Name = @itemName";
                                using (SqlCommand updateInventoryCmd = new SqlCommand(updateInventoryQuery, Con))
                                {
                                    updateInventoryCmd.Parameters.AddWithValue("@itemName", itemName);
                                    updateInventoryCmd.Parameters.AddWithValue("@orderItemQuantity", orderItemQuantity);
                                    updateInventoryCmd.ExecuteNonQuery();
                                }

                                MessageBox.Show("Item removed from the cart, and quantity added back to the inventory.");
                            }
                            else
                            {
                                MessageBox.Show("No item found with this OrderItemID.");
                            }
                        }
                    }

                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing item from cart: " + ex.Message);
            }
        }



        void populateLPgrid()
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True"))
                {
                    Con.Open();

                    string query = "SELECT ID, Tier_Level, Points FROM Loyalty_Program WHERE ID = @customID";
                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        // Add parameter to the SqlCommand
                        cmd.Parameters.AddWithValue("@customID", customID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            LpGrid.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating Loyalty Program grid: " + ex.Message);
            }
        }

        private void placeOrder_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Con = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True");
                Con.Open();
                decimal totalPrice = 0;

                // Sum the prices of items in the Order_Items table based on their matching entries in the Menu table
                string sumPricesQuery = "SELECT SUM(m.Price * oi.Items_Quantity) AS TotalPrice " +
                        "FROM Order_Items oi " +
                        "INNER JOIN Menu m ON oi.Items = m.Item_Name";


                using (SqlCommand sumPricesCmd = new SqlCommand(sumPricesQuery, Con))
                {
                    using (SqlDataReader sumPricesReader = sumPricesCmd.ExecuteReader())
                    {
                        if (sumPricesReader.Read() && !sumPricesReader.IsDBNull(sumPricesReader.GetOrdinal("TotalPrice")))
                        {
                            totalPrice = sumPricesReader.GetDecimal(sumPricesReader.GetOrdinal("TotalPrice"));
                        }
                    }
                }

                if (totalPrice > 0)
                {
                    string status = "Processing";
                    string specInstruction = instructions.Text;

                    string query = "INSERT INTO Ordertbl (Status, Special_Instruction, Total_Amount, RCustomer_ID, UCustomer_ID, Menu_ID, Inventory_ID) " +
                    "VALUES (@status, @specInstruction, @totalPrice, @customID, NULL, 1, 1)";

                    using (SqlCommand cmd1 = new SqlCommand(query, Con))
                    {
                        cmd1.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
                        cmd1.Parameters.Add("@specInstruction", SqlDbType.VarChar).Value = specInstruction;
                        cmd1.Parameters.Add("@totalPrice", SqlDbType.Decimal).Value = totalPrice;
                        cmd1.Parameters.Add("@customID", SqlDbType.Int).Value = customID;

                        cmd1.ExecuteNonQuery();
                    }
                    MessageBox.Show("Order Taken.");
                    string deleteOrderItemsQuery = "DELETE FROM Order_Items";
                    SqlCommand deleteOrderItemsCmd = new SqlCommand(deleteOrderItemsQuery, Con);
                    deleteOrderItemsCmd.ExecuteNonQuery();

                    int loyaltyPoints = (int)Math.Round(totalPrice * 0.01m);

                    // Determine loyalty tier
                    string loyaltyTier = "Bronze";
                    if (loyaltyPoints >= 200)
                    {
                        loyaltyTier = "Gold";
                    }
                    else if (loyaltyPoints >= 100)
                    {
                        loyaltyTier = "Silver";
                    }
                    string ExpiryDate = null; // You can set this to an actual date if needed

                    // Update Loyalty_Program table
                    string updateLoyaltyQuery = "MERGE INTO Loyalty_Program AS Target " +
                                  "USING (VALUES (@customID)) AS Source (CustomerID) " +
                                  "ON Target.ID = Source.CustomerID " +
                                  "WHEN MATCHED THEN " +
                                  "    UPDATE SET " +
                                  "        Points = Points + @loyaltyPoints, " +
                                  "        Tier_Level = @loyaltyTier, " +
                                  "        Expiry_Date = @expiryDate " +
                                  "WHEN NOT MATCHED THEN " +
                                  "    INSERT (ID, Points, Tier_Level, Expiry_Date) " +
                                  "    VALUES (@customID, @loyaltyPoints, @loyaltyTier, @expiryDate);";

                    using (SqlCommand updateLoyaltyCmd = new SqlCommand(updateLoyaltyQuery, Con))
                    {
                        updateLoyaltyCmd.Parameters.AddWithValue("@loyaltyPoints", loyaltyPoints);
                        updateLoyaltyCmd.Parameters.AddWithValue("@loyaltyTier", loyaltyTier);
                        updateLoyaltyCmd.Parameters.AddWithValue("@expiryDate", (object)ExpiryDate ?? DBNull.Value); // Use DBNull.Value for null values
                        updateLoyaltyCmd.Parameters.AddWithValue("@customID", customID);
                        updateLoyaltyCmd.ExecuteNonQuery();
                    }
                    // Display success message
                    MessageBox.Show("Order Taken. Loyalty Points Updated.");
                }
                else
                {
                    MessageBox.Show("No Items in the cart.");
                }
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error placing order: " + ex.Message);
            }
        }


        private void submitFeedback_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source=DESKTOP-9QPU007\\SQLEXPRESS;Initial Catalog=cafe_management_system;Integrated Security=True"))
                {
                    Con.Open();

                    // Assuming feedback.Text is a string, and feedbackID.Text is an int
                    string query = "INSERT INTO Feedback VALUES (@rating, @dateFeedback, @feedback, @feedbackID)";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        // Use proper SqlDbType for each parameter
                        cmd.Parameters.Add("@rating", SqlDbType.VarChar).Value = rating.Text;
                        cmd.Parameters.Add("@dateFeedback", SqlDbType.VarChar).Value = dateFeedback.Text;
                        cmd.Parameters.Add("@feedback", SqlDbType.VarChar).Value = feedback.Text;
                        cmd.Parameters.Add("@feedbackID", SqlDbType.Int).Value = customID;

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Feedback Taken. Thank you.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting feedback: " + ex.Message);
            }
        }


        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void LPupdate_Click(object sender, EventArgs e)
        {
            populateLPgrid();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog(this);
        }

        private void Lplanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
