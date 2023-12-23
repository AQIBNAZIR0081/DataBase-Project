namespace Bike_Repair_SpareParts_Shop
{
    partial class SearchSupplier
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
            SupplierValuesBox = new TextBox();
            LastNameradioButton = new RadioButton();
            S_EnterValues = new Label();
            SearchSupplierGridView = new DataGridView();
            FirstNameradioButton = new RadioButton();
            S_IDradioButton = new RadioButton();
            SearchBy = new Label();
            SearchSupplierbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)SearchSupplierGridView).BeginInit();
            SuspendLayout();
            // 
            // SupplierValuesBox
            // 
            SupplierValuesBox.Location = new Point(292, 99);
            SupplierValuesBox.Name = "SupplierValuesBox";
            SupplierValuesBox.Size = new Size(217, 23);
            SupplierValuesBox.TabIndex = 15;
            // 
            // LastNameradioButton
            // 
            LastNameradioButton.AutoSize = true;
            LastNameradioButton.Font = new Font("Segoe UI", 12F);
            LastNameradioButton.Location = new Point(411, 55);
            LastNameradioButton.Name = "LastNameradioButton";
            LastNameradioButton.Size = new Size(98, 25);
            LastNameradioButton.TabIndex = 14;
            LastNameradioButton.TabStop = true;
            LastNameradioButton.Text = "LastName";
            LastNameradioButton.UseVisualStyleBackColor = true;
            // 
            // S_EnterValues
            // 
            S_EnterValues.AutoSize = true;
            S_EnterValues.Font = new Font("Segoe UI", 12F);
            S_EnterValues.Location = new Point(191, 99);
            S_EnterValues.Name = "S_EnterValues";
            S_EnterValues.Size = new Size(95, 21);
            S_EnterValues.TabIndex = 13;
            S_EnterValues.Text = "Enter Values";
            // 
            // SearchSupplierGridView
            // 
            SearchSupplierGridView.BackgroundColor = SystemColors.ActiveCaption;
            SearchSupplierGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SearchSupplierGridView.Location = new Point(191, 191);
            SearchSupplierGridView.Name = "SearchSupplierGridView";
            SearchSupplierGridView.Size = new Size(782, 287);
            SearchSupplierGridView.TabIndex = 12;
            // 
            // FirstNameradioButton
            // 
            FirstNameradioButton.AutoSize = true;
            FirstNameradioButton.Font = new Font("Segoe UI", 12F);
            FirstNameradioButton.Location = new Point(305, 55);
            FirstNameradioButton.Name = "FirstNameradioButton";
            FirstNameradioButton.Size = new Size(100, 25);
            FirstNameradioButton.TabIndex = 11;
            FirstNameradioButton.TabStop = true;
            FirstNameradioButton.Text = "FirstName";
            FirstNameradioButton.UseVisualStyleBackColor = true;
            // 
            // S_IDradioButton
            // 
            S_IDradioButton.AutoSize = true;
            S_IDradioButton.Font = new Font("Segoe UI", 12F);
            S_IDradioButton.Location = new Point(256, 55);
            S_IDradioButton.Name = "S_IDradioButton";
            S_IDradioButton.Size = new Size(43, 25);
            S_IDradioButton.TabIndex = 10;
            S_IDradioButton.TabStop = true;
            S_IDradioButton.Text = "ID";
            S_IDradioButton.UseVisualStyleBackColor = true;
            // 
            // SearchBy
            // 
            SearchBy.AutoSize = true;
            SearchBy.Font = new Font("Segoe UI", 12F);
            SearchBy.Location = new Point(191, 25);
            SearchBy.Name = "SearchBy";
            SearchBy.Size = new Size(78, 21);
            SearchBy.TabIndex = 9;
            SearchBy.Text = "Search By";
            // 
            // SearchSupplierbutton
            // 
            SearchSupplierbutton.Font = new Font("Segoe UI", 12F);
            SearchSupplierbutton.Location = new Point(428, 141);
            SearchSupplierbutton.Name = "SearchSupplierbutton";
            SearchSupplierbutton.Size = new Size(81, 31);
            SearchSupplierbutton.TabIndex = 8;
            SearchSupplierbutton.Text = "Search";
            SearchSupplierbutton.UseVisualStyleBackColor = true;
            SearchSupplierbutton.Click += SearchSupplierbutton_Click;
            // 
            // SearchSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1194, 788);
            Controls.Add(SupplierValuesBox);
            Controls.Add(LastNameradioButton);
            Controls.Add(S_EnterValues);
            Controls.Add(SearchSupplierGridView);
            Controls.Add(FirstNameradioButton);
            Controls.Add(S_IDradioButton);
            Controls.Add(SearchBy);
            Controls.Add(SearchSupplierbutton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchSupplier";
            Text = "SearchSupplier";
            ((System.ComponentModel.ISupportInitialize)SearchSupplierGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SupplierValuesBox;
        private RadioButton LastNameradioButton;
        private Label S_EnterValues;
        private DataGridView SearchSupplierGridView;
        private RadioButton FirstNameradioButton;
        private RadioButton S_IDradioButton;
        private Label SearchBy;
        private Button SearchSupplierbutton;
    }
}