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
using WpfMessageBoxLibrary;

namespace ClassSchedule.Pages
{
    /// <summary>
    /// Логика взаимодействия для trialPage.xaml
    /// </summary>
    public partial class trialPage : Page
    {
        public trialPage()
        {
            InitializeComponent();
        }

        public void updateData()
        {
            if (trialCalendar.SelectedDate == null)
            {
                trialCalendar.SelectedDate = DateTime.Today;
            }

            trialNineDataGrid.ItemsSource = null;
            trialTenDataGrid.ItemsSource = null;
            trialElevenDataGrid.ItemsSource = null;
            trialTwelveDataGrid.ItemsSource = null;
            trialThirteenDataGrid.ItemsSource = null;
            trialFourteenDataGrid.ItemsSource = null;
            trialFifteenDataGrid.ItemsSource = null;
            trialSixteenDataGrid.ItemsSource = null;
            trialSeventeenDataGrid.ItemsSource = null;
            trialEighteenDataGrid.ItemsSource = null;
            trialNineteenDataGrid.ItemsSource = null;
            trialTwentyDataGrid.ItemsSource = null;
            trialTwentyOneDataGrid.ItemsSource = null;

            DateTime selectedDate = trialCalendar.SelectedDate.Value;

            string nameDate = selectedDate.DayOfWeek.ToString();
            if (nameDate == "Monday")
            {
                dateTextBlock.Text = $"Понедельник {selectedDate.ToShortDateString()}";
                Properties.Settings.Default.dayStart = "Monday";
            }
            else if (nameDate == "Tuesday")
            {
                dateTextBlock.Text = $"Вторник {selectedDate.ToShortDateString()}";
                Properties.Settings.Default.dayStart = "Tuesday";
            }
            else if (nameDate == "Wednesday")
            {
                dateTextBlock.Text = $"Среда {selectedDate.ToShortDateString()}";
                Properties.Settings.Default.dayStart = "Wednesday";
            }
            else if (nameDate == "Thursday")
            {
                dateTextBlock.Text = $"Четверг {selectedDate.ToShortDateString()}";
                Properties.Settings.Default.dayStart = "Thursday";
            }
            else if (nameDate == "Friday")
            {
                dateTextBlock.Text = $"Пятница {selectedDate.ToShortDateString()}";
                Properties.Settings.Default.dayStart = "Friday";
            }
            else if (nameDate == "Saturday")
            {
                dateTextBlock.Text = $"Суббота {selectedDate.ToShortDateString()}";
                Properties.Settings.Default.dayStart = "Saturday";
            }
            else if (nameDate == "Sunday")
            {
                dateTextBlock.Text = $"Воскресенье {selectedDate.ToShortDateString()}";
                Properties.Settings.Default.dayStart = "Sunday";
            }

            DataGrid[] trialDataGrids = new[] { trialNineDataGrid, trialTenDataGrid, trialElevenDataGrid, trialTwelveDataGrid, trialThirteenDataGrid, trialFourteenDataGrid, trialFifteenDataGrid, trialSixteenDataGrid, trialSeventeenDataGrid, trialEighteenDataGrid, trialNineteenDataGrid, trialTwentyDataGrid, trialTwentyOneDataGrid };
            TimeSpan[] time = new TimeSpan[] { TimeSpan.Parse("09:00"),  TimeSpan.Parse("10:00"), TimeSpan.Parse("11:00"), TimeSpan.Parse("12:00"), TimeSpan.Parse("13:00"), TimeSpan.Parse("14:00"), TimeSpan.Parse("15:00"), TimeSpan.Parse("16:00"),  TimeSpan.Parse("17:00"), TimeSpan.Parse("18:00"),  TimeSpan.Parse("19:00"),  TimeSpan.Parse("20:00"), TimeSpan.Parse("21:00"), };
            for (int i = 0; i < trialDataGrids.Length; i++)
            {
                for (int j = 0; j < time.Length; j++)
                {
                    TimeSpan startTime = time[j];
                    var trialLesson = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && (c.Time == startTime) && c.IsDeleted == false);
                    if (trialLesson.FirstOrDefault() != null)
                    {
                        trialDataGrids[j].ItemsSource = trialLesson.ToList();
                    }
                }
            }

