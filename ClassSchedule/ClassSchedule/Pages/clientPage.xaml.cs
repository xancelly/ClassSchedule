﻿using ClassSchedule.Entities;
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
    /// Логика взаимодействия для clientPage.xaml
    /// </summary>
    public partial class clientPage : Page
    {
        public clientPage()
        {
            InitializeComponent();
            clientDataGrid.ItemsSource = AppData.Context.Client.Where(c => c.IsDeleted == false).ToList();
        }

        public void updateClient()
        {
            
            var CurrentClient = AppData.Context.Client.Where(c => c.IsDeleted == false).ToList();
            CurrentClient = CurrentClient.Where(c => c.LastName.ToLower().Contains(searchTextBox.Text.ToLower()) || c.FirstName.ToLower().Contains(searchTextBox.Text.ToLower()) || c.MiddleName.ToLower().Contains(searchTextBox.Text.ToLower()) || c.PhoneNumber.ToLower().Contains(searchTextBox.Text.ToLower()) || c.Zoom.ToLower().Contains(searchTextBox.Text.ToLower()) || c.Skype.ToLower().Contains(searchTextBox.Text.ToLower()) || Convert.ToString(c.DateOfBirth).ToLower().Contains(searchTextBox.Text.ToLower())).ToList();
            clientDataGrid.ItemsSource = CurrentClient;
        }

        private void searchTextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            updateClient();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            updateClient();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new editClientPage(null));
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            Client CurrentClient = clientDataGrid.SelectedItem as Client;
            if (CurrentClient != null)
            {
                NavigationService.Navigate(new editClientPage(CurrentClient));
            }
            else
            {
                MessageBox.Show("Выберите обучающегося!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            Client CurrentClient = clientDataGrid.SelectedItem as Client;
            if (CurrentClient != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить обучающегося?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    CurrentClient.IsDeleted = true;
                    AppData.Context.SaveChanges();
                    Page_Loaded(null, null);
                    MessageBox.Show("Обучающийся был удален!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Выберите обучающегося!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
