using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DataHandlingLibrary.ProductNamespace
{
    // The ProductsJsonDeserialize class is responsible for deserializing a collection of  JSON data
    public class ProductsJsonDeserialize
    {
        // A collection of Product object
        [JsonProperty("products")]
        public ObservableCollection<Product> Product;



    }
}
