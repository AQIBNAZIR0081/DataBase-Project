using System.Data;
using System.Data.SqlClient;

namespace Bike_Repair_SpareParts_Shop
{
    public partial class UpdateProduct : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AQIB\SQLEXPRESS; Initial Catalog=BikeRepairShop; Integrated Security=True;");
        public UpdateProduct()
        {
            InitializeComponent();
            loadData();
        }

        private void GetProductIDbutton_Click(object sender, EventArgs e)
        {
            int productId;
            if (int.TryParse(EnterUP_IDBox.Text, out productId))
            {
                using (SqlCommand command = new SqlCommand("SELECT ProductName, Price FROM Product WHERE ProductID = @ID", con))
                {
                    command.Parameters.AddWithValue("@ID", productId);
                    con.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            UpdateProudutNameBox.Text = reader["ProductName"].ToString();
                            UpdateProductPriceBox.Text = reader["Price"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Product not found!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Product ID!");
            }

            con.Close();
        }

        private void UpdateProductbutton_Click(object sender, EventArgs e)
        {
            // Update the product with new values
            int productId;
            if (int.TryParse(EnterUP_IDBox.Text, out productId))
            {
                string newName = UpdateProudutNameBox.Text;
                decimal newPrice;
                if (decimal.TryParse(UpdateProductPriceBox.Text, out newPrice))
                {
                    using (SqlCommand command = new SqlCommand("UPDATE Product SET ProductName = @Name, Price = @Price WHERE ProductID = @ID", con))
                    {
                        command.Parameters.AddWithValue("@ID", productId);
                        command.Parameters.AddWithValue("@Name", newName);
                        command.Parameters.AddWithValue("@Price", newPrice);

                        con.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        con.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product updated successfully!");
                            // Refresh the GridView or any other display mechanism
                            loadData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update product!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Product Price!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Product ID!");
            }
        }

        private void loadData()
        {
            string query = "SELECT * FROM Product";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    // Create a DataTable to hold the data
                    DataTable dataTable = new DataTable();
                    // Fill the DataTable with data from the SQL Server table
                    adapter.Fill(dataTable);
                    // Bind the DataTable to the DataGridView
                    UpdateProductGridView.DataSource = dataTable;
                }
            }
        }

    }
}
