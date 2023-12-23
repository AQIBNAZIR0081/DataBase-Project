namespace Bike_Repair_SpareParts_Shop
{
    partial class AddProduct
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
            AddProductGridView = new DataGridView();
            Add_ProductPriceBox = new TextBox();
            ProuductPrice = new Label();
            Add_ProudutNameBox = new TextBox();
            ProductName = new Label();
            AddProductbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)AddProductGridView).BeginInit();
            SuspendLayout();
            // 
            // AddProductGridView
            // 
            AddProductGridView.BackgroundColor = SystemColors.ActiveCaption;
            AddProductGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AddProductGridView.Location = new Point(315, 276);
            AddProductGridView.Name = "AddProductGridView";
            AddProductGridView.Size = new Size(505, 232);
            AddProductGridView.TabIndex = 11;
            // 
            // Add_ProductPriceBox
            // 
            Add_ProductPriceBox.Location = new Point(423, 177);
            Add_ProductPriceBox.Name = "Add_ProductPriceBox";
            Add_ProductPriceBox.Size = new Size(100, 23);
            Add_ProductPriceBox.TabIndex = 10;
            // 
            // ProuductPrice
            // 
            ProuductPrice.AutoSize = true;
            ProuductPrice.Font = new Font("Segoe UI", 12F);
            ProuductPrice.Location = new Point(307, 179);
            ProuductPrice.Name = "ProuductPrice";
            ProuductPrice.Size = new Size(44, 21);
            ProuductPrice.TabIndex = 9;
            ProuductPrice.Text = "Price";
            // 
            // Add_ProudutNameBox
            // 
            Add_ProudutNameBox.Location = new Point(423, 137);
            Add_ProudutNameBox.Name = "Add_ProudutNameBox";
            Add_ProudutNameBox.Size = new Size(186, 23);
            Add_ProudutNameBox.TabIndex = 8;
            // 
            // ProductName
            // 
            ProductName.AutoSize = true;
            ProductName.Font = new Font("Segoe UI", 12F);
            ProductName.Location = new Point(307, 139);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(110, 21);
            ProductName.TabIndex = 7;
            ProductName.Text = "Product Name";
            // 
            // AddProductbutton
            // 
            AddProductbutton.Font = new Font("Segoe UI", 12F);
            AddProductbutton.Location = new Point(502, 215);
            AddProductbutton.Name = "AddProductbutton";
            AddProductbutton.Size = new Size(107, 32);
            AddProductbutton.TabIndex = 6;
            AddProductbutton.Text = "Add Product";
            AddProductbutton.UseVisualStyleBackColor = true;
            AddProductbutton.Click += AddProductbutton_Click;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1194, 713);
            Controls.Add(AddProductGridView);
            Controls.Add(Add_ProductPriceBox);
            Controls.Add(ProuductPrice);
            Controls.Add(Add_ProudutNameBox);
            Controls.Add(ProductName);
            Controls.Add(AddProductbutton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddProduct";
            Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)AddProductGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView AddProductGridView;
        private TextBox Add_ProductPriceBox;
        private Label ProuductPrice;
        private TextBox Add_ProudutNameBox;
        private new Label ProductName;
        private Button AddProductbutton;
    }
}