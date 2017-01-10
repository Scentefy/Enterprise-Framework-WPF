using Newtonsoft.Json.Linq;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Enterprise_Front_End.Models;

namespace Enterprise_Front_End.Controllers
{
    public class Utility
    {
        // Singleton instance
        public static Utility instance;

        public static IList getObjectList(string input, string objectType)
        {
            // Parse json and put the data section into an object list
            dynamic inputJsonObject = JObject.Parse(input);
            JArray dataObjects = (JArray)inputJsonObject["data"];

            Console.Write("printing properties : "+dataObjects[0]["ID"]);


            // get the type of objects that need to be put into a list
            Console.WriteLine("Getting type :: " + objectType);
            Type newObjectType = Type.GetType(objectType);
            if (newObjectType == null)
            {
                throw new Exception("type " + objectType + " not found.");
            }
            Object n = Activator.CreateInstance(newObjectType);

            //NCRObject n = new NCRObject();
            var objectProperties = n.GetType().GetProperties();
            
            foreach (var p in objectProperties)
            {
                Console.WriteLine("Name of property : " + p.Name);
                Console.Write("printing properties : " + dataObjects[0][p.Name]);
            }








            //// Get the attributes of the first object in the json object array
            //Type jsonType = dataObjects[0].GetType();
            //PropertyInfo[] attributes = jsonType.GetProperties();


            //// Create list with type extracted from the ObjectType String
            //Type listType = typeof(List<>).MakeGenericType(new[] { newObjectType });
            //IList objectList = (IList)Activator.CreateInstance(listType);


            //foreach (JObject jsonObj in dataObjects)
            //{
            //    // Create a new object each iteration
            //    Object newObject = Activator.CreateInstance(newObjectType);
            //    // TODO get each object
            //    foreach (dynamic attribute in attributes)
            //    {
            //        // TODO extract attributes and put it in object
            //        PropertyInfo newObjectPropertyInf = newObjectType.GetProperty(attribute.Name.ToString());
            //        newObjectPropertyInf.SetValue(newObject, jsonObj, )
            //    }
            //}

            //return objectList;

            return null;
        }

    }
}
