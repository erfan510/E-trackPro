using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandlingLibrary.PostNamespace
{
    // The PostJsonDeserialize class is responsible for deserializing a collection of  JSON data
    public class PostJsonDeserialize
    {
        // A collection of Post object
        [JsonProperty("posts")]
        public ObservableCollection<Post>? Posts;

    }
}
