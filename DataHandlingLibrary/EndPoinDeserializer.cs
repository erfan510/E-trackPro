using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandlingLibrary
{
    // The EndPointJsonDeserialize class represents a comment entity with the following properties
    //The purpose of this class is to deserialize an 'AllEndPoints.json' file, enabling access to various endpoints 
    public class EndPointJsonDeserialize
    {
        // The EndPoint of all users  
        [JsonProperty("UsersEndPoint")]
        public string UsersEndPoint { get; set; }

        // The EndPoint of all Posts  
        [JsonProperty("PostsEndPoint")]
        public string PostsEndPoint { get; set; }

        // The EndPoint of all Comments  
        [JsonProperty("CommentsEndPoint")]
        public string CommentsEndPoint { get; set; }

        // The EndPoint of all Products  
        [JsonProperty("ProductsEndPoint")]
        public string ProductsEndPoint { get; set; }
    }

}
