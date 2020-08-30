using ClassSchedule.Pages;
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

namespace ClassSchedule
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Navigate(new mainMenu());
        }

        private void mainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (mainFrame.CanGoBack)
            {
                backButton.Visibility = Visibility.Visible;
            } else
            {
                backButton.Visibility = Visibility.Hidden;
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            if (mainFrame.CanGoBack)
            {
                mainFrame.GoBack();
            }
        }
    }
}
