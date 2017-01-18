using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Enterprise_Front_End.Models;
using System.Collections.Specialized;
using Enterprise_Front_End.Controllers.ViewControllers;

namespace Enterprise_Front_End.Views.Pages.NCR
{
    /// <summary>
    /// Interaction logic for NCRNewForm.xaml
    /// </summary>
    public partial class NCRNewForm : Page
    {
        public NCRNewForm()
        {
            InitializeComponent();

            //try to add stuff into the database/backend

            var parameters = new OrderedDictionary();
            var skewOD = new OrderedDictionary();
            skewOD.Add("S", "testAdd");
            parameters.Add("Skew", skewOD);
            var DateIssdOD = new OrderedDictionary();
            DateIssdOD.Add("S", "2016-10-13");
            parameters.Add("DateIssd", DateIssdOD);
            var CostOD = new OrderedDictionary();
            CostOD.Add("S", "$4.20");
            parameters.Add("Cost", CostOD);
            var MnfctYearOD = new OrderedDictionary();
            MnfctYearOD.Add("S", "2016");
            parameters.Add("MnfctYear", MnfctYearOD);
            var DateMnfctOD = new OrderedDictionary();
            DateMnfctOD.Add("S", "2016-12-19");
            parameters.Add("DateMnfct", DateMnfctOD);
            var DateBBOD = new OrderedDictionary();
            DateBBOD.Add("S", "2016-12-19");
            parameters.Add("DateBB", DateBBOD);


            Application.Current.Dispatcher.InvokeAsync(
                new Action(() => {
                    ViewController.AddNCR(this, "NCR_R_TABLE", parameters);
                }
            ));
        }

        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TextBox_GotFocus;
        }

        //public void generateNCR(object sender, RoutedEventArgs e)
        //{
        //    string output = ManufactureDateTextBox.Text.Substring(ManufactureDateTextBox.Text.IndexOf('/') + 1);

        //    manfactDatePicker.Text
        //        manfactDatePicker.Value.ToString("yyyy-MM-dd");

        //    DateTime dt = DateTime.ParseExact(manfactDatePicker.DisplayDate, "ddMMyyyy",
        //                          CultureInfo.InvariantCulture);
        //    dt.ToString("yyyyMMdd");

        //    NCRObject ncrObj = new NCRObject
        //        (skewText.Text,
        //        DateTime.Now.ToString(),
        //        costTextBox.Text,
        //        manfactDatePicker.Text,
        //        manfactDatePicker.Text,
        //        bbDatePicker.Text);
        //}

        private void DatePicker_SelectedDateChanged(object sender,
           SelectionChangedEventArgs e)
        {
            // ... Get DatePicker reference.
            var picker = sender as DatePicker;

            // ... Get nullable DateTime from SelectedDate.
            DateTime? date = picker.SelectedDate;
            if (date == null)
            {
                // ... A null object.
                this.Title = "No date";
            }
            else
            {
                // ... No need to display the time.
                this.Title = date.Value.ToShortDateString();
            }
        }

    }
}
