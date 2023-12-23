namespace Bike_Repair_SpareParts_Shop
{
    partial class AddTechnician
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
            AddTechGridView = new DataGridView();
            AddTechbutton = new Button();
            TechSpecialityBox = new TextBox();
            TechSpeciality = new Label();
            TechPhoneNumberBox = new TextBox();
            TechPhoneNumber = new Label();
            TechLastNameBox = new TextBox();
            TechLastName = new Label();
            TechFirstNameBox = new TextBox();
            TechFirstName = new Label();
            ((System.ComponentModel.ISupportInitialize)AddTechGridView).BeginInit();
            SuspendLayout();
            // 
            // AddTechGridView
            // 
            AddTechGridView.BackgroundColor = SystemColors.ActiveCaption;
            AddTechGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AddTechGridView.GridColor = SystemColors.GradientActiveCaption;
            AddTechGridView.Location = new Point(248, 323);
            AddTechGridView.Name = "AddTechGridView";
            AddTechGridView.Size = new Size(570, 257);
            AddTechGridView.TabIndex = 55;
            // 
            // AddTechbutton
            // 
            AddTechbutton.Font = new Font("Segoe UI", 12F);
            AddTechbutton.Location = new Point(621, 228);
            AddTechbutton.Name = "AddTechbutton";
            AddTechbutton.Size = new Size(126, 27);
            AddTechbutton.TabIndex = 54;
            AddTechbutton.Text = "Add Technician";
            AddTechbutton.UseVisualStyleBackColor = true;
            AddTechbutton.Click += AddTechbutton_Click;
            // 
            // TechSpecialityBox
            // 
            TechSpecialityBox.Location = new Point(552, 145);
            TechSpecialityBox.Name = "TechSpecialityBox";
            TechSpecialityBox.Size = new Size(195, 23);
            TechSpecialityBox.TabIndex = 49;
            // 
            // TechSpeciality
            // 
            TechSpeciality.AutoSize = true;
            TechSpeciality.Font = new Font("Segoe UI", 12F);
            TechSpeciality.Location = new Point(552, 121);
            TechSpeciality.Name = "TechSpeciality";
            TechSpeciality.Size = new Size(76, 21);
            TechSpeciality.TabIndex = 48;
            TechSpeciality.Text = "Speciality";
            // 
            // TechPhoneNumberBox
            // 
            TechPhoneNumberBox.Location = new Point(290, 145);
            TechPhoneNumberBox.Name = "TechPhoneNumberBox";
            TechPhoneNumberBox.Size = new Size(195, 23);
            TechPhoneNumberBox.TabIndex = 47;
            // 
            // TechPhoneNumber
            // 
            TechPhoneNumber.AutoSize = true;
            TechPhoneNumber.Font = new Font("Segoe UI", 12F);
            TechPhoneNumber.Location = new Point(290, 121);
            TechPhoneNumber.Name = "TechPhoneNumber";
            TechPhoneNumber.Size = new Size(116, 21);
            TechPhoneNumber.TabIndex = 46;
            TechPhoneNumber.Text = "Phone Number";
            // 
            // TechLastNameBox
            // 
            TechLastNameBox.Location = new Point(552, 76);
            TechLastNameBox.Name = "TechLastNameBox";
            TechLastNameBox.Size = new Size(195, 23);
            TechLastNameBox.TabIndex = 45;
            // 
            // TechLastName
            // 
            TechLastName.AutoSize = true;
            TechLastName.Font = new Font("Segoe UI", 12F);
            TechLastName.Location = new Point(552, 52);
            TechLastName.Name = "TechLastName";
            TechLastName.Size = new Size(84, 21);
            TechLastName.TabIndex = 44;
            TechLastName.Text = "Last Name";
            // 
            // TechFirstNameBox
            // 
            TechFirstNameBox.Location = new Point(290, 76);
            TechFirstNameBox.Name = "TechFirstNameBox";
            TechFirstNameBox.Size = new Size(195, 23);
            TechFirstNameBox.TabIndex = 43;
            // 
            // TechFirstName
            // 
            TechFirstName.AutoSize = true;
            TechFirstName.Font = new Font("Segoe UI", 12F);
            TechFirstName.Location = new Point(290, 52);
            TechFirstName.Name = "TechFirstName";
            TechFirstName.Size = new Size(86, 21);
            TechFirstName.TabIndex = 42;
            TechFirstName.Text = "First Name";
            // 
            // AddTechnician
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1178, 674);
            Controls.Add(AddTechGridView);
            Controls.Add(AddTechbutton);
            Controls.Add(TechSpecialityBox);
            Controls.Add(TechSpeciality);
            Controls.Add(TechPhoneNumberBox);
            Controls.Add(TechPhoneNumber);
            Controls.Add(TechLastNameBox);
            Controls.Add(TechLastName);
            Controls.Add(TechFirstNameBox);
            Controls.Add(TechFirstName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddTechnician";
            Text = "AddTechnician";
            ((System.ComponentModel.ISupportInitialize)AddTechGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView AddTechGridView;
        private Button AddTechbutton;
        private TextBox TechSpecialityBox;
        private Label TechSpeciality;
        private TextBox TechPhoneNumberBox;
        private Label TechPhoneNumber;
        private TextBox TechLastNameBox;
        private Label TechLastName;
        private TextBox TechFirstNameBox;
        private Label TechFirstName;
    }
}