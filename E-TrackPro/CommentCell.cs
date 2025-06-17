using DataHandlingLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataHandlingLibrary.UserNamespace;

namespace E_TrackPro
{
    public partial class CommentCell : UserControl
    {

        private string _userName { get; set; }
        private string _body { get; set; }
        private int _userId { get; set; }


        /// <summary>
        /// Gets or sets the user name associated with the data.
        /// When set, updates the corresponding label on the user interface.
        /// </summary>
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; UserNameLabel.Text = value; }
        }

        /// <summary>
        /// Gets or sets the body text associated with the data.
        /// When set, updates the corresponding TextBox on the user interface.
        /// </summary>
        public string Body
        {
            get { return _body; }
            set { _body = value; BodyTextBox.Text = value; }
        }




        // constracter of comment cell class 
        public CommentCell(int userId, string userName, string body)
        {

            InitializeComponent();
            _userId = userId;
            UserName = userName;
            Body = body;
        }


        // constracter of comment cell class 
        public CommentCell(string userName, string body)
        {

            InitializeComponent();
            UserName = userName;
            Body = body;
        }


        // This event will be triggered when the page loads
        private void CommentCell_Load(object sender, EventArgs e)
        {
            // Create an instance of the response handler for sending a GET request 
            ResponseHandler responseHandler = new ResponseHandler();
            GetEndPoints getEndPoints = new GetEndPoints();


            var ueserSelectedData = new string[] {
                GetEndPoints.UserSelectData.image.ToString()

            };

            // using the user ID.
            string CommentsEndpoins = getEndPoints.GetSingleUserEndpoint(_userId, ueserSelectedData);
            string respons = responseHandler.SendGetRequest(CommentsEndpoins).Result;

            //Deserialize the JSON response and assign the image response to the PictureBox
            UserPictureBox.ImageLocation = responseHandler.DeserializeJsonData<User>(respons).Image;
        }
    }
}
