using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandlingLibrary.CommentNamespace
{
    // The Comment class represents a comment entity with the following properties
    public class Comment
    {
        // The unique identifier for the comment
        [JsonProperty("id")]
        public int Id;

        // The text content of the comment
        [JsonProperty("body")]
        public string Body;

        // The identifier of the post to which the comment belongs
        [JsonProperty("postId")]
        public int PostId;

        // The user associated with the comment, represented by the CommentsUsers class
        // CommentsUsers is class type
        [JsonProperty("user")]
        public CommentsUsers User;
    }

}
