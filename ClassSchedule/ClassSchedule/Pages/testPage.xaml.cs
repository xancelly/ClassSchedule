using ClassSchedule.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для testPage.xaml
    /// </summary>
    public partial class testPage : Page
    {
        public testPage()
        {
            InitializeComponent();
            //testListView.ItemsSource = AppData.Context.Lesson.Where(c => c.Id == 3).ToList();
            //testListView1.ItemsSource = AppData.Context.ClientLesson.Where(c => c.IdLesson == 3).ToList();
        }

        private void connectButton_Click(object sender, RoutedEventArgs e)
        {
            SqlConnectionStringBuilder connect1 =
                    new SqlConnectionStringBuilder();
            connect1.DataSource = serverNameTextBox.Text; // имя сервера
            connect1.InitialCatalog = databaseNameTextBox.Text; // имя базы данных
            connect1.IntegratedSecurity = true; //проверка подлинности через авторизацию Windows
            string conf_name = "ClassScheduleEntities"; // название строки подключения из app.config
                ConnectionStringSettings cs = ConfigurationManager.ConnectionStrings[conf_name];
            cs = new ConnectionStringSettings(conf_name, connect1.ConnectionString, "System.Data.SqlClient");

            System.Configuration.Configuration config =
                    ConfigurationManager.OpenExeConfiguration(
                    ConfigurationUserLevel.None);
            ConnectionStringsSection csSection =
                config.ConnectionStrings;
            csSection.ConnectionStrings.Remove(cs.Name);
            csSection.ConnectionStrings.Add(cs);
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
