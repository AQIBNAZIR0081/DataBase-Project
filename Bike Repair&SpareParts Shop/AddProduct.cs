using System.Data;
using System.Data.SqlClient;

namespace Bike_Repair_SpareParts_Shop
{
    public partial class AddProduct : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AQIB\SQLEXPRESS; Initial Catalog=BikeRepairShop; Integrated Security=True;");
        SqlCommand cmd;
        public AddProduct()
        {
            InitializeComponent();
            loadData();
        }

        private void AddProductbutton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                loadData();
                string productName = Add_ProudutNameBox.Text;
                string price = Add_ProductPriceBox.Text;
                bool isDuplicate = IsDuplicateSupplier(productName, price);

                if (!isDuplicate)
                {
                    cmd = new SqlCommand("INSERT INTO Product VALUES(@ProductName, @Price)", con);
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has saved in DataBase");
                    Add_ProudutNameBox.Text = "";
                    Add_ProductPriceBox.Text = "";
                    loadData();
                }
                else
                {
                    MessageBox.Show("Supplier with the same details already exists.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private bool IsDuplicateSupplier(string productName, string price )
        {
            // Check if a supplier with the same details already exists in the DataTable
            if (AddProductGridView.DataSource is DataTable dataTable)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["ProductName"].ToString() == productName &&
                        row["Price"].ToString() == price
                        )
                    {
                        return true; // Duplicate found
                    }
                }
            }
            return false; // No duplicate found
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
                    AddProductGridView.DataSource = dataTable;
                }
            }
        }
    }
}
