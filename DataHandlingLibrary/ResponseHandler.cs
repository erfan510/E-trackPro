using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandlingLibrary
{
    public class ResponseHandler 
    {




        /// <summary>
        /// This method sends a GET request to the specified URL using HttpClient.
        /// It is an synchronous method returning a Task<string> representing the response content.
        /// </summary>
        /// <param name="url">The EndPoint/url of Api</param>
        /// <returns> Task<string> </returns>
        public async Task<string> SendGetRequest(string url)
        {
            // Creating an instance of the HttpClient class to send the request.
            using (HttpClient client = new HttpClient())
            {
                // Creating a Uri object from the provided URL.
                Uri uri = new Uri(url);

                // Sending an synchronous GET request to the specified URI and obtaining the response.
                // Extracting the content from the response message.
                var responsMessage = client.GetAsync(uri).Result.Content;


                // Reading the content asynchronously and returning it as a string.
                return responsMessage.ReadAsStringAsync().Result;


            }
        }




        /// <summary>
        /// This method sends a GET request to the specified URL using HttpClient.
        /// It is an asynchronous method returning a Task<string> representing the response content.
        /// </summary>
        /// <param name="url">The EndPoint/url of Api</param>
        /// <returns> Task<string> </returns>
        public async Task<string> SendGetRequestAsync(string url)
        {
            // Creating an instance of the HttpClient class to send the request.
            using (HttpClient client = new HttpClient())
            {
                // Creating a Uri object from the provided URL.
                Uri uri = new Uri(url);

                // Sending an asynchronous GET request to the specified URI and obtaining the response.
                // Extracting the content from the response message.
                var responsMessage = await client.GetAsync(uri);


                // Reading the content asynchronously and returning it as a string.
                return responsMessage.Content.ReadAsStringAsync().Result;


            }
        }


        /// <summary>
        /// Asynchronously sends a PATCH request to the specified URL to update a single property.
        /// </summary>
        /// <param name="url">The URL of the resource to be updated.</param>
        /// <param name="propertyName">The name of the property to be updated.</param>
        /// <param name="newValue">The new value for the specified property.</param>
        /// <returns>A task representing the asynchronous operation, with the result being the response content as a string.</returns>
        public async Task<string> PatchRequesAsync(string url, string propertyName, string newValue)
        {


            if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                Uri uri = new Uri(url);
                using (HttpClient client = new HttpClient())
                {

                    StringContent Scontent = new StringContent(
                       content: newValue,
                       encoding: Encoding.UTF8,
                       mediaType: "application/json"

                       );

                    var content = new MultipartFormDataContent();
                    content.Add(Scontent, propertyName);



                    HttpResponseMessage responseMessage = await client.PatchAsync(uri, content);

                    return responseMessage.Content.ReadAsStringAsync().Result;
                }

            }
            else
            {
                throw new Exception("invalid Url");
            }



        }


        /// <summary>
        /// Asynchronously sends a PATCH request to the specified URL to update multiple properties.
        /// </summary>
        /// <param name="url">The URL of the resource to be updated.</param>
        /// <param name="propertyNameList">The list of property names to be updated.</param>
        /// <param name="newValueList">The list of new values corresponding to the property names.</param>
        /// <returns>A task representing the asynchronous operation, with the result being the response content as a string.</returns>
        public async Task<(bool success, string message)> PatchRequesAsync(string url, List<string> propertyNameList, List<string> newValueList)
        {

            if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                Uri uri = new Uri(url);
                using (HttpClient client = new HttpClient())
                {
                    var zippedList = propertyNameList.Zip(newValueList, (propertyName, newValue) => new { propertyname = propertyName, newvalue = newValue });
                    var content = new MultipartFormDataContent();

                    foreach (var item in zippedList)
                    {

                        StringContent stringContent = new StringContent(
                       content: item.newvalue,
                       encoding: Encoding.UTF8,
                       mediaType: "application/json"

                       );


                        content.Add(stringContent, item.propertyname);
                    }


                    HttpResponseMessage responseMessage = await client.PatchAsync(uri, content);

                    if (responseMessage.IsSuccessStatusCode)
                    {
                        var result = responseMessage.Content.ReadAsStringAsync().Result;
                        return (true, result);
                    } 
                    else
                    {
                        return (false, "cold not Changed user");
                    }

                }

            }
            else
            {
                throw new Exception("invalid Url");
            }



        }




        /// <summary>
        /// This method is used to deserialize JSON data into an object of type T.
        /// It utilizes the JsonConvert.DeserializeObject method from the Newtonsoft.Json library.
        /// The method takes a JSON string as input and returns an object of the specified generic type T.
        /// </summary>
        /// <typeparam name="T">The type of the Deserialize Object 
        /// T using the specified the type of deserialize Object.</typeparam>
        /// <param name="json">JSON string</param>
        /// <returns> T </returns>
        public T DeserializeJsonData<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }


    }
}
