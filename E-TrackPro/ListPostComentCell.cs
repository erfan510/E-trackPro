using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataHandlingLibrary;
using DataHandlingLibrary.CommentNamespace;
using DataHandlingLibrary.UserNamespace;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace E_TrackPro
{
    public partial class ListPostComentCell : UserControl
    {
        // Private properties to store data internally.
        private int _id { get; set; }
        private int _age { get; set; }

        private string _title { get; set; }
        private string _body { get; set; }
        private int _userId { get; set; }
        private string _userName { get; set; }
        private string _userPicture { get; set; }
        private List<string> _tags { get; set; }

        // Public properties with additional logic for external access and UI updates.
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; AgeLabel.Text = value.ToString(); }
        }

        public string UserPicture
        {
            get { return _userPicture; }
            set { _userPicture = value; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; UserNameLabel.Text = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; PostTitleTextBox.Text = value; }
        }

        public string Body
        {
            get { return _body; }
            set { _body = value; BodyTextBox.Text = value; }
        }

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public List<string> Tags
        {
            get { return _tags; }
            set { _tags = value; TagesLabel.Text = string.Join(", ", value); }
        }



        public ListPostComentCell(int id, string userPicture, string userName, string title, string body, int userId, List<string> tags, int age)
        {
            InitializeComponent();
            Id = id;
            Title = title;
            Body = body;
            UserId = userId;
            Tags = tags;
            UserPicture = userPicture;
            UserName = userName;
            Age = age;
        }


        // Event handler for the load event on the ListPostComentCell.
        private void ListPostComentCell_Load(object sender, EventArgs e)
        {
            // set user Image to the UserPictureBox
            UserPictureBox.ImageLocation = _userPicture;

        }

        // Event handler for the Comment Button when gets clicked
        private void CommentButton_Click(object sender, EventArgs e)
        {
            Responses responses = new Responses();

            //finding the comments that belong to the post
            var comments = responses.CommentResponsesByPostId(_id);

            // Iterate through the comment list, create an instance of the CommentCell for each comment, and display it on the CommentsViewePanel.
            foreach (var comment in comments)
            {
                CommentCell commentCell = new CommentCell(
                    userId: comment.User.Id,
                    userName: comment.User.Username,
                    body: comment.Body

                    );
                CommentsViewePanel.Controls.Add(commentCell);
            }
        }


    }
}
