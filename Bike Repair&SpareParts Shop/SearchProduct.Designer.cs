namespace Bike_Repair_SpareParts_Shop
{
    partial class SearchProduct
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
            SearchProductlabel = new Label();
            RP_IDradioButton = new RadioButton();
            RP_NameradioButton = new RadioButton();
            RPvaluesBox = new TextBox();
            RP_values = new Label();
            RPGridView = new DataGridView();
            RP_searchbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)RPGridView).BeginInit();
            SuspendLayout();
            // 
            // SearchProductlabel
            // 
            SearchProductlabel.AutoSize = true;
            SearchProductlabel.Font = new Font("Segoe UI", 12F);
            SearchProductlabel.Location = new Point(316, 160);
            SearchProductlabel.Name = "SearchProductlabel";
            SearchProductlabel.Size = new Size(115, 21);
            SearchProductlabel.TabIndex = 0;
            SearchProductlabel.Text = "Search Product";
            // 
            // RP_IDradioButton
            // 
            RP_IDradioButton.AutoSize = true;
            RP_IDradioButton.Font = new Font("Segoe UI", 12F);
            RP_IDradioButton.Location = new Point(386, 194);
            RP_IDradioButton.Name = "RP_IDradioButton";
            RP_IDradioButton.Size = new Size(43, 25);
            RP_IDradioButton.TabIndex = 1;
            RP_IDradioButton.TabStop = true;
            RP_IDradioButton.Text = "ID";
            RP_IDradioButton.UseVisualStyleBackColor = true;
            // 
            // RP_NameradioButton
            // 
            RP_NameradioButton.AutoSize = true;
            RP_NameradioButton.Font = new Font("Segoe UI", 12F);
            RP_NameradioButton.Location = new Point(437, 194);
            RP_NameradioButton.Name = "RP_NameradioButton";
            RP_NameradioButton.Size = new Size(70, 25);
            RP_NameradioButton.TabIndex = 2;
            RP_NameradioButton.TabStop = true;
            RP_NameradioButton.Text = "Name";
            RP_NameradioButton.UseVisualStyleBackColor = true;
            // 
            // RPvaluesBox
            // 
            RPvaluesBox.Location = new Point(386, 232);
            RPvaluesBox.Name = "RPvaluesBox";
            RPvaluesBox.Size = new Size(143, 23);
            RPvaluesBox.TabIndex = 3;
            // 
            // RP_values
            // 
            RP_values.AutoSize = true;
            RP_values.Font = new Font("Segoe UI", 12F);
            RP_values.Location = new Point(316, 235);
            RP_values.Name = "RP_values";
            RP_values.Size = new Size(55, 21);
            RP_values.TabIndex = 4;
            RP_values.Text = "Values";
            // 
            // RPGridView
            // 
            RPGridView.BackgroundColor = SystemColors.AppWorkspace;
            RPGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RPGridView.Location = new Point(248, 317);
            RPGridView.Name = "RPGridView";
            RPGridView.Size = new Size(521, 199);
            RPGridView.TabIndex = 5;
            // 
            // RP_searchbutton
            // 
            RP_searchbutton.Font = new Font("Segoe UI", 12F);
            RP_searchbutton.Location = new Point(446, 267);
            RP_searchbutton.Name = "RP_searchbutton";
            RP_searchbutton.Size = new Size(75, 30);
            RP_searchbutton.TabIndex = 6;
            RP_searchbutton.Text = "Search";
            RP_searchbutton.UseVisualStyleBackColor = true;
            RP_searchbutton.Click += RP_searchbutton_Click;
            // 
            // SearchProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1194, 788);
            Controls.Add(RP_searchbutton);
            Controls.Add(RPGridView);
            Controls.Add(RP_values);
            Controls.Add(RPvaluesBox);
            Controls.Add(RP_NameradioButton);
            Controls.Add(RP_IDradioButton);
            Controls.Add(SearchProductlabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchProduct";
            Text = "RemoveProduct";
            ((System.ComponentModel.ISupportInitialize)RPGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SearchProductlabel;
        private RadioButton RP_IDradioButton;
        private RadioButton RP_NameradioButton;
        private TextBox RPvaluesBox;
        private Label RP_values;
        private DataGridView RPGridView;
        private Button RP_searchbutton;
    }
}