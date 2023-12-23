using System.Data;
using System.Data.SqlClient;

namespace Bike_Repair_SpareParts_Shop
{
    public partial class AddShipment : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AQIB\SQLEXPRESS; Initial Catalog=BikeRepairShop; Integrated Security=True;");

        public AddShipment()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            string query = "SELECT " +
                   "S.ShipmentID, " +
                   "S.ShipmentDate, " +
                   "CONCAT(Su.FirstName, ' ', Su.LastName) AS [Supplier Name], " +
                   "P.ProductName, " +
                   "P.Price, " +
                   "S.Quantity " +
                   "FROM Shipment S " +
                   "JOIN Supplier Su ON S.SupplierID = Su.SupplierID " +
                   "JOIN Product P ON S.ProductID = P.ProductID";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    // Create a DataTable to hold the data
                    DataTable dataTable = new DataTable();
                    // Fill the DataTable with data from the SQL Server table
                    adapter.Fill(dataTable);
                    // Bind the DataTable to the DataGridView
                    ShipmentDetailGridView.DataSource = dataTable;
                }
            }
        }

        private void AddShipmentbutton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(ShipmentSupplierIDBox.Text, out int supplierID) &&
                int.TryParse(ShipmentProductIDBox.Text, out int productID) &&
                int.TryParse(QuantitynumericUpDown.Text, out int quantity) &&
                DateTime.TryParse(ShipmentdateTimePicker.Text, out DateTime shipmentDate))
            {
                if (SupplierExists(supplierID))
                {
                    if (ProductExists(productID))
                    {
                        InsertShipment(supplierID, productID, quantity, shipmentDate);
                        MessageBox.Show("Shipment added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Product not present in the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Supplier not present in the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ShipmentSupplierIDBox.Text = " ";
            ShipmentProductIDBox.Text = " ";
            QuantitynumericUpDown.Text = "0";
            loadData();
        }
        private bool SupplierExists(int supplierID)
        {
            try
            {
                con.Open();
                using (SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM Supplier WHERE SupplierID = {supplierID}", con))
                {
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
            finally
            {
                con.Close();
            }
        }
        private bool ProductExists(int productID)
        {
            try
            {
                con.Open();
                using (SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM Product WHERE ProductID = {productID}", con))
                {
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
            finally
            {
                con.Close();
            }
        }

        private void InsertShipment(int supplierID, int productID, int quantity, DateTime shipmentDate)
        {
            try
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Shipment (SupplierID, ProductID, Quantity, ShipmentDate) VALUES (@SupplierID, @ProductID, @Quantity, @ShipmentDate)", con))
                {
                    command.Parameters.AddWithValue("@SupplierID", supplierID);
                    command.Parameters.AddWithValue("@ProductID", productID);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@ShipmentDate", shipmentDate);
                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}
