using DataHandlingLibrary;
using DataHandlingLibrary.PostNamespace;
using DataHandlingLibrary.ProductNamespace;
using DataHandlingLibrary.UserNamespace;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_TrackPro
{
    public partial class TrackMainPage : Form
    {


        private CacheProvider _cacheUserData;
        private CacheProvider _cacheProductData;
        private CacheProvider _cachePostData;

        public Point mouseLocation;


        public TrackMainPage()
        {
            InitializeComponent();
            // Request all necessary data upon program startup.
            RequstFromAPiCacheData();
            // To display the page at the center.
            this.StartPosition = FormStartPosition.CenterScreen;


        }


        private async Task RequstFromAPiCacheData()
        {

            try
            {
                Responses response = new Responses();

                var Product = await response.ProductResponses();
                var Post = await response.PostResponses();
                var User = await response.UserResponses();

                _cacheProductData = new CacheProvider("Product", "ProductData", Product );
                _cacheProductData.AddDataToCache();

                _cachePostData = new CacheProvider("Post", "PostData", Post);
                _cachePostData.AddDataToCache();

                _cacheUserData = new CacheProvider("User", "UserData", User);
                _cacheUserData.AddDataToCache();


            }
            catch
            {
                MessageBox.Show("Try again later");
            }


        }

        // Event triggered when the mouse is held down on the panel.
        private void movePanel_MouseDown(object sender, MouseEventArgs e)
        {
            // get mouse x and y position converingt to Point 

            mouseLocation = new Point(e.X, e.Y);
        }

        // Event triggered when mouse Move 
        private void movePanel_MouseMove(object sender, MouseEventArgs e)
        {
            // Check if the Left Mouse Button Click
            if (e.Button == MouseButtons.Left)
            {
                // Calculate the change in X and Y coordinates between the current mouse position and the stored mouse location
                int movePalnex = e.Location.X - mouseLocation.X;
                int movePalney = e.Location.Y - mouseLocation.Y;

                // Update the form's location based on the calculated changes
                this.Location = new Point(this.Location.X + movePalnex, this.Location.Y + movePalney);
            }
        }

        // event Close Button to close the page and  Clear Cache Memory
        private void CloseButton_Click(object sender, EventArgs e)
        {
            // clearing the cache memory 
            _cacheUserData.ClearCacheMemory();
            _cacheProductData.ClearCacheMemory();
            _cachePostData.ClearCacheMemory();
            this.Close();
        }

        // Event handler for the MouseHover event of the CloseButton.
        // Changes the background color of the CloseButton to red.
        private void CloseButton_MouseHover(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.Red;
        }

        // Event handler for the MouseLeave event of the CloseButton.
        // Resets the background color of the CloseButton to the form's background color.
        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.BackColor = this.BackColor;
        }



        private void ProductsReviewButton_Click(object sender, EventArgs e)
        {
            SpecifyPageLabel.Text = "Products Review ";

            // Clearing the controls in the PagePanelView.
            this.PagePanelView.Controls.Clear();

            // Creating an instance of the ProductsReviewPage, which is assumed to be a form or control.
            ProductsReviewPage productsReviewPage = new ProductsReviewPage(_cacheProductData.GetData<ObservableCollection<Product>>())
            {
                // Setting the Dock property to fill the entire available space.
                Dock = DockStyle.Fill,

                // Indicating that this form is not a top-level form.
                TopLevel = false,

                // Setting the form to be the topmost in the Z-order.
                TopMost = true
            };

            // Setting the form's border style to None for a borderless appearance.
            productsReviewPage.FormBorderStyle = FormBorderStyle.None;

            // Adding the ProductsReviewPage control to the PagePanelView.
            this.PagePanelView.Controls.Add(productsReviewPage);

            // Showing the ProductsReviewPage control.
            productsReviewPage.Show();


        }





        private void SocialMediaButton_Click(object sender, EventArgs e)
        {

            SpecifyPageLabel.Text = "Social Media ";
            // Clearing the controls in the PagePanelView.
            this.PagePanelView.Controls.Clear();

            // Creating an instance of the SocialMediaDashboardPage, which is assumed to be a form or control.
            SocialMediaDashboardPage socialMediaPage = new SocialMediaDashboardPage(_cachePostData.GetData<ObservableCollection<Post>>(), _cacheUserData.GetData<ObservableCollection<User>>())
            {
                // Setting the Dock property to fill the entire available space.
                Dock = DockStyle.Fill,

                // Indicating that this form is not a top-level form.
                TopLevel = false,

                // Setting the form to be the topmost in the Z-order.
                TopMost = true
            };

            // Setting the form's border style to None for a borderless appearance.
            socialMediaPage.FormBorderStyle = FormBorderStyle.None;

            // Adding the SocialMediaDashboardPage control to the PagePanelView.
            this.PagePanelView.Controls.Add(socialMediaPage);

            // Showing the SocialMediaDashboardPage control.
            socialMediaPage.Show();

        }




        private void PriceMonitoringButton_Click(object sender, EventArgs e)
        {

            SpecifyPageLabel.Text = "Price Monitoring";

            // Clearing the controls in the PagePanelView.
            this.PagePanelView.Controls.Clear();

            // Creating an instance of the PriceMonitoringPage, which is assumed to be a form or control.
            PriceMonitoringPage priceMonitoringPage = new PriceMonitoringPage()
            {
                // Setting the Dock property to fill the entire available space.
                Dock = DockStyle.Fill,

                // Indicating that this form is not a top-level form.
                TopLevel = false,

                // Setting the form to be the topmost in the Z-order.
                TopMost = true
            };

            // Setting the form's border style to None for a borderless appearance.
            priceMonitoringPage.FormBorderStyle = FormBorderStyle.None;

            // Adding the PriceMonitoringPage control to the PagePanelView.
            this.PagePanelView.Controls.Add(priceMonitoringPage);

            // Showing the PriceMonitoringPage control.
            priceMonitoringPage.Show();
        }









        private void UpdateButton_Click(object sender, EventArgs e)
        {
            SpecifyPageLabel.Text = "Update";

            // Clearing the controls in the PagePanelView.
            this.PagePanelView.Controls.Clear();

            // Creating an instance of the UpdatePage, which is assumed to be a form or control.
            UpdatePage updatePage = new UpdatePage()
            {
                // Setting the Dock property to fill the entire available space.
                Dock = DockStyle.Fill,

                // Indicating that this form is not a top-level form.
                TopLevel = false,

                // Setting the form to be the topmost in the Z-order.
                TopMost = true
            };

            // Setting the form's border style to None for a borderless appearance.
            updatePage.FormBorderStyle = FormBorderStyle.None;

            // Adding the UpdatePage control to the PagePanelView.
            this.PagePanelView.Controls.Add(updatePage);

            // Showing the UpdatePage control.
            updatePage.Show();
        }
    }
}
