namespace Bike_Repair_SpareParts_Shop
{
    partial class AddShipment
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
            ShipmentSupplierID = new Label();
            ShipmentSupplierIDBox = new TextBox();
            ShipmentProductIDBox = new TextBox();
            ShipmentProductID = new Label();
            QuantitynumericUpDown = new NumericUpDown();
            ShipmentProductQuantity = new Label();
            ShipmentdateTimePicker = new DateTimePicker();
            ShipmentDate = new Label();
            ShipmentDetailGridView = new DataGridView();
            AddShipmentbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)QuantitynumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShipmentDetailGridView).BeginInit();
            SuspendLayout();
            // 
            // ShipmentSupplierID
            // 
            ShipmentSupplierID.AutoSize = true;
            ShipmentSupplierID.Font = new Font("Segoe UI", 12F);
            ShipmentSupplierID.Location = new Point(389, 98);
            ShipmentSupplierID.Name = "ShipmentSupplierID";
            ShipmentSupplierID.Size = new Size(87, 21);
            ShipmentSupplierID.TabIndex = 0;
            ShipmentSupplierID.Text = "Supplier ID";
            // 
            // ShipmentSupplierIDBox
            // 
            ShipmentSupplierIDBox.Location = new Point(549, 96);
            ShipmentSupplierIDBox.Name = "ShipmentSupplierIDBox";
            ShipmentSupplierIDBox.Size = new Size(100, 23);
            ShipmentSupplierIDBox.TabIndex = 1;
            // 
            // ShipmentProductIDBox
            // 
            ShipmentProductIDBox.Location = new Point(549, 147);
            ShipmentProductIDBox.Name = "ShipmentProductIDBox";
            ShipmentProductIDBox.Size = new Size(100, 23);
            ShipmentProductIDBox.TabIndex = 3;
            // 
            // ShipmentProductID
            // 
            ShipmentProductID.AutoSize = true;
            ShipmentProductID.Font = new Font("Segoe UI", 12F);
            ShipmentProductID.Location = new Point(389, 149);
            ShipmentProductID.Name = "ShipmentProductID";
            ShipmentProductID.Size = new Size(83, 21);
            ShipmentProductID.TabIndex = 2;
            ShipmentProductID.Text = "Product ID";
            // 
            // QuantitynumericUpDown
            // 
            QuantitynumericUpDown.Location = new Point(549, 201);
            QuantitynumericUpDown.Name = "QuantitynumericUpDown";
            QuantitynumericUpDown.Size = new Size(100, 23);
            QuantitynumericUpDown.TabIndex = 4;
            // 
            // ShipmentProductQuantity
            // 
            ShipmentProductQuantity.AutoSize = true;
            ShipmentProductQuantity.Font = new Font("Segoe UI", 12F);
            ShipmentProductQuantity.Location = new Point(389, 205);
            ShipmentProductQuantity.Name = "ShipmentProductQuantity";
            ShipmentProductQuantity.Size = new Size(70, 21);
            ShipmentProductQuantity.TabIndex = 5;
            ShipmentProductQuantity.Text = "Quantity";
            // 
            // ShipmentdateTimePicker
            // 
            ShipmentdateTimePicker.Format = DateTimePickerFormat.Short;
            ShipmentdateTimePicker.Location = new Point(549, 259);
            ShipmentdateTimePicker.Name = "ShipmentdateTimePicker";
            ShipmentdateTimePicker.Size = new Size(100, 23);
            ShipmentdateTimePicker.TabIndex = 6;
            // 
            // ShipmentDate
            // 
            ShipmentDate.AutoSize = true;
            ShipmentDate.Font = new Font("Segoe UI", 12F);
            ShipmentDate.Location = new Point(389, 261);
            ShipmentDate.Name = "ShipmentDate";
            ShipmentDate.Size = new Size(113, 21);
            ShipmentDate.TabIndex = 7;
            ShipmentDate.Text = "Shipment Date";
            // 
            // ShipmentDetailGridView
            // 
            ShipmentDetailGridView.BackgroundColor = SystemColors.GradientActiveCaption;
            ShipmentDetailGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShipmentDetailGridView.Location = new Point(265, 353);
            ShipmentDetailGridView.Name = "ShipmentDetailGridView";
            ShipmentDetailGridView.Size = new Size(584, 223);
            ShipmentDetailGridView.TabIndex = 8;
            // 
            // AddShipmentbutton
            // 
            AddShipmentbutton.Font = new Font("Segoe UI", 12F);
            AddShipmentbutton.Location = new Point(727, 309);
            AddShipmentbutton.Name = "AddShipmentbutton";
            AddShipmentbutton.Size = new Size(122, 27);
            AddShipmentbutton.TabIndex = 9;
            AddShipmentbutton.Text = "Add Shipment";
            AddShipmentbutton.UseVisualStyleBackColor = true;
            AddShipmentbutton.Click += AddShipmentbutton_Click;
            // 
            // AddShipment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1178, 674);
            Controls.Add(AddShipmentbutton);
            Controls.Add(ShipmentDetailGridView);
            Controls.Add(ShipmentDate);
            Controls.Add(ShipmentdateTimePicker);
            Controls.Add(ShipmentProductQuantity);
            Controls.Add(QuantitynumericUpDown);
            Controls.Add(ShipmentProductIDBox);
            Controls.Add(ShipmentProductID);
            Controls.Add(ShipmentSupplierIDBox);
            Controls.Add(ShipmentSupplierID);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddShipment";
            Text = "AddShipment";
            ((System.ComponentModel.ISupportInitialize)QuantitynumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShipmentDetailGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ShipmentSupplierID;
        private TextBox ShipmentSupplierIDBox;
        private TextBox ShipmentProductIDBox;
        private Label ShipmentProductID;
        private NumericUpDown QuantitynumericUpDown;
        private Label ShipmentProductQuantity;
        private DateTimePicker ShipmentdateTimePicker;
        private Label ShipmentDate;
        private DataGridView ShipmentDetailGridView;
        private Button AddShipmentbutton;
    }
}