            //var trialNine = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && (c.Time == "09:00" || c.Time == "9:00") && c.IsDeleted == false);
            //if (trialNine.FirstOrDefault() != null)
            //{
            //    trialNineDataGrid.ItemsSource = trialNine.ToList();
            //}

            //var trialTen = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && c.Time == "10:00" && c.IsDeleted == false);
            //if (trialTen.FirstOrDefault() != null)
            //{
            //    trialTenDataGrid.ItemsSource = trialTen.ToList();
            //}

            //var trialEleven = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && c.Time == "11:00" && c.IsDeleted == false);
            //if (trialEleven.FirstOrDefault() != null)
            //{
            //    trialElevenDataGrid.ItemsSource = trialEleven.ToList();
            //}

            //var trialTwelve = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && c.Time == "12:00" && c.IsDeleted == false);
            //if (trialTwelve.FirstOrDefault() != null)
            //{
            //    trialTwelveDataGrid.ItemsSource = trialTwelve.ToList();
            //}

            //var trialThirteen = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && c.Time == "13:00" && c.IsDeleted == false);
            //if (trialThirteen.FirstOrDefault() != null)
            //{
            //    trialThirteenDataGrid.ItemsSource = trialThirteen.ToList();
            //}

            //var trialFourteen = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && c.Time == "14:00" && c.IsDeleted == false);
            //if (trialFourteen.FirstOrDefault() != null)
            //{
            //    trialFourteenDataGrid.ItemsSource = trialFourteen.ToList();
            //}

            //var trialFifteen = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && c.Time == "15:00" && c.IsDeleted == false);
            //if (trialFifteen.FirstOrDefault() != null)
            //{
            //    trialFifteenDataGrid.ItemsSource = trialFifteen.ToList();
            //}

            //var trialSixteen = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && c.Time == "16:00" && c.IsDeleted == false);
            //if (trialSixteen.FirstOrDefault() != null)
            //{
            //    trialSixteenDataGrid.ItemsSource = trialSixteen.ToList();
            //}

            //var trialSeventeen = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && c.Time == "17:00" && c.IsDeleted == false);
            //if (trialSeventeen.FirstOrDefault() != null)
            //{
            //    trialSeventeenDataGrid.ItemsSource = trialSeventeen.ToList();
            //}

            //var trialEighteen = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && c.Time == "18:00" && c.IsDeleted == false);
            //if (trialEighteen.FirstOrDefault() != null)
            //{
            //    trialEighteenDataGrid.ItemsSource = trialEighteen.ToList();
            //}

            //var trialNineteen = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && c.Time == "19:00" && c.IsDeleted == false);
            //if (trialNineteen.FirstOrDefault() != null)
            //{
            //    trialNineteenDataGrid.ItemsSource = trialNineteen.ToList();
            //}

            //var trialTwenty = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && c.Time == "20:00" && c.IsDeleted == false);
            //if (trialTwenty.FirstOrDefault() != null)
            //{
            //    trialTwentyDataGrid.ItemsSource = trialTwenty.ToList();
            //}

            //var trialTwentyOne = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && c.Time == "21:00" && c.IsDeleted == false);
            //if (trialTwentyOne.FirstOrDefault() != null)
            //{
            //    trialTwentyOneDataGrid.ItemsSource = trialTwentyOne.ToList();
            //}

        }

