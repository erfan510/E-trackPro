using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandlingLibrary.UserNamespace
{
    /// <summary>
    /// This class facilitates the conversion of JSON data to C# objects
    /// </summary>
    public class User
    {
        // The unique identifier for the user.
        [JsonProperty("id")]
        public int Id;

        // The first name of the user.
        [JsonProperty("firstName")]
        public string FirstName;

        // The last name of the user.
        [JsonProperty("lastName")]
        public string LastName;

        // The age of the user.
        [JsonProperty("age")]
        public int Age;

        // The gender of the user.
        [JsonProperty("gender")]
        public string Gender;

        // The email address of the user.
        [JsonProperty("email")]
        public string Email;

        // The phone number of the user.
        [JsonProperty("phone")]
        public string Phone;

        // The username of the user.
        [JsonProperty("username")]
        public string Username;

        // The image URL associated with the user.
        [JsonProperty("image")]
        public string Image;
    }
}
