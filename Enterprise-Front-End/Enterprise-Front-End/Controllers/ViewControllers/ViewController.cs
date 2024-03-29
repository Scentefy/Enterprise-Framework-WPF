﻿using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Navigation;
using System.Threading.Tasks;
using Enterprise_Front_End.Models;
using Enterprise_Front_End.Controllers;
using System.Collections.Specialized;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections;

namespace Enterprise_Front_End.Controllers.ViewControllers
{
    /// <summary>
    /// View Controller called by only page objects to control the view elements on the page
    /// </summary>
    public class ViewController
    {
        // Singleton instance
        public static ViewController instance;
                                           
        /// <summary>
        /// ViewObject 
        /// </summary>
        /// <param name="viewObject"></param>
        /// <param name="pageLocation"></param>
        /// <param name="isNetworkRequest"></param>
        public static void NavigateToPage(dynamic viewObject, string pageLocation, Boolean isNetworkRequest)
        {
            // if needs network request run animation loading animation and run a request

            // if successful network use viewObject to populate view
            Type t = Type.GetType(pageLocation);
            if (t == null)
            {
                throw new Exception("Type " + pageLocation + " not found.");
            }
            else
            {
                Object o = Activator.CreateInstance(t);
                viewObject.NavigationService.Navigate(o);
            }
        }

        public static void GetDetailsView(dynamic viewObject)
        {
            // get record clicked 

            // put information into a custom page object

            // place page in side frame

        }

        public static void GetDetailsViewEnlarged(dynamic viewObject)
        {
            // get record clicked 

            // put information into a custom page object

            // place page in full frame 

        }

        public static void CloseView(dynamic viewObject)
        {

        }

        public static void GetFormView(dynamic viewObject)
        {
            
        }

        public static async void GetListView(dynamic viewObject, string tableName, string objectAddress)
        {
            // Create a network request
            var parameters = new OrderedDictionary();
            // Create a request Object
            Request request = new Request("get_records", parameters, tableName);
            // Store string value of response
            string responseString = null;

            // Request back end for data
            try
            {
                responseString = await Networking.GetResponseString(request);
            }
            catch (Exception e)
            {
                Console.WriteLine("Getting list failed : " + e);
            }
            // DEBUG printing out response from API
            Console.WriteLine("Response : " + responseString);

            // get the type of objects that need to be put into a list
            Console.WriteLine("Getting type :: " + objectAddress);
            Type objectType = Type.GetType(objectAddress);
            if (objectType == null)
            {
                throw new Exception("type " + objectAddress + " not found.");
            }

            // Bind list with recieved responseString to data grid
            viewObject.DataGridData.ItemsSource =
                Utility.GetObjectList(responseString, objectType);

            
        }

        public static void getConfirmationDialouge(dynamic viewObject)
        {

        }

    }
}
