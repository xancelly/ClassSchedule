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
    /// Логика взаимодействия для editSchedulePage.xaml
    /// </summary>
    public partial class editSchedulePage : Page
    {
        Lesson CurrentLesson = null;
        List<Client> Clients = new List<Client>();
        public editSchedulePage(Lesson lesson)
        {
            InitializeComponent();
            teacherComboBox.ItemsSource = AppData.Context.Teacher.Where(c => c.FavoriteTime == Properties.Settings.Default.timeStart).ToList();
            groupComboBox.ItemsSource = AppData.Context.Groups.ToList();
            freeClientsListView.ItemsSource = AppData.Context.Client.Where(c => c.FavoriteTime == Properties.Settings.Default.timeStart).ToList();
            CurrentLesson = lesson;

            if (CurrentLesson != null)
            {
                groupComboBox.SelectedItem = CurrentLesson.Groups as Groups;
                teacherComboBox.SelectedItem = CurrentLesson.Teacher as Teacher;
                var lessonClient = AppData.Context.ClientLesson.Where(c => c.IdLesson == CurrentLesson.Id).ToList().Select(c => c.Client).ToList();
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
            try
            {
                if (CurrentLesson == null)
                {
                    CurrentLesson = new Lesson()
                    {
                        Teacher = teacherComboBox.SelectedItem as Teacher,
                        Time = Properties.Settings.Default.timeStart,
                        Date = Convert.ToDateTime(Properties.Settings.Default.dateStart),
                        Day = Properties.Settings.Default.dayStart,
                        Groups = groupComboBox.SelectedItem as Groups,
                    };

                    foreach (var item in Clients)
                    {
                        CurrentLesson.ClientLesson.Add(
                            new ClientLesson
                            {
                                Client = item
                            });
                    }
                    AppData.Context.Lesson.Add(CurrentLesson);
                    AppData.Context.SaveChanges();
                    MessageBox.Show("Запись добавлена", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    NavigationService.GoBack();
                }
                else
                {
                    CurrentLesson.Teacher = teacherComboBox.SelectedItem as Teacher;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
