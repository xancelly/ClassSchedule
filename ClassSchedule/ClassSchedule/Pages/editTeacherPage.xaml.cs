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
    /// Логика взаимодействия для editTeacherPage.xaml
    /// </summary>
    public partial class editTeacherPage : Page
    {
        Teacher CurrentTeacher = null;
        public editTeacherPage(Teacher teacher)
        {
            InitializeComponent();
            CurrentTeacher = teacher;
            if (CurrentTeacher != null)
            {
                this.Title = "Редактирование преподавателя";
                lastNameTextBox.Text = CurrentTeacher.LastName;
                firstNameTextBox.Text = CurrentTeacher.FirstName;
                middleNameTextBox.Text = CurrentTeacher.MiddleName;
                phoneNumberTextBox.Text = CurrentTeacher.PhoneNumber;
                dateOfBirthDatePicker.SelectedDate = CurrentTeacher.DateOfBirth;
                zoomTextBox.Text = CurrentTeacher.Zoom;
                skypeTextBox.Text = CurrentTeacher.Skype;
                timeComboBox.Text = CurrentTeacher.FavoriteTime;
            }
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            string letterList = "ABCDEFGHIJKLMNOPRSTUVWXYZabcdefghijklmnoprstuvwxyzАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string numList = "1234567890";
            if (!String.IsNullOrWhiteSpace(lastNameTextBox.Text) && !String.IsNullOrWhiteSpace(firstNameTextBox.Text) && !String.IsNullOrWhiteSpace(phoneNumberTextBox.Text) && !String.IsNullOrWhiteSpace(zoomTextBox.Text) && !String.IsNullOrWhiteSpace(skypeTextBox.Text) && dateOfBirthDatePicker.SelectedDate != null && timeComboBox.SelectedItem != null)
            {
                if (lastNameTextBox.Text.IndexOfAny(numList.ToCharArray()) <= -1)
                {
                    if (firstNameTextBox.Text.IndexOfAny(numList.ToCharArray()) <= -1)
                    {
                        if (middleNameTextBox.Text.IndexOfAny(numList.ToCharArray()) <= -1)
                        {
                            if (phoneNumberTextBox.Text.Length == 18 && (phoneNumberTextBox.Text.IndexOfAny(letterList.ToCharArray()) <= -1) && !phoneNumberTextBox.Text.Contains('_'))
                            {
                                if (dateOfBirthDatePicker.SelectedDate < DateTime.Today)
                                {
                                    if (timeComboBox.SelectedItem.ToString() != "Не выбрано")
                                    {
                                        if (CurrentTeacher == null)
                                        {
                                            CurrentTeacher = new Teacher()
                                            {
                                                LastName = lastNameTextBox.Text.Substring(0, 1).ToUpper() + lastNameTextBox.Text.Substring(1, lastNameTextBox.Text.Length - 1),
                                                FirstName = firstNameTextBox.Text.Substring(0, 1).ToUpper() + firstNameTextBox.Text.Substring(1, firstNameTextBox.Text.Length - 1),
                                                MiddleName = middleNameTextBox.Text.Substring(0, 1).ToUpper() + middleNameTextBox.Text.Substring(1, middleNameTextBox.Text.Length - 1),
                                                DateOfBirth = Convert.ToDateTime(dateOfBirthDatePicker.SelectedDate.Value.ToShortDateString()),
                                                PhoneNumber = phoneNumberTextBox.Text,
                                                FavoriteTime = timeComboBox.Text,
                                                Skype = skypeTextBox.Text,
                                                Zoom = zoomTextBox.Text,
                                                IsDeleted = false,
                                            };
                                            AppData.Context.Teacher.Add(CurrentTeacher);
                                            AppData.Context.SaveChanges();
                                            MessageBox.Show("Преподаватель успешно добавлен!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                                            NavigationService.GoBack();
                                        }
                                        else
                                        {
                                            CurrentTeacher.LastName = lastNameTextBox.Text.Substring(0, 1).ToUpper() + lastNameTextBox.Text.Substring(1, lastNameTextBox.Text.Length - 1);
                                            CurrentTeacher.FirstName = firstNameTextBox.Text.Substring(0, 1).ToUpper() + firstNameTextBox.Text.Substring(1, firstNameTextBox.Text.Length - 1);
                                            CurrentTeacher.MiddleName = middleNameTextBox.Text.Substring(0, 1).ToUpper() + middleNameTextBox.Text.Substring(1, middleNameTextBox.Text.Length - 1);
                                            CurrentTeacher.DateOfBirth = Convert.ToDateTime(dateOfBirthDatePicker.SelectedDate.Value.ToShortDateString());
                                            CurrentTeacher.PhoneNumber = phoneNumberTextBox.Text;
                                            CurrentTeacher.Zoom = zoomTextBox.Text;
                                            CurrentTeacher.Skype = skypeTextBox.Text;
                                            CurrentTeacher.FavoriteTime = timeComboBox.Text;
                                            CurrentTeacher.IsDeleted = false;
                                            AppData.Context.SaveChanges();
                                            MessageBox.Show("Информация обновлена!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                                            NavigationService.GoBack();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Выберите время преподавания!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
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
