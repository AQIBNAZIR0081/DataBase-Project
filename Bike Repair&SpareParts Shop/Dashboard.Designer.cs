namespace Bike_Repair_SpareParts_Shop
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            supplierToolStripMenuItem = new ToolStripMenuItem();
            addSupplierToolStripMenuItem = new ToolStripMenuItem();
            searchSupplierToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            addProductToolStripMenuItem = new ToolStripMenuItem();
            removeProductToolStripMenuItem = new ToolStripMenuItem();
            updateProductToolStripMenuItem = new ToolStripMenuItem();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            addEmployeeToolStripMenuItem = new ToolStripMenuItem();
            removeEmployeeToolStripMenuItem = new ToolStripMenuItem();
            searchEmployeeToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            addCustomerToolStripMenuItem = new ToolStripMenuItem();
            removeCustomerToolStripMenuItem = new ToolStripMenuItem();
            searchCustomerToolStripMenuItem = new ToolStripMenuItem();
            shipmentToolStripMenuItem = new ToolStripMenuItem();
            addShipmentToolStripMenuItem = new ToolStripMenuItem();
            removeShipmentToolStripMenuItem = new ToolStripMenuItem();
            shipmentToolStripMenuItem1 = new ToolStripMenuItem();
            Homepanel = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.InactiveCaption;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { supplierToolStripMenuItem, productToolStripMenuItem, employeesToolStripMenuItem, customerToolStripMenuItem, shipmentToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(103, 713);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // supplierToolStripMenuItem
            // 
            supplierToolStripMenuItem.AutoToolTip = true;
            supplierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addSupplierToolStripMenuItem, searchSupplierToolStripMenuItem });
            supplierToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            supplierToolStripMenuItem.Size = new Size(90, 25);
            supplierToolStripMenuItem.Text = "Supplier";
            // 
            // addSupplierToolStripMenuItem
            // 
            addSupplierToolStripMenuItem.Name = "addSupplierToolStripMenuItem";
            addSupplierToolStripMenuItem.ShowShortcutKeys = false;
            addSupplierToolStripMenuItem.Size = new Size(189, 26);
            addSupplierToolStripMenuItem.Text = "Add Supplier";
            addSupplierToolStripMenuItem.Click += addSupplierToolStripMenuItem_Click;
            // 
            // searchSupplierToolStripMenuItem
            // 
            searchSupplierToolStripMenuItem.Name = "searchSupplierToolStripMenuItem";
            searchSupplierToolStripMenuItem.Size = new Size(189, 26);
            searchSupplierToolStripMenuItem.Text = "Search Supplier";
            searchSupplierToolStripMenuItem.Click += searchSupplierToolStripMenuItem_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addProductToolStripMenuItem, removeProductToolStripMenuItem, updateProductToolStripMenuItem });
            productToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(90, 25);
            productToolStripMenuItem.Text = "Product";
            // 
            // addProductToolStripMenuItem
            // 
            addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            addProductToolStripMenuItem.Size = new Size(188, 26);
            addProductToolStripMenuItem.Text = "Add Product";
            addProductToolStripMenuItem.Click += addProductToolStripMenuItem_Click;
            // 
            // removeProductToolStripMenuItem
            // 
            removeProductToolStripMenuItem.Name = "removeProductToolStripMenuItem";
            removeProductToolStripMenuItem.Size = new Size(188, 26);
            removeProductToolStripMenuItem.Text = "Search Product";
            removeProductToolStripMenuItem.Click += removeProductToolStripMenuItem_Click;
            // 
            // updateProductToolStripMenuItem
            // 
            updateProductToolStripMenuItem.Name = "updateProductToolStripMenuItem";
            updateProductToolStripMenuItem.Size = new Size(188, 26);
            updateProductToolStripMenuItem.Text = "Update Product";
            updateProductToolStripMenuItem.Click += updateProductToolStripMenuItem_Click;
            // 
            // employeesToolStripMenuItem
            // 
            employeesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addEmployeeToolStripMenuItem, removeEmployeeToolStripMenuItem, searchEmployeeToolStripMenuItem });
            employeesToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            employeesToolStripMenuItem.Size = new Size(90, 25);
            employeesToolStripMenuItem.Text = "Employees";
            // 
            // addEmployeeToolStripMenuItem
            // 
            addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            addEmployeeToolStripMenuItem.Size = new Size(209, 26);
            addEmployeeToolStripMenuItem.Text = "Add Employee";
            addEmployeeToolStripMenuItem.Click += addEmployeeToolStripMenuItem_Click;
            // 
            // removeEmployeeToolStripMenuItem
            // 
            removeEmployeeToolStripMenuItem.Name = "removeEmployeeToolStripMenuItem";
            removeEmployeeToolStripMenuItem.Size = new Size(209, 26);
            removeEmployeeToolStripMenuItem.Text = "Remove Employee";
            // 
            // searchEmployeeToolStripMenuItem
            // 
            searchEmployeeToolStripMenuItem.Name = "searchEmployeeToolStripMenuItem";
            searchEmployeeToolStripMenuItem.Size = new Size(209, 26);
            searchEmployeeToolStripMenuItem.Text = "Search Employee";
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addCustomerToolStripMenuItem, removeCustomerToolStripMenuItem, searchCustomerToolStripMenuItem });
            customerToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(90, 25);
            customerToolStripMenuItem.Text = "Customer";
            // 
            // addCustomerToolStripMenuItem
            // 
            addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            addCustomerToolStripMenuItem.Size = new Size(209, 26);
            addCustomerToolStripMenuItem.Text = "Add Customer";
            // 
            // removeCustomerToolStripMenuItem
            // 
            removeCustomerToolStripMenuItem.Name = "removeCustomerToolStripMenuItem";
            removeCustomerToolStripMenuItem.Size = new Size(209, 26);
            removeCustomerToolStripMenuItem.Text = "Remove Customer";
            // 
            // searchCustomerToolStripMenuItem
            // 
            searchCustomerToolStripMenuItem.Name = "searchCustomerToolStripMenuItem";
            searchCustomerToolStripMenuItem.Size = new Size(209, 26);
            searchCustomerToolStripMenuItem.Text = "Search Customer";
            // 
            // shipmentToolStripMenuItem
            // 
            shipmentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addShipmentToolStripMenuItem, removeShipmentToolStripMenuItem, shipmentToolStripMenuItem1 });
            shipmentToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            shipmentToolStripMenuItem.Name = "shipmentToolStripMenuItem";
            shipmentToolStripMenuItem.Size = new Size(90, 25);
            shipmentToolStripMenuItem.Text = "Shipment";
            // 
            // addShipmentToolStripMenuItem
            // 
            addShipmentToolStripMenuItem.Name = "addShipmentToolStripMenuItem";
            addShipmentToolStripMenuItem.Size = new Size(208, 26);
            addShipmentToolStripMenuItem.Text = "Add Shipment";
            addShipmentToolStripMenuItem.Click += addShipmentToolStripMenuItem_Click;
            // 
            // removeShipmentToolStripMenuItem
            // 
            removeShipmentToolStripMenuItem.Name = "removeShipmentToolStripMenuItem";
            removeShipmentToolStripMenuItem.Size = new Size(208, 26);
            removeShipmentToolStripMenuItem.Text = "Remove Shipment";
            // 
            // shipmentToolStripMenuItem1
            // 
            shipmentToolStripMenuItem1.Name = "shipmentToolStripMenuItem1";
            shipmentToolStripMenuItem1.Size = new Size(208, 26);
            shipmentToolStripMenuItem1.Text = "Search Shipment";
            // 
            // Homepanel
            // 
            Homepanel.Dock = DockStyle.Fill;
            Homepanel.ForeColor = Color.Black;
            Homepanel.Location = new Point(103, 0);
            Homepanel.Name = "Homepanel";
            Homepanel.Size = new Size(1194, 713);
            Homepanel.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1297, 713);
            Controls.Add(Homepanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem supplierToolStripMenuItem;
        private ToolStripMenuItem addSupplierToolStripMenuItem;
        private ToolStripMenuItem searchSupplierToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem addProductToolStripMenuItem;
        private ToolStripMenuItem removeProductToolStripMenuItem;
        private ToolStripMenuItem updateProductToolStripMenuItem;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem addEmployeeToolStripMenuItem;
        private ToolStripMenuItem removeEmployeeToolStripMenuItem;
        private ToolStripMenuItem searchEmployeeToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem addCustomerToolStripMenuItem;
        private ToolStripMenuItem removeCustomerToolStripMenuItem;
        private ToolStripMenuItem searchCustomerToolStripMenuItem;
        private ToolStripMenuItem shipmentToolStripMenuItem;
        private ToolStripMenuItem addShipmentToolStripMenuItem;
        private ToolStripMenuItem removeShipmentToolStripMenuItem;
        private ToolStripMenuItem shipmentToolStripMenuItem1;
        private Panel Homepanel;
    }
}
