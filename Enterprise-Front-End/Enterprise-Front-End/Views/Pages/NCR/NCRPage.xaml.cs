using System;
using System.Collections.Generic;
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
using System.Collections.Generic;
using System.Windows;
using Enterprise_Front_End.Controllers.ViewControllers;
using Enterprise_Front_End.Models;
using Enterprise_Front_End.Properties;


namespace Enterprise_Front_End.Views.Pages.NCR
{
    /// <summary>
    /// Interaction logic for NCRPage.xaml
    /// </summary>
    public partial class NCRPage : Page
    {
        // Data of NCR object type list for Data Grid
        public List<NCRObject> _dataList;

        public NCRPage()
        {
            // Init Components and data
            InitializeComponent();
            _dataList = new List<NCRObject>();

            // Async call to Set List data for data grid view
            Application.Current.Dispatcher.InvokeAsync(
                new Action(() => { ViewController.GetListView(this, "NCR_R_TABLE", Enterprise_Front_End.Properties.ResourcePaths.AddNCRObject); }
                    ));


            //data.Add(new Data() { Skew = 1, IssueTitle = "Miguel", ManufactureDate = new DateTime(1971, 7, 23), Status = "Approved" });
            //data.Add(new Data() { Skew = 2, IssueTitle = "Fingered", ManufactureDate = new DateTime(1974, 1, 17), Status = "Approved" });
            //data.Add(new Data() { Skew = 5, IssueTitle = "The yoghurt", ManufactureDate = new DateTime(1991, 9, 2), Status = "Approved" });
            //data.Add(new Data() { Skew = 9, IssueTitle = "The yoghurt", ManufactureDate = new DateTime(1991, 9, 2), Status = "Approved" });
            //data.Add(new Data() { Skew = 9, IssueTitle = "The yoghurt", ManufactureDate = new DateTime(1991, 9, 2), Status = "Approved" });
            //data.Add(new Data() { Skew = 3, IssueTitle = "The yoghurt", ManufactureDate = new DateTime(1991, 9, 2), Status = "Approved" });
            //data.Add(new Data() { Skew = 3, IssueTitle = "The yoghurt", ManufactureDate = new DateTime(1991, 9, 2), Status = "Approved" });
            //data.Add(new Data() { Skew = 7, IssueTitle = "The yoghurt", ManufactureDate = new DateTime(1991, 9, 2), Status = "Approved" });
            //data.Add(new Data() { Skew = 73, IssueTitle = "The yoghurt", ManufactureDate = new DateTime(1991, 9, 2), Status = "Approved" });
            //data.Add(new Data() { Skew = 2, IssueTitle = "The yoghurt", ManufactureDate = new DateTime(1991, 9, 2), Status = "Approved" });
            //data.Add(new Data() { Skew = 6, IssueTitle = "The yoghurt", ManufactureDate = new DateTime(1991, 9, 2), Status = "Approved" });
            //data.Add(new Data() { Skew = 8, IssueTitle = "The yoghurt", ManufactureDate = new DateTime(1991, 9, 2), Status = "Approved" });
            //data.Add(new Data() { Skew = 9, IssueTitle = "The yoghurt", ManufactureDate = new DateTime(1991, 9, 2), Status = "Approved" });
            //data.Add(new Data() { Skew = 365, IssueTitle = "The yoghurt", ManufactureDate = new DateTime(1991, 9, 2), Status = "Approved" });
            //data.Add(new Data() { Skew = 367, IssueTitle = "The yoghurt", ManufactureDate = new DateTime(1991, 9, 2), Status = "Approved" });
            //data.Add(new Data() { Skew = 32, IssueTitle = "The yoghurt", ManufactureDate = new DateTime(1991, 9, 2), Status = "Approved" });
            //data.Add(new Data() { Skew = 345, IssueTitle = "The yoghurt", ManufactureDate = new DateTime(1991, 9, 2), Status = "Approved" });
            //data.Add(new Data() { Skew = 23, IssueTitle = "The yoghurt", ManufactureDate = new DateTime(1991, 9, 2), Status = "Approved" });
            //data.Add(new Data() { Skew = 1, IssueTitle = "The yoghurt", ManufactureDate = new DateTime(1991, 9, 2), Status = "Approved" });

            //ncrData.ItemsSource = _dataList;
        }

        private void Add_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ViewController.NavigateToPage(this, Enterprise_Front_End.Properties.ResourcePaths.AddPageNCRNew, false);
        }

    }

    //public class NCR
    //{
    //    public int Skew { get; set; }

    //    public string IssueTitle { get; set; }

    //    public DateTime ManufactureDate { get; set; }

    //    public string Status { get; set; }
    //}
}
