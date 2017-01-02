using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
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
using Enterprise_Front_End.Properties;


namespace Enterprise_Front_End
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
            login_label.Content = ResourceStrings.LoginPageHeader;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri(ResourcePaths.FolderView+ResourcePaths.PageDash, UriKind.Relative));
            //this.Visibility = Visibility.Hidden;
        }

        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TextBox_GotFocus;
        }

        public void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox tb = (PasswordBox)sender;
            tb.Password = string.Empty;
            tb.GotFocus -= PasswordBox_GotFocus;
        }

        private void Hyperlink_RequestNavigate(object sender,
                                       System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.msn.com");
        }
    }
}
