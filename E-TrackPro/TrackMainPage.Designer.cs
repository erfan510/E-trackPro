namespace E_TrackPro
{
    partial class TrackMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackMainPage));
            bar = new Panel();
            UpdateButton = new Button();
            PriceMonitoringButton = new Button();
            SocialMediaButton = new Button();
            ProductsReviewButton = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            CloseButton = new Button();
            PagePanelView = new Panel();
            SpecifyPageLabel = new Label();
            movePanel = new Panel();
            bar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bar
            // 
            bar.BackColor = Color.FromArgb(24, 30, 54);
            bar.Controls.Add(UpdateButton);
            bar.Controls.Add(PriceMonitoringButton);
            bar.Controls.Add(SocialMediaButton);
            bar.Controls.Add(ProductsReviewButton);
            bar.Controls.Add(panel1);
            bar.Dock = DockStyle.Left;
            bar.ForeColor = Color.Transparent;
            bar.Location = new Point(0, 0);
            bar.Name = "bar";
            bar.Size = new Size(200, 849);
            bar.TabIndex = 0;
            // 
            // UpdateButton
            // 
            UpdateButton.Dock = DockStyle.Top;
            UpdateButton.FlatAppearance.BorderSize = 0;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateButton.ForeColor = Color.FromArgb(0, 126, 249);
            UpdateButton.Image = Properties.Resources.update_44;
            UpdateButton.ImageAlign = ContentAlignment.MiddleLeft;
            UpdateButton.Location = new Point(0, 451);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(200, 82);
            UpdateButton.TabIndex = 4;
            UpdateButton.Text = "     Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // PriceMonitoringButton
            // 
            PriceMonitoringButton.Dock = DockStyle.Top;
            PriceMonitoringButton.FlatAppearance.BorderSize = 0;
            PriceMonitoringButton.FlatStyle = FlatStyle.Flat;
            PriceMonitoringButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PriceMonitoringButton.ForeColor = Color.FromArgb(0, 126, 249);
            PriceMonitoringButton.Image = Properties.Resources.dollar_coin;
            PriceMonitoringButton.ImageAlign = ContentAlignment.MiddleLeft;
            PriceMonitoringButton.Location = new Point(0, 369);
            PriceMonitoringButton.Name = "PriceMonitoringButton";
            PriceMonitoringButton.Size = new Size(200, 82);
            PriceMonitoringButton.TabIndex = 3;
            PriceMonitoringButton.Text = "     Monitoring";
            PriceMonitoringButton.UseVisualStyleBackColor = true;
            PriceMonitoringButton.Click += PriceMonitoringButton_Click;
            // 
            // SocialMediaButton
            // 
            SocialMediaButton.Dock = DockStyle.Top;
            SocialMediaButton.FlatAppearance.BorderSize = 0;
            SocialMediaButton.FlatStyle = FlatStyle.Flat;
            SocialMediaButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SocialMediaButton.ForeColor = Color.FromArgb(0, 126, 249);
            SocialMediaButton.Image = Properties.Resources.connect;
            SocialMediaButton.ImageAlign = ContentAlignment.MiddleLeft;
            SocialMediaButton.Location = new Point(0, 285);
            SocialMediaButton.Name = "SocialMediaButton";
            SocialMediaButton.Size = new Size(200, 84);
            SocialMediaButton.TabIndex = 2;
            SocialMediaButton.Text = " Media";
            SocialMediaButton.UseVisualStyleBackColor = true;
            SocialMediaButton.Click += SocialMediaButton_Click;
            // 
            // ProductsReviewButton
            // 
            ProductsReviewButton.Dock = DockStyle.Top;
            ProductsReviewButton.FlatAppearance.BorderSize = 0;
            ProductsReviewButton.FlatStyle = FlatStyle.Flat;
            ProductsReviewButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ProductsReviewButton.ForeColor = Color.FromArgb(0, 126, 249);
            ProductsReviewButton.Image = (Image)resources.GetObject("ProductsReviewButton.Image");
            ProductsReviewButton.ImageAlign = ContentAlignment.MiddleLeft;
            ProductsReviewButton.Location = new Point(0, 203);
            ProductsReviewButton.Name = "ProductsReviewButton";
            ProductsReviewButton.Size = new Size(200, 82);
            ProductsReviewButton.TabIndex = 1;
            ProductsReviewButton.Text = "  Review";
            ProductsReviewButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ProductsReviewButton.UseVisualStyleBackColor = true;
            ProductsReviewButton.Click += ProductsReviewButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 203);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_100;
            pictureBox1.Location = new Point(12, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButton.BackColor = Color.Transparent;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.Location = new Point(1299, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(54, 35);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            CloseButton.MouseLeave += CloseButton_MouseLeave;
            CloseButton.MouseHover += CloseButton_MouseHover;
            // 
            // PagePanelView
            // 
            PagePanelView.Dock = DockStyle.Bottom;
            PagePanelView.Location = new Point(200, 203);
            PagePanelView.Name = "PagePanelView";
            PagePanelView.Size = new Size(1150, 646);
            PagePanelView.TabIndex = 2;
            // 
            // SpecifyPageLabel
            // 
            SpecifyPageLabel.AutoSize = true;
            SpecifyPageLabel.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            SpecifyPageLabel.ForeColor = Color.FromArgb(158, 161, 176);
            SpecifyPageLabel.Location = new Point(235, 64);
            SpecifyPageLabel.Name = "SpecifyPageLabel";
            SpecifyPageLabel.Size = new Size(0, 55);
            SpecifyPageLabel.TabIndex = 3;
            // 
            // movePanel
            // 
            movePanel.Location = new Point(200, 3);
            movePanel.Name = "movePanel";
            movePanel.Size = new Size(1093, 40);
            movePanel.TabIndex = 5;
            movePanel.MouseDown += movePanel_MouseDown;
            movePanel.MouseMove += movePanel_MouseMove;
            // 
            // TrackMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1350, 849);
            Controls.Add(SpecifyPageLabel);
            Controls.Add(PagePanelView);
            Controls.Add(CloseButton);
            Controls.Add(bar);
            Controls.Add(movePanel);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "TrackMainPage";
            Text = "TrackMainPage";
            bar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel bar;
        private Button ProductsReviewButton;
        private Panel panel1;
        private Button PriceMonitoringButton;
        private Button SocialMediaButton;
        private Button CloseButton;
        private Panel PagePanelView;
        private Label SpecifyPageLabel;
        private Button UpdateButton;
        private PictureBox pictureBox1;
        private Panel movePanel;
    }
}