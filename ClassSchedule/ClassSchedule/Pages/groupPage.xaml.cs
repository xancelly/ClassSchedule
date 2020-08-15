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
    /// Логика взаимодействия для groupPage.xaml
    /// </summary>
    public partial class groupPage : Page
    {
        public groupPage()
        {
            InitializeComponent();
            groupsDataGrid.ItemsSource = AppData.Context.Groups.Where(c => c.IsDeleted == false).ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            updateGroups();
        }

        public void updateGroups()
        {
            var CurrentGroup = AppData.Context.Groups.Where(c => c.IsDeleted == false).ToList();
            CurrentGroup = CurrentGroup.Where(c => c.Name.ToLower().Contains(searchTextBox.Text.ToLower())).ToList();
            groupsDataGrid.ItemsSource = CurrentGroup;
        }

        private void searchTextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            updateGroups();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new editGroupPage(null));
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            Groups CurrentGroup = groupsDataGrid.SelectedItem as Groups;
            if (CurrentGroup != null)
            {
                NavigationService.Navigate(new editGroupPage(CurrentGroup));
            }
            else
            {
                MessageBox.Show("Выберите учебную группу!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            Groups CurrentGroup = groupsDataGrid.SelectedItem as Groups;
            if (CurrentGroup != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить учебную группу?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    CurrentGroup.IsDeleted = true;
                    AppData.Context.SaveChanges();
                    Page_Loaded(null, null);
                    MessageBox.Show("Учебная группа была удалена!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Выберите учебную группу!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
