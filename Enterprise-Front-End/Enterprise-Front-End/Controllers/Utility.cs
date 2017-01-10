using Newtonsoft.Json;
using System;
using System.Reflection;
using System.Collections;
using Enterprise_Front_End.Models;
using Newtonsoft.Json.Linq;
using System.Windows.Documents;
using System.Collections.Generic;

namespace Enterprise_Front_End.Controllers
{
    public class Utility
    {
        // Singleton instance
        public static Utility instance;

        public static IList GetObjectList(string input, Type newObjectType)
        {
            // Parse json and put the data section into an object list
            dynamic inputJsonObject = JObject.Parse(input);
            JArray dataObjects = (JArray)inputJsonObject["data"];

            // Get Object Properties to be mapped to the JArray Items Attributes
            var objectProperties = Activator.CreateInstance(newObjectType)
                .GetType().GetProperties();

            // Create list with type extracted from the ObjectType String
            Type listType = typeof(List<>).MakeGenericType(new[] { newObjectType });
            IList objectList = (IList)Activator.CreateInstance(listType);

            //var objectList = new List<dynamic>();

            // Loop through all the JObjects in the JArray
            foreach (JObject jObject in dataObjects)
            {
                // Create the new Object to be put into the list
                Object listObject = Activator.CreateInstance(newObjectType);
                foreach (var p in objectProperties)
                {

                    // If value exists in response body
                    if (jObject.Property(p.Name) != null)
                    {
                        // Fill objects attributes
                        PropertyInfo newObjectPropertyInf = newObjectType.GetProperty(p.Name);
                        // Debug messages for properties of the JObject
                        Console.WriteLine("Name of property : " + p.Name);
                        Console.Write("printing properties : " + jObject[p.Name]["S"]);
                        // Set Value
                        newObjectPropertyInf.SetValue(listObject, Convert.ChangeType(jObject[p.Name]["S"],
                            newObjectPropertyInf.PropertyType), null);
                    }
                }
                // Add object to list
                objectList.Add(listObject);
            }
            return objectList;
        }

    }
}
