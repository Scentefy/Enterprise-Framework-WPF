using System;
using System.Threading.Tasks;
using System.Net.Http;
using testHttpController.Model;
using System.Collections.Specialized;

namespace Enterprise_Front_End.Controller
{
    public class Networking
    {
        // Declaration of Singleton instance
        public static Networking instance;

        private static string _apiEndPoint = "https://zz3az7p8rc.execute-api.us-east-1.amazonaws.com/prod";
        public static string _responseString = "";
        public string testRequestBodyString = "{\"request\" : \"get_records\", \"table_name\" : \"USER_TABLE\", \"parameters\" : {}}";
        public static Boolean _isLoggedin = false;

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
        
        public static Boolean Login()
        {
            var parameters = new OrderedDictionary();
            //parameters.Add("FName", "nigga");
            //parameters.Add("LName", "nigga");
            //parameters.Add("Password", "nigga");
            //parameters.Add("Email", "nigga");
            //parameters.Add("RoleID", "nigga");

            Request r = new Request("login", parameters, "USER_TABLE");
            
            
            return false;
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
