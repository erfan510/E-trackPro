namespace E_TrackPro
{
    partial class ListPostComentCell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListPostComentCell));
            UserPictureBox = new PictureBox();
            NameLabel = new Label();
            UserNameLabel = new Label();
            TagesLabel = new Label();
            BodyTextBox = new TextBox();
            PostTitleTextBox = new TextBox();
            CommentButton = new Button();
            CommentsViewePanel = new FlowLayoutPanel();
            AgeLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)UserPictureBox).BeginInit();
            SuspendLayout();
            // 
            // UserPictureBox
            // 
            UserPictureBox.Location = new Point(3, 3);
            UserPictureBox.Name = "UserPictureBox";
            UserPictureBox.Size = new Size(84, 63);
            UserPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            UserPictureBox.TabIndex = 0;
            UserPictureBox.TabStop = false;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.ForeColor = Color.White;
            NameLabel.Location = new Point(103, 28);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(134, 23);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name Lastname";
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UserNameLabel.ForeColor = Color.White;
            UserNameLabel.Location = new Point(93, 0);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(110, 28);
            UserNameLabel.TabIndex = 3;
            UserNameLabel.Text = "UserName";
            // 
            // TagesLabel
            // 
            TagesLabel.AutoSize = true;
            TagesLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TagesLabel.ForeColor = Color.FromArgb(0, 126, 249);
            TagesLabel.Location = new Point(105, 95);
            TagesLabel.Name = "TagesLabel";
            TagesLabel.Size = new Size(55, 25);
            TagesLabel.TabIndex = 4;
            TagesLabel.Text = "# # #";
            // 
            // BodyTextBox
            // 
            BodyTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BodyTextBox.BackColor = Color.FromArgb(36, 44, 60);
            BodyTextBox.BorderStyle = BorderStyle.None;
            BodyTextBox.ForeColor = Color.White;
            BodyTextBox.Location = new Point(3, 128);
            BodyTextBox.Multiline = true;
            BodyTextBox.Name = "BodyTextBox";
            BodyTextBox.ReadOnly = true;
            BodyTextBox.ScrollBars = ScrollBars.Vertical;
            BodyTextBox.Size = new Size(362, 176);
            BodyTextBox.TabIndex = 5;
            BodyTextBox.Text = resources.GetString("BodyTextBox.Text");
            // 
            // PostTitleTextBox
            // 
            PostTitleTextBox.BackColor = Color.FromArgb(36, 44, 60);
            PostTitleTextBox.BorderStyle = BorderStyle.None;
            PostTitleTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            PostTitleTextBox.ForeColor = Color.White;
            PostTitleTextBox.Location = new Point(12, 69);
            PostTitleTextBox.Multiline = true;
            PostTitleTextBox.Name = "PostTitleTextBox";
            PostTitleTextBox.Size = new Size(300, 45);
            PostTitleTextBox.TabIndex = 8;
            PostTitleTextBox.Text = "Hopes and dreams were dashed that day.";
            // 
            // CommentButton
            // 
            CommentButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CommentButton.FlatAppearance.BorderSize = 0;
            CommentButton.FlatStyle = FlatStyle.Flat;
            CommentButton.Image = Properties.Resources.commentIcon_44;
            CommentButton.ImageAlign = ContentAlignment.MiddleLeft;
            CommentButton.Location = new Point(284, 3);
            CommentButton.Name = "CommentButton";
            CommentButton.Size = new Size(54, 37);
            CommentButton.TabIndex = 10;
            CommentButton.UseVisualStyleBackColor = true;
            CommentButton.Click += CommentButton_Click;
            // 
            // CommentsViewePanel
            // 
            CommentsViewePanel.AutoScroll = true;
            CommentsViewePanel.Location = new Point(0, 310);
            CommentsViewePanel.Name = "CommentsViewePanel";
            CommentsViewePanel.Size = new Size(344, 141);
            CommentsViewePanel.TabIndex = 11;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AgeLabel.ForeColor = Color.White;
            AgeLabel.Location = new Point(234, 28);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(28, 23);
            AgeLabel.TabIndex = 14;
            AgeLabel.Text = "55";
            // 
            // ListPostComentCell
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 44, 60);
            Controls.Add(AgeLabel);
            Controls.Add(CommentsViewePanel);
            Controls.Add(CommentButton);
            Controls.Add(TagesLabel);
            Controls.Add(PostTitleTextBox);
            Controls.Add(BodyTextBox);
            Controls.Add(UserNameLabel);
            Controls.Add(NameLabel);
            Controls.Add(UserPictureBox);
            Name = "ListPostComentCell";
            Size = new Size(344, 451);
            Load += ListPostComentCell_Load;
            ((System.ComponentModel.ISupportInitialize)UserPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox UserPictureBox;
        private Label NameLabel;
        private Label UserNameLabel;
        private Label TagesLabel;
        private TextBox BodyTextBox;
        private TextBox PostTitleTextBox;
        private Button CommentButton;
        private FlowLayoutPanel CommentsViewePanel;
        private Label AgeLabel;
    }
}
