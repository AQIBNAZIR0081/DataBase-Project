using System.Data;
using System.Data.SqlClient;

namespace Bike_Repair_SpareParts_Shop
{
    public partial class SearchProduct : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AQIB\SQLEXPRESS; Initial Catalog=BikeRepairShop; Integrated Security=True;");

        public SearchProduct()
        {
            InitializeComponent();
            loadData();
        }

        private void RP_searchbutton_Click(object sender, EventArgs e)
        {
            string searchCriteria;

            if (RP_IDradioButton.Checked)
            {
                searchCriteria = "ProductID";
            }
            else if (RP_NameradioButton.Checked)
            {
                searchCriteria = "ProductName";
            }
            else
            {
                MessageBox.Show("Please select a search criteria (ID, First Name, or Last Name).");
                return;
            }
            string searchTerm = RPvaluesBox.Text;

            using (SqlConnection connection = new SqlConnection(@"Data Source=AQIB\SQLEXPRESS; Initial Catalog=BikeRepairShop; Integrated Security=True;"))
            {
                connection.Open();

                // Adjust the SQL query based on the selected search criteria
                string query = $"SELECT * FROM Product WHERE {searchCriteria} LIKE '%{searchTerm}%'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Create a DataTable to hold the data
                        DataTable dataTable = new DataTable();
                        // Fill the DataTable with data from the SQL Server table
                        adapter.Fill(dataTable);
                        // Bind the DataTable to the DataGridView
                        RPGridView.DataSource = dataTable;
                    }
                }
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
                    RPGridView.DataSource = dataTable;
                }
            }
        }
    }
}
