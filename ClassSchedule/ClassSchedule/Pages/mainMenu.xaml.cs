using ClassSchedule.Entities;
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
    /// Логика взаимодействия для mainMenu.xaml
    /// </summary>
    public partial class mainMenu : Page
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void scheduleButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new schedulePage());
            
        }

        private void groupButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new groupPage());
        }

        private void clientButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new clientPage());
        }

        private void teacherButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new teacherPage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Client client = null;
            //DateTime todayDate = DateTime.Today;
            //foreach (var item in AppData.Context.ClientLesson.Where(c => c.Lesson.Date < todayDate))
            //{
            //    client = AppData.Context.Client.Where(c => c.Id == item.Client.Id).FirstOrDefault();
            //    client.Balance -= Convert.ToDecimal("1200");
            //}
            //AppData.Context.SaveChanges();
        }
    }
}
