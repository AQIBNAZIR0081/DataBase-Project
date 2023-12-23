using System.Data;
using System.Data.SqlClient;

namespace Bike_Repair_SpareParts_Shop
{
    public partial class AddTechnician : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AQIB\SQLEXPRESS; Initial Catalog=BikeRepairShop; Integrated Security=True;");
        SqlCommand cmd;
        public AddTechnician()
        {
            InitializeComponent();
            loadData();
        }

        private void AddTechbutton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                loadData();
                string firstName = TechFirstNameBox.Text;
                string lastName = TechLastNameBox.Text;
                string phoneNumber = TechPhoneNumberBox.Text;
                string speciality = TechSpecialityBox.Text;

                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                    string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(speciality))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool isDuplicate = IsDuplicateTechnician(firstName, lastName, phoneNumber,speciality);

                if (!isDuplicate)
                {
                    cmd = new SqlCommand("INSERT INTO Technician VALUES(@FirstName, @LastName, @PhoneNumber, @Speciality)", con);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@Speciality", speciality);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has saved in DataBase");
                    TechFirstNameBox.Text = "";
                    TechLastNameBox.Text = "";
                    TechPhoneNumberBox.Text = "";
                    TechSpecialityBox.Text = "";
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

        private bool IsDuplicateTechnician(string firstName, string lastName, string phoneNumber, string speciality)
        {
            // Check if a supplier with the same details already exists in the DataTable
            if (AddTechGridView.DataSource is DataTable dataTable)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["FirstName"].ToString() == firstName &&
                        row["LastName"].ToString() == lastName &&
                        row["PhoneNumber"].ToString() == phoneNumber &&
                        row["Speciality"].ToString() == speciality
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
            string query = "SELECT * FROM Technician";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    // Create a DataTable to hold the data
                    DataTable dataTable = new DataTable();
                    // Fill the DataTable with data from the SQL Server table
                    adapter.Fill(dataTable);
                    // Bind the DataTable to the DataGridView
                    AddTechGridView.DataSource = dataTable;
                }
            }
        }
    }
}
