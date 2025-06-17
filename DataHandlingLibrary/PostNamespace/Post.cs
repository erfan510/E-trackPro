using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandlingLibrary.PostNamespace
{
    // Post class for represents with the following properties
    // For deserializing Post JSON data
    public class Post
    {
        // The unique identifier for the Post
        [JsonProperty("id")]
        public int Id;

        // The title of post 
        [JsonProperty("title")]
        public string? Title;

        // The text content of the Post
        [JsonProperty("body")]
        public string? Body;

        // The identifier of the post to which the UserId belongs
        [JsonProperty("userId")]
        public int UserId;

        // Represents a collection of tags associated with a Post
        [JsonProperty("tags")]
        public List<string>? Tags;

    }
}
