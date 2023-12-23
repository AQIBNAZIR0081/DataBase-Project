namespace Bike_Repair_SpareParts_Shop
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Home frm = new Home();
            frm.TopLevel = false;
            Homepanel.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void addSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSupplier frm = new AddSupplier();
            frm.TopLevel = false;
            Homepanel.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }
        private void searchSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchSupplier frm = new SearchSupplier();
            frm.TopLevel = false;
            Homepanel.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct frm = new AddProduct();
            frm.TopLevel = false;
            Homepanel.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void removeProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchProduct frm = new SearchProduct();
            frm.TopLevel = false;
            Homepanel.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void updateProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateProduct frm = new UpdateProduct();
            frm.TopLevel = false;
            Homepanel.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTechnician frm = new AddTechnician();
            frm.TopLevel = false;
            Homepanel.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void addShipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddShipment frm = new AddShipment();
            frm.TopLevel = false;
            Homepanel.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

    }
}
