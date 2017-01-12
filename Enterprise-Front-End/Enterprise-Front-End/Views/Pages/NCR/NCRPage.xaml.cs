using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Enterprise_Front_End.Controllers.ViewControllers;


namespace Enterprise_Front_End.Views.Pages.NCR
{
    /// <summary>
    /// Interaction logic for NCRPage.xaml
    /// </summary>
    public partial class NCRPage : Page
    {
        // Data of NCR object type list for Data Grid
        public List<object> _dataList { get; set; }

        public NCRPage()
        {
            // Init Components and data
            InitializeComponent();
            _dataList = null;

            // Async call to Set List data for data grid view
            Application.Current.Dispatcher.InvokeAsync(
                new Action(() => { ViewController.GetListView(this, "NCR_R_TABLE", 
                    Enterprise_Front_End.Properties.ResourcePaths.AddNCRObject); }
                    ));
        }

        private void Add_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ViewController.NavigateToPage(this, Enterprise_Front_End.Properties.ResourcePaths.AddPageNCRNew, false);
        }

        
    }
}
