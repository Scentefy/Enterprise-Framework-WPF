using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using Newtonsoft.Json;
using System.Reflection;
using testHttpController.Controller;
using testHttpController.Model;
using System;
using System.Collections;
using System.Collections.Specialized;

namespace testHttpController
{
    class Program
    {
        static void Main(string[] args)
        {

            //dynamic contact = new ExpandoObject();
            //contact.name = "lol";
            //Console.WriteLine(contact.name);

            //try
            //{
            //    var byName = (IDictionary<string, object>)contact;
            //    string name = (string)byName["name"];
            //    Console.WriteLine(name);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}

            //string json = JsonConvert.SerializeObject(contact);

            //Console.WriteLine(json);

            // Testing request

            var parameters = new OrderedDictionary();
            parameters.Add("FName", "nigga");
            parameters.Add("LName", "nigga");
            parameters.Add("Password", "nigga");
            parameters.Add("Email", "nigga");
            parameters.Add("RoleID", "nigga");

            Request r = new Request("put_record", parameters, "USER_TABLE");
            Console.WriteLine("Printing out Request.....");
            Console.WriteLine(r.Jsonify());

            
        }

    }
}
