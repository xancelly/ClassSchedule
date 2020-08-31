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

            var trialNine = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && (c.Time == "09:00" || c.Time == "9:00"));
            if (trialNine.FirstOrDefault() != null)
            {
                trialNineDataGrid.ItemsSource = trialNine.ToList();
            }

            var trialTen = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && c.Time == "10:00");
            if (trialTen.FirstOrDefault() != null)
            {
                trialTenDataGrid.ItemsSource = trialTen.ToList();
            }

            var trialEleven = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && c.Time == "11:00");
            if (trialEleven.FirstOrDefault() != null)
            {
                trialElevenDataGrid.ItemsSource = trialEleven.ToList();
            }

            var trialTwelve = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && c.Time == "12:00");
            if (trialTwelve.FirstOrDefault() != null)
            {
                trialTwelveDataGrid.ItemsSource = trialTwelve.ToList();
            }

            var trialThirteen = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && c.Time == "13:00");
            if (trialThirteen.FirstOrDefault() != null)
            {
                trialThirteenDataGrid.ItemsSource = trialThirteen.ToList();
            }

            var trialFourteen = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && c.Time == "14:00");
            if (trialFourteen.FirstOrDefault() != null)
            {
                trialFourteenDataGrid.ItemsSource = trialFourteen.ToList();
            }

            var trialFifteen = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && c.Time == "15:00");
            if (trialFifteen.FirstOrDefault() != null)
            {
                trialFifteenDataGrid.ItemsSource = trialFifteen.ToList();
            }

            var trialSixteen = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && c.Time == "16:00");
            if (trialSixteen.FirstOrDefault() != null)
            {
                trialSixteenDataGrid.ItemsSource = trialSixteen.ToList();
            }

            var trialSeventeen = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && c.Time == "17:00");
            if (trialSeventeen.FirstOrDefault() != null)
            {
                trialSeventeenDataGrid.ItemsSource = trialSeventeen.ToList();
            }

            var trialEighteen = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && c.Time == "18:00");
            if (trialEighteen.FirstOrDefault() != null)
            {
                trialEighteenDataGrid.ItemsSource = trialEighteen.ToList();
            }

            var trialNineteen = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && c.Time == "19:00");
            if (trialNineteen.FirstOrDefault() != null)
            {
                trialNineteenDataGrid.ItemsSource = trialNineteen.ToList();
            }

            var trialTwenty = AppData.Context.TrialLesson.Where(c => c.Date == selectedDate && c.Time == "20:00");
            if (trialTwenty.FirstOrDefault() != null)
            {
                trialTwentyDataGrid.ItemsSource = trialTwenty.ToList();
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

            Properties.Settings.Default.timeStart = timeMsg.TextBoxText;
            Properties.Settings.Default.dateStart = trialCalendar.SelectedDate.Value.ToShortDateString();

            if (resultTime == MessageBoxResult.OK)
            {
                if (timeMsg.TextBoxText == "09:00" || timeMsg.TextBoxText == "9:00" || timeMsg.TextBoxText == "10:00" || timeMsg.TextBoxText == "11:00" || timeMsg.TextBoxText == "12:00" || timeMsg.TextBoxText == "13:00" || timeMsg.TextBoxText == "14:00" || timeMsg.TextBoxText == "15:00" || timeMsg.TextBoxText == "16:00" || timeMsg.TextBoxText == "17:00" || timeMsg.TextBoxText == "18:00" || timeMsg.TextBoxText == "19:00" || timeMsg.TextBoxText == "20:00")
                {

                    if (AppData.Context.TrialLesson.Where(c => c.Date == trialCalendar.SelectedDate && c.Time == (timeMsg.TextBoxText)).FirstOrDefault() == null)
                    {
                        NavigationService.Navigate(new editTrialPage(null));
                    }
                    else
                    {
                        if (MessageBox.Show("В данное время уже сушествет пробное занятие,\nхотите его редактировать?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            TrialLesson CurrentTrialLesson = AppData.Context.TrialLesson.Where(c => c.Date == trialCalendar.SelectedDate && c.Time == timeMsg.TextBoxText).FirstOrDefault();
                            if (CurrentTrialLesson != null)
                            {
                                NavigationService.Navigate(new editTrialPage(CurrentTrialLesson));
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Некорректный ввод времени начала занятия!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }


    }
}
