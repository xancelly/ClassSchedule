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

                foreach (var item in AppData.Context.TeacherDayOfWeek.Where(c => c.Teacher.Id == CurrentTeacher.Id))
                {
                    if (item.DayOfWeek.Name == "Понедельник")
                    {
                        mondayCheckBox.IsChecked = true;
                        mondayStartComboBox.Text = item.StartTimeWork;
                        mondayEndComboBox.Text = item.EndTimeWork;
                    }

                    if (item.DayOfWeek.Name == "Вторник")
                    {
                        tuesdayCheckBox.IsChecked = true;
                        tuesdayStartComboBox.Text = item.StartTimeWork;
                        tuesdayEndComboBox.Text = item.EndTimeWork;
                    }

                    if (item.DayOfWeek.Name == "Среда")
                    {
                        wednesdayCheckBox.IsChecked = true;
                        wednesdayStartComboBox.Text = item.StartTimeWork;
                        wednesdayEndComboBox.Text = item.EndTimeWork;
                    }

                    if (item.DayOfWeek.Name == "Четверг")
                    {
                        thursdayCheckBox.IsChecked = true;
                        thursdayStartComboBox.Text = item.StartTimeWork;
                        thursdayEndComboBox.Text = item.EndTimeWork;
                    }

                    if (item.DayOfWeek.Name == "Пятница")
                    {
                        fridayCheckBox.IsChecked = true;
                        fridayStartComboBox.Text = item.StartTimeWork;
                        fridayEndComboBox.Text = item.EndTimeWork;
                    }

                    if (item.DayOfWeek.Name == "Суббота")
                    {
                        saturdayCheckBox.IsChecked = true;
                        saturdayStartComboBox.Text = item.StartTimeWork;
                        saturdayEndComboBox.Text = item.EndTimeWork;
                    }

                    if (item.DayOfWeek.Name == "Воскресенье")
                    {
                        sundayCheckBox.IsChecked = true;
                        sundayStartComboBox.Text = item.StartTimeWork;
                        sundayEndComboBox.Text = item.EndTimeWork;
                    }
                }
            }
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            string letterList = "ABCDEFGHIJKLMNOPRSTUVWXYZabcdefghijklmnoprstuvwxyzАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string numList = "1234567890";
            if (!String.IsNullOrWhiteSpace(lastNameTextBox.Text) && !String.IsNullOrWhiteSpace(firstNameTextBox.Text) && !String.IsNullOrWhiteSpace(phoneNumberTextBox.Text) && !String.IsNullOrWhiteSpace(zoomTextBox.Text) && dateOfBirthDatePicker.SelectedDate != null)
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
                                        if (CurrentTeacher == null)
                                        {
                                            CurrentTeacher = new Teacher()
                                            {
                                                LastName = lastNameTextBox.Text.Substring(0, 1).ToUpper() + lastNameTextBox.Text.Substring(1, lastNameTextBox.Text.Length - 1),
                                                FirstName = firstNameTextBox.Text.Substring(0, 1).ToUpper() + firstNameTextBox.Text.Substring(1, firstNameTextBox.Text.Length - 1),
                                                MiddleName = middleNameTextBox.Text.Substring(0, 1).ToUpper() + middleNameTextBox.Text.Substring(1, middleNameTextBox.Text.Length - 1),
                                                DateOfBirth = Convert.ToDateTime(dateOfBirthDatePicker.SelectedDate.Value.ToShortDateString()),
                                                PhoneNumber = phoneNumberTextBox.Text,
                                                Skype = skypeTextBox.Text,
                                                Zoom = zoomTextBox.Text,
                                                IsDeleted = false,
                                            };
                                        AppData.Context.Teacher.Add(CurrentTeacher);

                                        if (mondayCheckBox.IsChecked == true)
                                        {
                                            CurrentTeacher.TeacherDayOfWeek.Add(
                                                new TeacherDayOfWeek
                                                {
                                                    DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Понедельник").FirstOrDefault(),
                                                    StartTimeWork = mondayStartComboBox.Text,
                                                    EndTimeWork = mondayEndComboBox.Text,
                                                });
                                        };

                                        if (tuesdayCheckBox.IsChecked == true)
                                        {
                                            CurrentTeacher.TeacherDayOfWeek.Add(
                                                new TeacherDayOfWeek
                                                {
                                                    DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Вторник").FirstOrDefault(),
                                                    StartTimeWork = tuesdayStartComboBox.Text,
                                                    EndTimeWork = tuesdayEndComboBox.Text,
                                                });
                                        };

                                        if (wednesdayCheckBox.IsChecked == true)
                                        {
                                            CurrentTeacher.TeacherDayOfWeek.Add(
                                                new TeacherDayOfWeek
                                                {
                                                    DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Среда").FirstOrDefault(),
                                                    StartTimeWork = wednesdayStartComboBox.Text,
                                                    EndTimeWork = wednesdayEndComboBox.Text,
                                                });
                                        };

                                        if (thursdayCheckBox.IsChecked == true)
                                        {
                                            CurrentTeacher.TeacherDayOfWeek.Add(
                                                new TeacherDayOfWeek
                                                {
                                                    DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Четверг").FirstOrDefault(),
                                                    StartTimeWork = thursdayStartComboBox.Text,
                                                    EndTimeWork = thursdayEndComboBox.Text,
                                                });
                                        };

                                        if (fridayCheckBox.IsChecked == true)
                                        {
                                            CurrentTeacher.TeacherDayOfWeek.Add(
                                                new TeacherDayOfWeek
                                                {
                                                    DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Пятница").FirstOrDefault(),
                                                    StartTimeWork = fridayStartComboBox.Text,
                                                    EndTimeWork = fridayEndComboBox.Text,
                                                });
                                        };

                                        if (saturdayCheckBox.IsChecked == true)
                                        {
                                            CurrentTeacher.TeacherDayOfWeek.Add(
                                                new TeacherDayOfWeek
                                                {
                                                    DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Суббота").FirstOrDefault(),
                                                    StartTimeWork = saturdayStartComboBox.Text,
                                                    EndTimeWork = saturdayEndComboBox.Text,
                                                });
                                        };

                                        if (sundayCheckBox.IsChecked == true)
                                        {
                                            CurrentTeacher.TeacherDayOfWeek.Add(
                                                new TeacherDayOfWeek
                                                {
                                                    DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Воскресенье").FirstOrDefault(),
                                                    StartTimeWork = sundayStartComboBox.Text,
                                                    EndTimeWork = sundayEndComboBox.Text,
                                                });
                                        };
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
                                            CurrentTeacher.IsDeleted = false;

                                        AppData.Context.TeacherDayOfWeek.RemoveRange(AppData.Context.TeacherDayOfWeek.ToList().Where(c => c.Teacher.Id == CurrentTeacher.Id));
                                        if (mondayCheckBox.IsChecked == true)
                                        {
                                            CurrentTeacher.TeacherDayOfWeek.Add(
                                                new TeacherDayOfWeek
                                                {
                                                    DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Понедельник").FirstOrDefault(),
                                                    StartTimeWork = mondayStartComboBox.Text,
                                                    EndTimeWork = mondayEndComboBox.Text,
                                                });
                                        };

                                        if (tuesdayCheckBox.IsChecked == true)
                                        {
                                            CurrentTeacher.TeacherDayOfWeek.Add(
                                                new TeacherDayOfWeek
                                                {
                                                    DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Вторник").FirstOrDefault(),
                                                    StartTimeWork = tuesdayStartComboBox.Text,
                                                    EndTimeWork = tuesdayEndComboBox.Text,
                                                });
                                        };

                                        if (wednesdayCheckBox.IsChecked == true)
                                        {
                                            CurrentTeacher.TeacherDayOfWeek.Add(
                                                new TeacherDayOfWeek
                                                {
                                                    DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Среда").FirstOrDefault(),
                                                    StartTimeWork = wednesdayStartComboBox.Text,
                                                    EndTimeWork = wednesdayEndComboBox.Text,
                                                });
                                        };

                                        if (thursdayCheckBox.IsChecked == true)
                                        {
                                            CurrentTeacher.TeacherDayOfWeek.Add(
                                                new TeacherDayOfWeek
                                                {
                                                    DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Четверг").FirstOrDefault(),
                                                    StartTimeWork = thursdayStartComboBox.Text,
                                                    EndTimeWork = thursdayEndComboBox.Text,
                                                });
                                        };

                                        if (fridayCheckBox.IsChecked == true)
                                        {
                                            CurrentTeacher.TeacherDayOfWeek.Add(
                                                new TeacherDayOfWeek
                                                {
                                                    DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Пятница").FirstOrDefault(),
                                                    StartTimeWork = fridayStartComboBox.Text,
                                                    EndTimeWork = fridayEndComboBox.Text,
                                                });
                                        };

                                        if (saturdayCheckBox.IsChecked == true)
                                        {
                                            CurrentTeacher.TeacherDayOfWeek.Add(
                                                new TeacherDayOfWeek
                                                {
                                                    DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Суббота").FirstOrDefault(),
                                                    StartTimeWork = saturdayStartComboBox.Text,
                                                    EndTimeWork = saturdayEndComboBox.Text,
                                                });
                                        };

                                        if (sundayCheckBox.IsChecked == true)
                                        {
                                            CurrentTeacher.TeacherDayOfWeek.Add(
                                                new TeacherDayOfWeek
                                                {
                                                    DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Воскресенье").FirstOrDefault(),
                                                    StartTimeWork = sundayStartComboBox.Text,
                                                    EndTimeWork = sundayEndComboBox.Text,
                                                });
                                        };

                                        AppData.Context.SaveChanges();
                                            MessageBox.Show("Информация обновлена!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                                            NavigationService.GoBack();
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

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            //понедельник
            if (mondayCheckBox.IsChecked == true)
            {
                mondayStackPanel.Visibility = Visibility.Visible;
            } else
            {
                mondayStackPanel.Visibility = Visibility.Hidden;
            }

            //вторник
            if (tuesdayCheckBox.IsChecked == true)
            {
                tuesdayStackPanel.Visibility = Visibility.Visible;
            }
            else
            {
                tuesdayStackPanel.Visibility = Visibility.Hidden;
            }

            //среда
            if (wednesdayCheckBox.IsChecked == true)
            {
                wednesdayStackPanel.Visibility = Visibility.Visible;
            }
            else
            {
                wednesdayStackPanel.Visibility = Visibility.Hidden;
            }

            //четверг
            if (thursdayCheckBox.IsChecked == true)
            {
                thursdayStackPanel.Visibility = Visibility.Visible;
            }
            else
            {
                thursdayStackPanel.Visibility = Visibility.Hidden;
            }

            //пятница
            if (fridayCheckBox.IsChecked == true)
            {
                fridayStackPanel.Visibility = Visibility.Visible;
            }
            else
            {
                fridayStackPanel.Visibility = Visibility.Hidden;
            }

            //суббота
            if (saturdayCheckBox.IsChecked == true)
            {
                saturdayStackPanel.Visibility = Visibility.Visible;
            }
            else
            {
                saturdayStackPanel.Visibility = Visibility.Hidden;
            }

            //воскресенье
            if (sundayCheckBox.IsChecked == true)
            {
                sundayStackPanel.Visibility = Visibility.Visible;
            }
            else
            {
                sundayStackPanel.Visibility = Visibility.Hidden;
            }
        }
    }
}
