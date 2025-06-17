namespace E_TrackPro
{
    partial class ProductsReviewPage
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
            ListItemViewerPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // ListItemViewerPanel
            // 
            ListItemViewerPanel.AutoScroll = true;
            ListItemViewerPanel.Dock = DockStyle.Fill;
            ListItemViewerPanel.Location = new Point(0, 0);
            ListItemViewerPanel.Name = "ListItemViewerPanel";
            ListItemViewerPanel.Size = new Size(1152, 611);
            ListItemViewerPanel.TabIndex = 0;
            // 
            // ProductsReviewPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1152, 611);
            Controls.Add(ListItemViewerPanel);
            ForeColor = Color.Coral;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductsReviewPage";
            Text = "ProductsReviewPage";
            Load += ProductsReviewPage_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel ListItemViewerPanel;
    }
}