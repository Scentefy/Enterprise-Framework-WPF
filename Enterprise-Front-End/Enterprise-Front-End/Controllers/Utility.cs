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
            // Parse Json and put the data section into an Json object list
            dynamic inputJsonObject = JObject.Parse(input);
            JArray dataObjects = (JArray)inputJsonObject["data"];

            // Get List Object properties to be mapped to the JArray Items Attributes
            var objectProperties = Activator.CreateInstance(newObjectType)
                .GetType().GetProperties();

            // Create list with type extracted from the ObjectType String
            Type listType = typeof(List<>).MakeGenericType(new[] { newObjectType });
            IList objectList = (IList)Activator.CreateInstance(listType);

            // Loop through all the JObjects in the JArray
            foreach (JObject jObject in dataObjects)
            {
                // Create the new Object to be put into the list
                Object listObject = Activator.CreateInstance(newObjectType);
                // Loop through all the properties of the List object
                foreach (var prop in objectProperties)
                {

                    // If value exists in response body
                    if (jObject.Property(prop.Name) != null)
                    {

                        // Debug messages for properties of the JObject
                        //Console.WriteLine("Name of property : " + p.Name);
                        //Console.Write("printing properties : " + jObject[p.Name]["S"]);
                        PropertyInfo newObjectPropertyInf = newObjectType.GetProperty(prop.Name);
                        // Set Value of objects attributes
                        newObjectPropertyInf.SetValue(listObject, Convert.ChangeType(jObject[prop.Name]["S"],
                            newObjectPropertyInf.PropertyType), null);
                    }
                }
                // Add object to list
                objectList.Add(listObject);
            }
            return objectList;
        }

        /// <summary>
        /// Utility function which returns a Type object using a string address of the Class
        /// </summary>
        /// <param name="objectLocation"></param>
        /// <returns>Type object of the given Class address</returns>
        public static Type GetObjectType(string objectLocation)
        {
            Type t = Type.GetType(objectLocation);
            if (t == null)
            {
                throw new Exception("Type " + objectLocation + " not found.");
            }
            return t;
        }

    }

    
}
