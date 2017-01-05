using System;
using System.Threading.Tasks;
using System.Net.Http;
using testHttpController.Model;

namespace testHttpController.Controller
{
    public class Networking
    {
        public static Networking instance;

        private static string _apiEndPoint = "https://5szoc7knb5.execute-api.us-east-1.amazonaws.com/prod/";
        public static string _responseString = "";
        public string testRequestBodyString = "{\"request\" : \"get_records\", \"table_name\" : \"USER_TABLE\", \"parameters\" : {}}";

        public static async Task<string> GetResponseString(Request request)
        {
            var httpClient = new HttpClient();
            // Create the RequestBody
            StringContent requestBody = new StringContent(request.Jsonify(),
                System.Text.UTF8Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(_apiEndPoint, requestBody);
            var contents = await response.Content.ReadAsStringAsync();
            return contents;
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
