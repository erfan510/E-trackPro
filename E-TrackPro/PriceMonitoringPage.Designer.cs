namespace E_TrackPro
{
    partial class PriceMonitoringPage
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
            cartesianChartPrice = new LiveCharts.WinForms.CartesianChart();
            cartesianChartStock = new LiveCharts.WinForms.CartesianChart();
            label1 = new Label();
            label2 = new Label();
            CategoriesComboBox = new ComboBox();
            SuspendLayout();
            // 
            // cartesianChartPrice
            // 
            cartesianChartPrice.Location = new Point(0, 52);
            cartesianChartPrice.Name = "cartesianChartPrice";
            cartesianChartPrice.Size = new Size(1109, 227);
            cartesianChartPrice.TabIndex = 0;
            cartesianChartPrice.Text = "cartesianChart1";
            // 
            // cartesianChartStock
            // 
            cartesianChartStock.Location = new Point(0, 325);
            cartesianChartStock.Name = "cartesianChartStock";
            cartesianChartStock.Size = new Size(1109, 227);
            cartesianChartStock.TabIndex = 1;
            cartesianChartStock.Text = "cartesianChart2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(0, -1);
            label1.Name = "label1";
            label1.Size = new Size(101, 50);
            label1.TabIndex = 2;
            label1.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 126, 249);
            label2.Location = new Point(12, 272);
            label2.Name = "label2";
            label2.Size = new Size(111, 50);
            label2.TabIndex = 3;
            label2.Text = "Stock";
            // 
            // CategoriesComboBox
            // 
            CategoriesComboBox.BackColor = Color.FromArgb(46, 51, 73);
            CategoriesComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CategoriesComboBox.ForeColor = Color.FromArgb(0, 126, 249);
            CategoriesComboBox.FormattingEnabled = true;
            CategoriesComboBox.Items.AddRange(new object[] { "smartphones", "laptops", "fragrances", "skincare", "groceries", "home-decoration", "furniture", "tops", "womens-dresses", "womens-shoes", "mens-shirts", "mens-shoes", "mens-watches", "womens-watches", "womens-bag", "womens-jewellery", "sunglasses", "automotive", "motorcycle", "lighting" });
            CategoriesComboBox.Location = new Point(923, 12);
            CategoriesComboBox.Name = "CategoriesComboBox";
            CategoriesComboBox.Size = new Size(186, 36);
            CategoriesComboBox.TabIndex = 4;
            CategoriesComboBox.SelectedIndexChanged += CategoriesComboBox_SelectedIndexChanged;
            // 
            // PriceMonitoringPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1134, 564);
            Controls.Add(CategoriesComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cartesianChartStock);
            Controls.Add(cartesianChartPrice);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PriceMonitoringPage";
            Text = "PriceMonitoringPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChartPrice;
        private LiveCharts.WinForms.CartesianChart cartesianChartStock;
        private Label label1;
        private Label label2;
        private ComboBox CategoriesComboBox;
    }
}