namespace Bike_Repair_SpareParts_Shop
{
    partial class Home
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
            HomeTitle = new Label();
            SuspendLayout();
            // 
            // HomeTitle
            // 
            HomeTitle.AutoSize = true;
            HomeTitle.BackColor = Color.Transparent;
            HomeTitle.Font = new Font("Segoe UI", 25F);
            HomeTitle.ForeColor = Color.Olive;
            HomeTitle.Location = new Point(56, 47);
            HomeTitle.Name = "HomeTitle";
            HomeTitle.Size = new Size(464, 46);
            HomeTitle.TabIndex = 3;
            HomeTitle.Text = "Welcome To Bike Repair Shop";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 788);
            Controls.Add(HomeTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HomeTitle;
    }
}