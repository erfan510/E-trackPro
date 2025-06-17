using DataHandlingLibrary;
using DataHandlingLibrary.ProductNamespace;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
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

namespace E_TrackPro
{
    public partial class PriceMonitoringPage : Form
    {


        ResponseHandler handler = new ResponseHandler();
        GetEndPoints getEndPoints = new GetEndPoints();

        // creating a chart value of type float to be assigned later
        ChartValues<float> chartValuesPrice = new ChartValues<float>();
        ChartValues<float> chartValuesStock = new ChartValues<float>();

        ObservableCollection<Product> products;

        public PriceMonitoringPage()
        {
            InitializeComponent();
            // set the default value of the category of the Combo box 
            CategoriesComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Event handler for the SelectedIndexChanged event of the CategoriesComboBox.
        /// Sends a GET request to retrieve products based on the selected category and updates the charts.
        /// </summary>
        private async void CategoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Send a GET request to retrieve products based on the selected category
            string respons = await handler.SendGetRequest(getEndPoints.GetProductsByCategoryEdnPoint(CategoriesComboBox.Text));

            // Deserialize the JSON response and update the 'products' collection
            products = handler.DeserializeJsonData<ProductsJsonDeserialize>(respons).Product;

            // Update the charts with the new data
            Chart();

        }


        /// <summary>
        /// Clears and updates the CartesianCharts (cartesianChartStock and cartesianChartPrice) with product data.
        /// </summary>
        private void Chart()
        {
            // Clear existing series and axes
            cartesianChartStock.Series.Clear();
            cartesianChartStock.AxisX.Clear();
            cartesianChartStock.AxisY.Clear();

            cartesianChartPrice.Series.Clear();
            cartesianChartPrice.AxisX.Clear();
            cartesianChartPrice.AxisY.Clear();

            // Create LineSeries for Price and Stock
            LineSeries PriceSeries = new LineSeries()
            {
                Title = "Price",
                Values = chartValuesPrice

            };

            LineSeries StockSeries = new LineSeries()
            {
                Title = "Stock",
                Values = chartValuesStock

            };


            // Add data points to the chart
            foreach (Product product in products)
            {
                chartValuesPrice.Add(product.Price);
                chartValuesStock.Add(product.Stock);
            }

            // Add series to CartesianCharts
            cartesianChartStock.Series.Add(StockSeries);
            cartesianChartPrice.Series.Add(PriceSeries);

            // Configure X-axis for both charts
            cartesianChartPrice.AxisX.Add(new Axis
            {
                Title = "Time",

                LabelFormatter = value =>
                {
                    int index = (int)value;

                    if (index == StockSeries.Values.Count - 1)
                    {
                        // Special label for the last data point
                        return DateTime.Now.ToString("MM/yyyy");
                    }

                    // Default label formatting for other points
                    return value.ToString();
                },

                ShowLabels = true,
                Separator = new Separator { IsEnabled = false },



            });
            cartesianChartStock.AxisX.Add(new Axis
            {
                Title = "Time",

                LabelFormatter = value =>
                {
                    int index = (int)value;

                    if (index == StockSeries.Values.Count - 1)
                    {
                        // Special label for the last data point
                        return DateTime.Now.ToString("MM/yyyy");
                    }

                    // Default label formatting for other points
                    return value.ToString();
                },

                ShowLabels = true,
                Separator = new Separator { IsEnabled = false },



            });

            // Configure Y-axis for both charts
            cartesianChartStock.AxisY.Add(new Axis
            {
                Title = "Stock",
                LabelFormatter = Value => $"${Value}",
                Separator = new Separator { IsEnabled = false, }


            });
            cartesianChartPrice.AxisY.Add(new Axis
            {
                Title = "Price",
                LabelFormatter = Value => $"${Value}",
                Separator = new Separator { IsEnabled = false, }


            });
        }


    }
}
