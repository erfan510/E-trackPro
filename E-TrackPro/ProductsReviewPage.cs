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
using DataHandlingLibrary.ProductNamespace;
using DataHandlingLibrary;


namespace E_TrackPro
{
    public partial class ProductsReviewPage : Form
    {


        
        ObservableCollection<Product> _products;



        public ProductsReviewPage(ObservableCollection<Product> products)
        {
            InitializeComponent();
            _products = products;

        }



        // This event handler is called when the ProductsReviewPage is loaded.
        private void ProductsReviewPage_Load(object sender, EventArgs e)
        {
            // Call the PopUpListItem method to populate the ListItemViewerPanel.
            PopUpListItem();

        }

        // This method is responsible for populating the ListItemViewerPanel with ListItemCell controls.
        private void PopUpListItem()
        {


            foreach (Product product in _products)
            {
                // Iterate through the list of products and add ListItemCell controls to the ListItemViewerPanel.

                // Convert each Product into a ListItemCell and add it to the ListItemViewerPanel.
                ListItemViewerPanel.Controls.Add(ConvertToListItemCell(product));
            }


        }


        // converting Product type to ListItemCell
        // return ListItemCell
        private ListItemCell ConvertToListItemCell(Product product)
        {
            // Creating and returning a new ListItemCell with the specified parameters.
            return new ListItemCell(
                title: product.Title,
                    brand: product.Brand,
                    price: product.Price.ToString(),
                    rating: product.Rating,
                    imageList: product.Images

                );
        }

    }
}
