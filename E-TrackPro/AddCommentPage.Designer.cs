namespace E_TrackPro
{
    partial class AddCommentPage
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
            CloseButton = new Button();
            IdTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            CommentTextBox = new TextBox();
            SubmitButton = new Button();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButton.BackColor = Color.Transparent;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(344, 2);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(54, 35);
            CloseButton.TabIndex = 2;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // IdTextBox
            // 
            IdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IdTextBox.BackColor = Color.FromArgb(74, 82, 96);
            IdTextBox.BorderStyle = BorderStyle.None;
            IdTextBox.ForeColor = Color.White;
            IdTextBox.Location = new Point(70, 95);
            IdTextBox.MaxLength = 10;
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(244, 20);
            IdTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(70, 61);
            label1.Name = "label1";
            label1.Size = new Size(34, 31);
            label1.TabIndex = 4;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(70, 140);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 6;
            label2.Text = "Comment";
            // 
            // CommentTextBox
            // 
            CommentTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CommentTextBox.BackColor = Color.FromArgb(74, 82, 96);
            CommentTextBox.BorderStyle = BorderStyle.None;
            CommentTextBox.ForeColor = Color.White;
            CommentTextBox.Location = new Point(70, 174);
            CommentTextBox.MaxLength = 50;
            CommentTextBox.Name = "CommentTextBox";
            CommentTextBox.Size = new Size(244, 20);
            CommentTextBox.TabIndex = 5;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.FromArgb(117, 123, 132);
            SubmitButton.FlatAppearance.BorderSize = 0;
            SubmitButton.FlatStyle = FlatStyle.Flat;
            SubmitButton.ForeColor = Color.WhiteSmoke;
            SubmitButton.Location = new Point(220, 225);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(94, 29);
            SubmitButton.TabIndex = 7;
            SubmitButton.Text = "Ok";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // AddCommentPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 44, 60);
            ClientSize = new Size(398, 281);
            Controls.Add(SubmitButton);
            Controls.Add(label2);
            Controls.Add(CommentTextBox);
            Controls.Add(label1);
            Controls.Add(IdTextBox);
            Controls.Add(CloseButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddCommentPage";
            Text = "AddCommentPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CloseButton;
        private TextBox IdTextBox;
        private Label label1;
        private Label label2;
        private TextBox CommentTextBox;
        private Button SubmitButton;
    }
}