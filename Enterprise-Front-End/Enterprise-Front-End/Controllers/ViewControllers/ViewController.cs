﻿using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Navigation;
using System.Threading.Tasks;

namespace Enterprise_Front_End.Controllers.ViewControllers
{
    static class ViewController
    {

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

        public static void getDetailsView(dynamic viewObject)
        {
            // get record clicked 

            // put information into a custom page object

            // place page in side frame

        }

        public static void getDetailsViewEnlarged(dynamic viewObject)
        {
            // get record clicked 

            // put information into a custom page object

            // place page in full frame 

        }

        public static void closeView(dynamic viewObject)
        {

        }

        public static void getFormView(dynamic viewObject)
        {
            
        }

        public static void getListView(dynamic viewObject)
        {

        }

        public static void getConfirmationDialouge(dynamic viewObject)
        {

        }

    }
}
