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
using System.Windows.Threading;
using WpfMessageBoxLibrary;

namespace ClassSchedule.Pages
{
    /// <summary>
    /// Логика взаимодействия для trialPage.xaml
    /// </summary>
    public partial class trialPage : Page
    {
        DataGrid[] trialDataGrids;
        TimeSpan[] time;
        DispatcherTimer timer = new DispatcherTimer();
        int countData;
        public trialPage()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.Parse("00:00:05");
            timer.Tick += Timer_Tick;
            timer.Start();
            countData = AppData.Context.TrialLesson.Count();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            if (countData < AppData.Context.TrialLesson.Count() || countData > AppData.Context.TrialLesson.Count())
            {
                countData = AppData.Context.TrialLesson.Count();
                updateData();
            }
            timer.Start();
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

            trialDataGrids = new[] { trialNineDataGrid, trialTenDataGrid, trialElevenDataGrid, trialTwelveDataGrid, trialThirteenDataGrid, trialFourteenDataGrid, trialFifteenDataGrid, trialSixteenDataGrid, trialSeventeenDataGrid, trialEighteenDataGrid, trialNineteenDataGrid, trialTwentyDataGrid, trialTwentyOneDataGrid };
            time = new TimeSpan[] { TimeSpan.Parse("09:00"), TimeSpan.Parse("10:00"), TimeSpan.Parse("11:00"), TimeSpan.Parse("12:00"), TimeSpan.Parse("13:00"), TimeSpan.Parse("14:00"), TimeSpan.Parse("15:00"), TimeSpan.Parse("16:00"), TimeSpan.Parse("17:00"), TimeSpan.Parse("18:00"), TimeSpan.Parse("19:00"), TimeSpan.Parse("20:00"), TimeSpan.Parse("21:00"), };
            for (int i = 0; i < trialDataGrids.Length; i++)
            {
                for (int j = 0; j < time.Length; j++)
                {
                    TimeSpan startTime = time[j];
                    var trialLesson = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && (c.Time == startTime) && c.IsDeleted == false);
                    if (trialLesson.FirstOrDefault() != null)
                    {
                        trialDataGrids[j].ItemsSource = trialLesson.ToList();
                        break;
                    }
                }
            }
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
            for (int i = 0; i < trialDataGrids.Length; i++)
            {
                if (trialDataGrids[i].IsMouseOver == true)
                {
                    TrialLesson CurrentTrialLesson = trialDataGrids[i].SelectedItem as TrialLesson;
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
}
