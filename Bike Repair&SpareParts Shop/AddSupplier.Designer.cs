namespace Bike_Repair_SpareParts_Shop
{
    partial class AddSupplier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Add_SupplierGridView = new DataGridView();
            AddSupplierbutton = new Button();
            CompanyBox = new TextBox();
            Company = new Label();
            EmailBox = new TextBox();
            Email = new Label();
            PhoneNumberBox = new TextBox();
            PhoneNumber = new Label();
            AddressBox = new TextBox();
            Address = new Label();
            LastNameBox = new TextBox();
            LastName = new Label();
            FirstNameBox = new TextBox();
            FirstName = new Label();
            ((System.ComponentModel.ISupportInitialize)Add_SupplierGridView).BeginInit();
            SuspendLayout();
            // 
            // Add_SupplierGridView
            // 
            Add_SupplierGridView.BackgroundColor = SystemColors.ActiveCaption;
            Add_SupplierGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Add_SupplierGridView.GridColor = SystemColors.GradientActiveCaption;
            Add_SupplierGridView.Location = new Point(101, 389);
            Add_SupplierGridView.Name = "Add_SupplierGridView";
            Add_SupplierGridView.Size = new Size(825, 257);
            Add_SupplierGridView.TabIndex = 41;
            // 
            // AddSupplierbutton
            // 
            AddSupplierbutton.Font = new Font("Segoe UI", 12F);
            AddSupplierbutton.Location = new Point(553, 284);
            AddSupplierbutton.Name = "AddSupplierbutton";
            AddSupplierbutton.Size = new Size(118, 27);
            AddSupplierbutton.TabIndex = 40;
            AddSupplierbutton.Text = "Add Supplier";
            AddSupplierbutton.UseVisualStyleBackColor = true;
            AddSupplierbutton.Click += AddSupplierbutton_Click;
            // 
            // CompanyBox
            // 
            CompanyBox.Location = new Point(476, 237);
            CompanyBox.Name = "CompanyBox";
            CompanyBox.Size = new Size(195, 23);
            CompanyBox.TabIndex = 39;
            // 
            // Company
            // 
            Company.AutoSize = true;
            Company.Font = new Font("Segoe UI", 12F);
            Company.Location = new Point(476, 213);
            Company.Name = "Company";
            Company.Size = new Size(77, 21);
            Company.TabIndex = 38;
            Company.Text = "Company";
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(214, 237);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(195, 23);
            EmailBox.TabIndex = 37;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI", 12F);
            Email.Location = new Point(214, 213);
            Email.Name = "Email";
            Email.Size = new Size(48, 21);
            Email.TabIndex = 36;
            Email.Text = "Email";
            // 
            // PhoneNumberBox
            // 
            PhoneNumberBox.Location = new Point(476, 168);
            PhoneNumberBox.Name = "PhoneNumberBox";
            PhoneNumberBox.Size = new Size(195, 23);
            PhoneNumberBox.TabIndex = 35;
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSize = true;
            PhoneNumber.Font = new Font("Segoe UI", 12F);
            PhoneNumber.Location = new Point(476, 144);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(112, 21);
            PhoneNumber.TabIndex = 34;
            PhoneNumber.Text = "PhoneNumber";
            // 
            // AddressBox
            // 
            AddressBox.Location = new Point(214, 168);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(195, 23);
            AddressBox.TabIndex = 33;
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Font = new Font("Segoe UI", 12F);
            Address.Location = new Point(214, 144);
            Address.Name = "Address";
            Address.Size = new Size(66, 21);
            Address.TabIndex = 32;
            Address.Text = "Address";
            // 
            // LastNameBox
            // 
            LastNameBox.Location = new Point(476, 99);
            LastNameBox.Name = "LastNameBox";
            LastNameBox.Size = new Size(195, 23);
            LastNameBox.TabIndex = 31;
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Font = new Font("Segoe UI", 12F);
            LastName.Location = new Point(476, 75);
            LastName.Name = "LastName";
            LastName.Size = new Size(84, 21);
            LastName.TabIndex = 30;
            LastName.Text = "Last Name";
            // 
            // FirstNameBox
            // 
            FirstNameBox.Location = new Point(214, 99);
            FirstNameBox.Name = "FirstNameBox";
            FirstNameBox.Size = new Size(195, 23);
            FirstNameBox.TabIndex = 29;
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Font = new Font("Segoe UI", 12F);
            FirstName.Location = new Point(214, 75);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(86, 21);
            FirstName.TabIndex = 28;
            FirstName.Text = "First Name";
            // 
            // AddSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1194, 788);
            Controls.Add(Add_SupplierGridView);
            Controls.Add(AddSupplierbutton);
            Controls.Add(CompanyBox);
            Controls.Add(Company);
            Controls.Add(EmailBox);
            Controls.Add(Email);
            Controls.Add(PhoneNumberBox);
            Controls.Add(PhoneNumber);
            Controls.Add(AddressBox);
            Controls.Add(Address);
            Controls.Add(LastNameBox);
            Controls.Add(LastName);
            Controls.Add(FirstNameBox);
            Controls.Add(FirstName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddSupplier";
            Text = "AddSupplier";
            ((System.ComponentModel.ISupportInitialize)Add_SupplierGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Add_SupplierGridView;
        private Button AddSupplierbutton;
        private TextBox CompanyBox;
        private Label Company;
        private TextBox EmailBox;
        private Label Email;
        private TextBox PhoneNumberBox;
        private Label PhoneNumber;
        private TextBox AddressBox;
        private Label Address;
        private TextBox LastNameBox;
        private Label LastName;
        private TextBox FirstNameBox;
        private Label FirstName;
    }
}