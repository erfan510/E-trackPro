namespace E_TrackPro
{
    partial class SocialMediaDashboardPage
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
            ListPostViewePanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // ListPostViewePanel
            // 
            ListPostViewePanel.AutoScroll = true;
            ListPostViewePanel.Dock = DockStyle.Top;
            ListPostViewePanel.Location = new Point(0, 0);
            ListPostViewePanel.Name = "ListPostViewePanel";
            ListPostViewePanel.Size = new Size(1152, 643);
            ListPostViewePanel.TabIndex = 0;
            // 
            // SocialMediaDashboardPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1152, 646);
            Controls.Add(ListPostViewePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SocialMediaDashboardPage";
            Text = "SocialMediaDashboardPage";
            Load += SocialMediaDashboardPage_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel ListPostViewePanel;
    }
}