namespace E_TrackPro
{
    partial class ListUserCell
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
            panel1 = new Panel();
            AgeLabel = new TextBox();
            GenderLabel = new TextBox();
            SaveButton = new Button();
            label3 = new Label();
            label2 = new Label();
            UserNameLabel = new TextBox();
            FirstNameLabel = new TextBox();
            LastNameLable = new TextBox();
            ((System.ComponentModel.ISupportInitialize)UserPictureBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // UserPictureBox
            // 
            UserPictureBox.Location = new Point(95, 16);
            UserPictureBox.Name = "UserPictureBox";
            UserPictureBox.Size = new Size(168, 124);
            UserPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            UserPictureBox.TabIndex = 0;
            UserPictureBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 37, 51);
            panel1.Controls.Add(AgeLabel);
            panel1.Controls.Add(GenderLabel);
            panel1.Controls.Add(SaveButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 241);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 126);
            panel1.TabIndex = 1;
            // 
            // AgeLabel
            // 
            AgeLabel.BackColor = Color.FromArgb(31, 37, 51);
            AgeLabel.BorderStyle = BorderStyle.None;
            AgeLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            AgeLabel.ForeColor = Color.LightGray;
            AgeLabel.Location = new Point(49, 44);
            AgeLabel.MaxLength = 20;
            AgeLabel.Multiline = true;
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(71, 45);
            AgeLabel.TabIndex = 9;
            AgeLabel.Text = "55";
            // 
            // GenderLabel
            // 
            GenderLabel.BackColor = Color.FromArgb(31, 37, 51);
            GenderLabel.BorderStyle = BorderStyle.None;
            GenderLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            GenderLabel.ForeColor = Color.LightGray;
            GenderLabel.Location = new Point(256, 44);
            GenderLabel.MaxLength = 20;
            GenderLabel.Multiline = true;
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(71, 45);
            GenderLabel.TabIndex = 4;
            GenderLabel.Text = "Male";
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.FromArgb(117, 123, 132);
            SaveButton.Dock = DockStyle.Bottom;
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.ForeColor = Color.WhiteSmoke;
            SaveButton.Location = new Point(0, 97);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(364, 29);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Save Changes";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 126, 249);
            label3.Location = new Point(232, 8);
            label3.Name = "label3";
            label3.Size = new Size(114, 36);
            label3.TabIndex = 1;
            label3.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 126, 249);
            label2.Location = new Point(49, 8);
            label2.Name = "label2";
            label2.Size = new Size(69, 36);
            label2.TabIndex = 0;
            label2.Text = "Age";
            // 
            // UserNameLabel
            // 
            UserNameLabel.BackColor = Color.FromArgb(36, 44, 60);
            UserNameLabel.BorderStyle = BorderStyle.None;
            UserNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            UserNameLabel.ForeColor = Color.White;
            UserNameLabel.Location = new Point(95, 146);
            UserNameLabel.MaxLength = 20;
            UserNameLabel.Multiline = true;
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(176, 45);
            UserNameLabel.TabIndex = 10;
            UserNameLabel.Text = "UserName";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.BackColor = Color.FromArgb(36, 44, 60);
            FirstNameLabel.BorderStyle = BorderStyle.None;
            FirstNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameLabel.ForeColor = Color.White;
            FirstNameLabel.Location = new Point(16, 190);
            FirstNameLabel.MaxLength = 20;
            FirstNameLabel.Multiline = true;
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(176, 45);
            FirstNameLabel.TabIndex = 11;
            FirstNameLabel.Text = "FirstName";
            // 
            // LastNameLable
            // 
            LastNameLable.BackColor = Color.FromArgb(36, 44, 60);
            LastNameLable.BorderStyle = BorderStyle.None;
            LastNameLable.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameLable.ForeColor = Color.White;
            LastNameLable.Location = new Point(185, 190);
            LastNameLable.MaxLength = 20;
            LastNameLable.Multiline = true;
            LastNameLable.Name = "LastNameLable";
            LastNameLable.Size = new Size(176, 45);
            LastNameLable.TabIndex = 12;
            LastNameLable.Text = "LastName";
            // 
            // ListUserCell
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 44, 60);
            Controls.Add(LastNameLable);
            Controls.Add(FirstNameLabel);
            Controls.Add(UserNameLabel);
            Controls.Add(panel1);
            Controls.Add(UserPictureBox);
            Name = "ListUserCell";
            Size = new Size(364, 367);
            Load += ListUserCell_Load;
            ((System.ComponentModel.ISupportInitialize)UserPictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox UserPictureBox;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Button SaveButton;
        private TextBox GenderLabel;
        private TextBox AgeLabel;
        private TextBox UserNameLabel;
        private TextBox FirstNameLabel;
        private TextBox LastNameLable;
    }
}
