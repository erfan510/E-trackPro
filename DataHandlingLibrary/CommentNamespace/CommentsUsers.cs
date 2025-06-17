using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandlingLibrary.CommentNamespace
{
    // The CommentsUsers class represents a comment entity with the following properties
    public class CommentsUsers
    {
        // The identifier of the Comments to which the id belongs
        [JsonProperty("id")]
        public int Id;

        // The identifier of the Comments to which the UserName belongs
        [JsonProperty("username")]
        public string Username;
    }
}
