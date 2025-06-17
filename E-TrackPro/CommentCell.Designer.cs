namespace E_TrackPro
{
    partial class CommentCell
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
            UserPictureBox = new PictureBox();
            UserNameLabel = new Label();
            BodyTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)UserPictureBox).BeginInit();
            SuspendLayout();
            // 
            // UserPictureBox
            // 
            UserPictureBox.Location = new Point(3, 3);
            UserPictureBox.Name = "UserPictureBox";
            UserPictureBox.Size = new Size(48, 47);
            UserPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            UserPictureBox.TabIndex = 0;
            UserPictureBox.TabStop = false;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            UserNameLabel.ForeColor = Color.White;
            UserNameLabel.Location = new Point(65, 3);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(63, 25);
            UserNameLabel.TabIndex = 1;
            UserNameLabel.Text = "label1";
            // 
            // BodyTextBox
            // 
            BodyTextBox.BackColor = Color.FromArgb(31, 37, 51);
            BodyTextBox.BorderStyle = BorderStyle.None;
            BodyTextBox.ForeColor = Color.White;
            BodyTextBox.Location = new Point(57, 31);
            BodyTextBox.Multiline = true;
            BodyTextBox.Name = "BodyTextBox";
            BodyTextBox.ReadOnly = true;
            BodyTextBox.Size = new Size(269, 48);
            BodyTextBox.TabIndex = 2;
            BodyTextBox.Text = "I cannot believe how I found you, this is so pretty.";
            // 
            // CommentCell
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 37, 51);
            Controls.Add(BodyTextBox);
            Controls.Add(UserNameLabel);
            Controls.Add(UserPictureBox);
            Name = "CommentCell";
            Size = new Size(329, 77);
            Load += CommentCell_Load;
            ((System.ComponentModel.ISupportInitialize)UserPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox UserPictureBox;
        private Label UserNameLabel;
        private TextBox BodyTextBox;
    }
}
