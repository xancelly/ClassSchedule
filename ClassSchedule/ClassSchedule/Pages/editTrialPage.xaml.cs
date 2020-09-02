using ClassSchedule.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    /// Логика взаимодействия для editTrialPage.xaml
    /// </summary>
    public partial class editTrialPage : Page
    {
        TrialLesson CurrentTrialLesson = null;
        public editTrialPage(TrialLesson trialLesson)
        {
            InitializeComponent();
            languageLevelComboBox.ItemsSource = AppData.Context.LanguageLevel.ToList();
            CurrentTrialLesson = trialLesson;
            if (CurrentTrialLesson != null)
            {
                if (Properties.Settings.Default.dateStart != "0" && Properties.Settings.Default.timeStart != "0")
                {
                    this.Title = $"Редактирование пробного занятия \nна {Properties.Settings.Default.dateStart} в {Properties.Settings.Default.timeStart}";
                } else
                {
                    this.Title = $"Редактирование пробного занятия \nна {CurrentTrialLesson.Date.Value.ToShortDateString()} в {CurrentTrialLesson.Time}";
                }
                
                lastNameTextBox.Text = CurrentTrialLesson.LastName;
                firstNameTextBox.Text = CurrentTrialLesson.FirstName;
                middleNameTextBox.Text = CurrentTrialLesson.MiddleName;
                phoneNumberTextBox.Text = CurrentTrialLesson.PhoneNumber;
                emailTextBox.Text = CurrentTrialLesson.Email;
                commentTextBox.Text = CurrentTrialLesson.Comment;
                languageLevelComboBox.SelectedItem = CurrentTrialLesson.LanguageLevel;
            }
            else
            {
                this.Title = $"Добавление пробного занятия на {Properties.Settings.Default.dateStart} \nв {Properties.Settings.Default.timeStart}";
            }
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            string letterList = "ABCDEFGHIJKLMNOPRSTUVWXYZabcdefghijklmnoprstuvwxyzАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string numList = "1234567890";
            if (!String.IsNullOrWhiteSpace(lastNameTextBox.Text) && !String.IsNullOrWhiteSpace(firstNameTextBox.Text) && !String.IsNullOrWhiteSpace(phoneNumberTextBox.Text) && !String.IsNullOrWhiteSpace(emailTextBox.Text) && !String.IsNullOrWhiteSpace(commentTextBox.Text) && languageLevelComboBox.SelectedItem != null)
            {
                if (lastNameTextBox.Text.IndexOfAny(numList.ToCharArray()) <= -1)
                {
                    if (firstNameTextBox.Text.IndexOfAny(numList.ToCharArray()) <= -1)
                    {
                        if (middleNameTextBox.Text.IndexOfAny(numList.ToCharArray()) <= -1)
                        {
                            if (phoneNumberTextBox.Text.IndexOfAny(letterList.ToCharArray()) <= -1)
                            {
                                if (new EmailAddressAttribute().IsValid(emailTextBox.Text))
                                {
                                    if (CurrentTrialLesson == null)
                                    {
                                        CurrentTrialLesson = new TrialLesson()
                                        {
                                            LastName = lastNameTextBox.Text.Substring(0, 1).ToUpper() + lastNameTextBox.Text.Substring(1, lastNameTextBox.Text.Length - 1),
                                            FirstName = firstNameTextBox.Text.Substring(0, 1).ToUpper() + firstNameTextBox.Text.Substring(1, firstNameTextBox.Text.Length - 1),
                                            PhoneNumber = phoneNumberTextBox.Text,
                                            Email = emailTextBox.Text,
                                            Comment = commentTextBox.Text,
                                            LanguageLevel = languageLevelComboBox.SelectedItem as LanguageLevel,
                                            Time = Properties.Settings.Default.timeStart,
                                            Date = Convert.ToDateTime(Properties.Settings.Default.dateStart),
                                            IsDeleted = false,
                                        };
                                        if (!String.IsNullOrWhiteSpace(middleNameTextBox.Text))
                                        {
                                            CurrentTrialLesson.MiddleName = middleNameTextBox.Text.Substring(0, 1).ToUpper() + middleNameTextBox.Text.Substring(1, middleNameTextBox.Text.Length - 1);
                                        }
                                        AppData.Context.TrialLesson.Add(CurrentTrialLesson);
                                        AppData.Context.SaveChanges();
                                        MessageBox.Show("Пробное занятие успешно добавлено!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                                        NavigationService.GoBack();
                                    } else
                                    {
                                        CurrentTrialLesson.LastName = lastNameTextBox.Text.Substring(0, 1).ToUpper() + lastNameTextBox.Text.Substring(1, lastNameTextBox.Text.Length - 1);
                                        CurrentTrialLesson.FirstName = firstNameTextBox.Text.Substring(0, 1).ToUpper() + firstNameTextBox.Text.Substring(1, firstNameTextBox.Text.Length - 1);
                                        if (!String.IsNullOrWhiteSpace(middleNameTextBox.Text))
                                        {
                                            CurrentTrialLesson.MiddleName = middleNameTextBox.Text.Substring(0, 1).ToUpper() + middleNameTextBox.Text.Substring(1, middleNameTextBox.Text.Length - 1);
                                        }
                                        else
                                        {
                                            CurrentTrialLesson.MiddleName = middleNameTextBox.Text;
                                        }
                                        CurrentTrialLesson.PhoneNumber = phoneNumberTextBox.Text;
                                        CurrentTrialLesson.Email = emailTextBox.Text;
                                        CurrentTrialLesson.Comment = commentTextBox.Text;
                                        CurrentTrialLesson.LanguageLevel = languageLevelComboBox.SelectedItem as LanguageLevel;
                                        AppData.Context.SaveChanges();
                                        MessageBox.Show("Информация обновлена!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                                        NavigationService.GoBack();
                                    }

                                } else
                                {
                                    MessageBox.Show("E-Mail указан некорректно!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                                    emailTextBox.Focus();
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
