using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandlingLibrary.CommentNamespace
{
    /// <summary>
    /// This class facilitates the conversion of JSON data to C# objects
    /// </summary>

    // The CommentsJsonDeserialize class is responsible for deserializing a collection of  JSON data

    public class CommentsJsonDeserialize
    {
        // A collection of comments object
        [JsonProperty("comments")]
        public ObservableCollection<Comment> Comments;


    }
}
