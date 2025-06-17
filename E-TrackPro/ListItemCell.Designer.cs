namespace E_TrackPro
{
    partial class ListItemCell
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            ProductPictureBox = new PictureBox();
            RatingStarLabel = new Label();
            RatingNumberLabel = new Label();
            ProductTitleLabel = new Label();
            ProductBrandLabel = new Label();
            ProductPriceLabel = new Label();
            CommentPictureBox = new PictureBox();
            ListCommentViewePanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)ProductPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CommentPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 51, 51);
            panel1.Dock = DockStyle.Bottom;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 251);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 5);
            panel1.TabIndex = 1;
            // 
            // ProductPictureBox
            // 
            ProductPictureBox.Location = new Point(8, 12);
            ProductPictureBox.Name = "ProductPictureBox";
            ProductPictureBox.Size = new Size(160, 97);
            ProductPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ProductPictureBox.TabIndex = 2;
            ProductPictureBox.TabStop = false;
            ProductPictureBox.Click += ProductPictureBox_Click;
            // 
            // RatingStarLabel
            // 
            RatingStarLabel.AutoSize = true;
            RatingStarLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            RatingStarLabel.ForeColor = Color.FromArgb(255, 255, 128);
            RatingStarLabel.Location = new Point(8, 112);
            RatingStarLabel.Name = "RatingStarLabel";
            RatingStarLabel.Size = new Size(77, 38);
            RatingStarLabel.TabIndex = 3;
            RatingStarLabel.Text = "*****";
            // 
            // RatingNumberLabel
            // 
            RatingNumberLabel.AutoSize = true;
            RatingNumberLabel.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            RatingNumberLabel.ForeColor = SystemColors.ActiveBorder;
            RatingNumberLabel.Location = new Point(91, 116);
            RatingNumberLabel.Name = "RatingNumberLabel";
            RatingNumberLabel.Size = new Size(38, 28);
            RatingNumberLabel.TabIndex = 4;
            RatingNumberLabel.Text = "4.9";
            // 
            // ProductTitleLabel
            // 
            ProductTitleLabel.AutoSize = true;
            ProductTitleLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            ProductTitleLabel.ForeColor = Color.White;
            ProductTitleLabel.Location = new Point(189, 12);
            ProductTitleLabel.Name = "ProductTitleLabel";
            ProductTitleLabel.Size = new Size(132, 38);
            ProductTitleLabel.TabIndex = 5;
            ProductTitleLabel.Text = "iPhone 9";
            // 
            // ProductBrandLabel
            // 
            ProductBrandLabel.AutoSize = true;
            ProductBrandLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ProductBrandLabel.ForeColor = SystemColors.ActiveBorder;
            ProductBrandLabel.Location = new Point(204, 51);
            ProductBrandLabel.Name = "ProductBrandLabel";
            ProductBrandLabel.Size = new Size(75, 31);
            ProductBrandLabel.TabIndex = 6;
            ProductBrandLabel.Text = "Apple";
            // 
            // ProductPriceLabel
            // 
            ProductPriceLabel.AutoSize = true;
            ProductPriceLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            ProductPriceLabel.ForeColor = Color.FromArgb(0, 126, 249);
            ProductPriceLabel.Location = new Point(236, 82);
            ProductPriceLabel.Name = "ProductPriceLabel";
            ProductPriceLabel.Size = new Size(85, 50);
            ProductPriceLabel.TabIndex = 7;
            ProductPriceLabel.Text = "259";
            // 
            // CommentPictureBox
            // 
            CommentPictureBox.Image = Properties.Resources.commentIcon_44;
            CommentPictureBox.Location = new Point(330, 3);
            CommentPictureBox.Name = "CommentPictureBox";
            CommentPictureBox.Size = new Size(38, 34);
            CommentPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            CommentPictureBox.TabIndex = 8;
            CommentPictureBox.TabStop = false;
            CommentPictureBox.Click += CommentPictureBox_Click;
            // 
            // ListCommentViewePanel
            // 
            ListCommentViewePanel.AutoScroll = true;
            ListCommentViewePanel.Dock = DockStyle.Bottom;
            ListCommentViewePanel.Location = new Point(0, 147);
            ListCommentViewePanel.Name = "ListCommentViewePanel";
            ListCommentViewePanel.Size = new Size(368, 104);
            ListCommentViewePanel.TabIndex = 9;
            // 
            // ListItemCell
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 44, 60);
            Controls.Add(ListCommentViewePanel);
            Controls.Add(CommentPictureBox);
            Controls.Add(panel1);
            Controls.Add(ProductPriceLabel);
            Controls.Add(ProductBrandLabel);
            Controls.Add(ProductTitleLabel);
            Controls.Add(RatingNumberLabel);
            Controls.Add(RatingStarLabel);
            Controls.Add(ProductPictureBox);
            Name = "ListItemCell";
            Size = new Size(368, 256);
            Load += ListItemCell_Load;
            ((System.ComponentModel.ISupportInitialize)ProductPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CommentPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private PictureBox ProductPictureBox;
        private Label RatingStarLabel;
        private Label RatingNumberLabel;
        private Label ProductTitleLabel;
        private Label ProductBrandLabel;
        private Label ProductPriceLabel;
        private PictureBox CommentPictureBox;
        private FlowLayoutPanel ListCommentViewePanel;
    }
}
