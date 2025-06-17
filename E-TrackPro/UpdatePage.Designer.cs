namespace E_TrackPro
{
    partial class UpdatePage
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
            UserPanelViewer = new Panel();
            IdTextBox = new TextBox();
            SuspendLayout();
            // 
            // UserPanelViewer
            // 
            UserPanelViewer.Location = new Point(41, 72);
            UserPanelViewer.Name = "UserPanelViewer";
            UserPanelViewer.Size = new Size(364, 460);
            UserPanelViewer.TabIndex = 0;
            // 
            // IdTextBox
            // 
            IdTextBox.BackColor = Color.FromArgb(74, 82, 96);
            IdTextBox.BorderStyle = BorderStyle.None;
            IdTextBox.ForeColor = Color.Silver;
            IdTextBox.Location = new Point(41, 39);
            IdTextBox.MaxLength = 3;
            IdTextBox.Name = "IdTextBox";
            IdTextBox.PlaceholderText = "search id number";
            IdTextBox.Size = new Size(364, 20);
            IdTextBox.TabIndex = 1;
            IdTextBox.TextChanged += IdTextBox_TextChanged;
            // 
            // UpdatePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1132, 599);
            Controls.Add(IdTextBox);
            Controls.Add(UserPanelViewer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdatePage";
            Text = "UpdatePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel UserPanelViewer;
        private TextBox IdTextBox;
    }
}