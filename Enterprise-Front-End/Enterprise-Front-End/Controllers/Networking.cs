using System;
using System.Threading.Tasks;
using System.Net.Http;
using testHttpController.Model;

namespace Enterprise_Front_End.Controller
{
    public class Networking
    {
        private static string _apiEndPoint = "https://zz3az7p8rc.execute-api.us-east-1.amazonaws.com/prod";
        public static string _responseString = "";
        public string testRequestBodyString = "{\"request\" : \"get_records\", \"table_name\" : \"USER_TABLE\", \"parameters\" : {}}";
        public static Boolean _isLoggedin = false;

        public async Task<string> GetResponseString(Request request)
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
