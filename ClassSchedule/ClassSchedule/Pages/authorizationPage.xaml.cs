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

namespace ClassSchedule.Pages
{
    /// <summary>
    /// Логика взаимодействия для authorizationPage.xaml
    /// </summary>
    public partial class authorizationPage : Page
    {
        public authorizationPage()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new mainMenu());
        }
    }
}
