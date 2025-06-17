using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_TrackPro
{
    /// <summary>
    /// This page is designed for users to input their ID and comments for different products.
    /// </summary>
    public partial class AddCommentPage : Form
    {

        public AddCommentPage()
        {
            InitializeComponent();
        }

        // close this page  
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        /// <summary>
        /// Represents a delegate for handling comment-related events.
        /// </summary>
        /// <param name="source">The source of the event.</param>
        /// <param name="id">The ID associated with the comment.</param>
        /// <param name="comment">The comment text provided by the user.</param>
        public delegate void CommentEventHandeler(object source, string id, string comment);


        /// <summary>
        /// Event triggered when a comment is submitted.
        /// </summary
        public event CommentEventHandeler CommetEvent;


        /// <summary>
        /// Raises the CommentEvent by notifying subscribers with the provided ID and comment.
        /// </summary>
        /// <param name="id">The ID associated with the comment.</param>
        /// <param name="comment">The comment text provided by the user.</param>
        protected virtual void OnCommetEvent(string id, string comment)
        {
            // Check if there are subscribers before triggering the event
            if (CommetEvent != null)
            {
                
                CommetEvent(this, id, comment);
            }

        }



        /// <summary>
        /// Handles the click event of the SubmitButton.
        /// Submits a comment if both the ID and comment text are provided; otherwise, displays an error message.
        /// </summary>
        
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdTextBox.Text) || string.IsNullOrEmpty(CommentTextBox.Text))
            {
                MessageBox.Show("Invalid value");
            }
            else
            {
                // Trigger the CommentEvent with the provided ID and comment
                OnCommetEvent(IdTextBox.Text, CommentTextBox.Text);
                // Close the form after submitting the comment
                this.Close();
            }

        }
    }
}
