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
    /// Логика взаимодействия для editSchedulePage.xaml
    /// </summary>
    public partial class editSchedulePage : Page
    {
        Lesson CurrentLesson = null;
        TeacherDayOfWeek CurrentTeacherDayOfWeek = null;
        List<Client> Clients = new List<Client>();
        public editSchedulePage(Lesson lesson)
        {
            InitializeComponent();
            teacherComboBox.ItemsSource = AppData.Context.TeacherDayOfWeek.Where(c => c.Teacher.IsDeleted == false && c.DayOfWeek.Name == Properties.Settings.Default.dayStart && c.StartTimeWork <= Properties.Settings.Default.timeStart && c.EndTimeWork > Properties.Settings.Default.timeStart).ToList();
            groupComboBox.ItemsSource = AppData.Context.Groups.Where(c => c.IsDeleted == false).ToList();
            freeClientsListView.ItemsSource = AppData.Context.ClientDayOfWeek.Where(c => c.Client.IsDeleted == false && c.DayOfWeek.Name == Properties.Settings.Default.dayStart && c.StartTimeWork <= Properties.Settings.Default.timeStart && c.EndTimeWork > Properties.Settings.Default.timeStart).Select(c => c.Client).ToList();

            CurrentLesson = lesson;

            if (CurrentLesson != null)
            {
                CurrentTeacherDayOfWeek = AppData.Context.TeacherDayOfWeek.Where(c => c.IdTeacher == CurrentLesson.IdTeacher).FirstOrDefault();
                this.Title = $"Редактирование занятия \nна {Properties.Settings.Default.dateStart} в {Properties.Settings.Default.timeStart.TotalHours}";
                groupComboBox.SelectedItem = CurrentLesson.Groups as Groups;
                teacherComboBox.SelectedItem = CurrentTeacherDayOfWeek as TeacherDayOfWeek;
                var lessonClient = AppData.Context.ClientLesson.Where(c => c.IdLesson == CurrentLesson.Id).ToList().Select(c => c.Client).ToList();
                lessonTimeComboBox.Text = CurrentLesson.LessonTime;
                if (lessonClient == null)
                {
                    lessonClientsListView.ItemsSource = null;
                }
                else
                {
                    foreach (var item in lessonClient)
                    {
                        Clients.Add(AppData.Context.Client.Where(c => c.Id == item.Id).FirstOrDefault());
                    }
                    lessonClientsListView.ItemsSource = Clients;
                }
            }
            else
            {
                this.Title = $"Добавление занятия на {Properties.Settings.Default.dateStart} \nв {Properties.Settings.Default.timeStart}";
            }
        }

        private void lessonClientsListView_Drop(object sender, DragEventArgs e)
        {
            Clients.Add(e.Data.GetData(e.Data.GetFormats()[0]) as Client);
            lessonClientsListView.ItemsSource = null;
            lessonClientsListView.ItemsSource = Clients;
        }

        private void ClientText_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragDrop.DoDragDrop(freeClientsListView, (Client)(((sender) as TextBlock).DataContext), DragDropEffects.Copy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void lessonClientsListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                int Index = lessonClientsListView.SelectedIndex;
                Clients.RemoveAt(Index);
                lessonClientsListView.ItemsSource = null;
                lessonClientsListView.ItemsSource = Clients;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            DateTime dtStart = Convert.ToDateTime(Properties.Settings.Default.dateStart);
            try
            {
                if (CurrentLesson == null)
                {
                    if (teacherComboBox.SelectedItem != null)
                    {
                        if (lessonTimeComboBox.SelectedItem != null)
                        {
                            if (groupComboBox.SelectedItem != null)
                            {

                                CurrentTeacherDayOfWeek = teacherComboBox.SelectedItem as TeacherDayOfWeek;
                                if (AppData.Context.Lesson.Where(c => c.Teacher.Id == CurrentTeacherDayOfWeek.Teacher.Id && c.Time == Properties.Settings.Default.timeStart && c.Date == dtStart).Count() < 1)
                                {
                                    CurrentLesson = new Lesson()
                                    {
                                        Teacher = CurrentTeacherDayOfWeek.Teacher,
                                        Time = Properties.Settings.Default.timeStart,
                                        Date = Convert.ToDateTime(Properties.Settings.Default.dateStart),
                                        Day = Properties.Settings.Default.dayStart,
                                        Groups = groupComboBox.SelectedItem as Groups,
                                        LessonTime = lessonTimeComboBox.Text,
                                        IdTypeLesson = 1,
                                    };

                                    foreach (var item in Clients)
                                    {
                                        CurrentLesson.ClientLesson.Add(

                                            new ClientLesson
                                            {
                                                Client = item,
                                                IsAttendance = false,
                                                IsPaid = false,
                                            });
                                    }
                                    AppData.Context.Lesson.Add(CurrentLesson);
                                    AppData.Context.SaveChanges();
                                    MessageBox.Show("Запись добавлена", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                                    NavigationService.GoBack();
                                }
                                else
                                {
                                    MessageBox.Show("Занятие уже существует с данным преподавателем!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                                }


                            }
                            else
                            {
                                MessageBox.Show("Поле с группой обязательно должно быть заполнено!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Выберите продолжительность занятия!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Поле с преподавателем обязательно должно быть заполнено!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    if (teacherComboBox.SelectedItem != null)
                    {
                        if (groupComboBox.SelectedItem != null)
                        {
                            if (lessonTimeComboBox.SelectedItem != null)
                            {
                                if (showAllTeachers.IsChecked == true)
                                {
                                    CurrentLesson.Teacher = teacherComboBox.SelectedItem as Teacher;
                                }
                                else if (showAllTeachers.IsChecked == false)
                                {
                                    CurrentTeacherDayOfWeek = teacherComboBox.SelectedItem as TeacherDayOfWeek;
                                    CurrentLesson.Teacher = CurrentTeacherDayOfWeek.Teacher;
                                }
                                CurrentLesson.Groups = groupComboBox.SelectedItem as Groups;
                                if (Clients.Count() > 0)
                                {
                                    AppData.Context.ClientLesson.RemoveRange(AppData.Context.ClientLesson.ToList().Where(p => p.IdLesson == CurrentLesson.Id));
                                    foreach (var item in Clients)
                                    {
                                        CurrentLesson.ClientLesson.Add(
                                            new ClientLesson
                                            {
                                                Client = item
                                            }
                                        );
                                    }
                                    AppData.Context.SaveChanges();
                                    MessageBox.Show("Запись изменена", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                                    NavigationService.GoBack();
                                }
                                else
                                {
                                    MessageBox.Show("На занятии должен присутствовать минимум 1 человек!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Выберите продолжительность занятия!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Поле с группой обязательно должно быть заполнено!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Поле с преподавателем обязательно должно быть заполнено!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void showAllClients_Checked(object sender, RoutedEventArgs e)
        {
            if (showAllClients.IsChecked == true)
            {
                freeClientsListView.ItemsSource = null;
                freeClientsListView.Items.Clear();
                freeClientsListView.ItemsSource = AppData.Context.ClientDayOfWeek.Where(c => c.Client.IsDeleted == false).Select(c => c.Client).Distinct().ToList();
            }
            else
            {
                freeClientsListView.ItemsSource = null;
                freeClientsListView.Items.Clear();
                freeClientsListView.ItemsSource = AppData.Context.ClientDayOfWeek.Where(c => c.Client.IsDeleted == false && c.DayOfWeek.Name == Properties.Settings.Default.dayStart && c.StartTimeWork.Value <= Properties.Settings.Default.timeStart && c.EndTimeWork.Value > Properties.Settings.Default.timeStart).Select(c => c.Client).ToList();
            }
        }

        private void showAllTeachers_Checked(object sender, RoutedEventArgs e)
        {
            if (showAllTeachers.IsChecked == true)
            {
                teacherComboBox.ItemsSource = null;
                teacherComboBox.Items.Clear();
                teacherComboBox.ItemsSource = AppData.Context.TeacherDayOfWeek.Where(c => c.Teacher.IsDeleted == false).Distinct().ToList();
            }
            else
            {
                teacherComboBox.ItemsSource = null;
                teacherComboBox.Items.Clear();
                teacherComboBox.ItemsSource = AppData.Context.TeacherDayOfWeek.Where(c => c.Teacher.IsDeleted == false && c.DayOfWeek.Name == Properties.Settings.Default.dayStart && c.StartTimeWork.Value <= Properties.Settings.Default.timeStart && c.EndTimeWork.Value > Properties.Settings.Default.timeStart).ToList();
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
