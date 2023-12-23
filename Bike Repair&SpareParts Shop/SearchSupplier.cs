using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace Bike_Repair_SpareParts_Shop
{

    public partial class SearchSupplier : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AQIB\SQLEXPRESS; Initial Catalog=BikeRepairShop; Integrated Security=True;");
        public SearchSupplier()
        {
            InitializeComponent();
            loadData();
        }

        private void SearchSupplierbutton_Click(object sender, EventArgs e)
        {
                string searchCriteria;

                if (S_IDradioButton.Checked)
                {
                    searchCriteria = "SupplierID";
                }
                else if (FirstNameradioButton.Checked)
                {
                    searchCriteria = "FirstName";
                }
                else if (LastNameradioButton.Checked)
                {
                    searchCriteria = "LastName";
                }
                else
                {
                    MessageBox.Show("Please select a search criteria (ID, First Name, or Last Name).");
                    return;
                }
                string searchTerm = SupplierValuesBox.Text;

                using (SqlConnection connection = new SqlConnection(@"Data Source=AQIB\SQLEXPRESS; Initial Catalog=BikeRepairShop; Integrated Security=True;"))
                {
                    connection.Open();

                    // Adjust the SQL query based on the selected search criteria
                    string query = $"SELECT * FROM Supplier WHERE {searchCriteria} LIKE '%{searchTerm}%'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Create a DataTable to hold the data
                            DataTable dataTable = new DataTable();
                            // Fill the DataTable with data from the SQL Server table
                            adapter.Fill(dataTable);
                            // Bind the DataTable to the DataGridView
                            SearchSupplierGridView.DataSource = dataTable;
                        }
                    }
                }
            }
        private void loadData()
        {
            string query = "SELECT * FROM Supplier";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    // Create a DataTable to hold the data
                    DataTable dataTable = new DataTable();
                    // Fill the DataTable with data from the SQL Server table
                    adapter.Fill(dataTable);
                    // Bind the DataTable to the DataGridView
                    SearchSupplierGridView.DataSource = dataTable;
                }
            }
        }
    }
}