        private void trialCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            updateData();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            updateData();
        }

        private void trialCalendar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var timeMsg = new WpfMessageBoxProperties()
            {
                Title = "Внимание!",
                Button = MessageBoxButton.OKCancel,
                ButtonOkText = "Ок",
                ButtonCancelText = "Отмена",
                Image = MessageBoxImage.Information,
                Header = "Введите время начала проведения пробного занятия (например 9:00, 10:00)",
                IsTextBoxVisible = true,
            };
            MessageBoxResult resultTime = WpfMessageBox.Show(ref timeMsg);

            Properties.Settings.Default.timeStart = TimeSpan.Parse(timeMsg.TextBoxText);
            Properties.Settings.Default.dateStart = trialCalendar.SelectedDate.Value.ToShortDateString();

            if (resultTime == MessageBoxResult.OK)
            {
                if (timeMsg.TextBoxText == "09:00" || timeMsg.TextBoxText == "9:00" || timeMsg.TextBoxText == "10:00" || timeMsg.TextBoxText == "11:00" || timeMsg.TextBoxText == "12:00" || timeMsg.TextBoxText == "13:00" || timeMsg.TextBoxText == "14:00" || timeMsg.TextBoxText == "15:00" || timeMsg.TextBoxText == "16:00" || timeMsg.TextBoxText == "17:00" || timeMsg.TextBoxText == "18:00" || timeMsg.TextBoxText == "19:00" || timeMsg.TextBoxText == "20:00" || timeMsg.TextBoxText == "21:00")
                {
                    NavigationService.Navigate(new editTrialPage(null));
                }
                else
                {
                    MessageBox.Show("Некорректный ввод времени начала занятия!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void selectedDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (trialNineDataGrid.IsMouseOver == true)
            {
                TrialLesson CurrentTrialLesson = trialNineDataGrid.SelectedItem as TrialLesson;
                if (CurrentTrialLesson != null)
                {
                    var editTrialLesson = new WpfMessageBoxProperties()
                    {
                        Title = "Внимание!",
                        Button = MessageBoxButton.YesNoCancel,
                        ButtonYesText = "Изменить",
                        ButtonNoText = "Удалить",
                        ButtonCancelText = "Отмена",
                        Image = MessageBoxImage.Question,
                        Header = "Что вы хотите сделать с существующим пробным занятием?",
                    };
                    MessageBoxResult result = WpfMessageBox.Show(ref editTrialLesson);

                    if (result == MessageBoxResult.Yes)
                    {
                        NavigationService.Navigate(new editTrialPage(CurrentTrialLesson));
                    }
                    else if (result == MessageBoxResult.No)
                    {
                        if (MessageBox.Show("Вы действительно хотите удалить пробное занятие?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            CurrentTrialLesson.IsDeleted = true;
                            AppData.Context.SaveChanges();
                            Page_Loaded(null, null);
                            MessageBox.Show("Пробное занятие было удалено!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Выберите занятие!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (trialTenDataGrid.IsMouseOver == true)
            {
                TrialLesson CurrentTrialLesson = trialTenDataGrid.SelectedItem as TrialLesson;
                if (CurrentTrialLesson != null)
                {
                    var editTrialLesson = new WpfMessageBoxProperties()
                    {
                        Title = "Внимание!",
                        Button = MessageBoxButton.YesNoCancel,
                        ButtonYesText = "Изменить",
                        ButtonNoText = "Удалить",
                        ButtonCancelText = "Отмена",
                        Image = MessageBoxImage.Question,
                        Header = "Что вы хотите сделать с существующим пробным занятием?",
                    };
                    MessageBoxResult result = WpfMessageBox.Show(ref editTrialLesson);

                    if (result == MessageBoxResult.Yes)
                    {
                        NavigationService.Navigate(new editTrialPage(CurrentTrialLesson));
                    }
                    else if (result == MessageBoxResult.No)
                    {
                        if (MessageBox.Show("Вы действительно хотите удалить пробное занятие?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            CurrentTrialLesson.IsDeleted = true;
                            AppData.Context.SaveChanges();
                            Page_Loaded(null, null);
                            MessageBox.Show("Пробное занятие было удалено!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Выберите занятие!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (trialElevenDataGrid.IsMouseOver == true)
            {
                TrialLesson CurrentTrialLesson = trialElevenDataGrid.SelectedItem as TrialLesson;
                if (CurrentTrialLesson != null)
                {
                    var editTrialLesson = new WpfMessageBoxProperties()
                    {
                        Title = "Внимание!",
                        Button = MessageBoxButton.YesNoCancel,
                        ButtonYesText = "Изменить",
                        ButtonNoText = "Удалить",
                        ButtonCancelText = "Отмена",
                        Image = MessageBoxImage.Question,
                        Header = "Что вы хотите сделать с существующим пробным занятием?",
                    };
                    MessageBoxResult result = WpfMessageBox.Show(ref editTrialLesson);

                    if (result == MessageBoxResult.Yes)
                    {
                        NavigationService.Navigate(new editTrialPage(CurrentTrialLesson));
                    }
                    else if (result == MessageBoxResult.No)
                    {
                        if (MessageBox.Show("Вы действительно хотите удалить пробное занятие?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            CurrentTrialLesson.IsDeleted = true;
                            AppData.Context.SaveChanges();
                            Page_Loaded(null, null);
                            MessageBox.Show("Пробное занятие было удалено!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Выберите занятие!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (trialTwelveDataGrid.IsMouseOver == true)
            {
                TrialLesson CurrentTrialLesson = trialTwelveDataGrid.SelectedItem as TrialLesson;
                if (CurrentTrialLesson != null)
                {
                    var editTrialLesson = new WpfMessageBoxProperties()
                    {
                        Title = "Внимание!",
                        Button = MessageBoxButton.YesNoCancel,
                        ButtonYesText = "Изменить",
                        ButtonNoText = "Удалить",
                        ButtonCancelText = "Отмена",
                        Image = MessageBoxImage.Question,
                        Header = "Что вы хотите сделать с существующим пробным занятием?",
                    };
                    MessageBoxResult result = WpfMessageBox.Show(ref editTrialLesson);

                    if (result == MessageBoxResult.Yes)
                    {
                        NavigationService.Navigate(new editTrialPage(CurrentTrialLesson));
                    }
                    else if (result == MessageBoxResult.No)
                    {
                        if (MessageBox.Show("Вы действительно хотите удалить пробное занятие?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            CurrentTrialLesson.IsDeleted = true;
                            AppData.Context.SaveChanges();
                            Page_Loaded(null, null);
                            MessageBox.Show("Пробное занятие было удалено!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Выберите занятие!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (trialThirteenDataGrid.IsMouseOver == true)
            {
                TrialLesson CurrentTrialLesson = trialThirteenDataGrid.SelectedItem as TrialLesson;
                if (CurrentTrialLesson != null)
                {
                    var editTrialLesson = new WpfMessageBoxProperties()
                    {
                        Title = "Внимание!",
                        Button = MessageBoxButton.YesNoCancel,
                        ButtonYesText = "Изменить",
                        ButtonNoText = "Удалить",
                        ButtonCancelText = "Отмена",
                        Image = MessageBoxImage.Question,
                        Header = "Что вы хотите сделать с существующим пробным занятием?",
                    };
                    MessageBoxResult result = WpfMessageBox.Show(ref editTrialLesson);

                    if (result == MessageBoxResult.Yes)
                    {
                        NavigationService.Navigate(new editTrialPage(CurrentTrialLesson));
                    }
                    else if (result == MessageBoxResult.No)
                    {
                        if (MessageBox.Show("Вы действительно хотите удалить пробное занятие?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            CurrentTrialLesson.IsDeleted = true;
                            AppData.Context.SaveChanges();
                            Page_Loaded(null, null);
                            MessageBox.Show("Пробное занятие было удалено!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Выберите занятие!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (trialFourteenDataGrid.IsMouseOver == true)
            {
                TrialLesson CurrentTrialLesson = trialFourteenDataGrid.SelectedItem as TrialLesson;
                if (CurrentTrialLesson != null)
                {
                    var editTrialLesson = new WpfMessageBoxProperties()
                    {
                        Title = "Внимание!",
                        Button = MessageBoxButton.YesNoCancel,
                        ButtonYesText = "Изменить",
                        ButtonNoText = "Удалить",
                        ButtonCancelText = "Отмена",
                        Image = MessageBoxImage.Question,
                        Header = "Что вы хотите сделать с существующим пробным занятием?",
                    };
                    MessageBoxResult result = WpfMessageBox.Show(ref editTrialLesson);

                    if (result == MessageBoxResult.Yes)
                    {
                        NavigationService.Navigate(new editTrialPage(CurrentTrialLesson));
                    }
                    else if (result == MessageBoxResult.No)
                    {
                        if (MessageBox.Show("Вы действительно хотите удалить пробное занятие?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            CurrentTrialLesson.IsDeleted = true;
                            AppData.Context.SaveChanges();
                            Page_Loaded(null, null);
                            MessageBox.Show("Пробное занятие было удалено!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Выберите занятие!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (trialFifteenDataGrid.IsMouseOver == true)
            {
                TrialLesson CurrentTrialLesson = trialFifteenDataGrid.SelectedItem as TrialLesson;
                if (CurrentTrialLesson != null)
                {
                    var editTrialLesson = new WpfMessageBoxProperties()
                    {
                        Title = "Внимание!",
                        Button = MessageBoxButton.YesNoCancel,
                        ButtonYesText = "Изменить",
                        ButtonNoText = "Удалить",
                        ButtonCancelText = "Отмена",
                        Image = MessageBoxImage.Question,
                        Header = "Что вы хотите сделать с существующим пробным занятием?",
                    };
                    MessageBoxResult result = WpfMessageBox.Show(ref editTrialLesson);

                    if (result == MessageBoxResult.Yes)
                    {
                        NavigationService.Navigate(new editTrialPage(CurrentTrialLesson));
                    }
                    else if (result == MessageBoxResult.No)
                    {
                        if (MessageBox.Show("Вы действительно хотите удалить пробное занятие?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            CurrentTrialLesson.IsDeleted = true;
                            AppData.Context.SaveChanges();
                            Page_Loaded(null, null);
                            MessageBox.Show("Пробное занятие было удалено!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Выберите занятие!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (trialSixteenDataGrid.IsMouseOver == true)
            {
                TrialLesson CurrentTrialLesson = trialSixteenDataGrid.SelectedItem as TrialLesson;
                if (CurrentTrialLesson != null)
                {
                    var editTrialLesson = new WpfMessageBoxProperties()
                    {
                        Title = "Внимание!",
                        Button = MessageBoxButton.YesNoCancel,
                        ButtonYesText = "Изменить",
                        ButtonNoText = "Удалить",
                        ButtonCancelText = "Отмена",
                        Image = MessageBoxImage.Question,
                        Header = "Что вы хотите сделать с существующим пробным занятием?",
                    };
                    MessageBoxResult result = WpfMessageBox.Show(ref editTrialLesson);

                    if (result == MessageBoxResult.Yes)
                    {
                        NavigationService.Navigate(new editTrialPage(CurrentTrialLesson));
                    }
                    else if (result == MessageBoxResult.No)
                    {
                        if (MessageBox.Show("Вы действительно хотите удалить пробное занятие?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            CurrentTrialLesson.IsDeleted = true;
                            AppData.Context.SaveChanges();
                            Page_Loaded(null, null);
                            MessageBox.Show("Пробное занятие было удалено!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Выберите занятие!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (trialSeventeenDataGrid.IsMouseOver == true)
            {
                TrialLesson CurrentTrialLesson = trialSeventeenDataGrid.SelectedItem as TrialLesson;
                if (CurrentTrialLesson != null)
                {
                    var editTrialLesson = new WpfMessageBoxProperties()
                    {
                        Title = "Внимание!",
                        Button = MessageBoxButton.YesNoCancel,
                        ButtonYesText = "Изменить",
                        ButtonNoText = "Удалить",
                        ButtonCancelText = "Отмена",
                        Image = MessageBoxImage.Question,
                        Header = "Что вы хотите сделать с существующим пробным занятием?",
                    };
                    MessageBoxResult result = WpfMessageBox.Show(ref editTrialLesson);

                    if (result == MessageBoxResult.Yes)
                    {
                        NavigationService.Navigate(new editTrialPage(CurrentTrialLesson));
                    }
                    else if (result == MessageBoxResult.No)
                    {
                        if (MessageBox.Show("Вы действительно хотите удалить пробное занятие?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            CurrentTrialLesson.IsDeleted = true;
                            AppData.Context.SaveChanges();
                            Page_Loaded(null, null);
                            MessageBox.Show("Пробное занятие было удалено!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Выберите занятие!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (trialEighteenDataGrid.IsMouseOver == true)
            {
                TrialLesson CurrentTrialLesson = trialEighteenDataGrid.SelectedItem as TrialLesson;
                if (CurrentTrialLesson != null)
                {
                    var editTrialLesson = new WpfMessageBoxProperties()
                    {
                        Title = "Внимание!",
                        Button = MessageBoxButton.YesNoCancel,
                        ButtonYesText = "Изменить",
                        ButtonNoText = "Удалить",
                        ButtonCancelText = "Отмена",
                        Image = MessageBoxImage.Question,
                        Header = "Что вы хотите сделать с существующим пробным занятием?",
                    };
                    MessageBoxResult result = WpfMessageBox.Show(ref editTrialLesson);

                    if (result == MessageBoxResult.Yes)
                    {
                        NavigationService.Navigate(new editTrialPage(CurrentTrialLesson));
                    }
                    else if (result == MessageBoxResult.No)
                    {
                        if (MessageBox.Show("Вы действительно хотите удалить пробное занятие?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            CurrentTrialLesson.IsDeleted = true;
                            AppData.Context.SaveChanges();
                            Page_Loaded(null, null);
                            MessageBox.Show("Пробное занятие было удалено!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Выберите занятие!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (trialNineteenDataGrid.IsMouseOver == true)
            {
                TrialLesson CurrentTrialLesson = trialNineteenDataGrid.SelectedItem as TrialLesson;
                if (CurrentTrialLesson != null)
                {
                    var editTrialLesson = new WpfMessageBoxProperties()
                    {
                        Title = "Внимание!",
                        Button = MessageBoxButton.YesNoCancel,
                        ButtonYesText = "Изменить",
                        ButtonNoText = "Удалить",
                        ButtonCancelText = "Отмена",
                        Image = MessageBoxImage.Question,
                        Header = "Что вы хотите сделать с существующим пробным занятием?",
                    };
                    MessageBoxResult result = WpfMessageBox.Show(ref editTrialLesson);

                    if (result == MessageBoxResult.Yes)
                    {
                        NavigationService.Navigate(new editTrialPage(CurrentTrialLesson));
                    }
                    else if (result == MessageBoxResult.No)
                    {
                        if (MessageBox.Show("Вы действительно хотите удалить пробное занятие?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            CurrentTrialLesson.IsDeleted = true;
                            AppData.Context.SaveChanges();
                            Page_Loaded(null, null);
                            MessageBox.Show("Пробное занятие было удалено!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Выберите занятие!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (trialTwentyDataGrid.IsMouseOver == true)
            {
                TrialLesson CurrentTrialLesson = trialTwentyDataGrid.SelectedItem as TrialLesson;
                if (CurrentTrialLesson != null)
                {
                    var editTrialLesson = new WpfMessageBoxProperties()
                    {
                        Title = "Внимание!",
                        Button = MessageBoxButton.YesNoCancel,
                        ButtonYesText = "Изменить",
                        ButtonNoText = "Удалить",
                        ButtonCancelText = "Отмена",
                        Image = MessageBoxImage.Question,
                        Header = "Что вы хотите сделать с существующим пробным занятием?",
                    };
                    MessageBoxResult result = WpfMessageBox.Show(ref editTrialLesson);

                    if (result == MessageBoxResult.Yes)
                    {
                        NavigationService.Navigate(new editTrialPage(CurrentTrialLesson));
                    }
                    else if (result == MessageBoxResult.No)
                    {
                        if (MessageBox.Show("Вы действительно хотите удалить пробное занятие?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            CurrentTrialLesson.IsDeleted = true;
                            AppData.Context.SaveChanges();
                            Page_Loaded(null, null);
                            MessageBox.Show("Пробное занятие было удалено!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Выберите занятие!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (trialTwentyOneDataGrid.IsMouseOver == true)
            {
                TrialLesson CurrentTrialLesson = trialTwentyOneDataGrid.SelectedItem as TrialLesson;
                if (CurrentTrialLesson != null)
                {
                    var editTrialLesson = new WpfMessageBoxProperties()
                    {
                        Title = "Внимание!",
                        Button = MessageBoxButton.YesNoCancel,
                        ButtonYesText = "Изменить",
                        ButtonNoText = "Удалить",
                        ButtonCancelText = "Отмена",
                        Image = MessageBoxImage.Question,
                        Header = "Что вы хотите сделать с существующим пробным занятием?",
                    };
                    MessageBoxResult result = WpfMessageBox.Show(ref editTrialLesson);

                    if (result == MessageBoxResult.Yes)
                    {
                        NavigationService.Navigate(new editTrialPage(CurrentTrialLesson));
                    }
                    else if (result == MessageBoxResult.No)
                    {
                        if (MessageBox.Show("Вы действительно хотите удалить пробное занятие?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            CurrentTrialLesson.IsDeleted = true;
                            AppData.Context.SaveChanges();
                            Page_Loaded(null, null);
                            MessageBox.Show("Пробное занятие было удалено!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Выберите занятие!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }
    }
}
