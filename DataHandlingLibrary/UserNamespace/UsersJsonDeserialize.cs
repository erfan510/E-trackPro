using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandlingLibrary.UserNamespace
{
    // The UsersJsonDeserialize class is responsible for deserializing a collection of  JSON data
    public class UsersJsonDeserialize
    {
        // A collection of User object
        [JsonProperty("users")]
        public ObservableCollection<User> Users;

        

    }
}
