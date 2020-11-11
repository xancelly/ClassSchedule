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
using ClassSchedule.Entities;

namespace ClassSchedule.Pages
{
    /// <summary>
    /// Логика взаимодействия для lessonPage.xaml
    /// </summary>
    public partial class lessonPage : Page
    {
        Lesson CurrentLesson = null;
        public lessonPage(Lesson lesson)
        {
            InitializeComponent();
            CurrentLesson = lesson;
            lessonDataGrid.ItemsSource = AppData.Context.Lesson.Where(c => c.Id == CurrentLesson.Id).ToList();
            clientLessonDataGrid.ItemsSource = AppData.Context.ClientLesson.Where(c => c.Lesson.Id == CurrentLesson.Id).ToList();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new editSchedulePage(CurrentLesson));
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AppData.Context.ClientLesson.RemoveRange(AppData.Context.ClientLesson.Where(c => c.Lesson.Id == CurrentLesson.Id));
                AppData.Context.Lesson.Remove(CurrentLesson);
                AppData.Context.SaveChanges();
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PaidAndAttendance(object sender, RoutedEventArgs e)
        {
            ClientLesson CurrentClientLesson = clientLessonDataGrid.SelectedItem as ClientLesson;
            if (CurrentClientLesson != null)
            {
                var checkbox = (CheckBox)sender;
                if ((checkbox.IsChecked == true || checkbox.IsChecked == false) && checkbox.Name == "paid")
                {
                    CurrentClientLesson.IsPaid = checkbox.IsChecked.Value;
                    AppData.Context.SaveChanges();
                    Page_Loaded(null, null);
                }
                else if ((checkbox.IsChecked == true || checkbox.IsChecked == false) && checkbox.Name == "attendance")
                {
                    CurrentClientLesson.IsAttendance = checkbox.IsChecked.Value;
                    AppData.Context.SaveChanges();
                    Page_Loaded(null, null);
                }
            }
        }

        public void UpdateData()
        {
            lessonDataGrid.ItemsSource = null;
            lessonDataGrid.ItemsSource = AppData.Context.Lesson.Where(c => c.Id == CurrentLesson.Id).ToList();
            clientLessonDataGrid.ItemsSource = AppData.Context.ClientLesson.Where(c => c.Lesson.Id == CurrentLesson.Id).ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateData();
        }
    }
}
