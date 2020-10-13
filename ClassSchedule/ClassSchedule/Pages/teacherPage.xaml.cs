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
using System.Windows.Threading;

namespace ClassSchedule.Pages
{
    /// <summary>
    /// Логика взаимодействия для teacherPage.xaml
    /// </summary>
    public partial class teacherPage : Page
    {
        DispatcherTimer timer = new DispatcherTimer();
        int countData;
        public teacherPage()
        {
            InitializeComponent();
            teacherDataGrid.ItemsSource = AppData.Context.Teacher.Where(c => c.IsDeleted == false).ToList();

            timer.Interval = TimeSpan.Parse("00:00:05");
            timer.Tick += Timer_Tick;
            timer.Start();
            countData = AppData.Context.Teacher.Count();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            if (countData < AppData.Context.Teacher.Count() || countData > AppData.Context.Teacher.Count())
            {
                countData = AppData.Context.Teacher.Count();
                updateTeacher();
            }
            timer.Start();
        }

        public void updateTeacher()
        {
            var CurrentTeacher = AppData.Context.Teacher.Where(c => c.IsDeleted == false).ToList();
            CurrentTeacher = CurrentTeacher.Where(c => c.LastName.ToLower().Contains(searchTextBox.Text.ToLower()) || c.FirstName.ToLower().Contains(searchTextBox.Text.ToLower()) || c.MiddleName.ToLower().Contains(searchTextBox.Text.ToLower()) || c.PhoneNumber.ToLower().Contains(searchTextBox.Text.ToLower()) || c.Email.ToLower().Contains(searchTextBox.Text.ToLower()) || c.Comment.ToLower().Contains(searchTextBox.Text.ToLower()) || Convert.ToString(c.DateOfBirth).ToLower().Contains(searchTextBox.Text.ToLower())).ToList();
            teacherDataGrid.ItemsSource = CurrentTeacher;

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            updateTeacher();
        }

        private void searchTextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            updateTeacher();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new editTeacherPage(null));
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            Teacher CurrentTeacher = teacherDataGrid.SelectedItem as Teacher;
            if (CurrentTeacher != null)
            {
                NavigationService.Navigate(new editTeacherPage(CurrentTeacher));
            }
            else
            {
                MessageBox.Show("Выберите преподавателя!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            Teacher CurrentTeacher = teacherDataGrid.SelectedItem as Teacher;
            if (CurrentTeacher != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить преподавателя?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    CurrentTeacher.IsDeleted = true;
                    AppData.Context.SaveChanges();
                    Page_Loaded(null, null);
                    MessageBox.Show("Преподаватель был удален!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Выберите преподавателя!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
