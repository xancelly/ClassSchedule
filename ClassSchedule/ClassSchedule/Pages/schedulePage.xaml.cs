using ClassSchedule.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Логика взаимодействия для schedulePage.xaml
    /// </summary>
    public partial class schedulePage : Page
    {
        List<Client> Clients = new List<Client>();
        Teacher CurrentTeacher = null;
        DataGrid[] lessonDataGrids;
        DataGrid[] clientDataGrids;
        DispatcherTimer timer = new DispatcherTimer();
        int countData;
        public schedulePage()
        {
            InitializeComponent();
            teacherComboBox.ItemsSource = AppData.Context.Teacher.Where(c => c.IsDeleted == false).ToList();

            timer.Interval = TimeSpan.Parse("00:00:05");
            timer.Tick += Timer_Tick;
            timer.Start();
            countData = AppData.Context.Lesson.Count();

            lessonDataGrids = new[] { monday0900, monday0930, monday1000, monday1030, monday1100, monday1130, monday1200, monday1230, monday1300, monday1330, monday1400, monday1430, monday1500, monday1530, monday1600, monday1630, monday1700, monday1730, monday1800, monday1830, monday1900, monday1930, monday2000, monday2030, monday2100, monday2130, tuesday0900, tuesday0930, tuesday1000, tuesday1030, tuesday1100, tuesday1130, tuesday1200, tuesday1230, tuesday1300, tuesday1330, tuesday1400, tuesday1430, tuesday1500, tuesday1530, tuesday1600, tuesday1630, tuesday1700, tuesday1730, tuesday1800, tuesday1830, tuesday1900, tuesday1930, tuesday2000, tuesday2030, tuesday2100, tuesday2130, wednesday0900, wednesday0930, wednesday1000, wednesday1030, wednesday1100, wednesday1130, wednesday1200, wednesday1230, wednesday1300, wednesday1330, wednesday1400, wednesday1430, wednesday1500, wednesday1530, wednesday1600, wednesday1630, wednesday1700, wednesday1730, wednesday1800, wednesday1830, wednesday1900, wednesday1930, wednesday2000, wednesday2030, wednesday2100, wednesday2130, thursday0900, thursday0930, thursday1000, thursday1030, thursday1100, thursday1130, thursday1200, thursday1230, thursday1300, thursday1330, thursday1400, thursday1430, thursday1500, thursday1530, thursday1600, thursday1630, thursday1700, thursday1730, thursday1800, thursday1830, thursday1900, thursday1930, thursday2000, thursday2030, thursday2100, thursday2130, friday0900, friday0930, friday1000, friday1030, friday1100, friday1130, friday1200, friday1230, friday1300, friday1330, friday1400, friday1430, friday1500, friday1530, friday1600, friday1630, friday1700, friday1730, friday1800, friday1830, friday1900, friday1930, friday2000, friday2030, friday2100, friday2130, saturday0900, saturday0930, saturday1000, saturday1030, saturday1100, saturday1130, saturday1200, saturday1230, saturday1300, saturday1330, saturday1400, saturday1430, saturday1500, saturday1530, saturday1600, saturday1630, saturday1700, saturday1730, saturday1800, saturday1830, saturday1900, saturday1930, saturday2000, saturday2030, saturday2100, saturday2130, sunday0900, sunday0930, sunday1000, sunday1030, sunday1100, sunday1130, sunday1200, sunday1230, sunday1300, sunday1330, sunday1400, sunday1430, sunday1500, sunday1530, sunday1600, sunday1630, sunday1700, sunday1730, sunday1800, sunday1830, sunday1900, sunday1930, sunday2000, sunday2030, sunday2100, sunday2130 };

            clientDataGrids = new[] { mondayClients0900, mondayClients0930, mondayClients1000, mondayClients1030, mondayClients1100, mondayClients1130, mondayClients1200, mondayClients1230, mondayClients1300, mondayClients1330, mondayClients1400, mondayClients1430, mondayClients1500, mondayClients1530, mondayClients1600, mondayClients1630, mondayClients1700, mondayClients1730, mondayClients1800, mondayClients1830, mondayClients1900, mondayClients1930, mondayClients2000, mondayClients2030, mondayClients2100, mondayClients2130, tuesdayClients0900, tuesdayClients0930, tuesdayClients1000, tuesdayClients1030, tuesdayClients1100, tuesdayClients1130, tuesdayClients1200, tuesdayClients1230, tuesdayClients1300, tuesdayClients1330, tuesdayClients1400, tuesdayClients1430, tuesdayClients1500, tuesdayClients1530, tuesdayClients1600, tuesdayClients1630, tuesdayClients1700, tuesdayClients1730, tuesdayClients1800, tuesdayClients1830, tuesdayClients1900, tuesdayClients1930, tuesdayClients2000, tuesdayClients2030, tuesdayClients2100, tuesdayClients2130, wednesdayClients0900, wednesdayClients0930, wednesdayClients1000, wednesdayClients1030, wednesdayClients1100, wednesdayClients1130, wednesdayClients1200, wednesdayClients1230, wednesdayClients1300, wednesdayClients1330, wednesdayClients1400, wednesdayClients1430, wednesdayClients1500, wednesdayClients1530, wednesdayClients1600, wednesdayClients1630, wednesdayClients1700, wednesdayClients1730, wednesdayClients1800, wednesdayClients1830, wednesdayClients1900, wednesdayClients1930, wednesdayClients2000, wednesdayClients2030, wednesdayClients2100, wednesdayClients2130, thursdayClients0900, thursdayClients0930, thursdayClients1000, thursdayClients1030, thursdayClients1100, thursdayClients1130, thursdayClients1200, thursdayClients1230, thursdayClients1300, thursdayClients1330, thursdayClients1400, thursdayClients1430, thursdayClients1500, thursdayClients1530, thursdayClients1600, thursdayClients1630, thursdayClients1700, thursdayClients1730, thursdayClients1800, thursdayClients1830, thursdayClients1900, thursdayClients1930, thursdayClients2000, thursdayClients2030, thursdayClients2100, thursdayClients2130, fridayClients0900, fridayClients0930, fridayClients1000, fridayClients1030, fridayClients1100, fridayClients1130, fridayClients1200, fridayClients1230, fridayClients1300, fridayClients1330, fridayClients1400, fridayClients1430, fridayClients1500, fridayClients1530, fridayClients1600, fridayClients1630, fridayClients1700, fridayClients1730, fridayClients1800, fridayClients1830, fridayClients1900, fridayClients1930, fridayClients2000, fridayClients2030, fridayClients2100, fridayClients2130, saturdayClients0900, saturdayClients0930, saturdayClients1000, saturdayClients1030, saturdayClients1100, saturdayClients1130, saturdayClients1200, saturdayClients1230, saturdayClients1300, saturdayClients1330, saturdayClients1400, saturdayClients1430, saturdayClients1500, saturdayClients1530, saturdayClients1600, saturdayClients1630, saturdayClients1700, saturdayClients1730, saturdayClients1800, saturdayClients1830, saturdayClients1900, saturdayClients1930, saturdayClients2000, saturdayClients2030, saturdayClients2100, saturdayClients2130, sundayClients0900, sundayClients0930, sundayClients1000, sundayClients1030, sundayClients1100, sundayClients1130, sundayClients1200, sundayClients1230, sundayClients1300, sundayClients1330, sundayClients1400, sundayClients1430, sundayClients1500, sundayClients1530, sundayClients1600, sundayClients1630, sundayClients1700, sundayClients1730, sundayClients1800, sundayClients1830, sundayClients1900, sundayClients1930, sundayClients2000, sundayClients2030, sundayClients2100, sundayClients2130 };
        }




        private void secondScrollView_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            if (secondScrollView.HorizontalOffset != thirdScrollView.HorizontalOffset)
            {
                thirdScrollView.ScrollToHorizontalOffset(secondScrollView.HorizontalOffset);
            }
            if (firstScrollViewer.VerticalOffset != secondScrollView.VerticalOffset)
            {
                firstScrollViewer.ScrollToVerticalOffset(secondScrollView.VerticalOffset);
            }

        }

        public void updateData()
        {
            if (teacherComboBox.SelectedItem != null)
            {
                DateTime startDate = default(DateTime);
                DateTime endDate = default(DateTime);
                DateTime selectedDate;
                if (scheduleCalendar.SelectedDate != null)
                {
                    selectedDate = scheduleCalendar.SelectedDate.Value;
                }
                else
                {
                    selectedDate = DateTime.Today;
                }

                string nameDate = selectedDate.DayOfWeek.ToString();
                Properties.Settings.Default.dayStart = nameDate;
                if (nameDate == "Monday")
                {
                    startDate = selectedDate;
                    endDate = selectedDate.AddDays(6);
                }
                else if (nameDate == "Tuesday")
                {
                    startDate = selectedDate.AddDays(-1);
                    endDate = selectedDate.AddDays(5);
                }
                else if (nameDate == "Wednesday")
                {
                    startDate = selectedDate.AddDays(-2);
                    endDate = selectedDate.AddDays(4);
                }
                else if (nameDate == "Thursday")
                {
                    startDate = selectedDate.AddDays(-3);
                    endDate = selectedDate.AddDays(3);
                }
                else if (nameDate == "Friday")
                {
                    startDate = selectedDate.AddDays(-4);
                    endDate = selectedDate.AddDays(2);
                }
                else if (nameDate == "Saturday")
                {
                    startDate = selectedDate.AddDays(-5);
                    endDate = selectedDate.AddDays(1);
                }
                else if (nameDate == "Sunday")
                {
                    startDate = selectedDate.AddDays(-6);
                    endDate = selectedDate;
                }

                oneDate.Text = $"Понедельник {startDate.ToShortDateString()}";
                twoDate.Text = $"Вторник {startDate.AddDays(1).ToShortDateString()}";
                threeDate.Text = $"Среда {startDate.AddDays(2).ToShortDateString()}";
                fourDate.Text = $"Четверг {startDate.AddDays(3).ToShortDateString()}";
                fiveDate.Text = $"Пятница {startDate.AddDays(4).ToShortDateString()}";
                sixDate.Text = $"Суббота {startDate.AddDays(5).ToShortDateString()}";
                sevenDate.Text = $"Воскресенье {startDate.AddDays(6).ToShortDateString()}";

                //for (int i = 0; i < lessonDataGrids.Length; i++)
                //{
                //    lessonDataGrids[i].ItemsSource = null;
                //}

                //for (int i = 0; i < clientDataGrids.Length; i++)
                //{
                //    clientDataGrids[i].ItemsSource = null;
                //}

                //for (int i = 0; i < lessonDataGrids.Length; i++)
                //{
                //    lessonDataGrids[i].ItemsSource = AppData.Context.LessonData(DateTime.Today, TimeSpan.Parse("9:00"), CurrentTeacher.Id, 1).ToList();
                //}


                //monday0900.ItemsSource = AppData.Context.LessonData(startDate, TimeSpan.Parse("9:00"), CurrentTeacher.Id, 1).ToList();
                //monday0930.ItemsSource = AppData.Context.LessonData(startDate, TimeSpan.Parse("9:30"), CurrentTeacher.Id, 1).ToList();
                //monday1000.ItemsSource = AppData.Context.LessonData(startDate, TimeSpan.Parse("10:00"), CurrentTeacher.Id, 1).ToList();
                //monday1030.ItemsSource = AppData.Context.LessonData(startDate, TimeSpan.Parse("10:30"), CurrentTeacher.Id, 1).ToList();
                //monday1100.ItemsSource = AppData.Context.LessonData(startDate, TimeSpan.Parse("11:00"), CurrentTeacher.Id, 1).ToList();
                //monday1130.ItemsSource = AppData.Context.LessonData(startDate, TimeSpan.Parse("11:30"), CurrentTeacher.Id, 1).ToList();
                //monday1200.ItemsSource = AppData.Context.LessonData(startDate, TimeSpan.Parse("12:00"), CurrentTeacher.Id, 1).ToList();
                //monday1230.ItemsSource = AppData.Context.LessonData(startDate, TimeSpan.Parse("12:30"), CurrentTeacher.Id, 1).ToList();
                //monday1300.ItemsSource = AppData.Context.LessonData(startDate, TimeSpan.Parse("13:00"), CurrentTeacher.Id, 1).ToList();
                //monday1330.ItemsSource = AppData.Context.LessonData(startDate, TimeSpan.Parse("13:30"), CurrentTeacher.Id, 1).ToList();
                //monday1400.ItemsSource = AppData.Context.LessonData(startDate, TimeSpan.Parse("14:00"), CurrentTeacher.Id, 1).ToList();
                //monday1430.ItemsSource = AppData.Context.LessonData(startDate, TimeSpan.Parse("14:30"), CurrentTeacher.Id, 1).ToList();
                //monday1500.ItemsSource = AppData.Context.LessonData(startDate, TimeSpan.Parse("15:00"), CurrentTeacher.Id, 1).ToList();
                //monday1530.ItemsSource = AppData.Context.LessonData(startDate, TimeSpan.Parse("15:30"), CurrentTeacher.Id, 1).ToList();
                //monday1600.ItemsSource = AppData.Context.LessonData(startDate, TimeSpan.Parse("16:00"), CurrentTeacher.Id, 1).ToList();
                //monday1630.ItemsSource = AppData.Context.LessonData(startDate, TimeSpan.Parse("16:30"), CurrentTeacher.Id, 1).ToList();
                //monday1700.ItemsSource = AppData.Context.LessonData(startDate, TimeSpan.Parse("17:00"), CurrentTeacher.Id, 1).ToList();
                //monday1730.ItemsSource = AppData.Context.LessonData(startDate, TimeSpan.Parse("17:30"), CurrentTeacher.Id, 1).ToList();
                //monday1800.ItemsSource = AppData.Context.LessonData(startDate, TimeSpan.Parse("18:00"), CurrentTeacher.Id, 1).ToList();
                //monday1830.ItemsSource = AppData.Context.LessonData(startDate, TimeSpan.Parse("18:30"), CurrentTeacher.Id, 1).ToList();
                //monday1900.ItemsSource = AppData.Context.LessonData(startDate, TimeSpan.Parse("19:00"), CurrentTeacher.Id, 1).ToList();
                //monday1930.ItemsSource = AppData.Context.LessonData(startDate, TimeSpan.Parse("19:30"), CurrentTeacher.Id, 1).ToList();
                //monday2000.ItemsSource = AppData.Context.LessonData(startDate, TimeSpan.Parse("20:00"), CurrentTeacher.Id, 1).ToList();
                //monday2030.ItemsSource = AppData.Context.LessonData(startDate, TimeSpan.Parse("20:30"), CurrentTeacher.Id, 1).ToList();
                //monday2100.ItemsSource = AppData.Context.LessonData(startDate, TimeSpan.Parse("21:00"), CurrentTeacher.Id, 1).ToList();
                //monday2130.ItemsSource = AppData.Context.LessonData(startDate, TimeSpan.Parse("21:30"), CurrentTeacher.Id, 1).ToList();

                //tuesday0900.ItemsSource = AppData.Context.LessonData(startDate.AddDays(1), TimeSpan.Parse("9:00"), CurrentTeacher.Id, 1).ToList();
                //tuesday0930.ItemsSource = AppData.Context.LessonData(startDate.AddDays(1), TimeSpan.Parse("9:30"), CurrentTeacher.Id, 1).ToList();
                //tuesday1000.ItemsSource = AppData.Context.LessonData(startDate.AddDays(1), TimeSpan.Parse("10:00"), CurrentTeacher.Id, 1).ToList();
                //tuesday1030.ItemsSource = AppData.Context.LessonData(startDate.AddDays(1), TimeSpan.Parse("10:30"), CurrentTeacher.Id, 1).ToList();
                //tuesday1100.ItemsSource = AppData.Context.LessonData(startDate.AddDays(1), TimeSpan.Parse("11:00"), CurrentTeacher.Id, 1).ToList();
                //tuesday1130.ItemsSource = AppData.Context.LessonData(startDate.AddDays(1), TimeSpan.Parse("11:30"), CurrentTeacher.Id, 1).ToList();
                //tuesday1200.ItemsSource = AppData.Context.LessonData(startDate.AddDays(1), TimeSpan.Parse("12:00"), CurrentTeacher.Id, 1).ToList();
                //tuesday1230.ItemsSource = AppData.Context.LessonData(startDate.AddDays(1), TimeSpan.Parse("12:30"), CurrentTeacher.Id, 1).ToList();
                //tuesday1300.ItemsSource = AppData.Context.LessonData(startDate.AddDays(1), TimeSpan.Parse("13:00"), CurrentTeacher.Id, 1).ToList();
                //tuesday1330.ItemsSource = AppData.Context.LessonData(startDate.AddDays(1), TimeSpan.Parse("13:30"), CurrentTeacher.Id, 1).ToList();
                //tuesday1400.ItemsSource = AppData.Context.LessonData(startDate.AddDays(1), TimeSpan.Parse("14:00"), CurrentTeacher.Id, 1).ToList();
                //tuesday1430.ItemsSource = AppData.Context.LessonData(startDate.AddDays(1), TimeSpan.Parse("14:30"), CurrentTeacher.Id, 1).ToList();
                //tuesday1500.ItemsSource = AppData.Context.LessonData(startDate.AddDays(1), TimeSpan.Parse("15:00"), CurrentTeacher.Id, 1).ToList();
                //tuesday1530.ItemsSource = AppData.Context.LessonData(startDate.AddDays(1), TimeSpan.Parse("15:30"), CurrentTeacher.Id, 1).ToList();
                //tuesday1600.ItemsSource = AppData.Context.LessonData(startDate.AddDays(1), TimeSpan.Parse("16:00"), CurrentTeacher.Id, 1).ToList();
                //tuesday1630.ItemsSource = AppData.Context.LessonData(startDate.AddDays(1), TimeSpan.Parse("16:30"), CurrentTeacher.Id, 1).ToList();
                //tuesday1700.ItemsSource = AppData.Context.LessonData(startDate.AddDays(1), TimeSpan.Parse("17:00"), CurrentTeacher.Id, 1).ToList();
                //tuesday1730.ItemsSource = AppData.Context.LessonData(startDate.AddDays(1), TimeSpan.Parse("17:30"), CurrentTeacher.Id, 1).ToList();
                //tuesday1800.ItemsSource = AppData.Context.LessonData(startDate.AddDays(1), TimeSpan.Parse("18:00"), CurrentTeacher.Id, 1).ToList();
                //tuesday1830.ItemsSource = AppData.Context.LessonData(startDate.AddDays(1), TimeSpan.Parse("18:30"), CurrentTeacher.Id, 1).ToList();
                //tuesday1900.ItemsSource = AppData.Context.LessonData(startDate.AddDays(1), TimeSpan.Parse("19:00"), CurrentTeacher.Id, 1).ToList();
                //tuesday1930.ItemsSource = AppData.Context.LessonData(startDate.AddDays(1), TimeSpan.Parse("19:30"), CurrentTeacher.Id, 1).ToList();
                //tuesday2000.ItemsSource = AppData.Context.LessonData(startDate.AddDays(1), TimeSpan.Parse("20:00"), CurrentTeacher.Id, 1).ToList();
                //tuesday2030.ItemsSource = AppData.Context.LessonData(startDate.AddDays(1), TimeSpan.Parse("20:30"), CurrentTeacher.Id, 1).ToList();
                //tuesday2100.ItemsSource = AppData.Context.LessonData(startDate.AddDays(1), TimeSpan.Parse("21:00"), CurrentTeacher.Id, 1).ToList();
                //tuesday2130.ItemsSource = AppData.Context.LessonData(startDate.AddDays(1), TimeSpan.Parse("21:30"), CurrentTeacher.Id, 1).ToList();

                //wednesday0900.ItemsSource = AppData.Context.LessonData(startDate.AddDays(2), TimeSpan.Parse("9:00"), CurrentTeacher.Id, 1).ToList();
                //wednesday0930.ItemsSource = AppData.Context.LessonData(startDate.AddDays(2), TimeSpan.Parse("9:30"), CurrentTeacher.Id, 1).ToList();
                //wednesday1000.ItemsSource = AppData.Context.LessonData(startDate.AddDays(2), TimeSpan.Parse("10:00"), CurrentTeacher.Id, 1).ToList();
                //wednesday1030.ItemsSource = AppData.Context.LessonData(startDate.AddDays(2), TimeSpan.Parse("10:30"), CurrentTeacher.Id, 1).ToList();
                //wednesday1100.ItemsSource = AppData.Context.LessonData(startDate.AddDays(2), TimeSpan.Parse("11:00"), CurrentTeacher.Id, 1).ToList();
                //wednesday1130.ItemsSource = AppData.Context.LessonData(startDate.AddDays(2), TimeSpan.Parse("11:30"), CurrentTeacher.Id, 1).ToList();
                //wednesday1200.ItemsSource = AppData.Context.LessonData(startDate.AddDays(2), TimeSpan.Parse("12:00"), CurrentTeacher.Id, 1).ToList();
                //wednesday1230.ItemsSource = AppData.Context.LessonData(startDate.AddDays(2), TimeSpan.Parse("12:30"), CurrentTeacher.Id, 1).ToList();
                //wednesday1300.ItemsSource = AppData.Context.LessonData(startDate.AddDays(2), TimeSpan.Parse("13:00"), CurrentTeacher.Id, 1).ToList();
                //wednesday1330.ItemsSource = AppData.Context.LessonData(startDate.AddDays(2), TimeSpan.Parse("13:30"), CurrentTeacher.Id, 1).ToList();
                //wednesday1400.ItemsSource = AppData.Context.LessonData(startDate.AddDays(2), TimeSpan.Parse("14:00"), CurrentTeacher.Id, 1).ToList();
                //wednesday1430.ItemsSource = AppData.Context.LessonData(startDate.AddDays(2), TimeSpan.Parse("14:30"), CurrentTeacher.Id, 1).ToList();
                //wednesday1500.ItemsSource = AppData.Context.LessonData(startDate.AddDays(2), TimeSpan.Parse("15:00"), CurrentTeacher.Id, 1).ToList();
                //wednesday1530.ItemsSource = AppData.Context.LessonData(startDate.AddDays(2), TimeSpan.Parse("15:30"), CurrentTeacher.Id, 1).ToList();
                //wednesday1600.ItemsSource = AppData.Context.LessonData(startDate.AddDays(2), TimeSpan.Parse("16:00"), CurrentTeacher.Id, 1).ToList();
                //wednesday1630.ItemsSource = AppData.Context.LessonData(startDate.AddDays(2), TimeSpan.Parse("16:30"), CurrentTeacher.Id, 1).ToList();
                //wednesday1700.ItemsSource = AppData.Context.LessonData(startDate.AddDays(2), TimeSpan.Parse("17:00"), CurrentTeacher.Id, 1).ToList();
                //wednesday1730.ItemsSource = AppData.Context.LessonData(startDate.AddDays(2), TimeSpan.Parse("17:30"), CurrentTeacher.Id, 1).ToList();
                //wednesday1800.ItemsSource = AppData.Context.LessonData(startDate.AddDays(2), TimeSpan.Parse("18:00"), CurrentTeacher.Id, 1).ToList();
                //wednesday1830.ItemsSource = AppData.Context.LessonData(startDate.AddDays(2), TimeSpan.Parse("18:30"), CurrentTeacher.Id, 1).ToList();
                //wednesday1900.ItemsSource = AppData.Context.LessonData(startDate.AddDays(2), TimeSpan.Parse("19:00"), CurrentTeacher.Id, 1).ToList();
                //wednesday1930.ItemsSource = AppData.Context.LessonData(startDate.AddDays(2), TimeSpan.Parse("19:30"), CurrentTeacher.Id, 1).ToList();
                //wednesday2000.ItemsSource = AppData.Context.LessonData(startDate.AddDays(2), TimeSpan.Parse("20:00"), CurrentTeacher.Id, 1).ToList();
                //wednesday2030.ItemsSource = AppData.Context.LessonData(startDate.AddDays(2), TimeSpan.Parse("20:30"), CurrentTeacher.Id, 1).ToList();
                //wednesday2100.ItemsSource = AppData.Context.LessonData(startDate.AddDays(2), TimeSpan.Parse("21:00"), CurrentTeacher.Id, 1).ToList();
                //wednesday2130.ItemsSource = AppData.Context.LessonData(startDate.AddDays(2), TimeSpan.Parse("21:30"), CurrentTeacher.Id, 1).ToList();

                //thursday0900.ItemsSource = AppData.Context.LessonData(startDate.AddDays(3), TimeSpan.Parse("9:00"), CurrentTeacher.Id, 1).ToList();
                //thursday0930.ItemsSource = AppData.Context.LessonData(startDate.AddDays(3), TimeSpan.Parse("9:30"), CurrentTeacher.Id, 1).ToList();
                //thursday1000.ItemsSource = AppData.Context.LessonData(startDate.AddDays(3), TimeSpan.Parse("10:00"), CurrentTeacher.Id, 1).ToList();
                //thursday1030.ItemsSource = AppData.Context.LessonData(startDate.AddDays(3), TimeSpan.Parse("10:30"), CurrentTeacher.Id, 1).ToList();
                //thursday1100.ItemsSource = AppData.Context.LessonData(startDate.AddDays(3), TimeSpan.Parse("11:00"), CurrentTeacher.Id, 1).ToList();
                //thursday1130.ItemsSource = AppData.Context.LessonData(startDate.AddDays(3), TimeSpan.Parse("11:30"), CurrentTeacher.Id, 1).ToList();
                //thursday1200.ItemsSource = AppData.Context.LessonData(startDate.AddDays(3), TimeSpan.Parse("12:00"), CurrentTeacher.Id, 1).ToList();
                //thursday1230.ItemsSource = AppData.Context.LessonData(startDate.AddDays(3), TimeSpan.Parse("12:30"), CurrentTeacher.Id, 1).ToList();
                //thursday1300.ItemsSource = AppData.Context.LessonData(startDate.AddDays(3), TimeSpan.Parse("13:00"), CurrentTeacher.Id, 1).ToList();
                //thursday1330.ItemsSource = AppData.Context.LessonData(startDate.AddDays(3), TimeSpan.Parse("13:30"), CurrentTeacher.Id, 1).ToList();
                //thursday1400.ItemsSource = AppData.Context.LessonData(startDate.AddDays(3), TimeSpan.Parse("14:00"), CurrentTeacher.Id, 1).ToList();
                //thursday1430.ItemsSource = AppData.Context.LessonData(startDate.AddDays(3), TimeSpan.Parse("14:30"), CurrentTeacher.Id, 1).ToList();
                //thursday1500.ItemsSource = AppData.Context.LessonData(startDate.AddDays(3), TimeSpan.Parse("15:00"), CurrentTeacher.Id, 1).ToList();
                //thursday1530.ItemsSource = AppData.Context.LessonData(startDate.AddDays(3), TimeSpan.Parse("15:30"), CurrentTeacher.Id, 1).ToList();
                //thursday1600.ItemsSource = AppData.Context.LessonData(startDate.AddDays(3), TimeSpan.Parse("16:00"), CurrentTeacher.Id, 1).ToList();
                //thursday1630.ItemsSource = AppData.Context.LessonData(startDate.AddDays(3), TimeSpan.Parse("16:30"), CurrentTeacher.Id, 1).ToList();
                //thursday1700.ItemsSource = AppData.Context.LessonData(startDate.AddDays(3), TimeSpan.Parse("17:00"), CurrentTeacher.Id, 1).ToList();
                //thursday1730.ItemsSource = AppData.Context.LessonData(startDate.AddDays(3), TimeSpan.Parse("17:30"), CurrentTeacher.Id, 1).ToList();
                //thursday1800.ItemsSource = AppData.Context.LessonData(startDate.AddDays(3), TimeSpan.Parse("18:00"), CurrentTeacher.Id, 1).ToList();
                //thursday1830.ItemsSource = AppData.Context.LessonData(startDate.AddDays(3), TimeSpan.Parse("18:30"), CurrentTeacher.Id, 1).ToList();
                //thursday1900.ItemsSource = AppData.Context.LessonData(startDate.AddDays(3), TimeSpan.Parse("19:00"), CurrentTeacher.Id, 1).ToList();
                //thursday1930.ItemsSource = AppData.Context.LessonData(startDate.AddDays(3), TimeSpan.Parse("19:30"), CurrentTeacher.Id, 1).ToList();
                //thursday2000.ItemsSource = AppData.Context.LessonData(startDate.AddDays(3), TimeSpan.Parse("20:00"), CurrentTeacher.Id, 1).ToList();
                //thursday2030.ItemsSource = AppData.Context.LessonData(startDate.AddDays(3), TimeSpan.Parse("20:30"), CurrentTeacher.Id, 1).ToList();
                //thursday2100.ItemsSource = AppData.Context.LessonData(startDate.AddDays(3), TimeSpan.Parse("21:00"), CurrentTeacher.Id, 1).ToList();
                //thursday2130.ItemsSource = AppData.Context.LessonData(startDate.AddDays(3), TimeSpan.Parse("21:30"), CurrentTeacher.Id, 1).ToList();

                //friday0900.ItemsSource = AppData.Context.LessonData(startDate.AddDays(4), TimeSpan.Parse("9:00"), CurrentTeacher.Id, 1).ToList();
                //friday0930.ItemsSource = AppData.Context.LessonData(startDate.AddDays(4), TimeSpan.Parse("9:30"), CurrentTeacher.Id, 1).ToList();
                //friday1000.ItemsSource = AppData.Context.LessonData(startDate.AddDays(4), TimeSpan.Parse("10:00"), CurrentTeacher.Id, 1).ToList();
                //friday1030.ItemsSource = AppData.Context.LessonData(startDate.AddDays(4), TimeSpan.Parse("10:30"), CurrentTeacher.Id, 1).ToList();
                //friday1100.ItemsSource = AppData.Context.LessonData(startDate.AddDays(4), TimeSpan.Parse("11:00"), CurrentTeacher.Id, 1).ToList();
                //friday1130.ItemsSource = AppData.Context.LessonData(startDate.AddDays(4), TimeSpan.Parse("11:30"), CurrentTeacher.Id, 1).ToList();
                //friday1200.ItemsSource = AppData.Context.LessonData(startDate.AddDays(4), TimeSpan.Parse("12:00"), CurrentTeacher.Id, 1).ToList();
                //friday1230.ItemsSource = AppData.Context.LessonData(startDate.AddDays(4), TimeSpan.Parse("12:30"), CurrentTeacher.Id, 1).ToList();
                //friday1300.ItemsSource = AppData.Context.LessonData(startDate.AddDays(4), TimeSpan.Parse("13:00"), CurrentTeacher.Id, 1).ToList();
                //friday1330.ItemsSource = AppData.Context.LessonData(startDate.AddDays(4), TimeSpan.Parse("13:30"), CurrentTeacher.Id, 1).ToList();
                //friday1400.ItemsSource = AppData.Context.LessonData(startDate.AddDays(4), TimeSpan.Parse("14:00"), CurrentTeacher.Id, 1).ToList();
                //friday1430.ItemsSource = AppData.Context.LessonData(startDate.AddDays(4), TimeSpan.Parse("14:30"), CurrentTeacher.Id, 1).ToList();
                //friday1500.ItemsSource = AppData.Context.LessonData(startDate.AddDays(4), TimeSpan.Parse("15:00"), CurrentTeacher.Id, 1).ToList();
                //friday1530.ItemsSource = AppData.Context.LessonData(startDate.AddDays(4), TimeSpan.Parse("15:30"), CurrentTeacher.Id, 1).ToList();
                //friday1600.ItemsSource = AppData.Context.LessonData(startDate.AddDays(4), TimeSpan.Parse("16:00"), CurrentTeacher.Id, 1).ToList();
                //friday1630.ItemsSource = AppData.Context.LessonData(startDate.AddDays(4), TimeSpan.Parse("16:30"), CurrentTeacher.Id, 1).ToList();
                //friday1700.ItemsSource = AppData.Context.LessonData(startDate.AddDays(4), TimeSpan.Parse("17:00"), CurrentTeacher.Id, 1).ToList();
                //friday1730.ItemsSource = AppData.Context.LessonData(startDate.AddDays(4), TimeSpan.Parse("17:30"), CurrentTeacher.Id, 1).ToList();
                //friday1800.ItemsSource = AppData.Context.LessonData(startDate.AddDays(4), TimeSpan.Parse("18:00"), CurrentTeacher.Id, 1).ToList();
                //friday1830.ItemsSource = AppData.Context.LessonData(startDate.AddDays(4), TimeSpan.Parse("18:30"), CurrentTeacher.Id, 1).ToList();
                //friday1900.ItemsSource = AppData.Context.LessonData(startDate.AddDays(4), TimeSpan.Parse("19:00"), CurrentTeacher.Id, 1).ToList();
                //friday1930.ItemsSource = AppData.Context.LessonData(startDate.AddDays(4), TimeSpan.Parse("19:30"), CurrentTeacher.Id, 1).ToList();
                //friday2000.ItemsSource = AppData.Context.LessonData(startDate.AddDays(4), TimeSpan.Parse("20:00"), CurrentTeacher.Id, 1).ToList();
                //friday2030.ItemsSource = AppData.Context.LessonData(startDate.AddDays(4), TimeSpan.Parse("20:30"), CurrentTeacher.Id, 1).ToList();
                //friday2100.ItemsSource = AppData.Context.LessonData(startDate.AddDays(4), TimeSpan.Parse("21:00"), CurrentTeacher.Id, 1).ToList();
                //friday2130.ItemsSource = AppData.Context.LessonData(startDate.AddDays(4), TimeSpan.Parse("21:30"), CurrentTeacher.Id, 1).ToList();

                //saturday0900.ItemsSource = AppData.Context.LessonData(startDate.AddDays(5), TimeSpan.Parse("9:00"), CurrentTeacher.Id, 1).ToList();
                //saturday0930.ItemsSource = AppData.Context.LessonData(startDate.AddDays(5), TimeSpan.Parse("9:30"), CurrentTeacher.Id, 1).ToList();
                //saturday1000.ItemsSource = AppData.Context.LessonData(startDate.AddDays(5), TimeSpan.Parse("10:00"), CurrentTeacher.Id, 1).ToList();
                //saturday1030.ItemsSource = AppData.Context.LessonData(startDate.AddDays(5), TimeSpan.Parse("10:30"), CurrentTeacher.Id, 1).ToList();
                //saturday1100.ItemsSource = AppData.Context.LessonData(startDate.AddDays(5), TimeSpan.Parse("11:00"), CurrentTeacher.Id, 1).ToList();
                //saturday1130.ItemsSource = AppData.Context.LessonData(startDate.AddDays(5), TimeSpan.Parse("11:30"), CurrentTeacher.Id, 1).ToList();
                //saturday1200.ItemsSource = AppData.Context.LessonData(startDate.AddDays(5), TimeSpan.Parse("12:00"), CurrentTeacher.Id, 1).ToList();
                //saturday1230.ItemsSource = AppData.Context.LessonData(startDate.AddDays(5), TimeSpan.Parse("12:30"), CurrentTeacher.Id, 1).ToList();
                //saturday1300.ItemsSource = AppData.Context.LessonData(startDate.AddDays(5), TimeSpan.Parse("13:00"), CurrentTeacher.Id, 1).ToList();
                //saturday1330.ItemsSource = AppData.Context.LessonData(startDate.AddDays(5), TimeSpan.Parse("13:30"), CurrentTeacher.Id, 1).ToList();
                //saturday1400.ItemsSource = AppData.Context.LessonData(startDate.AddDays(5), TimeSpan.Parse("14:00"), CurrentTeacher.Id, 1).ToList();
                //saturday1430.ItemsSource = AppData.Context.LessonData(startDate.AddDays(5), TimeSpan.Parse("14:30"), CurrentTeacher.Id, 1).ToList();
                //saturday1500.ItemsSource = AppData.Context.LessonData(startDate.AddDays(5), TimeSpan.Parse("15:00"), CurrentTeacher.Id, 1).ToList();
                //saturday1530.ItemsSource = AppData.Context.LessonData(startDate.AddDays(5), TimeSpan.Parse("15:30"), CurrentTeacher.Id, 1).ToList();
                //saturday1600.ItemsSource = AppData.Context.LessonData(startDate.AddDays(5), TimeSpan.Parse("16:00"), CurrentTeacher.Id, 1).ToList();
                //saturday1630.ItemsSource = AppData.Context.LessonData(startDate.AddDays(5), TimeSpan.Parse("16:30"), CurrentTeacher.Id, 1).ToList();
                //saturday1700.ItemsSource = AppData.Context.LessonData(startDate.AddDays(5), TimeSpan.Parse("17:00"), CurrentTeacher.Id, 1).ToList();
                //saturday1730.ItemsSource = AppData.Context.LessonData(startDate.AddDays(5), TimeSpan.Parse("17:30"), CurrentTeacher.Id, 1).ToList();
                //saturday1800.ItemsSource = AppData.Context.LessonData(startDate.AddDays(5), TimeSpan.Parse("18:00"), CurrentTeacher.Id, 1).ToList();
                //saturday1830.ItemsSource = AppData.Context.LessonData(startDate.AddDays(5), TimeSpan.Parse("18:30"), CurrentTeacher.Id, 1).ToList();
                //saturday1900.ItemsSource = AppData.Context.LessonData(startDate.AddDays(5), TimeSpan.Parse("19:00"), CurrentTeacher.Id, 1).ToList();
                //saturday1930.ItemsSource = AppData.Context.LessonData(startDate.AddDays(5), TimeSpan.Parse("19:30"), CurrentTeacher.Id, 1).ToList();
                //saturday2000.ItemsSource = AppData.Context.LessonData(startDate.AddDays(5), TimeSpan.Parse("20:00"), CurrentTeacher.Id, 1).ToList();
                //saturday2030.ItemsSource = AppData.Context.LessonData(startDate.AddDays(5), TimeSpan.Parse("20:30"), CurrentTeacher.Id, 1).ToList();
                //saturday2100.ItemsSource = AppData.Context.LessonData(startDate.AddDays(5), TimeSpan.Parse("21:00"), CurrentTeacher.Id, 1).ToList();
                //saturday2130.ItemsSource = AppData.Context.LessonData(startDate.AddDays(5), TimeSpan.Parse("21:30"), CurrentTeacher.Id, 1).ToList();

                //sunday0900.ItemsSource = AppData.Context.LessonData(startDate.AddDays(6), TimeSpan.Parse("9:00"), CurrentTeacher.Id, 1).ToList();
                //sunday0930.ItemsSource = AppData.Context.LessonData(startDate.AddDays(6), TimeSpan.Parse("9:30"), CurrentTeacher.Id, 1).ToList();
                //sunday1000.ItemsSource = AppData.Context.LessonData(startDate.AddDays(6), TimeSpan.Parse("10:00"), CurrentTeacher.Id, 1).ToList();
                //sunday1030.ItemsSource = AppData.Context.LessonData(startDate.AddDays(6), TimeSpan.Parse("10:30"), CurrentTeacher.Id, 1).ToList();
                //sunday1100.ItemsSource = AppData.Context.LessonData(startDate.AddDays(6), TimeSpan.Parse("11:00"), CurrentTeacher.Id, 1).ToList();
                //sunday1130.ItemsSource = AppData.Context.LessonData(startDate.AddDays(6), TimeSpan.Parse("11:30"), CurrentTeacher.Id, 1).ToList();
                //sunday1200.ItemsSource = AppData.Context.LessonData(startDate.AddDays(6), TimeSpan.Parse("12:00"), CurrentTeacher.Id, 1).ToList();
                //sunday1230.ItemsSource = AppData.Context.LessonData(startDate.AddDays(6), TimeSpan.Parse("12:30"), CurrentTeacher.Id, 1).ToList();
                //sunday1300.ItemsSource = AppData.Context.LessonData(startDate.AddDays(6), TimeSpan.Parse("13:00"), CurrentTeacher.Id, 1).ToList();
                //sunday1330.ItemsSource = AppData.Context.LessonData(startDate.AddDays(6), TimeSpan.Parse("13:30"), CurrentTeacher.Id, 1).ToList();
                //sunday1400.ItemsSource = AppData.Context.LessonData(startDate.AddDays(6), TimeSpan.Parse("14:00"), CurrentTeacher.Id, 1).ToList();
                //sunday1430.ItemsSource = AppData.Context.LessonData(startDate.AddDays(6), TimeSpan.Parse("14:30"), CurrentTeacher.Id, 1).ToList();
                //sunday1500.ItemsSource = AppData.Context.LessonData(startDate.AddDays(6), TimeSpan.Parse("15:00"), CurrentTeacher.Id, 1).ToList();
                //sunday1530.ItemsSource = AppData.Context.LessonData(startDate.AddDays(6), TimeSpan.Parse("15:30"), CurrentTeacher.Id, 1).ToList();
                //sunday1600.ItemsSource = AppData.Context.LessonData(startDate.AddDays(6), TimeSpan.Parse("16:00"), CurrentTeacher.Id, 1).ToList();
                //sunday1630.ItemsSource = AppData.Context.LessonData(startDate.AddDays(6), TimeSpan.Parse("16:30"), CurrentTeacher.Id, 1).ToList();
                //sunday1700.ItemsSource = AppData.Context.LessonData(startDate.AddDays(6), TimeSpan.Parse("17:00"), CurrentTeacher.Id, 1).ToList();
                //sunday1730.ItemsSource = AppData.Context.LessonData(startDate.AddDays(6), TimeSpan.Parse("17:30"), CurrentTeacher.Id, 1).ToList();
                //sunday1800.ItemsSource = AppData.Context.LessonData(startDate.AddDays(6), TimeSpan.Parse("18:00"), CurrentTeacher.Id, 1).ToList();
                //sunday1830.ItemsSource = AppData.Context.LessonData(startDate.AddDays(6), TimeSpan.Parse("18:30"), CurrentTeacher.Id, 1).ToList();
                //sunday1900.ItemsSource = AppData.Context.LessonData(startDate.AddDays(6), TimeSpan.Parse("19:00"), CurrentTeacher.Id, 1).ToList();
                //sunday1930.ItemsSource = AppData.Context.LessonData(startDate.AddDays(6), TimeSpan.Parse("19:30"), CurrentTeacher.Id, 1).ToList();
                //sunday2000.ItemsSource = AppData.Context.LessonData(startDate.AddDays(6), TimeSpan.Parse("20:00"), CurrentTeacher.Id, 1).ToList();
                //sunday2030.ItemsSource = AppData.Context.LessonData(startDate.AddDays(6), TimeSpan.Parse("20:30"), CurrentTeacher.Id, 1).ToList();
                //sunday2100.ItemsSource = AppData.Context.LessonData(startDate.AddDays(6), TimeSpan.Parse("21:00"), CurrentTeacher.Id, 1).ToList();
                //sunday2130.ItemsSource = AppData.Context.LessonData(startDate.AddDays(6), TimeSpan.Parse("21:30"), CurrentTeacher.Id, 1).ToList();

                //mondayClients0900.ItemsSource = AppData.Context.ClientLessonData(startDate, TimeSpan.Parse("9:00"), CurrentTeacher.Id, 1).ToList();
                //mondayClients0930.ItemsSource = AppData.Context.ClientLessonData(startDate, TimeSpan.Parse("9:30"), CurrentTeacher.Id, 1).ToList();
                //mondayClients1000.ItemsSource = AppData.Context.ClientLessonData(startDate, TimeSpan.Parse("10:00"), CurrentTeacher.Id, 1).ToList();
                //mondayClients1030.ItemsSource = AppData.Context.ClientLessonData(startDate, TimeSpan.Parse("10:30"), CurrentTeacher.Id, 1).ToList();
                //mondayClients1100.ItemsSource = AppData.Context.ClientLessonData(startDate, TimeSpan.Parse("11:00"), CurrentTeacher.Id, 1).ToList();
                //mondayClients1130.ItemsSource = AppData.Context.ClientLessonData(startDate, TimeSpan.Parse("11:30"), CurrentTeacher.Id, 1).ToList();
                //mondayClients1200.ItemsSource = AppData.Context.ClientLessonData(startDate, TimeSpan.Parse("12:00"), CurrentTeacher.Id, 1).ToList();
                //mondayClients1230.ItemsSource = AppData.Context.ClientLessonData(startDate, TimeSpan.Parse("12:30"), CurrentTeacher.Id, 1).ToList();
                //mondayClients1300.ItemsSource = AppData.Context.ClientLessonData(startDate, TimeSpan.Parse("13:00"), CurrentTeacher.Id, 1).ToList();
                //mondayClients1330.ItemsSource = AppData.Context.ClientLessonData(startDate, TimeSpan.Parse("13:30"), CurrentTeacher.Id, 1).ToList();
                //mondayClients1400.ItemsSource = AppData.Context.ClientLessonData(startDate, TimeSpan.Parse("14:00"), CurrentTeacher.Id, 1).ToList();
                //mondayClients1430.ItemsSource = AppData.Context.ClientLessonData(startDate, TimeSpan.Parse("14:30"), CurrentTeacher.Id, 1).ToList();
                //mondayClients1500.ItemsSource = AppData.Context.ClientLessonData(startDate, TimeSpan.Parse("15:00"), CurrentTeacher.Id, 1).ToList();
                //mondayClients1530.ItemsSource = AppData.Context.ClientLessonData(startDate, TimeSpan.Parse("15:30"), CurrentTeacher.Id, 1).ToList();
                //mondayClients1600.ItemsSource = AppData.Context.ClientLessonData(startDate, TimeSpan.Parse("16:00"), CurrentTeacher.Id, 1).ToList();
                //mondayClients1630.ItemsSource = AppData.Context.ClientLessonData(startDate, TimeSpan.Parse("16:30"), CurrentTeacher.Id, 1).ToList();
                //mondayClients1700.ItemsSource = AppData.Context.ClientLessonData(startDate, TimeSpan.Parse("17:00"), CurrentTeacher.Id, 1).ToList();
                //mondayClients1730.ItemsSource = AppData.Context.ClientLessonData(startDate, TimeSpan.Parse("17:30"), CurrentTeacher.Id, 1).ToList();
                //mondayClients1800.ItemsSource = AppData.Context.ClientLessonData(startDate, TimeSpan.Parse("18:00"), CurrentTeacher.Id, 1).ToList();
                //mondayClients1830.ItemsSource = AppData.Context.ClientLessonData(startDate, TimeSpan.Parse("18:30"), CurrentTeacher.Id, 1).ToList();
                //mondayClients1900.ItemsSource = AppData.Context.ClientLessonData(startDate, TimeSpan.Parse("19:00"), CurrentTeacher.Id, 1).ToList();
                //mondayClients1930.ItemsSource = AppData.Context.ClientLessonData(startDate, TimeSpan.Parse("19:30"), CurrentTeacher.Id, 1).ToList();
                //mondayClients2000.ItemsSource = AppData.Context.ClientLessonData(startDate, TimeSpan.Parse("20:00"), CurrentTeacher.Id, 1).ToList();
                //mondayClients2030.ItemsSource = AppData.Context.ClientLessonData(startDate, TimeSpan.Parse("20:30"), CurrentTeacher.Id, 1).ToList();
                //mondayClients2100.ItemsSource = AppData.Context.ClientLessonData(startDate, TimeSpan.Parse("21:00"), CurrentTeacher.Id, 1).ToList();
                //mondayClients2130.ItemsSource = AppData.Context.ClientLessonData(startDate, TimeSpan.Parse("21:30"), CurrentTeacher.Id, 1).ToList();

                //tuesdayClients0900.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(1), TimeSpan.Parse("9:00"), CurrentTeacher.Id, 1).ToList();
                //tuesdayClients0930.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(1), TimeSpan.Parse("9:30"), CurrentTeacher.Id, 1).ToList();
                //tuesdayClients1000.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(1), TimeSpan.Parse("10:00"), CurrentTeacher.Id, 1).ToList();
                //tuesdayClients1030.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(1), TimeSpan.Parse("10:30"), CurrentTeacher.Id, 1).ToList();
                //tuesdayClients1100.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(1), TimeSpan.Parse("11:00"), CurrentTeacher.Id, 1).ToList();
                //tuesdayClients1130.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(1), TimeSpan.Parse("11:30"), CurrentTeacher.Id, 1).ToList();
                //tuesdayClients1200.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(1), TimeSpan.Parse("12:00"), CurrentTeacher.Id, 1).ToList();
                //tuesdayClients1230.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(1), TimeSpan.Parse("12:30"), CurrentTeacher.Id, 1).ToList();
                //tuesdayClients1300.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(1), TimeSpan.Parse("13:00"), CurrentTeacher.Id, 1).ToList();
                //tuesdayClients1330.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(1), TimeSpan.Parse("13:30"), CurrentTeacher.Id, 1).ToList();
                //tuesdayClients1400.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(1), TimeSpan.Parse("14:00"), CurrentTeacher.Id, 1).ToList();
                //tuesdayClients1430.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(1), TimeSpan.Parse("14:30"), CurrentTeacher.Id, 1).ToList();
                //tuesdayClients1500.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(1), TimeSpan.Parse("15:00"), CurrentTeacher.Id, 1).ToList();
                //tuesdayClients1530.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(1), TimeSpan.Parse("15:30"), CurrentTeacher.Id, 1).ToList();
                //tuesdayClients1600.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(1), TimeSpan.Parse("16:00"), CurrentTeacher.Id, 1).ToList();
                //tuesdayClients1630.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(1), TimeSpan.Parse("16:30"), CurrentTeacher.Id, 1).ToList();
                //tuesdayClients1700.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(1), TimeSpan.Parse("17:00"), CurrentTeacher.Id, 1).ToList();
                //tuesdayClients1730.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(1), TimeSpan.Parse("17:30"), CurrentTeacher.Id, 1).ToList();
                //tuesdayClients1800.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(1), TimeSpan.Parse("18:00"), CurrentTeacher.Id, 1).ToList();
                //tuesdayClients1830.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(1), TimeSpan.Parse("18:30"), CurrentTeacher.Id, 1).ToList();
                //tuesdayClients1900.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(1), TimeSpan.Parse("19:00"), CurrentTeacher.Id, 1).ToList();
                //tuesdayClients1930.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(1), TimeSpan.Parse("19:30"), CurrentTeacher.Id, 1).ToList();
                //tuesdayClients2000.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(1), TimeSpan.Parse("20:00"), CurrentTeacher.Id, 1).ToList();
                //tuesdayClients2030.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(1), TimeSpan.Parse("20:30"), CurrentTeacher.Id, 1).ToList();
                //tuesdayClients2100.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(1), TimeSpan.Parse("21:00"), CurrentTeacher.Id, 1).ToList();
                //tuesdayClients2130.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(1), TimeSpan.Parse("21:30"), CurrentTeacher.Id, 1).ToList();

                //wednesdayClients0900.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(2), TimeSpan.Parse("9:00"), CurrentTeacher.Id, 1).ToList();
                //wednesdayClients0930.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(2), TimeSpan.Parse("9:30"), CurrentTeacher.Id, 1).ToList();
                //wednesdayClients1000.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(2), TimeSpan.Parse("10:00"), CurrentTeacher.Id, 1).ToList();
                //wednesdayClients1030.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(2), TimeSpan.Parse("10:30"), CurrentTeacher.Id, 1).ToList();
                //wednesdayClients1100.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(2), TimeSpan.Parse("11:00"), CurrentTeacher.Id, 1).ToList();
                //wednesdayClients1130.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(2), TimeSpan.Parse("11:30"), CurrentTeacher.Id, 1).ToList();
                //wednesdayClients1200.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(2), TimeSpan.Parse("12:00"), CurrentTeacher.Id, 1).ToList();
                //wednesdayClients1230.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(2), TimeSpan.Parse("12:30"), CurrentTeacher.Id, 1).ToList();
                //wednesdayClients1300.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(2), TimeSpan.Parse("13:00"), CurrentTeacher.Id, 1).ToList();
                //wednesdayClients1330.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(2), TimeSpan.Parse("13:30"), CurrentTeacher.Id, 1).ToList();
                //wednesdayClients1400.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(2), TimeSpan.Parse("14:00"), CurrentTeacher.Id, 1).ToList();
                //wednesdayClients1430.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(2), TimeSpan.Parse("14:30"), CurrentTeacher.Id, 1).ToList();
                //wednesdayClients1500.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(2), TimeSpan.Parse("15:00"), CurrentTeacher.Id, 1).ToList();
                //wednesdayClients1530.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(2), TimeSpan.Parse("15:30"), CurrentTeacher.Id, 1).ToList();
                //wednesdayClients1600.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(2), TimeSpan.Parse("16:00"), CurrentTeacher.Id, 1).ToList();
                //wednesdayClients1630.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(2), TimeSpan.Parse("16:30"), CurrentTeacher.Id, 1).ToList();
                //wednesdayClients1700.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(2), TimeSpan.Parse("17:00"), CurrentTeacher.Id, 1).ToList();
                //wednesdayClients1730.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(2), TimeSpan.Parse("17:30"), CurrentTeacher.Id, 1).ToList();
                //wednesdayClients1800.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(2), TimeSpan.Parse("18:00"), CurrentTeacher.Id, 1).ToList();
                //wednesdayClients1830.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(2), TimeSpan.Parse("18:30"), CurrentTeacher.Id, 1).ToList();
                //wednesdayClients1900.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(2), TimeSpan.Parse("19:00"), CurrentTeacher.Id, 1).ToList();
                //wednesdayClients1930.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(2), TimeSpan.Parse("19:30"), CurrentTeacher.Id, 1).ToList();
                //wednesdayClients2000.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(2), TimeSpan.Parse("20:00"), CurrentTeacher.Id, 1).ToList();
                //wednesdayClients2030.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(2), TimeSpan.Parse("20:30"), CurrentTeacher.Id, 1).ToList();
                //wednesdayClients2100.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(2), TimeSpan.Parse("21:00"), CurrentTeacher.Id, 1).ToList();
                //wednesdayClients2130.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(2), TimeSpan.Parse("21:30"), CurrentTeacher.Id, 1).ToList();

                //thursdayClients0900.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(3), TimeSpan.Parse("9:00"), CurrentTeacher.Id, 1).ToList();
                //thursdayClients0930.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(3), TimeSpan.Parse("9:30"), CurrentTeacher.Id, 1).ToList();
                //thursdayClients1000.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(3), TimeSpan.Parse("10:00"), CurrentTeacher.Id, 1).ToList();
                //thursdayClients1030.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(3), TimeSpan.Parse("10:30"), CurrentTeacher.Id, 1).ToList();
                //thursdayClients1100.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(3), TimeSpan.Parse("11:00"), CurrentTeacher.Id, 1).ToList();
                //thursdayClients1130.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(3), TimeSpan.Parse("11:30"), CurrentTeacher.Id, 1).ToList();
                //thursdayClients1200.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(3), TimeSpan.Parse("12:00"), CurrentTeacher.Id, 1).ToList();
                //thursdayClients1230.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(3), TimeSpan.Parse("12:30"), CurrentTeacher.Id, 1).ToList();
                //thursdayClients1300.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(3), TimeSpan.Parse("13:00"), CurrentTeacher.Id, 1).ToList();
                //thursdayClients1330.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(3), TimeSpan.Parse("13:30"), CurrentTeacher.Id, 1).ToList();
                //thursdayClients1400.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(3), TimeSpan.Parse("14:00"), CurrentTeacher.Id, 1).ToList();
                //thursdayClients1430.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(3), TimeSpan.Parse("14:30"), CurrentTeacher.Id, 1).ToList();
                //thursdayClients1500.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(3), TimeSpan.Parse("15:00"), CurrentTeacher.Id, 1).ToList();
                //thursdayClients1530.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(3), TimeSpan.Parse("15:30"), CurrentTeacher.Id, 1).ToList();
                //thursdayClients1600.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(3), TimeSpan.Parse("16:00"), CurrentTeacher.Id, 1).ToList();
                //thursdayClients1630.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(3), TimeSpan.Parse("16:30"), CurrentTeacher.Id, 1).ToList();
                //thursdayClients1700.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(3), TimeSpan.Parse("17:00"), CurrentTeacher.Id, 1).ToList();
                //thursdayClients1730.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(3), TimeSpan.Parse("17:30"), CurrentTeacher.Id, 1).ToList();
                //thursdayClients1800.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(3), TimeSpan.Parse("18:00"), CurrentTeacher.Id, 1).ToList();
                //thursdayClients1830.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(3), TimeSpan.Parse("18:30"), CurrentTeacher.Id, 1).ToList();
                //thursdayClients1900.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(3), TimeSpan.Parse("19:00"), CurrentTeacher.Id, 1).ToList();
                //thursdayClients1930.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(3), TimeSpan.Parse("19:30"), CurrentTeacher.Id, 1).ToList();
                //thursdayClients2000.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(3), TimeSpan.Parse("20:00"), CurrentTeacher.Id, 1).ToList();
                //thursdayClients2030.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(3), TimeSpan.Parse("20:30"), CurrentTeacher.Id, 1).ToList();
                //thursdayClients2100.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(3), TimeSpan.Parse("21:00"), CurrentTeacher.Id, 1).ToList();
                //thursdayClients2130.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(3), TimeSpan.Parse("21:30"), CurrentTeacher.Id, 1).ToList();

                //fridayClients0900.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(4), TimeSpan.Parse("9:00"), CurrentTeacher.Id, 1).ToList();
                //fridayClients0930.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(4), TimeSpan.Parse("9:30"), CurrentTeacher.Id, 1).ToList();
                //fridayClients1000.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(4), TimeSpan.Parse("10:00"), CurrentTeacher.Id, 1).ToList();
                //fridayClients1030.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(4), TimeSpan.Parse("10:30"), CurrentTeacher.Id, 1).ToList();
                //fridayClients1100.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(4), TimeSpan.Parse("11:00"), CurrentTeacher.Id, 1).ToList();
                //fridayClients1130.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(4), TimeSpan.Parse("11:30"), CurrentTeacher.Id, 1).ToList();
                //fridayClients1200.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(4), TimeSpan.Parse("12:00"), CurrentTeacher.Id, 1).ToList();
                //fridayClients1230.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(4), TimeSpan.Parse("12:30"), CurrentTeacher.Id, 1).ToList();
                //fridayClients1300.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(4), TimeSpan.Parse("13:00"), CurrentTeacher.Id, 1).ToList();
                //fridayClients1330.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(4), TimeSpan.Parse("13:30"), CurrentTeacher.Id, 1).ToList();
                //fridayClients1400.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(4), TimeSpan.Parse("14:00"), CurrentTeacher.Id, 1).ToList();
                //fridayClients1430.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(4), TimeSpan.Parse("14:30"), CurrentTeacher.Id, 1).ToList();
                //fridayClients1500.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(4), TimeSpan.Parse("15:00"), CurrentTeacher.Id, 1).ToList();
                //fridayClients1530.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(4), TimeSpan.Parse("15:30"), CurrentTeacher.Id, 1).ToList();
                //fridayClients1600.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(4), TimeSpan.Parse("16:00"), CurrentTeacher.Id, 1).ToList();
                //fridayClients1630.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(4), TimeSpan.Parse("16:30"), CurrentTeacher.Id, 1).ToList();
                //fridayClients1700.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(4), TimeSpan.Parse("17:00"), CurrentTeacher.Id, 1).ToList();
                //fridayClients1730.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(4), TimeSpan.Parse("17:30"), CurrentTeacher.Id, 1).ToList();
                //fridayClients1800.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(4), TimeSpan.Parse("18:00"), CurrentTeacher.Id, 1).ToList();
                //fridayClients1830.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(4), TimeSpan.Parse("18:30"), CurrentTeacher.Id, 1).ToList();
                //fridayClients1900.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(4), TimeSpan.Parse("19:00"), CurrentTeacher.Id, 1).ToList();
                //fridayClients1930.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(4), TimeSpan.Parse("19:30"), CurrentTeacher.Id, 1).ToList();
                //fridayClients2000.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(4), TimeSpan.Parse("20:00"), CurrentTeacher.Id, 1).ToList();
                //fridayClients2030.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(4), TimeSpan.Parse("20:30"), CurrentTeacher.Id, 1).ToList();
                //fridayClients2100.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(4), TimeSpan.Parse("21:00"), CurrentTeacher.Id, 1).ToList();
                //fridayClients2130.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(4), TimeSpan.Parse("21:30"), CurrentTeacher.Id, 1).ToList();

                //saturdayClients0900.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(5), TimeSpan.Parse("9:00"), CurrentTeacher.Id, 1).ToList();
                //saturdayClients0930.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(5), TimeSpan.Parse("9:30"), CurrentTeacher.Id, 1).ToList();
                //saturdayClients1000.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(5), TimeSpan.Parse("10:00"), CurrentTeacher.Id, 1).ToList();
                //saturdayClients1030.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(5), TimeSpan.Parse("10:30"), CurrentTeacher.Id, 1).ToList();
                //saturdayClients1100.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(5), TimeSpan.Parse("11:00"), CurrentTeacher.Id, 1).ToList();
                //saturdayClients1130.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(5), TimeSpan.Parse("11:30"), CurrentTeacher.Id, 1).ToList();
                //saturdayClients1200.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(5), TimeSpan.Parse("12:00"), CurrentTeacher.Id, 1).ToList();
                //saturdayClients1230.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(5), TimeSpan.Parse("12:30"), CurrentTeacher.Id, 1).ToList();
                //saturdayClients1300.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(5), TimeSpan.Parse("13:00"), CurrentTeacher.Id, 1).ToList();
                //saturdayClients1330.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(5), TimeSpan.Parse("13:30"), CurrentTeacher.Id, 1).ToList();
                //saturdayClients1400.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(5), TimeSpan.Parse("14:00"), CurrentTeacher.Id, 1).ToList();
                //saturdayClients1430.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(5), TimeSpan.Parse("14:30"), CurrentTeacher.Id, 1).ToList();
                //saturdayClients1500.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(5), TimeSpan.Parse("15:00"), CurrentTeacher.Id, 1).ToList();
                //saturdayClients1530.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(5), TimeSpan.Parse("15:30"), CurrentTeacher.Id, 1).ToList();
                //saturdayClients1600.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(5), TimeSpan.Parse("16:00"), CurrentTeacher.Id, 1).ToList();
                //saturdayClients1630.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(5), TimeSpan.Parse("16:30"), CurrentTeacher.Id, 1).ToList();
                //saturdayClients1700.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(5), TimeSpan.Parse("17:00"), CurrentTeacher.Id, 1).ToList();
                //saturdayClients1730.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(5), TimeSpan.Parse("17:30"), CurrentTeacher.Id, 1).ToList();
                //saturdayClients1800.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(5), TimeSpan.Parse("18:00"), CurrentTeacher.Id, 1).ToList();
                //saturdayClients1830.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(5), TimeSpan.Parse("18:30"), CurrentTeacher.Id, 1).ToList();
                //saturdayClients1900.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(5), TimeSpan.Parse("19:00"), CurrentTeacher.Id, 1).ToList();
                //saturdayClients1930.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(5), TimeSpan.Parse("19:30"), CurrentTeacher.Id, 1).ToList();
                //saturdayClients2000.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(5), TimeSpan.Parse("20:00"), CurrentTeacher.Id, 1).ToList();
                //saturdayClients2030.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(5), TimeSpan.Parse("20:30"), CurrentTeacher.Id, 1).ToList();
                //saturdayClients2100.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(5), TimeSpan.Parse("21:00"), CurrentTeacher.Id, 1).ToList();
                //saturdayClients2130.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(5), TimeSpan.Parse("21:30"), CurrentTeacher.Id, 1).ToList();

                //sundayClients0900.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(6), TimeSpan.Parse("9:00"), CurrentTeacher.Id, 1).ToList();
                //sundayClients0930.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(6), TimeSpan.Parse("9:30"), CurrentTeacher.Id, 1).ToList();
                //sundayClients1000.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(6), TimeSpan.Parse("10:00"), CurrentTeacher.Id, 1).ToList();
                //sundayClients1030.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(6), TimeSpan.Parse("10:30"), CurrentTeacher.Id, 1).ToList();
                //sundayClients1100.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(6), TimeSpan.Parse("11:00"), CurrentTeacher.Id, 1).ToList();
                //sundayClients1130.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(6), TimeSpan.Parse("11:30"), CurrentTeacher.Id, 1).ToList();
                //sundayClients1200.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(6), TimeSpan.Parse("12:00"), CurrentTeacher.Id, 1).ToList();
                //sundayClients1230.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(6), TimeSpan.Parse("12:30"), CurrentTeacher.Id, 1).ToList();
                //sundayClients1300.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(6), TimeSpan.Parse("13:00"), CurrentTeacher.Id, 1).ToList();
                //sundayClients1330.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(6), TimeSpan.Parse("13:30"), CurrentTeacher.Id, 1).ToList();
                //sundayClients1400.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(6), TimeSpan.Parse("14:00"), CurrentTeacher.Id, 1).ToList();
                //sundayClients1430.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(6), TimeSpan.Parse("14:30"), CurrentTeacher.Id, 1).ToList();
                //sundayClients1500.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(6), TimeSpan.Parse("15:00"), CurrentTeacher.Id, 1).ToList();
                //sundayClients1530.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(6), TimeSpan.Parse("15:30"), CurrentTeacher.Id, 1).ToList();
                //sundayClients1600.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(6), TimeSpan.Parse("16:00"), CurrentTeacher.Id, 1).ToList();
                //sundayClients1630.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(6), TimeSpan.Parse("16:30"), CurrentTeacher.Id, 1).ToList();
                //sundayClients1700.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(6), TimeSpan.Parse("17:00"), CurrentTeacher.Id, 1).ToList();
                //sundayClients1730.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(6), TimeSpan.Parse("17:30"), CurrentTeacher.Id, 1).ToList();
                //sundayClients1800.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(6), TimeSpan.Parse("18:00"), CurrentTeacher.Id, 1).ToList();
                //sundayClients1830.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(6), TimeSpan.Parse("18:30"), CurrentTeacher.Id, 1).ToList();
                //sundayClients1900.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(6), TimeSpan.Parse("19:00"), CurrentTeacher.Id, 1).ToList();
                //sundayClients1930.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(6), TimeSpan.Parse("19:30"), CurrentTeacher.Id, 1).ToList();
                //sundayClients2000.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(6), TimeSpan.Parse("20:00"), CurrentTeacher.Id, 1).ToList();
                //sundayClients2030.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(6), TimeSpan.Parse("20:30"), CurrentTeacher.Id, 1).ToList();
                //sundayClients2100.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(6), TimeSpan.Parse("21:00"), CurrentTeacher.Id, 1).ToList();
                //sundayClients2130.ItemsSource = AppData.Context.ClientLessonData(startDate.AddDays(6), TimeSpan.Parse("21:30"), CurrentTeacher.Id, 1).ToList();


                //TimeSpan[] time = new TimeSpan[] { TimeSpan.Parse("09:00"), TimeSpan.Parse("09:30"), TimeSpan.Parse("10:00"), TimeSpan.Parse("10:30"), TimeSpan.Parse("11:00"), TimeSpan.Parse("11:30"), TimeSpan.Parse("12:00"), TimeSpan.Parse("12:30"), TimeSpan.Parse("13:00"), TimeSpan.Parse("13:30"), TimeSpan.Parse("14:00"), TimeSpan.Parse("14:30"), TimeSpan.Parse("15:00"), TimeSpan.Parse("15:30"), TimeSpan.Parse("16:00"), TimeSpan.Parse("16:30"), TimeSpan.Parse("17:00"), TimeSpan.Parse("17:30"), TimeSpan.Parse("18:00"), TimeSpan.Parse("18:30"), TimeSpan.Parse("19:00"), TimeSpan.Parse("19:30"), TimeSpan.Parse("20:00"), TimeSpan.Parse("20:30"), TimeSpan.Parse("21:00"), TimeSpan.Parse("21:30") };
                //string[] day = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

                //for (int i = 0; i < lessonDataGrids.Length; i++)
                //{
                //    DateTime date = startDate;
                //    for (int j = 0; j < day.Length; j++)
                //    {
                //        string dayStart = day[j];
                //        for (int k = 0; k < time.Length; k++)
                //        {
                //            lessonDataGrids[i].ItemsSource = null;
                //            if (lessonDataGrids[i].Name == $"{day[j].ToLower()}{time[k].ToString().Remove(2, 1).Remove(4, 3)}")
                //            {
                //                TimeSpan startTime = time[k];
                //                var lesson = AppData.Context.LessonData(date, startTime, CurrentTeacher.Id, 1);
                //                if (lesson.FirstOrDefault() != null)
                //                {
                //                    lessonDataGrids[i].ItemsSource = lesson.ToList();
                //                }
                //            }
                //        }
                //        if (lessonDataGrids[i].ItemsSource != null)
                //        {
                //            break;
                //        }
                //        date = date.AddDays(1);
                //    }
                //}

                //for (int i = 0; i < clientDataGrids.Length; i++)
                //{
                //    DateTime date = startDate;
                //    for (int j = 0; j < day.Length; j++)
                //    {
                //        string dayStart = day[j];
                //        for (int k = 0; k < time.Length; k++)
                //        {
                //            clientDataGrids[i].ItemsSource = null;
                //            if (clientDataGrids[i].Name == $"{day[j].ToLower()}{time[k].ToString().Remove(2, 1).Remove(4, 3)}")
                //            {
                //                TimeSpan startTime = time[k];
                //                var clientLesson = AppData.Context.ClientLessonData(date, startTime, CurrentTeacher.Id, 1);
                //                if (clientLesson.FirstOrDefault() != null)
                //                {
                //                    clientDataGrids[i].ItemsSource = clientLesson.ToList();
                //                }
                //            }
                //        }
                //        if (clientDataGrids[i].ItemsSource != null)
                //        {
                //            break;
                //        }
                //        date = date.AddDays(1);
                //    }
                //}
            }
        }
        private void scheduleCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            updateData();
        }

        private void scheduleCalendar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DateTime selectedDate = scheduleCalendar.SelectedDate.Value;
            string nameDate = selectedDate.DayOfWeek.ToString();
            Properties.Settings.Default.dayStart = nameDate;

            var timeMsg = new WpfMessageBoxProperties()
            {
                Title = "Внимание!",
                Button = MessageBoxButton.OKCancel,
                ButtonOkText = "Ок",
                ButtonCancelText = "Отмена",
                Image = MessageBoxImage.Information,
                Header = "Введите время начала проведения занятия (например 9:00, 10:00)",
                IsTextBoxVisible = true,
            };
            MessageBoxResult resultTime = WpfMessageBox.Show(ref timeMsg);

            Properties.Settings.Default.timeStart = TimeSpan.Parse(timeMsg.TextBoxText);
            Properties.Settings.Default.dateStart = scheduleCalendar.SelectedDate.Value.ToShortDateString();



            if (resultTime == MessageBoxResult.OK)
            {
                if (timeMsg.TextBoxText == "9:00" || timeMsg.TextBoxText == "10:00" || timeMsg.TextBoxText == "11:00" || timeMsg.TextBoxText == "12:00" || timeMsg.TextBoxText == "13:00" || timeMsg.TextBoxText == "14:00" || timeMsg.TextBoxText == "15:00" || timeMsg.TextBoxText == "16:00" || timeMsg.TextBoxText == "17:00" || timeMsg.TextBoxText == "18:00" || timeMsg.TextBoxText == "19:00" || timeMsg.TextBoxText == "20:00" || timeMsg.TextBoxText == "21:00" || timeMsg.TextBoxText == "9:30" || timeMsg.TextBoxText == "10:30" || timeMsg.TextBoxText == "11:30" || timeMsg.TextBoxText == "12:30" || timeMsg.TextBoxText == "13:30" || timeMsg.TextBoxText == "14:30" || timeMsg.TextBoxText == "15:30" || timeMsg.TextBoxText == "16:30" || timeMsg.TextBoxText == "17:30" || timeMsg.TextBoxText == "18:30" || timeMsg.TextBoxText == "19:30" || timeMsg.TextBoxText == "20:30" || timeMsg.TextBoxText == "21:30")
                {
                    if (teacherComboBox.SelectedItem != null)
                    {
                        if (AppData.Context.Lesson.Where(c => c.Date == scheduleCalendar.SelectedDate && c.Time == Properties.Settings.Default.timeStart && c.Teacher.Id == CurrentTeacher.Id).FirstOrDefault() == null)
                        {
                            NavigationService.Navigate(new editSchedulePage(null));
                        }
                        else
                        {
                            if (MessageBox.Show("В данное время уже сушествет занятие,\nхотите его редактировать?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                            {
                                Lesson CurrentLesson = AppData.Context.Lesson.Where(c => c.Date == scheduleCalendar.SelectedDate && c.Time == Properties.Settings.Default.timeStart && c.Teacher.Id == CurrentTeacher.Id).FirstOrDefault();
                                if (CurrentLesson != null)
                                {
                                    NavigationService.Navigate(new editSchedulePage(CurrentLesson));
                                }
                            }
                        }
                    }
                    else
                    {
                        NavigationService.Navigate(new editSchedulePage(null));
                    }
                }
                else
                {
                    MessageBox.Show("Некорректный ввод времени начала занятия!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            updateData();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            if (countData < AppData.Context.Lesson.Count() || countData > AppData.Context.Lesson.Count())
            {
                countData = AppData.Context.Lesson.Count();
                updateData();
            }
            timer.Start();
        }

        private void teacherComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CurrentTeacher = teacherComboBox.SelectedItem as Teacher;
            Page_Loaded(null, null);
        }

        private void PaidAndAttendance(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < clientDataGrids.Length; i++)
            {
                if (clientDataGrids[i].IsMouseOver == true)
                {
                    ClientLesson CurrentClientLesson = clientDataGrids[i].SelectedItem as ClientLesson;
                    if (CurrentClientLesson != null)
                    {
                        var checkbox = (CheckBox)sender;
                        if ((checkbox.IsChecked == true || checkbox.IsChecked == false) && checkbox.Name == "paid")
                        {
                            CurrentClientLesson.IsPaid = checkbox.IsChecked.Value;
                            AppData.Context.SaveChanges();
                            Page_Loaded(null, null);
                        }
                        else if ((checkbox.IsChecked == true || checkbox.IsChecked == false) && checkbox.Name == "attendance")
                        {
                            CurrentClientLesson.IsAttendance = checkbox.IsChecked.Value;
                            AppData.Context.SaveChanges();
                            Page_Loaded(null, null);
                        }
                    }
                }
            }
        }

        private void dublicateDataButton_Click(object sender, RoutedEventArgs e)
        {
            DateTime selectedDate;
            DateTime startDate = default(DateTime);
            DateTime endDate = default(DateTime);
            if (scheduleCalendar.SelectedDate != null)
            {
                selectedDate = scheduleCalendar.SelectedDate.Value;
            }
            else
            {
                selectedDate = DateTime.Today;
            }

            string nameDate = selectedDate.DayOfWeek.ToString();
            if (nameDate == "Monday")
            {
                startDate = selectedDate;
                endDate = selectedDate.AddDays(6);
                Properties.Settings.Default.dayStart = "Monday";

            }
            else if (nameDate == "Tuesday")
            {
                startDate = selectedDate.AddDays(-1);
                endDate = selectedDate.AddDays(5);
                Properties.Settings.Default.dayStart = "Tuesday";
            }
            else if (nameDate == "Wednesday")
            {
                startDate = selectedDate.AddDays(-2);
                endDate = selectedDate.AddDays(4);
                Properties.Settings.Default.dayStart = "Wednesday";
            }
            else if (nameDate == "Thursday")
            {
                startDate = selectedDate.AddDays(-3);
                endDate = selectedDate.AddDays(3);
                Properties.Settings.Default.dayStart = "Thursday";
            }
            else if (nameDate == "Friday")
            {
                startDate = selectedDate.AddDays(-4);
                endDate = selectedDate.AddDays(2);
                Properties.Settings.Default.dayStart = "Friday";
            }
            else if (nameDate == "Saturday")
            {
                startDate = selectedDate.AddDays(-5);
                endDate = selectedDate.AddDays(1);
                Properties.Settings.Default.dayStart = "Saturday";
            }
            else if (nameDate == "Sunday")
            {
                startDate = selectedDate.AddDays(-6);
                endDate = selectedDate;
                Properties.Settings.Default.dayStart = "Sunday";
            }

            var CurrentTeacher = teacherComboBox.SelectedItem as Teacher;
            TimeSpan[] times = new TimeSpan[] {TimeSpan.Parse("09:00"), TimeSpan.Parse("09:30"), TimeSpan.Parse("10:00"), TimeSpan.Parse("10:30"), TimeSpan.Parse("11:00"), TimeSpan.Parse("11:30"), TimeSpan.Parse("12:00"), TimeSpan.Parse("12:30"), TimeSpan.Parse("13:00"), TimeSpan.Parse("13:30"), TimeSpan.Parse("14:00"), TimeSpan.Parse("14:30"), TimeSpan.Parse("15:00"), TimeSpan.Parse("15:30"), TimeSpan.Parse("16:00"), TimeSpan.Parse("16:30"), TimeSpan.Parse("17:00"), TimeSpan.Parse("17:30"), TimeSpan.Parse("18:00"), TimeSpan.Parse("18:30"), TimeSpan.Parse("19:00"), TimeSpan.Parse("19:30"), TimeSpan.Parse("20:00"), TimeSpan.Parse("20:30"), TimeSpan.Parse("21:00"), TimeSpan.Parse("21:30")};
            string[] days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            TimeSpan time;
            string day;
            int dayCount = 7;

            for (int i = 0; i < days.Length; i++)
            {
                day = days[i];
                for (int j = 0; j < times.Length; j++)
                {
                    time = times[j];
                    var lesson = AppData.Context.Lesson.Where(c => c.Date == startDate && c.Time == time && c.Day == day && c.Teacher.Id == CurrentTeacher.Id).FirstOrDefault();
                    var client = AppData.Context.ClientLesson.Where(c => c.Lesson.Date == startDate && c.Lesson.Time == time && c.Lesson.Day == day && c.Lesson.Teacher.Id == CurrentTeacher.Id).FirstOrDefault();
                    if (lesson != null && client != null)
                    {
                        Lesson CurrentLesson = new Lesson()
                        {
                            Date = lesson.Date.Value.AddDays(dayCount),
                            Time = lesson.Time,
                            Day = lesson.Day,
                            Groups = lesson.Groups,
                            TypeLesson = lesson.TypeLesson,
                            Teacher = lesson.Teacher,
                            LessonTime = lesson.LessonTime,
                        };
                        AppData.Context.Lesson.Add(CurrentLesson);

                        foreach (var item in AppData.Context.ClientLesson.Where(c => c.Lesson.Date == startDate && c.Lesson.Time == time && c.Lesson.Day == day && c.Lesson.Teacher.Id == CurrentTeacher.Id).Select(c => c.Client).ToList())
                        {
                            CurrentLesson.ClientLesson.Add(

                                new ClientLesson
                                {
                                    Client = item,
                                    IsAttendance = false,
                                    IsPaid = false,
                                });
                        }
                        AppData.Context.SaveChanges();
                    }
                }
                startDate = startDate.AddDays(1);
            }

            MessageBox.Show("Дублирование успешно завершено!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
