using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using testHttpController.Model;

namespace testHttpController.Controller
{
    public static class Networking
    {
        private static string _apiEndPoint = "https://zz3az7p8rc.execute-api.us-east-1.amazonaws.com/prod";
        //string requestBody = @"{\"request\" : \"get_records\", \"table_name\" : \"USER_TABLE\", \"parameters\" : {}}";


        /// <summary>
        /// This function posts a json string given to it with a 
        /// predefined api url which is set
        /// </summary>
        public static async Task<String> postRequest(Request request)
        {
            using (var client = new HttpClient())
            {
                // Create the RequestBody
                StringContent requestBody = new StringContent(request.Jsonify(), 
                    System.Text.UTF8Encoding.UTF8, "application/json");
                // Send the Async Request
                var response = await client.PostAsync(_apiEndPoint, requestBody);
                // Extract the response body
                return await response.Content.ReadAsStringAsync();
            }
        }

        /// <summary>
        /// Sets the APIEndPoint to which the system communicates with
        /// </summary>
        public static string apiEndPoint
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException();
                _apiEndPoint = value;
            }
        }

        

    }




}
