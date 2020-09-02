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
    /// Логика взаимодействия для editClientPage.xaml
    /// </summary>
    public partial class editClientPage : Page
    {
        Client CurrentClient = null;
        public editClientPage(Client client)
        {
            InitializeComponent();
            CurrentClient = client;
            if (CurrentClient != null)
            {
                this.Title = "Редактирование обучающегося";
                lastNameTextBox.Text = CurrentClient.LastName;
                firstNameTextBox.Text = CurrentClient.FirstName;
                middleNameTextBox.Text = CurrentClient.MiddleName;
                phoneNumberTextBox.Text = CurrentClient.PhoneNumber;
                dateOfBirthDatePicker.SelectedDate = CurrentClient.DateOfBirth;
                zoomTextBox.Text = CurrentClient.Zoom;
                skypeTextBox.Text = CurrentClient.Skype;
                timeComboBox.Text = CurrentClient.FavoriteTime;
            }
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            string letterList = "ABCDEFGHIJKLMNOPRSTUVWXYZabcdefghijklmnoprstuvwxyzАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string numList = "1234567890";
            if (!String.IsNullOrWhiteSpace(lastNameTextBox.Text) && !String.IsNullOrWhiteSpace(firstNameTextBox.Text) && !String.IsNullOrWhiteSpace(phoneNumberTextBox.Text) && !String.IsNullOrWhiteSpace(zoomTextBox.Text) && dateOfBirthDatePicker.SelectedDate != null && timeComboBox.SelectedItem != null)
            {
                if (lastNameTextBox.Text.IndexOfAny(numList.ToCharArray()) <= -1)
                {
                    if (firstNameTextBox.Text.IndexOfAny(numList.ToCharArray()) <= -1)
                    {
                        if (middleNameTextBox.Text.IndexOfAny(numList.ToCharArray()) <= -1)
                        {
                            if (phoneNumberTextBox.Text.IndexOfAny(letterList.ToCharArray()) <= -1)
                            {
                                if (dateOfBirthDatePicker.SelectedDate < DateTime.Today)
                                {
                                    if (timeComboBox.SelectedItem.ToString() != "Не выбрано")
                                    {
                                        if (CurrentClient == null)
                                        {
                                            CurrentClient = new Client()
                                            {
                                                LastName = lastNameTextBox.Text.Substring(0, 1).ToUpper() + lastNameTextBox.Text.Substring(1, lastNameTextBox.Text.Length - 1),
                                                FirstName = firstNameTextBox.Text.Substring(0, 1).ToUpper() + firstNameTextBox.Text.Substring(1, firstNameTextBox.Text.Length - 1),
                                                DateOfBirth = Convert.ToDateTime(dateOfBirthDatePicker.SelectedDate.Value.ToShortDateString()),
                                                PhoneNumber = phoneNumberTextBox.Text,
                                                FavoriteTime = timeComboBox.Text,
                                                Skype = skypeTextBox.Text,
                                                Zoom = zoomTextBox.Text,
                                                IsDeleted = false,
                                            };
                                            if (!String.IsNullOrWhiteSpace(middleNameTextBox.Text))
                                            {
                                                CurrentClient.MiddleName = middleNameTextBox.Text.Substring(0, 1).ToUpper() + middleNameTextBox.Text.Substring(1, middleNameTextBox.Text.Length - 1);
                                            }
                                            AppData.Context.Client.Add(CurrentClient);
                                            AppData.Context.SaveChanges();
                                            MessageBox.Show("Обучающийся успешно добавлен!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                                            NavigationService.GoBack();
                                        }
                                        else
                                        {
                                            CurrentClient.LastName = lastNameTextBox.Text.Substring(0, 1).ToUpper() + lastNameTextBox.Text.Substring(1, lastNameTextBox.Text.Length - 1);
                                            CurrentClient.FirstName = firstNameTextBox.Text.Substring(0, 1).ToUpper() + firstNameTextBox.Text.Substring(1, firstNameTextBox.Text.Length - 1);
                                            if (!String.IsNullOrWhiteSpace(middleNameTextBox.Text))
                                            {
                                                CurrentClient.MiddleName = middleNameTextBox.Text.Substring(0, 1).ToUpper() + middleNameTextBox.Text.Substring(1, middleNameTextBox.Text.Length - 1);
                                            }
                                            else
                                            {
                                                CurrentClient.MiddleName = middleNameTextBox.Text;
                                            }
                                            CurrentClient.DateOfBirth = Convert.ToDateTime(dateOfBirthDatePicker.SelectedDate.Value.ToShortDateString());
                                            CurrentClient.PhoneNumber = phoneNumberTextBox.Text;
                                            CurrentClient.Zoom = zoomTextBox.Text;
                                            CurrentClient.Skype = skypeTextBox.Text;
                                            CurrentClient.FavoriteTime = timeComboBox.Text;
                                            CurrentClient.IsDeleted = false;
                                            AppData.Context.SaveChanges();
                                            MessageBox.Show("Информация обновлена!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                                            NavigationService.GoBack();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Выберите время обучения!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Дата рождения указана некорректно!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                                    dateOfBirthDatePicker.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Номер телефона указан некорректно!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                                phoneNumberTextBox.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Отчество указано некорректно!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                            middleNameTextBox.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Имя указано некорректно!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        firstNameTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Фамилия указана некорректно!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    lastNameTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
