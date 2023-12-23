using System.Data;
using System.Data.SqlClient;

namespace Bike_Repair_SpareParts_Shop
{
    public partial class AddSupplier : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AQIB\SQLEXPRESS; Initial Catalog=BikeRepairShop; Integrated Security=True;");
        SqlCommand cmd;

        public AddSupplier()
        {
            InitializeComponent();
            loadData();
        }

        private void AddSupplierbutton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                loadData();
                string firstName = FirstNameBox.Text;
                string lastName = LastNameBox.Text;
                string address = AddressBox.Text;
                string phoneNumber = PhoneNumberBox.Text;
                string email = EmailBox.Text;
                string company = CompanyBox.Text;

                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                    string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phoneNumber) ||
                    string.IsNullOrEmpty(email) || string.IsNullOrEmpty(company))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool isDuplicate = IsDuplicateSupplier(firstName, lastName, address, phoneNumber, email, company);

                if (!isDuplicate)
                {
                    cmd = new SqlCommand("INSERT INTO Supplier VALUES(@FirstName, @LastName, @Address, @PhoneNumber, @Email, @Company)", con);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Company", company);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has saved in DataBase");
                    FirstNameBox.Text = "";
                    LastNameBox.Text = "";
                    AddressBox.Text = "";
                    PhoneNumberBox.Text = "";
                    EmailBox.Text = "";
                    CompanyBox.Text = "";
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

        private bool IsDuplicateSupplier(string firstName, string lastName, string address, string phoneNumber, string email, string company)
        {
            // Check if a supplier with the same details already exists in the DataTable
            if (Add_SupplierGridView.DataSource is DataTable dataTable)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["FirstName"].ToString() == firstName &&
                        row["LastName"].ToString() == lastName &&
                        row["Address"].ToString() == address &&
                        row["PhoneNumber"].ToString() == phoneNumber &&
                        row["Email"].ToString() == email &&
                        row["Company"].ToString() == company
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
                    Add_SupplierGridView.DataSource = dataTable;
                }
            }
        }
    }
}
