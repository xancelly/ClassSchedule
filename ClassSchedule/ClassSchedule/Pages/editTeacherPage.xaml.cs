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
                emailTextBox.Text = CurrentTeacher.Email;
                commentTextBox.Text = CurrentTeacher.Comment;

                foreach (var item in AppData.Context.TeacherDayOfWeek.Where(c => c.Teacher.Id == CurrentTeacher.Id))
                {
                    if (item.DayOfWeek.Name == "Monday")
                    {
                        mondayCheckBox.IsChecked = true;
                        mondayStartTextBox.Text = Convert.ToString(item.StartTimeWork).Remove(5, 3);
                        mondayEndTextBox.Text = Convert.ToString(item.EndTimeWork).Remove(5, 3);
                    }

                    if (item.DayOfWeek.Name == "Tuesday")
                    {
                        tuesdayCheckBox.IsChecked = true;
                        tuesdayStartTextBox.Text = Convert.ToString(item.StartTimeWork).Remove(5, 3);
                        tuesdayEndTextBox.Text = Convert.ToString(item.EndTimeWork).Remove(5, 3);
                    }

                    if (item.DayOfWeek.Name == "Wednesday")
                    {
                        wednesdayCheckBox.IsChecked = true;
                        wednesdayStartTextBox.Text = Convert.ToString(item.StartTimeWork).Remove(5, 3);
                        wednesdayEndTextBox.Text = Convert.ToString(item.EndTimeWork).Remove(5, 3);
                    }

                    if (item.DayOfWeek.Name == "Thursday")
                    {
                        thursdayCheckBox.IsChecked = true;
                        thursdayStartTextBox.Text = Convert.ToString(item.StartTimeWork).Remove(5, 3);
                        thursdayEndTextBox.Text = Convert.ToString(item.EndTimeWork).Remove(5, 3);
                    }

                    if (item.DayOfWeek.Name == "Friday")
                    {
                        fridayCheckBox.IsChecked = true;
                        fridayStartTextBox.Text = Convert.ToString(item.StartTimeWork).Remove(5, 3);
                        fridayEndTextBox.Text = Convert.ToString(item.EndTimeWork).Remove(5, 3);
                    }

                    if (item.DayOfWeek.Name == "Saturday")
                    {
                        saturdayCheckBox.IsChecked = true;
                        saturdayStartTextBox.Text = Convert.ToString(item.StartTimeWork).Remove(5, 3);
                        saturdayEndTextBox.Text = Convert.ToString(item.EndTimeWork).Remove(5, 3);
                    }

                    if (item.DayOfWeek.Name == "Sunday")
                    {
                        sundayCheckBox.IsChecked = true;
                        sundayStartTextBox.Text = Convert.ToString(item.StartTimeWork).Remove(5, 3);
                        sundayEndTextBox.Text = Convert.ToString(item.EndTimeWork).Remove(5, 3);
                    }
                }
            }
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            string letterList = "ABCDEFGHIJKLMNOPRSTUVWXYZabcdefghijklmnoprstuvwxyzАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string numList = "1234567890";
            if (!String.IsNullOrWhiteSpace(lastNameTextBox.Text) && !String.IsNullOrWhiteSpace(firstNameTextBox.Text) && !String.IsNullOrWhiteSpace(phoneNumberTextBox.Text) && !String.IsNullOrWhiteSpace(emailTextBox.Text) && dateOfBirthDatePicker.SelectedDate != null)
            {
                if ((!String.IsNullOrWhiteSpace(mondayStartTextBox.Text) && !mondayStartTextBox.Text.Contains('_') && !String.IsNullOrWhiteSpace(mondayStartTextBox.Text) && !mondayEndTextBox.Text.Contains('_')) || (!String.IsNullOrWhiteSpace(tuesdayStartTextBox.Text) && !tuesdayStartTextBox.Text.Contains('_') && !String.IsNullOrWhiteSpace(tuesdayStartTextBox.Text) && !tuesdayEndTextBox.Text.Contains('_')) || (!String.IsNullOrWhiteSpace(wednesdayStartTextBox.Text) && !wednesdayStartTextBox.Text.Contains('_') && !String.IsNullOrWhiteSpace(wednesdayStartTextBox.Text) && !wednesdayEndTextBox.Text.Contains('_')) || (!String.IsNullOrWhiteSpace(thursdayStartTextBox.Text) && !thursdayStartTextBox.Text.Contains('_') && !String.IsNullOrWhiteSpace(thursdayStartTextBox.Text) && !thursdayEndTextBox.Text.Contains('_')) || (!String.IsNullOrWhiteSpace(fridayStartTextBox.Text) && !fridayStartTextBox.Text.Contains('_') && !String.IsNullOrWhiteSpace(fridayStartTextBox.Text) && !fridayEndTextBox.Text.Contains('_')) || (!String.IsNullOrWhiteSpace(saturdayStartTextBox.Text) && !saturdayStartTextBox.Text.Contains('_') && !String.IsNullOrWhiteSpace(saturdayStartTextBox.Text) && !saturdayEndTextBox.Text.Contains('_')) || (!String.IsNullOrWhiteSpace(sundayStartTextBox.Text) && !sundayStartTextBox.Text.Contains('_') && !String.IsNullOrWhiteSpace(sundayStartTextBox.Text) && !sundayEndTextBox.Text.Contains('_')))
                {
                    if (new EmailAddressAttribute().IsValid(emailTextBox.Text))
                    {
                        if (lastNameTextBox.Text.IndexOfAny(numList.ToCharArray()) <= -1)
                        {
                            if (firstNameTextBox.Text.IndexOfAny(numList.ToCharArray()) <= -1)
                            {
                                if (middleNameTextBox.Text.IndexOfAny(numList.ToCharArray()) <= -1)
                                {
                                    if (phoneNumberTextBox.Text.IndexOfAny(letterList.ToCharArray()) <= -1)
                                    {
                                        if ((mondayCheckBox.IsChecked == true && TimeSpan.Parse(mondayStartTextBox.Text) < TimeSpan.Parse(mondayEndTextBox.Text)) || (tuesdayCheckBox.IsChecked == true && TimeSpan.Parse(tuesdayStartTextBox.Text) < TimeSpan.Parse(tuesdayEndTextBox.Text)) || (wednesdayCheckBox.IsChecked == true && TimeSpan.Parse(wednesdayStartTextBox.Text) < TimeSpan.Parse(wednesdayEndTextBox.Text)) || (thursdayCheckBox.IsChecked == true && TimeSpan.Parse(thursdayStartTextBox.Text) < TimeSpan.Parse(thursdayEndTextBox.Text)) || (fridayCheckBox.IsChecked == true && TimeSpan.Parse(fridayStartTextBox.Text) < TimeSpan.Parse(fridayEndTextBox.Text)) || (saturdayCheckBox.IsChecked == true && TimeSpan.Parse(saturdayStartTextBox.Text) < TimeSpan.Parse(saturdayEndTextBox.Text)) || (sundayCheckBox.IsChecked == true && TimeSpan.Parse(sundayStartTextBox.Text) < TimeSpan.Parse(sundayEndTextBox.Text)))
                                        {
                                            if (dateOfBirthDatePicker.SelectedDate < DateTime.Today)
                                            {
                                                if (CurrentTeacher == null)
                                                {
                                                    CurrentTeacher = new Teacher()
                                                    {
                                                        LastName = lastNameTextBox.Text.Substring(0, 1).ToUpper() + lastNameTextBox.Text.Substring(1, lastNameTextBox.Text.Length - 1),
                                                        FirstName = firstNameTextBox.Text.Substring(0, 1).ToUpper() + firstNameTextBox.Text.Substring(1, firstNameTextBox.Text.Length - 1),
                                                        DateOfBirth = Convert.ToDateTime(dateOfBirthDatePicker.SelectedDate.Value.ToShortDateString()),
                                                        PhoneNumber = phoneNumberTextBox.Text,
                                                        Comment = commentTextBox.Text,
                                                        Email = emailTextBox.Text,
                                                        IsDeleted = false,
                                                    };
                                                    if (!String.IsNullOrWhiteSpace(middleNameTextBox.Text))
                                                    {
                                                        CurrentTeacher.MiddleName = middleNameTextBox.Text.Substring(0, 1).ToUpper() + middleNameTextBox.Text.Substring(1, middleNameTextBox.Text.Length - 1);
                                                    }
                                                    AppData.Context.Teacher.Add(CurrentTeacher);

                                                    if (mondayCheckBox.IsChecked == true)
                                                    {
                                                        CurrentTeacher.TeacherDayOfWeek.Add(
                                                            new TeacherDayOfWeek
                                                            {
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Monday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(mondayStartTextBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(mondayEndTextBox.Text),
                                                            });
                                                    };

                                                    if (tuesdayCheckBox.IsChecked == true)
                                                    {
                                                        CurrentTeacher.TeacherDayOfWeek.Add(
                                                            new TeacherDayOfWeek
                                                            {
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Tuesday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(tuesdayStartTextBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(tuesdayEndTextBox.Text),
                                                            });
                                                    };

                                                    if (wednesdayCheckBox.IsChecked == true)
                                                    {
                                                        CurrentTeacher.TeacherDayOfWeek.Add(
                                                            new TeacherDayOfWeek
                                                            {
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Wednesday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(wednesdayStartTextBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(wednesdayEndTextBox.Text),
                                                            });
                                                    };

                                                    if (thursdayCheckBox.IsChecked == true)
                                                    {
                                                        CurrentTeacher.TeacherDayOfWeek.Add(
                                                            new TeacherDayOfWeek
                                                            {
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Thursday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(thursdayStartTextBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(thursdayEndTextBox.Text),
                                                            });
                                                    };

                                                    if (fridayCheckBox.IsChecked == true)
                                                    {
                                                        CurrentTeacher.TeacherDayOfWeek.Add(
                                                            new TeacherDayOfWeek
                                                            {
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Friday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(fridayStartTextBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(fridayEndTextBox.Text),
                                                            });
                                                    };

                                                    if (saturdayCheckBox.IsChecked == true)
                                                    {
                                                        CurrentTeacher.TeacherDayOfWeek.Add(
                                                            new TeacherDayOfWeek
                                                            {
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Saturday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(saturdayStartTextBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(saturdayEndTextBox.Text),
                                                            });
                                                    };

                                                    if (sundayCheckBox.IsChecked == true)
                                                    {
                                                        CurrentTeacher.TeacherDayOfWeek.Add(
                                                            new TeacherDayOfWeek
                                                            {
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Sunday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(sundayStartTextBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(sundayEndTextBox.Text),
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
                                                    if (!String.IsNullOrWhiteSpace(middleNameTextBox.Text))
                                                    {
                                                        CurrentTeacher.MiddleName = middleNameTextBox.Text.Substring(0, 1).ToUpper() + middleNameTextBox.Text.Substring(1, middleNameTextBox.Text.Length - 1);
                                                    }
                                                    else
                                                    {
                                                        CurrentTeacher.MiddleName = middleNameTextBox.Text;
                                                    }
                                                    CurrentTeacher.DateOfBirth = Convert.ToDateTime(dateOfBirthDatePicker.SelectedDate.Value.ToShortDateString());
                                                    CurrentTeacher.PhoneNumber = phoneNumberTextBox.Text;
                                                    CurrentTeacher.Email = emailTextBox.Text;
                                                    CurrentTeacher.Comment = commentTextBox.Text;
                                                    CurrentTeacher.IsDeleted = false;

                                                    AppData.Context.TeacherDayOfWeek.RemoveRange(AppData.Context.TeacherDayOfWeek.ToList().Where(c => c.Teacher.Id == CurrentTeacher.Id));
                                                    if (mondayCheckBox.IsChecked == true)
                                                    {
                                                        CurrentTeacher.TeacherDayOfWeek.Add(
                                                            new TeacherDayOfWeek
                                                            {
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Monday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(mondayStartTextBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(mondayEndTextBox.Text),
                                                            });
                                                    };

                                                    if (tuesdayCheckBox.IsChecked == true)
                                                    {
                                                        CurrentTeacher.TeacherDayOfWeek.Add(
                                                            new TeacherDayOfWeek
                                                            {
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Tuesday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(tuesdayStartTextBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(tuesdayEndTextBox.Text),
                                                            });
                                                    };

                                                    if (wednesdayCheckBox.IsChecked == true)
                                                    {
                                                        CurrentTeacher.TeacherDayOfWeek.Add(
                                                            new TeacherDayOfWeek
                                                            {
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Wednesday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(wednesdayStartTextBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(wednesdayEndTextBox.Text),
                                                            });
                                                    };

                                                    if (thursdayCheckBox.IsChecked == true)
                                                    {
                                                        CurrentTeacher.TeacherDayOfWeek.Add(
                                                            new TeacherDayOfWeek
                                                            {
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Thursday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(thursdayStartTextBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(thursdayEndTextBox.Text),
                                                            });
                                                    };

                                                    if (fridayCheckBox.IsChecked == true)
                                                    {
                                                        CurrentTeacher.TeacherDayOfWeek.Add(
                                                            new TeacherDayOfWeek
                                                            {
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Friday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(fridayStartTextBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(fridayEndTextBox.Text),
                                                            });
                                                    };

                                                    if (saturdayCheckBox.IsChecked == true)
                                                    {
                                                        CurrentTeacher.TeacherDayOfWeek.Add(
                                                            new TeacherDayOfWeek
                                                            {
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Saturday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(saturdayStartTextBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(saturdayEndTextBox.Text),
                                                            });
                                                    };

                                                    if (sundayCheckBox.IsChecked == true)
                                                    {
                                                        CurrentTeacher.TeacherDayOfWeek.Add(
                                                            new TeacherDayOfWeek
                                                            {
                                                                DayOfWeek = AppData.Context.DayOfWeek.Where(c => c.Name == "Sunday").FirstOrDefault(),
                                                                StartTimeWork = TimeSpan.Parse(sundayStartTextBox.Text),
                                                                EndTimeWork = TimeSpan.Parse(sundayEndTextBox.Text),
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
                                            MessageBox.Show("Некорректный ввод рабочего времени преподавателя!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
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
                        MessageBox.Show("E-mail указан некорректно!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        emailTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Укажите рабочие часы преподавателя!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
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
            }
            else
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
