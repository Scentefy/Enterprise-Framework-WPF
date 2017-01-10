using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using Newtonsoft.Json;
using System.Net.Http;
using Enterprise_Front_End.Controllers;


namespace Enterprise_Front_End.Models
{
    public class Request
    {
        // Class field variables
        // TODO : Add getters and setters like the NCR object
        private string _requestType;
        private dynamic _parameters;
        private string _tableName;

        // Default Constructor
        public Request(string requestType, dynamic parameters, string tableName)
        {
            _requestType = requestType;
            _parameters = parameters;
            _tableName = tableName;
        }
        
        /// <summary>
        /// Returns a Json string of the Request Object
        /// </summary>
        /// <returns>Json string representing the request object</returns>
        public string Jsonify()
        {
            dynamic json = new ExpandoObject();
            json.request = _requestType;
            json.table_name = _tableName;
            json.parameters = _parameters;
            // Return Json String
            return JsonConvert.SerializeObject(json);
        }
    }


}
