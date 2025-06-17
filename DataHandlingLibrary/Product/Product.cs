using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandlingLibrary.ProductNamespace
{
    /// <summary>
    /// This class facilitates the conversion of JSON data to C# objects
    /// </summary>
    public class Product
    {
        // The unique identifier for the product.
        [JsonProperty("id")]
        public int Id;

        // The title of the product.
        [JsonProperty("title")]
        public string Title;

        // The description of the product.
        [JsonProperty("description")]
        public string Description;

        // The price of the product.
        [JsonProperty("price")]
        public float Price;

        // The discount percentage applied to the product.
        [JsonProperty("discountPercentage")]
        public double DiscountPercentage;

        // The rating of the product.
        [JsonProperty("rating")]
        public double Rating;

        // The available stock of the product.
        [JsonProperty("stock")]
        public float Stock;

        // The brand of the product.
        [JsonProperty("brand")]
        public string Brand;

        // The category to which the product belongs.
        [JsonProperty("category")]
        public string Category;

        // The thumbnail image URL of the product.
        [JsonProperty("thumbnail")]
        public string Thumbnail;

        // A list of image URLs associated with the product.
        [JsonProperty("images")]
        public List<string> Images;
    }
}
