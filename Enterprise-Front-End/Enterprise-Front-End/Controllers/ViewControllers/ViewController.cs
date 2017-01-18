using System;
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
            Type t = Utility.GetObjectType(pageLocation);
            Object o = Activator.CreateInstance(t);
            viewObject.NavigationService.Navigate(o);
            
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

            // Create a request Object
            var parameters = new OrderedDictionary();
            Request request = new Request("get_records", parameters, tableName);
            string responseString = null;

            // Send Network Request for data
            try
            {
                responseString = await Networking.GetResponseString(request);
            }
            catch (Exception e)
            {
                Console.WriteLine("Getting list failed : " + e);
            }
            //// DEBUG printing out response from API
            //Console.WriteLine("Response : " + responseString);

            // get the type of objects that need to be put into a list
            Type objectType = Utility.GetObjectType(objectAddress);

            // Bind list with recieved responseString to data grid
            viewObject.DataGridData.ItemsSource =
                Utility.GetObjectList(responseString, objectType);
        }

        public static async void AddNCR(dynamic viewObject, string tableName, dynamic parameters)
        {
            // Create a request Object
            Request request = new Request("put_record", parameters, tableName);
            // Store string value of response
            string responseString = null;

            // Request and sending data/parameters to back end for data
            try
            {
                responseString = await Networking.GetResponseString(request);
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to put record to server : " + e);
            }
            // DEBUG printing out response from API
            Console.WriteLine("Response : " + responseString);

        }

        public static void getConfirmationDialouge(dynamic viewObject)
        {

        }

    }
}
