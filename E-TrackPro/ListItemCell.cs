using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace E_TrackPro
{
    public partial class ListItemCell : UserControl
    {

        // Fields to control substring length, rating character, and image list counter.
        private int startLength = 0;
        private int endLength = 8;
        private string ratingCharacter = "*";
        private int imageListCounter = 0;

        // Private properties to store data internally.
        private string _titel { get; set; }
        private string _brand { get; set; }
        private string _price { get; set; }
        private double _rating { get; set; }
        private List<string> _imageList { get; set; }
        private List<Tuple<string, string>> _commentList = new List<Tuple<string, string>>();



        // Public properties with additional logic for external access and UI updates.

        // Property for the title with logic to update the UI.
        public string Title
        {
            get { return _titel; }
            set
            {
                _titel = value;
                // only specified length can be printed 
                ProductTitleLabel.Text = value.Substring(startLength, Math.Min(value.Length, endLength));
            }
        }

        // Property for the brand with logic to update the UI.
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; ProductBrandLabel.Text = value; }
        }

        // Property for the price with logic to update the UI.
        public string Price
        {
            get { return _price; }
            set { _price = value; ProductPriceLabel.Text = $"{value}$"; }
        }

        // Property for the rating with logic to update the UI.
        public double Rating
        {
            get { return _rating; }
            set
            {
                _rating = value;
                RatingNumberLabel.Text = value.ToString();
                RatingStarLabel.Text = WordRepetition(value, ratingCharacter);
            }
        }

        // Property for the image list.
        public List<string> ImageList
        {
            get { return _imageList; }
            set { _imageList = value; }
        }

        // Constructor to initialize the control with data.
        public ListItemCell(string title, string brand, string price, double rating, List<string> imageList)
        {
            InitializeComponent();
            Title = title;
            Brand = brand;
            Price = price;
            Rating = rating;
            ImageList = imageList;
        }

        // Event handler for the click event on the ProductPictureBox.
        private void ProductPictureBox_Click(object sender, EventArgs e)
        {
            // Cycle through images in the image list.
            if (imageListCounter++ >= _imageList.Count - 1) imageListCounter = 0;
            ProductPictureBox.ImageLocation = _imageList[imageListCounter];
        }

        // Event handler for the load event of the ListItemCell.
        private void ListItemCell_Load(object sender, EventArgs e)
        {
            // Set the initial image from the image list.
            ProductPictureBox.ImageLocation = _imageList[imageListCounter];
            ShowComment();


        }

        // Helper method to repeat a word (used for the rating stars).
        private string WordRepetition(double repetition, string word)
        {
            string EmptyString = string.Empty;

            for (int i = 0; i < repetition; i++)
            {
                EmptyString += word;
            }
            return EmptyString;
        }


        /// <summary>
        /// Handles the click event of the CommentPictureBox.
        /// Opens the AddCommentPage for users to add comments.
        /// </summary>
        
        private void CommentPictureBox_Click(object sender, EventArgs e)
        {
            // Create an instance of AddCommentPage and set its starting position
            AddCommentPage addCommentPage = new AddCommentPage();
            addCommentPage.StartPosition = FormStartPosition.CenterScreen;

            // Subscribe to the CommentEvent of AddCommentPage
            addCommentPage.CommetEvent += AddComment;
            // Show the AddCommentPage as a dialog
            addCommentPage.ShowDialog();
        }



        /// <summary>
        /// Event handler for the CommentEvent triggered by the AddCommentPage.
        /// Adds a new comment (ID, comment) to the comment list and displays the comments.
        /// </summary>
        /// <param name="source">The source of the event.</param>
        /// <param name="id">The ID associated with the comment.</param>
        /// <param name="comment">The comment text provided by the user.</param>
        private void AddComment(object source, string id, string comment)
        {
            // Add the new comment to the comment list
            _commentList.Add(Tuple.Create(id, comment));
            // Display the updated comments
            ShowComment();


        }



        /// <summary>
        /// Displays comments in the ListCommentViewePanel.
        /// </summary>
        private void ShowComment()
        {
            if (_commentList.Count >= 0)
            {
                foreach (Tuple<string, string> item in _commentList)
                {
                    // Add a new CommentCell to the ListCommentViewePanel for each comment
                    ListCommentViewePanel.Controls.Add(new CommentCell(item.Item1, item.Item2));
                }

            }
        }



    }
}
