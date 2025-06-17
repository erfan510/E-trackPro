using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataHandlingLibrary
{
    public class GetEndPoints
    {
        /// <summary>
        /// Enumeration representing selectable data fields for user entities.
        /// </summary>
        public enum UserSelectData
        {
            firstName, lastName, age, username, image , gender, email, birthDate , phone,
            id
        }

        /// <summary>
        /// Enumeration representing selectable data fields for post entities.
        /// </summary>
        public enum PostSelectData
        {
            title , body , tags , userId
        }

        /// <summary>
        /// Enumeration representing selectable data fields for product entities.
        /// </summary>
        public enum ProductSelectData
        {
            price,
            title,
            description,
            stock,
            brand,
            category


        }


        /// <summary>
        /// Reads endpoint configurations from the 'AllEndPoints.json' file.
        /// </summary>
        /// <returns>An instance of the EndPointJsonDeserialize class containing endpoint configurations.</returns>

        private static EndPointJsonDeserialize ReadFromJsonFile()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
           

            StreamReader reader = new StreamReader(assembly.GetManifestResourceStream("DataHandlingLibrary.AllEndPoints.json"));

            return JsonConvert.DeserializeObject<EndPointJsonDeserialize>(reader.ReadToEnd());

        }



        /// <summary>
        /// Gets the endpoint URL for retrieving all users.
        /// </summary>
        public static string GetUserEndpoin()
        {
           string Endpoint =  ReadFromJsonFile().UsersEndPoint;

            return $"{Endpoint}";

        }


        /// <summary>
        /// Gets the endpoint URL for retrieving user.
        /// </summary>
        /// <param name="limit">Sets the maximum number of items to retrieve or process.</param>
        /// <param name="skip">Determines the starting point by skipping a specified number of items.</param>
        /// <returns>a string url </returns>
        public string GetUserEndpoint(int limit , int skip)
        {
            string Endpoint = ReadFromJsonFile().UsersEndPoint;

            return $"{Endpoint}?limit={limit}&skip={skip}";

        }




        /// <summary>
        /// Gets the endpoint URL for retrieving all users with optional query parameters.
        /// </summary>
        /// <param name="limit">Sets the maximum number of items to retrieve or process.</param>
        /// <param name="skip">Determines the starting point by skipping a specified number of items.</param>
        /// <param name="selectData">Specifies which data attributes to include in the result set.</param>
        /// <returns>a string url </returns>
        public string GetUserEndpoint(int limit, int skip, string[] selectData )
        {
            string Endpoint = ReadFromJsonFile().UsersEndPoint;
           
            
             return $"{Endpoint}?limit={limit}&skip={skip}&select={ string.Join(",", selectData) }";

        }



        /// <summary>
        /// Gets the endpoint URL for retrieving user using id 
        /// </summary>
        /// <param name="id">The id of user</param>
        /// <returns>string url </returns>
        public string GetSingleUserEndpoint(int id)
        {
            string EndPoint = ReadFromJsonFile().UsersEndPoint;


            return $"{EndPoint}/{id}";

        }

        /// <summary>
        /// Gets the endpoint URL for retrieving user using id 
        /// Specifies which data attributes to include in the result set.
        /// </summary>
        /// <param name="id">The id of user</param>
        /// <param name="selectData">Specifies which data attributes to include in the result set.</param>
        /// <returns>a string url </returns>
        public string GetSingleUserEndpoint(int id,string[] selectData)
        {
            string EndPoint = ReadFromJsonFile().UsersEndPoint;


            return $"{EndPoint}/{id}?select={string.Join(",", selectData)}";

        }



        /// <summary>
        /// Gets the endpoint URL for retrieving all Post.
        /// </summary>
        public string GetPostEndPoint()
        {
            string EndPoint = ReadFromJsonFile().PostsEndPoint;

            return $"{EndPoint}";

        }


        /// <summary>
        /// Gets the endpoint URL for retrieving Post using id 
        /// </summary>
        /// <param name="id">The id of Post</param>
        /// <returns>string url </returns>
        public string GetPostEndPointByUserId(int id)
        {
            string EndPoint = ReadFromJsonFile().PostsEndPoint;

            return $"{EndPoint}/user/{id}";

        }


        /// <summary>
        /// Gets the endpoint URL for retrieving all Post with optional query parameters.
        /// </summary>
        /// <param name="limit">Sets the maximum number of items to retrieve or process.</param>
        /// <param name="skip">Determines the starting point by skipping a specified number of items.</param>
        /// <param name="selectData">Specifies which data attributes to include in the result set.</param>
        /// <returns>a string url </returns>
        public string GetPostEndPoint(int limit, int skip)
        {
            string EndPoint = ReadFromJsonFile().PostsEndPoint;

            return $"{EndPoint}?limit={limit}&skip={skip}";

        }


        /// <summary>
        /// Gets the endpoint URL for retrieving all post with optional query parameters.
        /// </summary>
        /// <param name="limit">Sets the maximum number of items to retrieve or process.</param>
        /// <param name="skip">Determines the starting point by skipping a specified number of items.</param>
        /// <param name="selectData">Specifies which data attributes to include in the result set.</param>
        /// <returns>a string url </returns>
        public string GetPostEndPoint(int limit, int skip, string[] selectData)
        {
            string EndPoint = ReadFromJsonFile().PostsEndPoint;


            return $"{EndPoint}?limit={limit}&skip={skip}&select={string.Join(",", selectData)}";

        }



        /// <summary>
        /// Gets the endpoint URL for retrieving all post with optional query parameters.
        /// </summary>
        /// <param name="id">The id of Post</param>
        /// <param name="limit">Sets the maximum number of items to retrieve or process.</param>
        /// <param name="skip">Determines the starting point by skipping a specified number of items.</param>
        /// <param name="selectData">Specifies which data attributes to include in the result set.</param>
        /// <returns>a string url </returns>
        public string GetPostEndPointByUserId(int id, int limit, int skip, string[] selectData)
        {
            string EndPoint = ReadFromJsonFile().PostsEndPoint;


            return $"{EndPoint}/user/{id}?limit={limit}&skip={skip}&select={string.Join(",", selectData)}";

        }


        /// <summary>
        /// Gets the endpoint URL for retrieving comments associated with a specific post.
        /// </summary>
        /// <param name="id">The identifier of the post.</param>
        /// <returns>The endpoint URL for comments related to the specified post.</returns>

        public string GetCommentsByPostId(int id)
        {
            string EndPoint = ReadFromJsonFile().CommentsEndPoint;

            return $"{EndPoint}/post/{id}";

        }


        /// <summary>
        /// Gets the endpoint URL for retrieving comments associated with a specific post with optional limit and skip parameters.
        /// </summary>
        /// <param name="id">The identifier of the post.</param>
        /// <param name="limit">The maximum number of comments to retrieve.</param>
        /// <param name="skip">The number of comments to skip before starting to retrieve.</param>
        /// <returns>The endpoint URL for comments related to the specified post with optional limit and skip parameters.</returns>

        public string GetCommentsByPostId(int id, int limit, int skip)
        {
            string EndPoint = ReadFromJsonFile().CommentsEndPoint;

            return $"{EndPoint}/post/{id}?limit={limit}&skip={skip}";

        }



        /// <summary>
        /// Gets the endpoint URL for retrieving products.
        /// </summary>
        /// <returns>The endpoint URL for retrieving all products.</returns>

        public string GetProductsEdnPoint()
        {
            string EndPoint = ReadFromJsonFile().ProductsEndPoint;

            return $"{EndPoint}";
        }


        /// <summary>
        /// Gets the endpoint URL for retrieving products with optional limit and skip parameters.
        /// </summary>
        /// <param name="limit">The maximum number of products to retrieve.</param>
        /// <param name="skip">The number of products to skip before starting to retrieve.</param>
        /// <returns>The endpoint URL for retrieving products with optional limit and skip parameters.</returns>

        public string GetProductsEdnPoint(int limit, int skip)
        {
            string EndPoint = ReadFromJsonFile().ProductsEndPoint;

            return $"{EndPoint}?limit={limit}&skip={skip}";
        }

        /// <summary>
        /// Gets the endpoint URL for retrieving products with optional limit, skip, and selectData parameters.
        /// </summary>
        /// <param name="limit">The maximum number of products to retrieve.</param>
        /// <param name="skip">The number of products to skip before starting to retrieve.</param>
        /// <param name="selectData">The data attributes to include in the result set.</param>
        /// <returns>The endpoint URL for retrieving products with optional limit, skip, and selectData parameters.</returns>

        public string GetProductsEdnPoint(int limit, int skip, string[] selectData)
        {
            string EndPoint = ReadFromJsonFile().ProductsEndPoint;

            return $"{EndPoint}?limit={limit}&skip={skip}&select={string.Join(",", selectData)}";
        }


        /// <summary>
        /// Gets the endpoint URL for retrieving products by a specific category.
        /// </summary>
        /// <param name="categoryName">The name of the category.</param>
        /// <returns>The endpoint URL for retrieving products by the specified category.</returns>

        public string GetProductsByCategoryEdnPoint(string CategoryName)
        {
            string EndPoint = ReadFromJsonFile().ProductsEndPoint;

            return $"{EndPoint}/category/{CategoryName}";
        }

    }
}
