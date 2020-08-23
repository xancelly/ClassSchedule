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
                    if (item.DayOfWeek.Name == "Monday")
                    {
                        mondayCheckBox.IsChecked = true;
                        mondayStartComboBox.Text = Convert.ToString(item.StartTimeWork).Remove(5,3);
                        mondayEndComboBox.Text = Convert.ToString(item.EndTimeWork).Remove(5, 3);
                    }

                    if (item.DayOfWeek.Name == "Tuesday")
                    {
                        tuesdayCheckBox.IsChecked = true;
                        tuesdayStartComboBox.Text = Convert.ToString(item.StartTimeWork).Remove(5, 3);
                        tuesdayEndComboBox.Text = Convert.ToString(item.EndTimeWork).Remove(5, 3);
                    }

                    if (item.DayOfWeek.Name == "Wednesday")
                    {
                        wednesdayCheckBox.IsChecked = true;
                        wednesdayStartComboBox.Text = Convert.ToString(item.StartTimeWork).Remove(5, 3);
                        wednesdayEndComboBox.Text = Convert.ToString(item.EndTimeWork).Remove(5, 3);
                    }

                    if (item.DayOfWeek.Name == "Thursday")
                    {
                        thursdayCheckBox.IsChecked = true;
                        thursdayStartComboBox.Text = Convert.ToString(item.StartTimeWork).Remove(5, 3);
                        thursdayEndComboBox.Text = Convert.ToString(item.EndTimeWork).Remove(5, 3);
                    }

                    if (item.DayOfWeek.Name == "Friday")
                    {
                        fridayCheckBox.IsChecked = true;
                        fridayStartComboBox.Text = Convert.ToString(item.StartTimeWork).Remove(5, 3);
                        fridayEndComboBox.Text = Convert.ToString(item.EndTimeWork).Remove(5, 3);
                    }

                    if (item.DayOfWeek.Name == "Saturday")
                    {
                        saturdayCheckBox.IsChecked = true;
                        saturdayStartComboBox.Text = Convert.ToString(item.StartTimeWork).Remove(5, 3);
                        saturdayEndComboBox.Text = Convert.ToString(item.EndTimeWork).Remove(5, 3);
                    }

                    if (item.DayOfWeek.Name == "Sunday")
                    {
                        sundayCheckBox.IsChecked = true;
                        sundayStartComboBox.Text = Convert.ToString(item.StartTimeWork).Remove(5, 3);
                        sundayEndComboBox.Text = Convert.ToString(item.EndTimeWork).Remove(5, 3);
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
                if ((mondayStartComboBox.SelectedItem != null && mondayEndComboBox.SelectedItem != null) || (tuesdayStartComboBox.SelectedItem != null && tuesdayEndComboBox.SelectedItem != null) || (wednesdayStartComboBox.SelectedItem != null && wednesdayEndComboBox.SelectedItem != null) || (thursdayStartComboBox.SelectedItem != null && thursdayEndComboBox.SelectedItem != null) || (fridayStartComboBox.SelectedItem != null && fridayEndComboBox.SelectedItem != null) || (saturdayStartComboBox.SelectedItem != null && saturdayEndComboBox.SelectedItem != null) || (sundayStartComboBox.SelectedItem != null && sundayEndComboBox.SelectedItem != null))
                {
                    if (lastNameTextBox.Text.IndexOfAny(numList.ToCharArray()) <= -1)
                    {
                        if (firstNameTextBox.Text.IndexOfAny(numList.ToCharArray()) <= -1)
                        {
                            if (middleNameTextBox.Text.IndexOfAny(numList.ToCharArray()) <= -1)
                            {
                                if (phoneNumberTextBox.Text.Length == 18 && (phoneNumberTextBox.Text.IndexOfAny(letterList.ToCharArray()) <= -1) && !phoneNumberTextBox.Text.Contains('_'))
                                {
                                    if (mondayCheckBox.IsChecked == true || tuesdayCheckBox.IsChecked == true || wednesdayCheckBox.IsChecked == true || thursdayCheckBox.IsChecked == true || fridayCheckBox.IsChecked == true || saturdayCheckBox.IsChecked == true || sundayCheckBox.IsChecked == true)
                                    {
                                        if ((mondayStartComboBox.Text != null && mondayEndComboBox != null && mondayStartComboBox.SelectedIndex < mondayEndComboBox.SelectedIndex) || (tuesdayStartComboBox.Text != null && tuesdayEndComboBox != null && tuesdayStartComboBox.SelectedIndex < tuesdayEndComboBox.SelectedIndex) || (wednesdayStartComboBox.Text != null && wednesdayEndComboBox != null && wednesdayStartComboBox.SelectedIndex < wednesdayEndComboBox.SelectedIndex) || (thursdayStartComboBox.Text != null && thursdayEndComboBox != null && thursdayStartComboBox.SelectedIndex < thursdayEndComboBox.SelectedIndex) || (fridayStartComboBox.Text != null && fridayEndComboBox != null && fridayStartComboBox.SelectedIndex < fridayEndComboBox.SelectedIndex) || (saturdayStartComboBox.Text != null && saturdayEndComboBox != null && saturdayStartComboBox.SelectedIndex < saturdayEndComboBox.SelectedIndex) || (sundayStartComboBox.Text != null && sundayEndComboBox != null && sundayStartComboBox.SelectedIndex < sundayEndComboBox.SelectedIndex))
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
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Monday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(mondayStartComboBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(mondayEndComboBox.Text),
                                                            });
                                                    };

                                                    if (tuesdayCheckBox.IsChecked == true)
                                                    {
                                                        CurrentTeacher.TeacherDayOfWeek.Add(
                                                            new TeacherDayOfWeek
                                                            {
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Tuesday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(tuesdayStartComboBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(tuesdayEndComboBox.Text),
                                                            });
                                                    };

                                                    if (wednesdayCheckBox.IsChecked == true)
                                                    {
                                                        CurrentTeacher.TeacherDayOfWeek.Add(
                                                            new TeacherDayOfWeek
                                                            {
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Wednesday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(wednesdayStartComboBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(wednesdayEndComboBox.Text),
                                                            });
                                                    };

                                                    if (thursdayCheckBox.IsChecked == true)
                                                    {
                                                        CurrentTeacher.TeacherDayOfWeek.Add(
                                                            new TeacherDayOfWeek
                                                            {
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Thursday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(thursdayStartComboBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(thursdayEndComboBox.Text),
                                                            });
                                                    };

                                                    if (fridayCheckBox.IsChecked == true)
                                                    {
                                                        CurrentTeacher.TeacherDayOfWeek.Add(
                                                            new TeacherDayOfWeek
                                                            {
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Friday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(fridayStartComboBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(fridayEndComboBox.Text),
                                                            });
                                                    };

                                                    if (saturdayCheckBox.IsChecked == true)
                                                    {
                                                        CurrentTeacher.TeacherDayOfWeek.Add(
                                                            new TeacherDayOfWeek
                                                            {
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Saturday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(saturdayStartComboBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(saturdayEndComboBox.Text),
                                                            });
                                                    };

                                                    if (sundayCheckBox.IsChecked == true)
                                                    {
                                                        CurrentTeacher.TeacherDayOfWeek.Add(
                                                            new TeacherDayOfWeek
                                                            {
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Sunday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(sundayStartComboBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(sundayEndComboBox.Text),
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
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Monday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(mondayStartComboBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(mondayEndComboBox.Text),
                                                            });
                                                    };

                                                    if (tuesdayCheckBox.IsChecked == true)
                                                    {
                                                        CurrentTeacher.TeacherDayOfWeek.Add(
                                                            new TeacherDayOfWeek
                                                            {
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Tuesday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(tuesdayStartComboBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(tuesdayEndComboBox.Text),
                                                            });
                                                    };

                                                    if (wednesdayCheckBox.IsChecked == true)
                                                    {
                                                        CurrentTeacher.TeacherDayOfWeek.Add(
                                                            new TeacherDayOfWeek
                                                            {
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Wednesday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(wednesdayStartComboBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(wednesdayEndComboBox.Text),
                                                            });
                                                    };

                                                    if (thursdayCheckBox.IsChecked == true)
                                                    {
                                                        CurrentTeacher.TeacherDayOfWeek.Add(
                                                            new TeacherDayOfWeek
                                                            {
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Thursday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(thursdayStartComboBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(thursdayEndComboBox.Text),
                                                            });
                                                    };

                                                    if (fridayCheckBox.IsChecked == true)
                                                    {
                                                        CurrentTeacher.TeacherDayOfWeek.Add(
                                                            new TeacherDayOfWeek
                                                            {
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Friday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(fridayStartComboBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(fridayEndComboBox.Text),
                                                            });
                                                    };

                                                    if (saturdayCheckBox.IsChecked == true)
                                                    {
                                                        CurrentTeacher.TeacherDayOfWeek.Add(
                                                            new TeacherDayOfWeek
                                                            {
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Saturday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(saturdayStartComboBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(saturdayEndComboBox.Text),
                                                            });
                                                    };

                                                    if (sundayCheckBox.IsChecked == true)
                                                    {
                                                        CurrentTeacher.TeacherDayOfWeek.Add(
                                                            new TeacherDayOfWeek
                                                            {
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Sunday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(sundayStartComboBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(sundayEndComboBox.Text),
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
                                            MessageBox.Show("Некорректные ввод рабочего времени преподавателя!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("У преподавателя должен быть хотя бы один рабочий день!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
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
                    MessageBox.Show("Укажите рабочие часы преподавателя!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            } else
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
