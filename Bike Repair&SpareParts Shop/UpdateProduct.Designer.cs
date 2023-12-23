namespace Bike_Repair_SpareParts_Shop
{
    partial class UpdateProduct
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
            UpdateProductGridView = new DataGridView();
            UpdateProductPriceBox = new TextBox();
            UpdateProuductPrice = new Label();
            UpdateProudutNameBox = new TextBox();
            UpdateProductName = new Label();
            UpdateProductbutton = new Button();
            UPbyID = new Label();
            EnterIDforUP = new Label();
            EnterUP_IDBox = new TextBox();
            GetProductIDbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)UpdateProductGridView).BeginInit();
            SuspendLayout();
            // 
            // UpdateProductGridView
            // 
            UpdateProductGridView.BackgroundColor = SystemColors.ActiveCaption;
            UpdateProductGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UpdateProductGridView.Location = new Point(269, 309);
            UpdateProductGridView.Name = "UpdateProductGridView";
            UpdateProductGridView.Size = new Size(505, 232);
            UpdateProductGridView.TabIndex = 17;
            // 
            // UpdateProductPriceBox
            // 
            UpdateProductPriceBox.Location = new Point(457, 211);
            UpdateProductPriceBox.Name = "UpdateProductPriceBox";
            UpdateProductPriceBox.Size = new Size(100, 23);
            UpdateProductPriceBox.TabIndex = 16;
            // 
            // UpdateProuductPrice
            // 
            UpdateProuductPrice.AutoSize = true;
            UpdateProuductPrice.Font = new Font("Segoe UI", 12F);
            UpdateProuductPrice.Location = new Point(269, 213);
            UpdateProuductPrice.Name = "UpdateProuductPrice";
            UpdateProuductPrice.Size = new Size(98, 21);
            UpdateProuductPrice.TabIndex = 15;
            UpdateProuductPrice.Text = "Update Price";
            // 
            // UpdateProudutNameBox
            // 
            UpdateProudutNameBox.Location = new Point(457, 171);
            UpdateProudutNameBox.Name = "UpdateProudutNameBox";
            UpdateProudutNameBox.Size = new Size(186, 23);
            UpdateProudutNameBox.TabIndex = 14;
            // 
            // UpdateProductName
            // 
            UpdateProductName.AutoSize = true;
            UpdateProductName.Font = new Font("Segoe UI", 12F);
            UpdateProductName.Location = new Point(269, 173);
            UpdateProductName.Name = "UpdateProductName";
            UpdateProductName.Size = new Size(164, 21);
            UpdateProductName.TabIndex = 13;
            UpdateProductName.Text = "Update Product Name";
            // 
            // UpdateProductbutton
            // 
            UpdateProductbutton.Font = new Font("Segoe UI", 12F);
            UpdateProductbutton.Location = new Point(506, 249);
            UpdateProductbutton.Name = "UpdateProductbutton";
            UpdateProductbutton.Size = new Size(137, 32);
            UpdateProductbutton.TabIndex = 12;
            UpdateProductbutton.Text = "Update Product";
            UpdateProductbutton.UseVisualStyleBackColor = true;
            UpdateProductbutton.Click += UpdateProductbutton_Click;
            // 
            // UPbyID
            // 
            UPbyID.AutoSize = true;
            UPbyID.Font = new Font("Segoe UI", 12F);
            UPbyID.Location = new Point(269, 70);
            UPbyID.Name = "UPbyID";
            UPbyID.Size = new Size(158, 21);
            UPbyID.TabIndex = 18;
            UPbyID.Text = "Update Product By ID";
            // 
            // EnterIDforUP
            // 
            EnterIDforUP.AutoSize = true;
            EnterIDforUP.Font = new Font("Segoe UI", 12F);
            EnterIDforUP.Location = new Point(269, 125);
            EnterIDforUP.Name = "EnterIDforUP";
            EnterIDforUP.Size = new Size(91, 21);
            EnterIDforUP.TabIndex = 19;
            EnterIDforUP.Text = "Enter the ID";
            // 
            // EnterUP_IDBox
            // 
            EnterUP_IDBox.Location = new Point(457, 127);
            EnterUP_IDBox.Name = "EnterUP_IDBox";
            EnterUP_IDBox.Size = new Size(100, 23);
            EnterUP_IDBox.TabIndex = 20;
            // 
            // GetProductIDbutton
            // 
            GetProductIDbutton.Location = new Point(576, 128);
            GetProductIDbutton.Name = "GetProductIDbutton";
            GetProductIDbutton.Size = new Size(79, 23);
            GetProductIDbutton.TabIndex = 21;
            GetProductIDbutton.Text = "Get Product";
            GetProductIDbutton.UseVisualStyleBackColor = true;
            GetProductIDbutton.Click += GetProductIDbutton_Click;
            // 
            // UpdateProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1194, 713);
            Controls.Add(GetProductIDbutton);
            Controls.Add(EnterUP_IDBox);
            Controls.Add(EnterIDforUP);
            Controls.Add(UPbyID);
            Controls.Add(UpdateProductGridView);
            Controls.Add(UpdateProductPriceBox);
            Controls.Add(UpdateProuductPrice);
            Controls.Add(UpdateProudutNameBox);
            Controls.Add(UpdateProductName);
            Controls.Add(UpdateProductbutton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateProduct";
            Text = "UpdateProduct";
            ((System.ComponentModel.ISupportInitialize)UpdateProductGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView UpdateProductGridView;
        private TextBox UpdateProductPriceBox;
        private Label UpdateProuductPrice;
        private TextBox UpdateProudutNameBox;
        private Label UpdateProductName;
        private Button UpdateProductbutton;
        private Label UPbyID;
        private Label EnterIDforUP;
        private TextBox EnterUP_IDBox;
        private Button GetProductIDbutton;
    }
}