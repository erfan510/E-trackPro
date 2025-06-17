using DataHandlingLibrary.PostNamespace;
using DataHandlingLibrary.UserNamespace;
using DataHandlingLibrary.ProductNamespace;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataHandlingLibrary.CommentNamespace;
using System.Security.Cryptography;

namespace DataHandlingLibrary
{
    public class Responses : ResponseHandler
    {

        /// <summary>
        /// This method sends a GET request to the API, deserializes the received data, and returns a collection of type 'Post'
        /// </summary>
        /// <returns>collection of post </returns>
        public async Task<ObservableCollection<Post>> PostResponses() 
        {
            GetEndPoints getEndPoints = new GetEndPoints();

            //Specifies which data to include in the result set
            var selectedPostData = new string[] {
                GetEndPoints.PostSelectData.userId.ToString(),
                GetEndPoints.PostSelectData.body.ToString(),
                GetEndPoints.PostSelectData.title.ToString(),
                GetEndPoints.PostSelectData.tags.ToString(),

            };

            //get a specific url from class getEndPoints 
            string PostEndpoint = getEndPoints.GetPostEndPoint(20, 0, selectedPostData);
            string PostRespons = await SendGetRequestAsync(PostEndpoint);

            return DeserializeJsonData<PostJsonDeserialize>(PostRespons).Posts;

            
        }



        /// <summary>
        /// this sends a GET request to the API to get specifide user, deserializes the received data  
        /// </summary>
        /// <param name="id">User Id</param>
        /// <returns>User</returns>
        public User SerchaUserById(int id)
        {
            GetEndPoints getEndPoints = new GetEndPoints();

            var user = SendGetRequest(getEndPoints.GetSingleUserEndpoint(id)).Result;

            return DeserializeJsonData<User>(user);

        }


        /// <summary>
        /// This method sends a GET request to the API, deserializes the received data, and returns a collection of type 'User'
        /// </summary>
        /// <returns>collection of User </returns>
        public async Task<ObservableCollection<User>> UserResponses() {

            //Specifies which data to include in the result set
            string[] userSelectedData = new string[] {
              GetEndPoints.UserSelectData.id.ToString(),
               GetEndPoints.UserSelectData.firstName.ToString(),
               GetEndPoints.UserSelectData.lastName.ToString(),
               GetEndPoints.UserSelectData.image.ToString(),
               GetEndPoints.UserSelectData.username.ToString(),
               GetEndPoints.UserSelectData.gender.ToString(),
               GetEndPoints.UserSelectData.age.ToString(),

             
            
            };


            GetEndPoints getEndPoints = new GetEndPoints();

            //get a specific url from class getEndPoints 
            string UserEndPoint = getEndPoints.GetUserEndpoint(20, 0, userSelectedData);
            string UserRespons = await SendGetRequestAsync(UserEndPoint);
            ObservableCollection<User> singleuser = DeserializeJsonData<UsersJsonDeserialize>(UserRespons).Users;

            return singleuser;

        }



        /// <summary>
        /// This method sends a GET request to the API, deserializes the received data, and returns a collection of type 'Product'
        /// </summary>
        /// <returns>collection of User </returns>
        public async Task<ObservableCollection<Product>> ProductResponses()
        {


            GetEndPoints getEndPoints = new GetEndPoints();

            string ProductRespons = await SendGetRequestAsync(getEndPoints.GetProductsEdnPoint(20,0));
          
            ObservableCollection<Product> products = DeserializeJsonData<ProductsJsonDeserialize>(ProductRespons).Product;

           
            return products;

        }


        /// <summary>
        /// This method sends a GET request to the API, deserializes the received data, and returns a collection of type 'Comment'
        /// </summary>
        /// <returns>collection of User </returns>
        public ObservableCollection<Comment> CommentResponsesByPostId(int id)
        {
            GetEndPoints getEndPoints = new GetEndPoints();
            

            var respons = SendGetRequest(getEndPoints.GetCommentsByPostId(id)).Result;
            ObservableCollection<Comment> comments = DeserializeJsonData<CommentsJsonDeserialize>(respons).Comments;

            return comments;
        }


        /// <summary>
        /// This method updates the specific user identified by the provided ID.
        /// </summary>
        /// <param name="id">User Id</param>
        /// <param name="newValues">is a collection containing all the new values that will be applied during the update.</param>
        /// <returns> Task<string> </returns>
        public async Task<(bool success, string message)> PatchUserById(int id , List<string> newValues)
        {
            GetEndPoints getEndPoints = new GetEndPoints();
            //Specifies which data to include in the result set
            var selectedData = new List<string>() {
              
                GetEndPoints.UserSelectData.lastName.ToString(),
                GetEndPoints.UserSelectData.firstName.ToString(),
                GetEndPoints.UserSelectData.username.ToString(),
                GetEndPoints.UserSelectData.age.ToString(),
                GetEndPoints.UserSelectData.gender.ToString()

            };
                
            

           string userEndPoint =  getEndPoints.GetSingleUserEndpoint(id);

            var (success, message) = await PatchRequesAsync(userEndPoint, selectedData, newValues);
            return (success, message);


        }

    }
}
