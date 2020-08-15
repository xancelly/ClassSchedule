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
    /// Логика взаимодействия для editGroupPage.xaml
    /// </summary>
    public partial class editGroupPage : Page
    {
        Groups CurrentGroup = null;
        public editGroupPage(Groups groups)
        {
            InitializeComponent();
            CurrentGroup = groups;
            if (CurrentGroup != null)
            {
                this.Title = "Редактирование учебной группы";
                nameGroupTextBox.Text = CurrentGroup.Name;
            }
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(nameGroupTextBox.Text))
            {
                if (AppData.Context.Groups.Where(c => c.Name.ToLower() == nameGroupTextBox.Text.ToLower() && c.IsDeleted == false).FirstOrDefault() == null)
                {
                    if (CurrentGroup == null)
                    {

                        CurrentGroup = new Groups()
                        {
                            Name = nameGroupTextBox.Text,
                            IsDeleted = false
                        };
                        AppData.Context.Groups.Add(CurrentGroup);
                        AppData.Context.SaveChanges();
                        MessageBox.Show("Учебная группа успешно добавлена!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                        NavigationService.GoBack();

                    }
                    else
                    {
                        CurrentGroup.Name = nameGroupTextBox.Text;
                        CurrentGroup.IsDeleted = false;
                        MessageBox.Show("Информация обновлена!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                        AppData.Context.SaveChanges();
                        NavigationService.GoBack();
                    }
                }
                else
                {
                    MessageBox.Show("Учебная группа с таким наименованием уже существует!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Некорректный ввод наименования учебной группы!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
