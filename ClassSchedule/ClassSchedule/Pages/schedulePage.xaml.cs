using ClassSchedule.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Логика взаимодействия для schedulePage.xaml
    /// </summary>
    public partial class schedulePage : Page
    {
        Teacher CurrentTeacher = null;
        public schedulePage()
        {
            InitializeComponent();

            teacherComboBox.ItemsSource = AppData.Context.Teacher.Where(c => c.IsDeleted == false).ToList();

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
                monday900.ItemsSource = null;
                mondayClients900.ItemsSource = null;
                monday930.ItemsSource = null;
                mondayClients930.ItemsSource = null;
                monday1000.ItemsSource = null;
                mondayClients1000.ItemsSource = null;
                monday1030.ItemsSource = null;
                mondayClients1030.ItemsSource = null;
                monday1100.ItemsSource = null;
                mondayClients1100.ItemsSource = null;
                monday1130.ItemsSource = null;
                mondayClients1130.ItemsSource = null;
                monday1200.ItemsSource = null;
                mondayClients1200.ItemsSource = null;
                monday1230.ItemsSource = null;
                mondayClients1230.ItemsSource = null;
                monday1300.ItemsSource = null;
                mondayClients1300.ItemsSource = null;
                monday1330.ItemsSource = null;
                mondayClients1330.ItemsSource = null;
                monday1400.ItemsSource = null;
                mondayClients1400.ItemsSource = null;
                monday1430.ItemsSource = null;
                mondayClients1430.ItemsSource = null;
                monday1500.ItemsSource = null;
                mondayClients1500.ItemsSource = null;
                monday1530.ItemsSource = null;
                mondayClients1530.ItemsSource = null;
                monday1600.ItemsSource = null;
                mondayClients1600.ItemsSource = null;
                monday1630.ItemsSource = null;
                mondayClients1630.ItemsSource = null;
                monday1700.ItemsSource = null;
                mondayClients1700.ItemsSource = null;
                monday1730.ItemsSource = null;
                mondayClients1730.ItemsSource = null;
                monday1800.ItemsSource = null;
                mondayClients1800.ItemsSource = null;
                monday1830.ItemsSource = null;
                mondayClients1830.ItemsSource = null;
                monday1900.ItemsSource = null;
                mondayClients1900.ItemsSource = null;
                monday1930.ItemsSource = null;
                mondayClients1930.ItemsSource = null;
                monday2000.ItemsSource = null;
                mondayClients2000.ItemsSource = null;
                monday2030.ItemsSource = null;
                mondayClients2030.ItemsSource = null;
                monday2100.ItemsSource = null;
                mondayClients2100.ItemsSource = null;
                monday2130.ItemsSource = null;
                mondayClients2130.ItemsSource = null;

                tuesday900.ItemsSource = null;
                tuesdayClients900.ItemsSource = null;
                tuesday930.ItemsSource = null;
                tuesdayClients930.ItemsSource = null;
                tuesday1000.ItemsSource = null;
                tuesdayClients1000.ItemsSource = null;
                tuesday1030.ItemsSource = null;
                tuesdayClients1030.ItemsSource = null;
                tuesday1100.ItemsSource = null;
                tuesdayClients1100.ItemsSource = null;
                tuesday1130.ItemsSource = null;
                tuesdayClients1130.ItemsSource = null;
                tuesday1200.ItemsSource = null;
                tuesdayClients1200.ItemsSource = null;
                tuesday1230.ItemsSource = null;
                tuesdayClients1230.ItemsSource = null;
                tuesday1300.ItemsSource = null;
                tuesdayClients1300.ItemsSource = null;
                tuesday1330.ItemsSource = null;
                tuesdayClients1330.ItemsSource = null;
                tuesday1400.ItemsSource = null;
                tuesdayClients1400.ItemsSource = null;
                tuesday1430.ItemsSource = null;
                tuesdayClients1430.ItemsSource = null;
                tuesday1500.ItemsSource = null;
                tuesdayClients1500.ItemsSource = null;
                tuesday1530.ItemsSource = null;
                tuesdayClients1530.ItemsSource = null;
                tuesday1600.ItemsSource = null;
                tuesdayClients1600.ItemsSource = null;
                tuesday1630.ItemsSource = null;
                tuesdayClients1630.ItemsSource = null;
                tuesday1700.ItemsSource = null;
                tuesdayClients1700.ItemsSource = null;
                tuesday1730.ItemsSource = null;
                tuesdayClients1730.ItemsSource = null;
                tuesday1800.ItemsSource = null;
                tuesdayClients1800.ItemsSource = null;
                tuesday1830.ItemsSource = null;
                tuesdayClients1830.ItemsSource = null;
                tuesday1900.ItemsSource = null;
                tuesdayClients1900.ItemsSource = null;
                tuesday1930.ItemsSource = null;
                tuesdayClients1930.ItemsSource = null;
                tuesday2000.ItemsSource = null;
                tuesdayClients2000.ItemsSource = null;
                tuesday2030.ItemsSource = null;
                tuesdayClients2030.ItemsSource = null;
                tuesday2100.ItemsSource = null;
                tuesdayClients2100.ItemsSource = null;
                tuesday2130.ItemsSource = null;
                tuesdayClients2130.ItemsSource = null;

                wednesday900.ItemsSource = null;
                wednesdayClients900.ItemsSource = null;
                wednesday930.ItemsSource = null;
                wednesdayClients930.ItemsSource = null;
                wednesday1000.ItemsSource = null;
                wednesdayClients1000.ItemsSource = null;
                wednesday1030.ItemsSource = null;
                wednesdayClients1030.ItemsSource = null;
                wednesday1100.ItemsSource = null;
                wednesdayClients1100.ItemsSource = null;
                wednesday1130.ItemsSource = null;
                wednesdayClients1130.ItemsSource = null;
                wednesday1200.ItemsSource = null;
                wednesdayClients1200.ItemsSource = null;
                wednesday1230.ItemsSource = null;
                wednesdayClients1230.ItemsSource = null;
                wednesday1300.ItemsSource = null;
                wednesdayClients1300.ItemsSource = null;
                wednesday1330.ItemsSource = null;
                wednesdayClients1330.ItemsSource = null;
                wednesday1400.ItemsSource = null;
                wednesdayClients1400.ItemsSource = null;
                wednesday1430.ItemsSource = null;
                wednesdayClients1430.ItemsSource = null;
                wednesday1500.ItemsSource = null;
                wednesdayClients1500.ItemsSource = null;
                wednesday1530.ItemsSource = null;
                wednesdayClients1530.ItemsSource = null;
                wednesday1600.ItemsSource = null;
                wednesdayClients1600.ItemsSource = null;
                wednesday1630.ItemsSource = null;
                wednesdayClients1630.ItemsSource = null;
                wednesday1700.ItemsSource = null;
                wednesdayClients1700.ItemsSource = null;
                wednesday1730.ItemsSource = null;
                wednesdayClients1730.ItemsSource = null;
                wednesday1800.ItemsSource = null;
                wednesdayClients1800.ItemsSource = null;
                wednesday1830.ItemsSource = null;
                wednesdayClients1830.ItemsSource = null;
                wednesday1900.ItemsSource = null;
                wednesdayClients1900.ItemsSource = null;
                wednesday1930.ItemsSource = null;
                wednesdayClients1930.ItemsSource = null;
                wednesday2000.ItemsSource = null;
                wednesdayClients2000.ItemsSource = null;
                wednesday2030.ItemsSource = null;
                wednesdayClients2030.ItemsSource = null;
                wednesday2100.ItemsSource = null;
                wednesdayClients2100.ItemsSource = null;
                wednesday2130.ItemsSource = null;
                wednesdayClients2130.ItemsSource = null;

                thursday900.ItemsSource = null;
                thursdayClients900.ItemsSource = null;
                thursday930.ItemsSource = null;
                thursdayClients930.ItemsSource = null;
                thursday1000.ItemsSource = null;
                thursdayClients1000.ItemsSource = null;
                thursday1030.ItemsSource = null;
                thursdayClients1030.ItemsSource = null;
                thursday1100.ItemsSource = null;
                thursdayClients1100.ItemsSource = null;
                thursday1130.ItemsSource = null;
                thursdayClients1130.ItemsSource = null;
                thursday1200.ItemsSource = null;
                thursdayClients1200.ItemsSource = null;
                thursday1230.ItemsSource = null;
                thursdayClients1230.ItemsSource = null;
                thursday1300.ItemsSource = null;
                thursdayClients1300.ItemsSource = null;
                thursday1330.ItemsSource = null;
                thursdayClients1330.ItemsSource = null;
                thursday1400.ItemsSource = null;
                thursdayClients1400.ItemsSource = null;
                thursday1430.ItemsSource = null;
                thursdayClients1430.ItemsSource = null;
                thursday1500.ItemsSource = null;
                thursdayClients1500.ItemsSource = null;
                thursday1530.ItemsSource = null;
                thursdayClients1530.ItemsSource = null;
                thursday1600.ItemsSource = null;
                thursdayClients1600.ItemsSource = null;
                thursday1630.ItemsSource = null;
                thursdayClients1630.ItemsSource = null;
                thursday1700.ItemsSource = null;
                thursdayClients1700.ItemsSource = null;
                thursday1730.ItemsSource = null;
                thursdayClients1730.ItemsSource = null;
                thursday1800.ItemsSource = null;
                thursdayClients1800.ItemsSource = null;
                thursday1830.ItemsSource = null;
                thursdayClients1830.ItemsSource = null;
                thursday1900.ItemsSource = null;
                thursdayClients1900.ItemsSource = null;
                thursday1930.ItemsSource = null;
                thursdayClients1930.ItemsSource = null;
                thursday2000.ItemsSource = null;
                thursdayClients2000.ItemsSource = null;
                thursday2030.ItemsSource = null;
                thursdayClients2030.ItemsSource = null;
                thursday2100.ItemsSource = null;
                thursdayClients2100.ItemsSource = null;
                thursday2130.ItemsSource = null;
                thursdayClients2130.ItemsSource = null;

                friday900.ItemsSource = null;
                fridayClients900.ItemsSource = null;
                friday930.ItemsSource = null;
                fridayClients930.ItemsSource = null;
                friday1000.ItemsSource = null;
                fridayClients1000.ItemsSource = null;
                friday1030.ItemsSource = null;
                fridayClients1030.ItemsSource = null;
                friday1100.ItemsSource = null;
                fridayClients1100.ItemsSource = null;
                friday1130.ItemsSource = null;
                fridayClients1130.ItemsSource = null;
                friday1200.ItemsSource = null;
                fridayClients1200.ItemsSource = null;
                friday1230.ItemsSource = null;
                fridayClients1230.ItemsSource = null;
                friday1300.ItemsSource = null;
                fridayClients1300.ItemsSource = null;
                friday1330.ItemsSource = null;
                fridayClients1330.ItemsSource = null;
                friday1400.ItemsSource = null;
                fridayClients1400.ItemsSource = null;
                friday1430.ItemsSource = null;
                fridayClients1430.ItemsSource = null;
                friday1500.ItemsSource = null;
                fridayClients1500.ItemsSource = null;
                friday1530.ItemsSource = null;
                fridayClients1530.ItemsSource = null;
                friday1600.ItemsSource = null;
                fridayClients1600.ItemsSource = null;
                friday1630.ItemsSource = null;
                fridayClients1630.ItemsSource = null;
                friday1700.ItemsSource = null;
                fridayClients1700.ItemsSource = null;
                friday1730.ItemsSource = null;
                fridayClients1730.ItemsSource = null;
                friday1800.ItemsSource = null;
                fridayClients1800.ItemsSource = null;
                friday1830.ItemsSource = null;
                fridayClients1830.ItemsSource = null;
                friday1900.ItemsSource = null;
                fridayClients1900.ItemsSource = null;
                friday1930.ItemsSource = null;
                fridayClients1930.ItemsSource = null;
                friday2000.ItemsSource = null;
                fridayClients2000.ItemsSource = null;
                friday2030.ItemsSource = null;
                fridayClients2030.ItemsSource = null;
                friday2100.ItemsSource = null;
                fridayClients2100.ItemsSource = null;
                friday2130.ItemsSource = null;
                fridayClients2130.ItemsSource = null;

                saturday900.ItemsSource = null;
                saturdayClients900.ItemsSource = null;
                saturday930.ItemsSource = null;
                saturdayClients930.ItemsSource = null;
                saturday1000.ItemsSource = null;
                saturdayClients1000.ItemsSource = null;
                saturday1030.ItemsSource = null;
                saturdayClients1030.ItemsSource = null;
                saturday1100.ItemsSource = null;
                saturdayClients1100.ItemsSource = null;
                saturday1130.ItemsSource = null;
                saturdayClients1130.ItemsSource = null;
                saturday1200.ItemsSource = null;
                saturdayClients1200.ItemsSource = null;
                saturday1230.ItemsSource = null;
                saturdayClients1230.ItemsSource = null;
                saturday1300.ItemsSource = null;
                saturdayClients1300.ItemsSource = null;
                saturday1330.ItemsSource = null;
                saturdayClients1330.ItemsSource = null;
                saturday1400.ItemsSource = null;
                saturdayClients1400.ItemsSource = null;
                saturday1430.ItemsSource = null;
                saturdayClients1430.ItemsSource = null;
                saturday1500.ItemsSource = null;
                saturdayClients1500.ItemsSource = null;
                saturday1530.ItemsSource = null;
                saturdayClients1530.ItemsSource = null;
                saturday1600.ItemsSource = null;
                saturdayClients1600.ItemsSource = null;
                saturday1630.ItemsSource = null;
                saturdayClients1630.ItemsSource = null;
                saturday1700.ItemsSource = null;
                saturdayClients1700.ItemsSource = null;
                saturday1730.ItemsSource = null;
                saturdayClients1730.ItemsSource = null;
                saturday1800.ItemsSource = null;
                saturdayClients1800.ItemsSource = null;
                saturday1830.ItemsSource = null;
                saturdayClients1830.ItemsSource = null;
                saturday1900.ItemsSource = null;
                saturdayClients1900.ItemsSource = null;
                saturday1930.ItemsSource = null;
                saturdayClients1930.ItemsSource = null;
                saturday2000.ItemsSource = null;
                saturdayClients2000.ItemsSource = null;
                saturday2030.ItemsSource = null;
                saturdayClients2030.ItemsSource = null;
                saturday2100.ItemsSource = null;
                saturdayClients2100.ItemsSource = null;
                saturday2130.ItemsSource = null;
                saturdayClients2130.ItemsSource = null;

                sunday900.ItemsSource = null;
                sundayClients900.ItemsSource = null;
                sunday930.ItemsSource = null;
                sundayClients930.ItemsSource = null;
                sunday1000.ItemsSource = null;
                sundayClients1000.ItemsSource = null;
                sunday1030.ItemsSource = null;
                sundayClients1030.ItemsSource = null;
                sunday1100.ItemsSource = null;
                sundayClients1100.ItemsSource = null;
                sunday1130.ItemsSource = null;
                sundayClients1130.ItemsSource = null;
                sunday1200.ItemsSource = null;
                sundayClients1200.ItemsSource = null;
                sunday1230.ItemsSource = null;
                sundayClients1230.ItemsSource = null;
                sunday1300.ItemsSource = null;
                sundayClients1300.ItemsSource = null;
                sunday1330.ItemsSource = null;
                sundayClients1330.ItemsSource = null;
                sunday1400.ItemsSource = null;
                sundayClients1400.ItemsSource = null;
                sunday1430.ItemsSource = null;
                sundayClients1430.ItemsSource = null;
                sunday1500.ItemsSource = null;
                sundayClients1500.ItemsSource = null;
                sunday1530.ItemsSource = null;
                sundayClients1530.ItemsSource = null;
                sunday1600.ItemsSource = null;
                sundayClients1600.ItemsSource = null;
                sunday1630.ItemsSource = null;
                sundayClients1630.ItemsSource = null;
                sunday1700.ItemsSource = null;
                sundayClients1700.ItemsSource = null;
                sunday1730.ItemsSource = null;
                sundayClients1730.ItemsSource = null;
                sunday1800.ItemsSource = null;
                sundayClients1800.ItemsSource = null;
                sunday1830.ItemsSource = null;
                sundayClients1830.ItemsSource = null;
                sunday1900.ItemsSource = null;
                sundayClients1900.ItemsSource = null;
                sunday1930.ItemsSource = null;
                sundayClients1930.ItemsSource = null;
                sunday2000.ItemsSource = null;
                sundayClients2000.ItemsSource = null;
                sunday2030.ItemsSource = null;
                sundayClients2030.ItemsSource = null;
                sunday2100.ItemsSource = null;
                sundayClients2100.ItemsSource = null;
                sunday2130.ItemsSource = null;
                sundayClients2130.ItemsSource = null;


                DateTime startDate = default(DateTime);
                DateTime endDate = default(DateTime);
                DateTime selectedDate;
                if (scheduleCalendar.SelectedDate != null)
                {
                    selectedDate = scheduleCalendar.SelectedDate.Value;
                } else
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

                //понедельник 9:00
                var monday900Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:00") && (c.Day == "Monday") && (c.Teacher.Id == CurrentTeacher.Id));
                var mondayClients900Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:00") && (c.Lesson.Day == "Monday") && (c.Lesson.Teacher.Id == CurrentTeacher.Id));
                if (monday900Data.FirstOrDefault() != null && mondayClients900Data.FirstOrDefault() != null)
                {
                    monday900.ItemsSource = monday900Data.ToList();
                    mondayClients900.ItemsSource = mondayClients900Data.ToList();
                }

                //понедельник 9:30
                var monday930Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:30") && (c.Day == "Monday") && c.Teacher.Id == CurrentTeacher.Id);
                var mondayClients930Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:30") && (c.Lesson.Day == "Monday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (monday930Data.FirstOrDefault() != null && mondayClients930Data.FirstOrDefault() != null)
                {
                    monday930.ItemsSource = monday930Data.ToList();
                    mondayClients930.ItemsSource = mondayClients930Data.ToList();
                }

                //понедельник 10:00
                var monday1000Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:00") && (c.Day == "Monday") && c.Teacher.Id == CurrentTeacher.Id);
                var mondayClients1000Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:00") && (c.Lesson.Day == "Monday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (monday1000Data.FirstOrDefault() != null && mondayClients1000Data.FirstOrDefault() != null)
                {
                    monday1000.ItemsSource = monday1000Data.ToList();
                    mondayClients1000.ItemsSource = mondayClients1000Data.ToList();
                }

                //понедельник 10:30
                var monday1030Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:30") && (c.Day == "Monday") && c.Teacher.Id == CurrentTeacher.Id);
                var mondayClients1030Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:30") && (c.Lesson.Day == "Monday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (monday1030Data.FirstOrDefault() != null && mondayClients1030Data.FirstOrDefault() != null)
                {
                    monday1030.ItemsSource = monday1030Data.ToList();
                    mondayClients1030.ItemsSource = mondayClients1030Data.ToList();
                }

                //понедельник 11:00
                var monday1100Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:00") && (c.Day == "Monday") && c.Teacher.Id == CurrentTeacher.Id);
                var mondayClients1100Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:00") && (c.Lesson.Day == "Monday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (monday1100Data.FirstOrDefault() != null && mondayClients1100Data.FirstOrDefault() != null)
                {
                    monday1100.ItemsSource = monday1100Data.ToList();
                    mondayClients1100.ItemsSource = mondayClients1100Data.ToList();
                }

                //понедельник 11:30
                var monday1130Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:30") && (c.Day == "Monday") && c.Teacher.Id == CurrentTeacher.Id);
                var mondayClients1130Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:30") && (c.Lesson.Day == "Monday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (monday1130Data.FirstOrDefault() != null && mondayClients1130Data.FirstOrDefault() != null)
                {
                    monday1130.ItemsSource = monday1130Data.ToList();
                    mondayClients1130.ItemsSource = mondayClients1130Data.ToList();
                }

                //понедельник 12:00
                var monday1200Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:00") && (c.Day == "Monday") && c.Teacher.Id == CurrentTeacher.Id);
                var mondayClients1200Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:00") && (c.Lesson.Day == "Monday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (monday1200Data.FirstOrDefault() != null && mondayClients1200Data.FirstOrDefault() != null)
                {
                    monday1200.ItemsSource = monday1200Data.ToList();
                    mondayClients1200.ItemsSource = mondayClients1200Data.ToList();
                }

                //понедельник 12:30
                var monday1230Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:30") && (c.Day == "Monday") && c.Teacher.Id == CurrentTeacher.Id);
                var mondayClients1230Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:30") && (c.Lesson.Day == "Monday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (monday1230Data.FirstOrDefault() != null && mondayClients1230Data.FirstOrDefault() != null)
                {
                    monday1230.ItemsSource = monday1230Data.ToList();
                    mondayClients1230.ItemsSource = mondayClients1230Data.ToList();
                }

                //понедельник 13:00
                var monday1300Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:00") && (c.Day == "Monday") && c.Teacher.Id == CurrentTeacher.Id);
                var mondayClients1300Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:00") && (c.Lesson.Day == "Monday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (monday1300Data.FirstOrDefault() != null && mondayClients1300Data.FirstOrDefault() != null)
                {
                    monday1300.ItemsSource = monday1300Data.ToList();
                    mondayClients1300.ItemsSource = mondayClients1300Data.ToList();
                }

                //понедельник 13:30
                var monday1330Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:30") && (c.Day == "Monday") && c.Teacher.Id == CurrentTeacher.Id);
                var mondayClients1330Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:30") && (c.Lesson.Day == "Monday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (monday1330Data.FirstOrDefault() != null && mondayClients1330Data.FirstOrDefault() != null)
                {
                    monday1330.ItemsSource = monday1330Data.ToList();
                    mondayClients1330.ItemsSource = mondayClients1330Data.ToList();
                }

                //понедельник 14:00
                var monday1400Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:00") && (c.Day == "Monday") && c.Teacher.Id == CurrentTeacher.Id);
                var mondayClients1400Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:00") && (c.Lesson.Day == "Monday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (monday1400Data.FirstOrDefault() != null && mondayClients1400Data.FirstOrDefault() != null)
                {
                    monday1400.ItemsSource = monday1400Data.ToList();
                    mondayClients1400.ItemsSource = mondayClients1400Data.ToList();
                }

                //понедельник 14:30
                var monday1430Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:30") && (c.Day == "Monday") && c.Teacher.Id == CurrentTeacher.Id);
                var mondayClients1430Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:30") && (c.Lesson.Day == "Monday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (monday1430Data.FirstOrDefault() != null && mondayClients1430Data.FirstOrDefault() != null)
                {
                    monday1430.ItemsSource = monday1430Data.ToList();
                    mondayClients1430.ItemsSource = mondayClients1430Data.ToList();
                }

                //понедельник 15:00
                var monday1500Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:00") && (c.Day == "Monday") && c.Teacher.Id == CurrentTeacher.Id);
                var mondayClients1500Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:00") && (c.Lesson.Day == "Monday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (monday1500Data.FirstOrDefault() != null && mondayClients1500Data.FirstOrDefault() != null)
                {
                    monday1500.ItemsSource = monday1500Data.ToList();
                    mondayClients1500.ItemsSource = mondayClients1500Data.ToList();
                }

                //понедельник 15:30
                var monday1530Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:30") && (c.Day == "Monday") && c.Teacher.Id == CurrentTeacher.Id);
                var mondayClients1530Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:30") && (c.Lesson.Day == "Monday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (monday1530Data.FirstOrDefault() != null && mondayClients1530Data.FirstOrDefault() != null)
                {
                    monday1530.ItemsSource = monday1530Data.ToList();
                    mondayClients1530.ItemsSource = mondayClients1530Data.ToList();
                }

                //понедельник 16:00
                var monday1600Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:00") && (c.Day == "Monday") && c.Teacher.Id == CurrentTeacher.Id);
                var mondayClients1600Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:00") && (c.Lesson.Day == "Monday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (monday1600Data.FirstOrDefault() != null && mondayClients1600Data.FirstOrDefault() != null)
                {
                    monday1600.ItemsSource = monday1600Data.ToList();
                    mondayClients1600.ItemsSource = mondayClients1600Data.ToList();
                }

                //понедельник 16:30
                var monday1630Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:30") && (c.Day == "Monday") && c.Teacher.Id == CurrentTeacher.Id);
                var mondayClients1630Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:30") && (c.Lesson.Day == "Monday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (monday1630Data.FirstOrDefault() != null && mondayClients1630Data.FirstOrDefault() != null)
                {
                    monday1630.ItemsSource = monday1630Data.ToList();
                    mondayClients1630.ItemsSource = mondayClients1630Data.ToList();
                }

                //понедельник 17:00
                var monday1700Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:00") && (c.Day == "Monday") && c.Teacher.Id == CurrentTeacher.Id);
                var mondayClients1700Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:00") && (c.Lesson.Day == "Monday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (monday1700Data.FirstOrDefault() != null && mondayClients1700Data.FirstOrDefault() != null)
                {
                    monday1700.ItemsSource = monday1700Data.ToList();
                    mondayClients1700.ItemsSource = mondayClients1700Data.ToList();
                }

                //понедельник 17:30
                var monday1730Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:30") && (c.Day == "Monday") && c.Teacher.Id == CurrentTeacher.Id);
                var mondayClients1730Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:30") && (c.Lesson.Day == "Monday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (monday1730Data.FirstOrDefault() != null && mondayClients1730Data.FirstOrDefault() != null)
                {
                    monday1730.ItemsSource = monday1730Data.ToList();
                    mondayClients1730.ItemsSource = mondayClients1730Data.ToList();
                }

                //понедельник 18:00
                var monday1800Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:00") && (c.Day == "Monday") && c.Teacher.Id == CurrentTeacher.Id);
                var mondayClients1800Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:00") && (c.Lesson.Day == "Monday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (monday1800Data.FirstOrDefault() != null && mondayClients1800Data.FirstOrDefault() != null)
                {
                    monday1800.ItemsSource = monday1800Data.ToList();
                    mondayClients1800.ItemsSource = mondayClients1800Data.ToList();
                }

                //понедельник 18:30
                var monday1830Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:30") && (c.Day == "Monday") && c.Teacher.Id == CurrentTeacher.Id);
                var mondayClients1830Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:30") && (c.Lesson.Day == "Monday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (monday1830Data.FirstOrDefault() != null && mondayClients1830Data.FirstOrDefault() != null)
                {
                    monday1830.ItemsSource = monday1830Data.ToList();
                    mondayClients1830.ItemsSource = mondayClients1830Data.ToList();
                }

                //понедельник 19:00
                var monday1900Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:00") && (c.Day == "Monday") && c.Teacher.Id == CurrentTeacher.Id);
                var mondayClients1900Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:00") && (c.Lesson.Day == "Monday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (monday1900Data.FirstOrDefault() != null && mondayClients1900Data.FirstOrDefault() != null)
                {
                    monday1900.ItemsSource = monday1900Data.ToList();
                    mondayClients1900.ItemsSource = mondayClients1900Data.ToList();
                }

                //понедельник 19:30
                var monday1930Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:30") && (c.Day == "Monday") && c.Teacher.Id == CurrentTeacher.Id);
                var mondayClients1930Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:30") && (c.Lesson.Day == "Monday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (monday1930Data.FirstOrDefault() != null && mondayClients1930Data.FirstOrDefault() != null)
                {
                    monday1930.ItemsSource = monday1930Data.ToList();
                    mondayClients1930.ItemsSource = mondayClients1930Data.ToList();
                }

                //понедельник 20:00
                var monday2000Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "20:00") && (c.Day == "Monday") && c.Teacher.Id == CurrentTeacher.Id);
                var mondayClients2000Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "20:00") && (c.Lesson.Day == "Monday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (monday2000Data.FirstOrDefault() != null && mondayClients2000Data.FirstOrDefault() != null)
                {
                    monday2000.ItemsSource = monday2000Data.ToList();
                    mondayClients2000.ItemsSource = mondayClients2000Data.ToList();
                }

                //понедельник 20:30
                var monday2030Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "20:30") && (c.Day == "Monday") && c.Teacher.Id == CurrentTeacher.Id);
                var mondayClients2030Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "20:30") && (c.Lesson.Day == "Monday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (monday2030Data.FirstOrDefault() != null && mondayClients2030Data.FirstOrDefault() != null)
                {
                    monday2030.ItemsSource = monday2030Data.ToList();
                    mondayClients2030.ItemsSource = mondayClients2030Data.ToList();
                }

                //понедельник 21:00
                var monday2100Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "21:00") && (c.Day == "Monday") && c.Teacher.Id == CurrentTeacher.Id);
                var mondayClients2100Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "21:00") && (c.Lesson.Day == "Monday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (monday2100Data.FirstOrDefault() != null && mondayClients2100Data.FirstOrDefault() != null)
                {
                    monday2100.ItemsSource = monday2100Data.ToList();
                    mondayClients2100.ItemsSource = mondayClients2100Data.ToList();
                }

                //понедельник 21:30
                var monday2130Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "21:30") && (c.Day == "Monday") && c.Teacher.Id == CurrentTeacher.Id);
                var mondayClients2130Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "21:30") && (c.Lesson.Day == "Monday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (monday2130Data.FirstOrDefault() != null && mondayClients2130Data.FirstOrDefault() != null)
                {
                    monday2130.ItemsSource = monday2130Data.ToList();
                    mondayClients2130.ItemsSource = mondayClients2130Data.ToList();
                }

                //вторник 9:00
                var tuesday900Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:00") && (c.Day == "Tuesday") && c.Teacher.Id == CurrentTeacher.Id);
                var tuesdayClients900Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:00") && (c.Lesson.Day == "Tuesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (tuesday900Data.FirstOrDefault() != null && tuesdayClients900Data.FirstOrDefault() != null)
                {
                    tuesday900.ItemsSource = tuesday900Data.ToList();
                    tuesdayClients900.ItemsSource = tuesdayClients900Data.ToList();
                }

                //вторник 9:30
                var tuesday930Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:30") && (c.Day == "Tuesday") && c.Teacher.Id == CurrentTeacher.Id);
                var tuesdayClients930Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:30") && (c.Lesson.Day == "Tuesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (tuesday930Data.FirstOrDefault() != null && tuesdayClients930Data.FirstOrDefault() != null)
                {
                    tuesday930.ItemsSource = tuesday930Data.ToList();
                    tuesdayClients930.ItemsSource = tuesdayClients930Data.ToList();
                }

                //вторник 10:00
                var tuesday1000Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:00") && (c.Day == "Tuesday") && c.Teacher.Id == CurrentTeacher.Id);
                var tuesdayClients1000Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:00") && (c.Lesson.Day == "Tuesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (tuesday1000Data.FirstOrDefault() != null && tuesdayClients1000Data.FirstOrDefault() != null)
                {
                    tuesday1000.ItemsSource = tuesday1000Data.ToList();
                    tuesdayClients1000.ItemsSource = tuesdayClients1000Data.ToList();
                }

                //вторник 10:30
                var tuesday1030Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:30") && (c.Day == "Tuesday") && c.Teacher.Id == CurrentTeacher.Id);
                var tuesdayClients1030Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:30") && (c.Lesson.Day == "Tuesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (tuesday1030Data.FirstOrDefault() != null && tuesdayClients1030Data.FirstOrDefault() != null)
                {
                    tuesday1030.ItemsSource = tuesday1030Data.ToList();
                    tuesdayClients1030.ItemsSource = tuesdayClients1030Data.ToList();
                }

                //вторник 11:00
                var tuesday1100Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:00") && (c.Day == "Tuesday") && c.Teacher.Id == CurrentTeacher.Id);
                var tuesdayClients1100Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:00") && (c.Lesson.Day == "Tuesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (tuesday1100Data.FirstOrDefault() != null && tuesdayClients1100Data.FirstOrDefault() != null)
                {
                    tuesday1100.ItemsSource = tuesday1100Data.ToList();
                    tuesdayClients1100.ItemsSource = tuesdayClients1100Data.ToList();
                }

                //вторник 11:30
                var tuesday1130Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:30") && (c.Day == "Tuesday") && c.Teacher.Id == CurrentTeacher.Id);
                var tuesdayClients1130Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:30") && (c.Lesson.Day == "Tuesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (tuesday1130Data.FirstOrDefault() != null && tuesdayClients1130Data.FirstOrDefault() != null)
                {
                    tuesday1130.ItemsSource = tuesday1130Data.ToList();
                    tuesdayClients1130.ItemsSource = tuesdayClients1130Data.ToList();
                }

                //вторник 12:00
                var tuesday1200Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:00") && (c.Day == "Tuesday") && c.Teacher.Id == CurrentTeacher.Id);
                var tuesdayClients1200Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:00") && (c.Lesson.Day == "Tuesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (tuesday1200Data.FirstOrDefault() != null && tuesdayClients1200Data.FirstOrDefault() != null)
                {
                    tuesday1200.ItemsSource = tuesday1200Data.ToList();
                    tuesdayClients1200.ItemsSource = tuesdayClients1200Data.ToList();
                }

                //вторник 12:30
                var tuesday1230Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:30") && (c.Day == "Tuesday") && c.Teacher.Id == CurrentTeacher.Id);
                var tuesdayClients1230Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:30") && (c.Lesson.Day == "Tuesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (tuesday1230Data.FirstOrDefault() != null && tuesdayClients1230Data.FirstOrDefault() != null)
                {
                    tuesday1230.ItemsSource = tuesday1230Data.ToList();
                    tuesdayClients1230.ItemsSource = tuesdayClients1230Data.ToList();
                }

                //вторник 13:00
                var tuesday1300Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:00") && (c.Day == "Tuesday") && c.Teacher.Id == CurrentTeacher.Id);
                var tuesdayClients1300Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:00") && (c.Lesson.Day == "Tuesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (tuesday1300Data.FirstOrDefault() != null && tuesdayClients1300Data.FirstOrDefault() != null)
                {
                    tuesday1300.ItemsSource = tuesday1300Data.ToList();
                    tuesdayClients1300.ItemsSource = tuesdayClients1300Data.ToList();
                }

                //вторник 13:30
                var tuesday1330Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:30") && (c.Day == "Tuesday") && c.Teacher.Id == CurrentTeacher.Id);
                var tuesdayClients1330Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:30") && (c.Lesson.Day == "Tuesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (tuesday1330Data.FirstOrDefault() != null && tuesdayClients1330Data.FirstOrDefault() != null)
                {
                    tuesday1330.ItemsSource = tuesday1330Data.ToList();
                    tuesdayClients1330.ItemsSource = tuesdayClients1330Data.ToList();
                }

                //вторник 14:00
                var tuesday1400Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:00") && (c.Day == "Tuesday") && c.Teacher.Id == CurrentTeacher.Id);
                var tuesdayClients1400Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:00") && (c.Lesson.Day == "Tuesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (tuesday1400Data.FirstOrDefault() != null && tuesdayClients1400Data.FirstOrDefault() != null)
                {
                    tuesday1400.ItemsSource = tuesday1400Data.ToList();
                    tuesdayClients1400.ItemsSource = tuesdayClients1400Data.ToList();
                }

                //вторник 14:30
                var tuesday1430Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:30") && (c.Day == "Tuesday") && c.Teacher.Id == CurrentTeacher.Id);
                var tuesdayClients1430Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:30") && (c.Lesson.Day == "Tuesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (tuesday1430Data.FirstOrDefault() != null && tuesdayClients1430Data.FirstOrDefault() != null)
                {
                    tuesday1430.ItemsSource = tuesday1430Data.ToList();
                    tuesdayClients1430.ItemsSource = tuesdayClients1430Data.ToList();
                }

                //вторник 15:00
                var tuesday1500Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:00") && (c.Day == "Tuesday") && c.Teacher.Id == CurrentTeacher.Id);
                var tuesdayClients1500Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:00") && (c.Lesson.Day == "Tuesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (tuesday1500Data.FirstOrDefault() != null && tuesdayClients1500Data.FirstOrDefault() != null)
                {
                    tuesday1500.ItemsSource = tuesday1500Data.ToList();
                    tuesdayClients1500.ItemsSource = tuesdayClients1500Data.ToList();
                }

                //вторник 15:30
                var tuesday1530Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:30") && (c.Day == "Tuesday") && c.Teacher.Id == CurrentTeacher.Id);
                var tuesdayClients1530Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:30") && (c.Lesson.Day == "Tuesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (tuesday1530Data.FirstOrDefault() != null && tuesdayClients1530Data.FirstOrDefault() != null)
                {
                    tuesday1530.ItemsSource = tuesday1530Data.ToList();
                    tuesdayClients1530.ItemsSource = tuesdayClients1530Data.ToList();
                }

                //вторник 16:00
                var tuesday1600Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:00") && (c.Day == "Tuesday") && c.Teacher.Id == CurrentTeacher.Id);
                var tuesdayClients1600Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:00") && (c.Lesson.Day == "Tuesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (tuesday1600Data.FirstOrDefault() != null && tuesdayClients1600Data.FirstOrDefault() != null)
                {
                    tuesday1600.ItemsSource = tuesday1600Data.ToList();
                    tuesdayClients1600.ItemsSource = tuesdayClients1600Data.ToList();
                }

                //вторник 16:30
                var tuesday1630Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:30") && (c.Day == "Tuesday") && c.Teacher.Id == CurrentTeacher.Id);
                var tuesdayClients1630Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:30") && (c.Lesson.Day == "Tuesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (tuesday1630Data.FirstOrDefault() != null && tuesdayClients1630Data.FirstOrDefault() != null)
                {
                    tuesday1630.ItemsSource = tuesday1630Data.ToList();
                    tuesdayClients1630.ItemsSource = tuesdayClients1630Data.ToList();
                }

                //вторник 17:00
                var tuesday1700Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:00") && (c.Day == "Tuesday") && c.Teacher.Id == CurrentTeacher.Id);
                var tuesdayClients1700Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:00") && (c.Lesson.Day == "Tuesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (tuesday1700Data.FirstOrDefault() != null && tuesdayClients1700Data.FirstOrDefault() != null)
                {
                    tuesday1700.ItemsSource = tuesday1700Data.ToList();
                    tuesdayClients1700.ItemsSource = tuesdayClients1700Data.ToList();
                }

                //вторник 17:30
                var tuesday1730Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:30") && (c.Day == "Tuesday") && c.Teacher.Id == CurrentTeacher.Id);
                var tuesdayClients1730Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:30") && (c.Lesson.Day == "Tuesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (tuesday1730Data.FirstOrDefault() != null && tuesdayClients1730Data.FirstOrDefault() != null)
                {
                    tuesday1730.ItemsSource = tuesday1730Data.ToList();
                    tuesdayClients1730.ItemsSource = tuesdayClients1730Data.ToList();
                }

                //вторник 18:00
                var tuesday1800Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:00") && (c.Day == "Tuesday") && c.Teacher.Id == CurrentTeacher.Id);
                var tuesdayClients1800Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:00") && (c.Lesson.Day == "Tuesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (tuesday1800Data.FirstOrDefault() != null && tuesdayClients1800Data.FirstOrDefault() != null)
                {
                    tuesday1800.ItemsSource = tuesday1800Data.ToList();
                    tuesdayClients1800.ItemsSource = tuesdayClients1800Data.ToList();
                }

                //вторник 18:30
                var tuesday1830Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:30") && (c.Day == "Tuesday") && c.Teacher.Id == CurrentTeacher.Id);
                var tuesdayClients1830Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:30") && (c.Lesson.Day == "Tuesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (tuesday1830Data.FirstOrDefault() != null && tuesdayClients1830Data.FirstOrDefault() != null)
                {
                    tuesday1830.ItemsSource = tuesday1830Data.ToList();
                    tuesdayClients1830.ItemsSource = tuesdayClients1830Data.ToList();
                }

                //вторник 19:00
                var tuesday1900Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:00") && (c.Day == "Tuesday") && c.Teacher.Id == CurrentTeacher.Id);
                var tuesdayClients1900Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:00") && (c.Lesson.Day == "Tuesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (tuesday1900Data.FirstOrDefault() != null && tuesdayClients1900Data.FirstOrDefault() != null)
                {
                    tuesday1900.ItemsSource = tuesday1900Data.ToList();
                    tuesdayClients1900.ItemsSource = tuesdayClients1900Data.ToList();
                }

                //вторник 19:30
                var tuesday1930Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:30") && (c.Day == "Tuesday") && c.Teacher.Id == CurrentTeacher.Id);
                var tuesdayClients1930Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:30") && (c.Lesson.Day == "Tuesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (tuesday1930Data.FirstOrDefault() != null && tuesdayClients1930Data.FirstOrDefault() != null)
                {
                    tuesday1930.ItemsSource = tuesday1930Data.ToList();
                    tuesdayClients1930.ItemsSource = tuesdayClients1930Data.ToList();
                }

                //вторник 20:00
                var tuesday2000Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "20:00") && (c.Day == "Tuesday") && c.Teacher.Id == CurrentTeacher.Id);
                var tuesdayClients2000Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "20:00") && (c.Lesson.Day == "Tuesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (tuesday2000Data.FirstOrDefault() != null && tuesdayClients2000Data.FirstOrDefault() != null)
                {
                    tuesday2000.ItemsSource = tuesday2000Data.ToList();
                    tuesdayClients2000.ItemsSource = tuesdayClients2000Data.ToList();
                }

                //вторник 20:30
                var tuesday2030Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "20:30") && (c.Day == "Tuesday") && c.Teacher.Id == CurrentTeacher.Id);
                var tuesdayClients2030Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "20:30") && (c.Lesson.Day == "Tuesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (tuesday2030Data.FirstOrDefault() != null && tuesdayClients2030Data.FirstOrDefault() != null)
                {
                    tuesday2030.ItemsSource = tuesday2030Data.ToList();
                    tuesdayClients2030.ItemsSource = tuesdayClients2030Data.ToList();
                }

                //вторник 21:00
                var tuesday2100Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "21:00") && (c.Day == "Tuesday") && c.Teacher.Id == CurrentTeacher.Id);
                var tuesdayClients2100Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "21:00") && (c.Lesson.Day == "Tuesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (tuesday2100Data.FirstOrDefault() != null && tuesdayClients2100Data.FirstOrDefault() != null)
                {
                    tuesday2100.ItemsSource = tuesday2100Data.ToList();
                    tuesdayClients2100.ItemsSource = tuesdayClients2100Data.ToList();
                }

                //вторник 21:30
                var tuesday2130Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "21:30") && (c.Day == "Tuesday") && c.Teacher.Id == CurrentTeacher.Id);
                var tuesdayClients2130Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "21:30") && (c.Lesson.Day == "Tuesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (tuesday2130Data.FirstOrDefault() != null && tuesdayClients2130Data.FirstOrDefault() != null)
                {
                    tuesday2130.ItemsSource = tuesday2130Data.ToList();
                    tuesdayClients2130.ItemsSource = tuesdayClients2130Data.ToList();
                }

                //среда 9:00
                var wednesday900Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:00") && (c.Day == "Wednesday") && c.Teacher.Id == CurrentTeacher.Id);
                var wednesdayClients900Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:00") && (c.Lesson.Day == "Wednesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (wednesday900Data.FirstOrDefault() != null && wednesdayClients900Data.FirstOrDefault() != null)
                {
                    wednesday900.ItemsSource = wednesday900Data.ToList();
                    wednesdayClients900.ItemsSource = wednesdayClients900Data.ToList();
                }

                //среда 9:30
                var wednesday930Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:30") && (c.Day == "Wednesday") && c.Teacher.Id == CurrentTeacher.Id);
                var wednesdayClients930Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:30") && (c.Lesson.Day == "Wednesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (wednesday930Data.FirstOrDefault() != null && wednesdayClients930Data.FirstOrDefault() != null)
                {
                    wednesday930.ItemsSource = wednesday930Data.ToList();
                    wednesdayClients930.ItemsSource = wednesdayClients930Data.ToList();
                }

                //среда 10:00
                var wednesday1000Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:00") && (c.Day == "Wednesday") && c.Teacher.Id == CurrentTeacher.Id);
                var wednesdayClients1000Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:00") && (c.Lesson.Day == "Wednesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (wednesday1000Data.FirstOrDefault() != null && wednesdayClients1000Data.FirstOrDefault() != null)
                {
                    wednesday1000.ItemsSource = wednesday1000Data.ToList();
                    wednesdayClients1000.ItemsSource = wednesdayClients1000Data.ToList();
                }

                //среда 10:30
                var wednesday1030Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:30") && (c.Day == "Wednesday") && c.Teacher.Id == CurrentTeacher.Id);
                var wednesdayClients1030Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:30") && (c.Lesson.Day == "Wednesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (wednesday1030Data.FirstOrDefault() != null && wednesdayClients1030Data.FirstOrDefault() != null)
                {
                    wednesday1030.ItemsSource = wednesday1030Data.ToList();
                    wednesdayClients1030.ItemsSource = wednesdayClients1030Data.ToList();
                }

                //среда 11:00
                var wednesday1100Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:00") && (c.Day == "Wednesday") && c.Teacher.Id == CurrentTeacher.Id);
                var wednesdayClients1100Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:00") && (c.Lesson.Day == "Wednesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (wednesday1100Data.FirstOrDefault() != null && wednesdayClients1100Data.FirstOrDefault() != null)
                {
                    wednesday1100.ItemsSource = wednesday1100Data.ToList();
                    wednesdayClients1100.ItemsSource = wednesdayClients1100Data.ToList();
                }

                //среда 11:30
                var wednesday1130Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:30") && (c.Day == "Wednesday") && c.Teacher.Id == CurrentTeacher.Id);
                var wednesdayClients1130Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:30") && (c.Lesson.Day == "Wednesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (wednesday1130Data.FirstOrDefault() != null && wednesdayClients1130Data.FirstOrDefault() != null)
                {
                    wednesday1130.ItemsSource = wednesday1130Data.ToList();
                    wednesdayClients1130.ItemsSource = wednesdayClients1130Data.ToList();
                }

                //среда 12:00
                var wednesday1200Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:00") && (c.Day == "Wednesday") && c.Teacher.Id == CurrentTeacher.Id);
                var wednesdayClients1200Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:00") && (c.Lesson.Day == "Wednesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (wednesday1200Data.FirstOrDefault() != null && wednesdayClients1200Data.FirstOrDefault() != null)
                {
                    wednesday1200.ItemsSource = wednesday1200Data.ToList();
                    wednesdayClients1200.ItemsSource = wednesdayClients1200Data.ToList();
                }

                //среда 12:30
                var wednesday1230Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:30") && (c.Day == "Wednesday") && c.Teacher.Id == CurrentTeacher.Id);
                var wednesdayClients1230Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:30") && (c.Lesson.Day == "Wednesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (wednesday1230Data.FirstOrDefault() != null && wednesdayClients1230Data.FirstOrDefault() != null)
                {
                    wednesday1230.ItemsSource = wednesday1230Data.ToList();
                    wednesdayClients1230.ItemsSource = wednesdayClients1230Data.ToList();
                }

                //среда 13:00
                var wednesday1300Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:00") && (c.Day == "Wednesday") && c.Teacher.Id == CurrentTeacher.Id);
                var wednesdayClients1300Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:00") && (c.Lesson.Day == "Wednesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (wednesday1300Data.FirstOrDefault() != null && wednesdayClients1300Data.FirstOrDefault() != null)
                {
                    wednesday1300.ItemsSource = wednesday1300Data.ToList();
                    wednesdayClients1300.ItemsSource = wednesdayClients1300Data.ToList();
                }

                //среда 13:30
                var wednesday1330Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:30") && (c.Day == "Wednesday") && c.Teacher.Id == CurrentTeacher.Id);
                var wednesdayClients1330Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:30") && (c.Lesson.Day == "Wednesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (wednesday1330Data.FirstOrDefault() != null && wednesdayClients1330Data.FirstOrDefault() != null)
                {
                    wednesday1330.ItemsSource = wednesday1330Data.ToList();
                    wednesdayClients1330.ItemsSource = wednesdayClients1330Data.ToList();
                }

                //среда 14:00
                var wednesday1400Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:00") && (c.Day == "Wednesday") && c.Teacher.Id == CurrentTeacher.Id);
                var wednesdayClients1400Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:00") && (c.Lesson.Day == "Wednesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (wednesday1400Data.FirstOrDefault() != null && wednesdayClients1400Data.FirstOrDefault() != null)
                {
                    wednesday1400.ItemsSource = wednesday1400Data.ToList();
                    wednesdayClients1400.ItemsSource = wednesdayClients1400Data.ToList();
                }

                //среда 14:30
                var wednesday1430Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:30") && (c.Day == "Wednesday") && c.Teacher.Id == CurrentTeacher.Id);
                var wednesdayClients1430Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:30") && (c.Lesson.Day == "Wednesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (wednesday1430Data.FirstOrDefault() != null && wednesdayClients1430Data.FirstOrDefault() != null)
                {
                    wednesday1430.ItemsSource = wednesday1430Data.ToList();
                    wednesdayClients1430.ItemsSource = wednesdayClients1430Data.ToList();
                }

                //среда 15:00
                var wednesday1500Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:00") && (c.Day == "Wednesday") && c.Teacher.Id == CurrentTeacher.Id);
                var wednesdayClients1500Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:00") && (c.Lesson.Day == "Wednesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (wednesday1500Data.FirstOrDefault() != null && wednesdayClients1500Data.FirstOrDefault() != null)
                {
                    wednesday1500.ItemsSource = wednesday1500Data.ToList();
                    wednesdayClients1500.ItemsSource = wednesdayClients1500Data.ToList();
                }

                //среда 15:30
                var wednesday1530Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:30") && (c.Day == "Wednesday") && c.Teacher.Id == CurrentTeacher.Id);
                var wednesdayClients1530Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:30") && (c.Lesson.Day == "Wednesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (wednesday1530Data.FirstOrDefault() != null && wednesdayClients1530Data.FirstOrDefault() != null)
                {
                    wednesday1530.ItemsSource = wednesday1530Data.ToList();
                    wednesdayClients1530.ItemsSource = wednesdayClients1530Data.ToList();
                }

                //среда 16:00
                var wednesday1600Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:00") && (c.Day == "Wednesday") && c.Teacher.Id == CurrentTeacher.Id);
                var wednesdayClients1600Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:00") && (c.Lesson.Day == "Wednesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (wednesday1600Data.FirstOrDefault() != null && wednesdayClients1600Data.FirstOrDefault() != null)
                {
                    wednesday1600.ItemsSource = wednesday1600Data.ToList();
                    wednesdayClients1600.ItemsSource = wednesdayClients1600Data.ToList();
                }

                //среда 16:30
                var wednesday1630Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:30") && (c.Day == "Wednesday") && c.Teacher.Id == CurrentTeacher.Id);
                var wednesdayClients1630Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:30") && (c.Lesson.Day == "Wednesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (wednesday1630Data.FirstOrDefault() != null && wednesdayClients1630Data.FirstOrDefault() != null)
                {
                    wednesday1630.ItemsSource = wednesday1630Data.ToList();
                    wednesdayClients1630.ItemsSource = wednesdayClients1630Data.ToList();
                }

                //среда 17:00
                var wednesday1700Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:00") && (c.Day == "Wednesday") && c.Teacher.Id == CurrentTeacher.Id);
                var wednesdayClients1700Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:00") && (c.Lesson.Day == "Wednesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (wednesday1700Data.FirstOrDefault() != null && wednesdayClients1700Data.FirstOrDefault() != null)
                {
                    wednesday1700.ItemsSource = wednesday1700Data.ToList();
                    wednesdayClients1700.ItemsSource = wednesdayClients1700Data.ToList();
                }

                //среда 17:30
                var wednesday1730Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:30") && (c.Day == "Wednesday") && c.Teacher.Id == CurrentTeacher.Id);
                var wednesdayClients1730Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:30") && (c.Lesson.Day == "Wednesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (wednesday1730Data.FirstOrDefault() != null && wednesdayClients1730Data.FirstOrDefault() != null)
                {
                    wednesday1730.ItemsSource = wednesday1730Data.ToList();
                    wednesdayClients1730.ItemsSource = wednesdayClients1730Data.ToList();
                }

                //среда 18:00
                var wednesday1800Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:00") && (c.Day == "Wednesday") && c.Teacher.Id == CurrentTeacher.Id);
                var wednesdayClients1800Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:00") && (c.Lesson.Day == "Wednesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (wednesday1800Data.FirstOrDefault() != null && wednesdayClients1800Data.FirstOrDefault() != null)
                {
                    wednesday1800.ItemsSource = wednesday1800Data.ToList();
                    wednesdayClients1800.ItemsSource = wednesdayClients1800Data.ToList();
                }

                //среда 18:30
                var wednesday1830Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:30") && (c.Day == "Wednesday") && c.Teacher.Id == CurrentTeacher.Id);
                var wednesdayClients1830Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:30") && (c.Lesson.Day == "Wednesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (wednesday1830Data.FirstOrDefault() != null && wednesdayClients1830Data.FirstOrDefault() != null)
                {
                    wednesday1830.ItemsSource = wednesday1830Data.ToList();
                    wednesdayClients1830.ItemsSource = wednesdayClients1830Data.ToList();
                }

                //среда 19:00
                var wednesday1900Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:00") && (c.Day == "Wednesday") && c.Teacher.Id == CurrentTeacher.Id);
                var wednesdayClients1900Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:00") && (c.Lesson.Day == "Wednesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (wednesday1900Data.FirstOrDefault() != null && wednesdayClients1900Data.FirstOrDefault() != null)
                {
                    wednesday1900.ItemsSource = wednesday1900Data.ToList();
                    wednesdayClients1900.ItemsSource = wednesdayClients1900Data.ToList();
                }

                //среда 19:30
                var wednesday1930Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:30") && (c.Day == "Wednesday") && c.Teacher.Id == CurrentTeacher.Id);
                var wednesdayClients1930Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:30") && (c.Lesson.Day == "Wednesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (wednesday1930Data.FirstOrDefault() != null && wednesdayClients1930Data.FirstOrDefault() != null)
                {
                    wednesday1930.ItemsSource = wednesday1930Data.ToList();
                    wednesdayClients1930.ItemsSource = wednesdayClients1930Data.ToList();
                }

                //среда 20:00
                var wednesday2000Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "20:00") && (c.Day == "Wednesday") && c.Teacher.Id == CurrentTeacher.Id);
                var wednesdayClients2000Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "20:00") && (c.Lesson.Day == "Wednesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (wednesday2000Data.FirstOrDefault() != null && wednesdayClients2000Data.FirstOrDefault() != null)
                {
                    wednesday2000.ItemsSource = wednesday2000Data.ToList();
                    wednesdayClients2000.ItemsSource = wednesdayClients2000Data.ToList();
                }

                //среда 20:30
                var wednesday2030Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "20:30") && (c.Day == "Wednesday") && c.Teacher.Id == CurrentTeacher.Id);
                var wednesdayClients2030Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "20:30") && (c.Lesson.Day == "Wednesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (wednesday2030Data.FirstOrDefault() != null && wednesdayClients2030Data.FirstOrDefault() != null)
                {
                    wednesday2030.ItemsSource = wednesday2030Data.ToList();
                    wednesdayClients2030.ItemsSource = wednesdayClients2030Data.ToList();
                }

                //среда 21:00
                var wednesday2100Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "21:00") && (c.Day == "Wednesday") && c.Teacher.Id == CurrentTeacher.Id);
                var wednesdayClients2100Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "21:00") && (c.Lesson.Day == "Wednesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (wednesday2100Data.FirstOrDefault() != null && wednesdayClients2100Data.FirstOrDefault() != null)
                {
                    wednesday2100.ItemsSource = wednesday2100Data.ToList();
                    wednesdayClients2100.ItemsSource = wednesdayClients2100Data.ToList();
                }

                //среда 21:30
                var wednesday2130Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "21:30") && (c.Day == "Wednesday") && c.Teacher.Id == CurrentTeacher.Id);
                var wednesdayClients2130Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "21:30") && (c.Lesson.Day == "Wednesday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (wednesday2130Data.FirstOrDefault() != null && wednesdayClients2130Data.FirstOrDefault() != null)
                {
                    wednesday2130.ItemsSource = wednesday2130Data.ToList();
                    wednesdayClients2130.ItemsSource = wednesdayClients2130Data.ToList();
                }

                //четверг 9:00
                var thursday900Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:00") && (c.Day == "Thursday") && c.Teacher.Id == CurrentTeacher.Id);
                var thursdayClients900Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:00") && (c.Lesson.Day == "Thursday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (thursday900Data.FirstOrDefault() != null && thursdayClients900Data.FirstOrDefault() != null)
                {
                    thursday900.ItemsSource = thursday900Data.ToList();
                    thursdayClients900.ItemsSource = thursdayClients900Data.ToList();
                }

                //четверг 9:30
                var thursday930Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:30") && (c.Day == "Thursday") && c.Teacher.Id == CurrentTeacher.Id);
                var thursdayClients930Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:30") && (c.Lesson.Day == "Thursday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (thursday930Data.FirstOrDefault() != null && thursdayClients930Data.FirstOrDefault() != null)
                {
                    thursday930.ItemsSource = thursday930Data.ToList();
                    thursdayClients930.ItemsSource = thursdayClients930Data.ToList();
                }

                //четверг 10:00
                var thursday1000Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:00") && (c.Day == "Thursday") && c.Teacher.Id == CurrentTeacher.Id);
                var thursdayClients1000Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:00") && (c.Lesson.Day == "Thursday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (thursday1000Data.FirstOrDefault() != null && thursdayClients1000Data.FirstOrDefault() != null)
                {
                    thursday1000.ItemsSource = thursday1000Data.ToList();
                    thursdayClients1000.ItemsSource = thursdayClients1000Data.ToList();
                }

                //четверг 10:30
                var thursday1030Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:30") && (c.Day == "Thursday") && c.Teacher.Id == CurrentTeacher.Id);
                var thursdayClients1030Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:30") && (c.Lesson.Day == "Thursday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (thursday1030Data.FirstOrDefault() != null && thursdayClients1030Data.FirstOrDefault() != null)
                {
                    thursday1030.ItemsSource = thursday1030Data.ToList();
                    thursdayClients1030.ItemsSource = thursdayClients1030Data.ToList();
                }

                //четверг 11:00
                var thursday1100Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:00") && (c.Day == "Thursday") && c.Teacher.Id == CurrentTeacher.Id);
                var thursdayClients1100Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:00") && (c.Lesson.Day == "Thursday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (thursday1100Data.FirstOrDefault() != null && thursdayClients1100Data.FirstOrDefault() != null)
                {
                    thursday1100.ItemsSource = thursday1100Data.ToList();
                    thursdayClients1100.ItemsSource = thursdayClients1100Data.ToList();
                }

                //четверг 11:30
                var thursday1130Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:30") && (c.Day == "Thursday") && c.Teacher.Id == CurrentTeacher.Id);
                var thursdayClients1130Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:30") && (c.Lesson.Day == "Thursday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (thursday1130Data.FirstOrDefault() != null && thursdayClients1130Data.FirstOrDefault() != null)
                {
                    thursday1130.ItemsSource = thursday1130Data.ToList();
                    thursdayClients1130.ItemsSource = thursdayClients1130Data.ToList();
                }

                //четверг 12:00
                var thursday1200Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:00") && (c.Day == "Thursday") && c.Teacher.Id == CurrentTeacher.Id);
                var thursdayClients1200Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:00") && (c.Lesson.Day == "Thursday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (thursday1200Data.FirstOrDefault() != null && thursdayClients1200Data.FirstOrDefault() != null)
                {
                    thursday1200.ItemsSource = thursday1200Data.ToList();
                    thursdayClients1200.ItemsSource = thursdayClients1200Data.ToList();
                }

                //четверг 12:30
                var thursday1230Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:30") && (c.Day == "Thursday") && c.Teacher.Id == CurrentTeacher.Id);
                var thursdayClients1230Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:30") && (c.Lesson.Day == "Thursday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (thursday1230Data.FirstOrDefault() != null && thursdayClients1230Data.FirstOrDefault() != null)
                {
                    thursday1230.ItemsSource = thursday1230Data.ToList();
                    thursdayClients1230.ItemsSource = thursdayClients1230Data.ToList();
                }

                //четверг 13:00
                var thursday1300Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:00") && (c.Day == "Thursday") && c.Teacher.Id == CurrentTeacher.Id);
                var thursdayClients1300Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:00") && (c.Lesson.Day == "Thursday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (thursday1300Data.FirstOrDefault() != null && thursdayClients1300Data.FirstOrDefault() != null)
                {
                    thursday1300.ItemsSource = thursday1300Data.ToList();
                    thursdayClients1300.ItemsSource = thursdayClients1300Data.ToList();
                }

                //четверг 13:30
                var thursday1330Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:30") && (c.Day == "Thursday") && c.Teacher.Id == CurrentTeacher.Id);
                var thursdayClients1330Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:30") && (c.Lesson.Day == "Thursday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (thursday1330Data.FirstOrDefault() != null && thursdayClients1330Data.FirstOrDefault() != null)
                {
                    thursday1330.ItemsSource = thursday1330Data.ToList();
                    thursdayClients1330.ItemsSource = thursdayClients1330Data.ToList();
                }

                //четверг 14:00
                var thursday1400Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:00") && (c.Day == "Thursday") && c.Teacher.Id == CurrentTeacher.Id);
                var thursdayClients1400Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:00") && (c.Lesson.Day == "Thursday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (thursday1400Data.FirstOrDefault() != null && thursdayClients1400Data.FirstOrDefault() != null)
                {
                    thursday1400.ItemsSource = thursday1400Data.ToList();
                    thursdayClients1400.ItemsSource = thursdayClients1400Data.ToList();
                }

                //четверг 14:30
                var thursday1430Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:30") && (c.Day == "Thursday") && c.Teacher.Id == CurrentTeacher.Id);
                var thursdayClients1430Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:30") && (c.Lesson.Day == "Thursday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (thursday1430Data.FirstOrDefault() != null && thursdayClients1430Data.FirstOrDefault() != null)
                {
                    thursday1430.ItemsSource = thursday1430Data.ToList();
                    thursdayClients1430.ItemsSource = thursdayClients1430Data.ToList();
                }

                //четверг 15:00
                var thursday1500Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:00") && (c.Day == "Thursday") && c.Teacher.Id == CurrentTeacher.Id);
                var thursdayClients1500Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:00") && (c.Lesson.Day == "Thursday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (thursday1500Data.FirstOrDefault() != null && thursdayClients1500Data.FirstOrDefault() != null)
                {
                    thursday1500.ItemsSource = thursday1500Data.ToList();
                    thursdayClients1500.ItemsSource = thursdayClients1500Data.ToList();
                }

                //четверг 15:30
                var thursday1530Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:30") && (c.Day == "Thursday") && c.Teacher.Id == CurrentTeacher.Id);
                var thursdayClients1530Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:30") && (c.Lesson.Day == "Thursday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (thursday1530Data.FirstOrDefault() != null && thursdayClients1530Data.FirstOrDefault() != null)
                {
                    thursday1530.ItemsSource = thursday1530Data.ToList();
                    thursdayClients1530.ItemsSource = thursdayClients1530Data.ToList();
                }

                //четверг 16:00
                var thursday1600Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:00") && (c.Day == "Thursday") && c.Teacher.Id == CurrentTeacher.Id);
                var thursdayClients1600Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:00") && (c.Lesson.Day == "Thursday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (thursday1600Data.FirstOrDefault() != null && thursdayClients1600Data.FirstOrDefault() != null)
                {
                    thursday1600.ItemsSource = thursday1600Data.ToList();
                    thursdayClients1600.ItemsSource = thursdayClients1600Data.ToList();
                }

                //четверг 16:30
                var thursday1630Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:30") && (c.Day == "Thursday") && c.Teacher.Id == CurrentTeacher.Id);
                var thursdayClients1630Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:30") && (c.Lesson.Day == "Thursday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (thursday1630Data.FirstOrDefault() != null && thursdayClients1630Data.FirstOrDefault() != null)
                {
                    thursday1630.ItemsSource = thursday1630Data.ToList();
                    thursdayClients1630.ItemsSource = thursdayClients1630Data.ToList();
                }

                //четверг 17:00
                var thursday1700Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:00") && (c.Day == "Thursday") && c.Teacher.Id == CurrentTeacher.Id);
                var thursdayClients1700Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:00") && (c.Lesson.Day == "Thursday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (thursday1700Data.FirstOrDefault() != null && thursdayClients1700Data.FirstOrDefault() != null)
                {
                    thursday1700.ItemsSource = thursday1700Data.ToList();
                    thursdayClients1700.ItemsSource = thursdayClients1700Data.ToList();
                }

                //четверг 17:30
                var thursday1730Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:30") && (c.Day == "Thursday") && c.Teacher.Id == CurrentTeacher.Id);
                var thursdayClients1730Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:30") && (c.Lesson.Day == "Thursday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (thursday1730Data.FirstOrDefault() != null && thursdayClients1730Data.FirstOrDefault() != null)
                {
                    thursday1730.ItemsSource = thursday1730Data.ToList();
                    thursdayClients1730.ItemsSource = thursdayClients1730Data.ToList();
                }

                //четверг 18:00
                var thursday1800Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:00") && (c.Day == "Thursday") && c.Teacher.Id == CurrentTeacher.Id);
                var thursdayClients1800Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:00") && (c.Lesson.Day == "Thursday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (thursday1800Data.FirstOrDefault() != null && thursdayClients1800Data.FirstOrDefault() != null)
                {
                    thursday1800.ItemsSource = thursday1800Data.ToList();
                    thursdayClients1800.ItemsSource = thursdayClients1800Data.ToList();
                }

                //четверг 18:30
                var thursday1830Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:30") && (c.Day == "Thursday") && c.Teacher.Id == CurrentTeacher.Id);
                var thursdayClients1830Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:30") && (c.Lesson.Day == "Thursday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (thursday1830Data.FirstOrDefault() != null && thursdayClients1830Data.FirstOrDefault() != null)
                {
                    thursday1830.ItemsSource = thursday1830Data.ToList();
                    thursdayClients1830.ItemsSource = thursdayClients1830Data.ToList();
                }

                //четверг 19:00
                var thursday1900Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:00") && (c.Day == "Thursday") && c.Teacher.Id == CurrentTeacher.Id);
                var thursdayClients1900Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:00") && (c.Lesson.Day == "Thursday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (thursday1900Data.FirstOrDefault() != null && thursdayClients1900Data.FirstOrDefault() != null)
                {
                    thursday1900.ItemsSource = thursday1900Data.ToList();
                    thursdayClients1900.ItemsSource = thursdayClients1900Data.ToList();
                }

                //четверг 19:30
                var thursday1930Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:30") && (c.Day == "Thursday") && c.Teacher.Id == CurrentTeacher.Id);
                var thursdayClients1930Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:30") && (c.Lesson.Day == "Thursday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (thursday1930Data.FirstOrDefault() != null && thursdayClients1930Data.FirstOrDefault() != null)
                {
                    thursday1930.ItemsSource = thursday1930Data.ToList();
                    thursdayClients1930.ItemsSource = thursdayClients1930Data.ToList();
                }

                //четверг 20:00
                var thursday2000Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "20:00") && (c.Day == "Thursday") && c.Teacher.Id == CurrentTeacher.Id);
                var thursdayClients2000Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "20:00") && (c.Lesson.Day == "Thursday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (thursday2000Data.FirstOrDefault() != null && thursdayClients2000Data.FirstOrDefault() != null)
                {
                    thursday2000.ItemsSource = thursday2000Data.ToList();
                    thursdayClients2000.ItemsSource = thursdayClients2000Data.ToList();
                }

                //четверг 20:30
                var thursday2030Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "20:30") && (c.Day == "Thursday") && c.Teacher.Id == CurrentTeacher.Id);
                var thursdayClients2030Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "20:30") && (c.Lesson.Day == "Thursday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (thursday2030Data.FirstOrDefault() != null && thursdayClients2030Data.FirstOrDefault() != null)
                {
                    thursday2030.ItemsSource = thursday2030Data.ToList();
                    thursdayClients2030.ItemsSource = thursdayClients2030Data.ToList();
                }

                //четверг 21:00
                var thursday2100Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "21:00") && (c.Day == "Thursday") && c.Teacher.Id == CurrentTeacher.Id);
                var thursdayClients2100Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "21:00") && (c.Lesson.Day == "Thursday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (thursday2100Data.FirstOrDefault() != null && thursdayClients2100Data.FirstOrDefault() != null)
                {
                    thursday2100.ItemsSource = thursday2100Data.ToList();
                    thursdayClients2100.ItemsSource = thursdayClients2100Data.ToList();
                }

                //четверг 21:30
                var thursday2130Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "21:30") && (c.Day == "Thursday") && c.Teacher.Id == CurrentTeacher.Id);
                var thursdayClients2130Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "21:30") && (c.Lesson.Day == "Thursday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (thursday2130Data.FirstOrDefault() != null && thursdayClients2130Data.FirstOrDefault() != null)
                {
                    thursday2130.ItemsSource = thursday2130Data.ToList();
                    thursdayClients2130.ItemsSource = thursdayClients2130Data.ToList();
                }

                //пятница 9:00
                var friday900Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:00") && (c.Day == "Friday") && c.Teacher.Id == CurrentTeacher.Id);
                var fridayClients900Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:00") && (c.Lesson.Day == "Friday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (friday900Data.FirstOrDefault() != null && fridayClients900Data.FirstOrDefault() != null)
                {
                    friday900.ItemsSource = friday900Data.ToList();
                    fridayClients900.ItemsSource = fridayClients900Data.ToList();
                }

                //пятница 9:30
                var friday930Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:30") && (c.Day == "Friday") && c.Teacher.Id == CurrentTeacher.Id);
                var fridayClients930Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:30") && (c.Lesson.Day == "Friday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (friday930Data.FirstOrDefault() != null && fridayClients930Data.FirstOrDefault() != null)
                {
                    friday930.ItemsSource = friday930Data.ToList();
                    fridayClients930.ItemsSource = fridayClients930Data.ToList();
                }

                //пятница 10:00
                var friday1000Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:00") && (c.Day == "Friday") && c.Teacher.Id == CurrentTeacher.Id);
                var fridayClients1000Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:00") && (c.Lesson.Day == "Friday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (friday1000Data.FirstOrDefault() != null && fridayClients1000Data.FirstOrDefault() != null)
                {
                    friday1000.ItemsSource = friday1000Data.ToList();
                    fridayClients1000.ItemsSource = fridayClients1000Data.ToList();
                }

                //пятница 10:30
                var friday1030Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:30") && (c.Day == "Friday") && c.Teacher.Id == CurrentTeacher.Id);
                var fridayClients1030Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:30") && (c.Lesson.Day == "Friday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (friday1030Data.FirstOrDefault() != null && fridayClients1030Data.FirstOrDefault() != null)
                {
                    friday1030.ItemsSource = friday1030Data.ToList();
                    fridayClients1030.ItemsSource = fridayClients1030Data.ToList();
                }

                //пятница 11:00
                var friday1100Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:00") && (c.Day == "Friday") && c.Teacher.Id == CurrentTeacher.Id);
                var fridayClients1100Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:00") && (c.Lesson.Day == "Friday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (friday1100Data.FirstOrDefault() != null && fridayClients1100Data.FirstOrDefault() != null)
                {
                    friday1100.ItemsSource = friday1100Data.ToList();
                    fridayClients1100.ItemsSource = fridayClients1100Data.ToList();
                }

                //пятница 11:30
                var friday1130Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:30") && (c.Day == "Friday") && c.Teacher.Id == CurrentTeacher.Id);
                var fridayClients1130Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:30") && (c.Lesson.Day == "Friday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (friday1130Data.FirstOrDefault() != null && fridayClients1130Data.FirstOrDefault() != null)
                {
                    friday1130.ItemsSource = friday1130Data.ToList();
                    fridayClients1130.ItemsSource = fridayClients1130Data.ToList();
                }

                //пятница 12:00
                var friday1200Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:00") && (c.Day == "Friday") && c.Teacher.Id == CurrentTeacher.Id);
                var fridayClients1200Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:00") && (c.Lesson.Day == "Friday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (friday1200Data.FirstOrDefault() != null && fridayClients1200Data.FirstOrDefault() != null)
                {
                    friday1200.ItemsSource = friday1200Data.ToList();
                    fridayClients1200.ItemsSource = fridayClients1200Data.ToList();
                }

                //пятница 12:30
                var friday1230Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:30") && (c.Day == "Friday") && c.Teacher.Id == CurrentTeacher.Id);
                var fridayClients1230Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:30") && (c.Lesson.Day == "Friday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (friday1230Data.FirstOrDefault() != null && fridayClients1230Data.FirstOrDefault() != null)
                {
                    friday1230.ItemsSource = friday1230Data.ToList();
                    fridayClients1230.ItemsSource = fridayClients1230Data.ToList();
                }

                //пятница 13:00
                var friday1300Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:00") && (c.Day == "Friday") && c.Teacher.Id == CurrentTeacher.Id);
                var fridayClients1300Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:00") && (c.Lesson.Day == "Friday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (friday1300Data.FirstOrDefault() != null && fridayClients1300Data.FirstOrDefault() != null)
                {
                    friday1300.ItemsSource = friday1300Data.ToList();
                    fridayClients1300.ItemsSource = fridayClients1300Data.ToList();
                }

                //пятница 13:30
                var friday1330Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:30") && (c.Day == "Friday") && c.Teacher.Id == CurrentTeacher.Id);
                var fridayClients1330Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:30") && (c.Lesson.Day == "Friday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (friday1330Data.FirstOrDefault() != null && fridayClients1330Data.FirstOrDefault() != null)
                {
                    friday1330.ItemsSource = friday1330Data.ToList();
                    fridayClients1330.ItemsSource = fridayClients1330Data.ToList();
                }

                //пятница 14:00
                var friday1400Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:00") && (c.Day == "Friday") && c.Teacher.Id == CurrentTeacher.Id);
                var fridayClients1400Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:00") && (c.Lesson.Day == "Friday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (friday1400Data.FirstOrDefault() != null && fridayClients1400Data.FirstOrDefault() != null)
                {
                    friday1400.ItemsSource = friday1400Data.ToList();
                    fridayClients1400.ItemsSource = fridayClients1400Data.ToList();
                }

                //пятница 14:30
                var friday1430Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:30") && (c.Day == "Friday") && c.Teacher.Id == CurrentTeacher.Id);
                var fridayClients1430Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:30") && (c.Lesson.Day == "Friday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (friday1430Data.FirstOrDefault() != null && fridayClients1430Data.FirstOrDefault() != null)
                {
                    friday1430.ItemsSource = friday1430Data.ToList();
                    fridayClients1430.ItemsSource = fridayClients1430Data.ToList();
                }

                //пятница 15:00
                var friday1500Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:00") && (c.Day == "Friday") && c.Teacher.Id == CurrentTeacher.Id);
                var fridayClients1500Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:00") && (c.Lesson.Day == "Friday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (friday1500Data.FirstOrDefault() != null && fridayClients1500Data.FirstOrDefault() != null)
                {
                    friday1500.ItemsSource = friday1500Data.ToList();
                    fridayClients1500.ItemsSource = fridayClients1500Data.ToList();
                }

                //пятница 15:30
                var friday1530Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:30") && (c.Day == "Friday") && c.Teacher.Id == CurrentTeacher.Id);
                var fridayClients1530Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:30") && (c.Lesson.Day == "Friday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (friday1530Data.FirstOrDefault() != null && fridayClients1530Data.FirstOrDefault() != null)
                {
                    friday1530.ItemsSource = friday1530Data.ToList();
                    fridayClients1530.ItemsSource = fridayClients1530Data.ToList();
                }

                //пятница 16:00
                var friday1600Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:00") && (c.Day == "Friday") && c.Teacher.Id == CurrentTeacher.Id);
                var fridayClients1600Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:00") && (c.Lesson.Day == "Friday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (friday1600Data.FirstOrDefault() != null && fridayClients1600Data.FirstOrDefault() != null)
                {
                    friday1600.ItemsSource = friday1600Data.ToList();
                    fridayClients1600.ItemsSource = fridayClients1600Data.ToList();
                }

                //пятница 16:30
                var friday1630Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:30") && (c.Day == "Friday") && c.Teacher.Id == CurrentTeacher.Id);
                var fridayClients1630Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:30") && (c.Lesson.Day == "Friday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (friday1630Data.FirstOrDefault() != null && fridayClients1630Data.FirstOrDefault() != null)
                {
                    friday1630.ItemsSource = friday1630Data.ToList();
                    fridayClients1630.ItemsSource = fridayClients1630Data.ToList();
                }

                //пятница 17:00
                var friday1700Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:00") && (c.Day == "Friday") && c.Teacher.Id == CurrentTeacher.Id);
                var fridayClients1700Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:00") && (c.Lesson.Day == "Friday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (friday1700Data.FirstOrDefault() != null && fridayClients1700Data.FirstOrDefault() != null)
                {
                    friday1700.ItemsSource = friday1700Data.ToList();
                    fridayClients1700.ItemsSource = fridayClients1700Data.ToList();
                }

                //пятница 17:30
                var friday1730Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:30") && (c.Day == "Friday") && c.Teacher.Id == CurrentTeacher.Id);
                var fridayClients1730Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:30") && (c.Lesson.Day == "Friday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (friday1730Data.FirstOrDefault() != null && fridayClients1730Data.FirstOrDefault() != null)
                {
                    friday1730.ItemsSource = friday1730Data.ToList();
                    fridayClients1730.ItemsSource = fridayClients1730Data.ToList();
                }

                //пятница 18:00
                var friday1800Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:00") && (c.Day == "Friday") && c.Teacher.Id == CurrentTeacher.Id);
                var fridayClients1800Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:00") && (c.Lesson.Day == "Friday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (friday1800Data.FirstOrDefault() != null && fridayClients1800Data.FirstOrDefault() != null)
                {
                    friday1800.ItemsSource = friday1800Data.ToList();
                    fridayClients1800.ItemsSource = fridayClients1800Data.ToList();
                }

                //пятница 18:30
                var friday1830Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:30") && (c.Day == "Friday") && c.Teacher.Id == CurrentTeacher.Id);
                var fridayClients1830Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:30") && (c.Lesson.Day == "Friday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (friday1830Data.FirstOrDefault() != null && fridayClients1830Data.FirstOrDefault() != null)
                {
                    friday1830.ItemsSource = friday1830Data.ToList();
                    fridayClients1830.ItemsSource = fridayClients1830Data.ToList();
                }

                //пятница 19:00
                var friday1900Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:00") && (c.Day == "Friday") && c.Teacher.Id == CurrentTeacher.Id);
                var fridayClients1900Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:00") && (c.Lesson.Day == "Friday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (friday1900Data.FirstOrDefault() != null && fridayClients1900Data.FirstOrDefault() != null)
                {
                    friday1900.ItemsSource = friday1900Data.ToList();
                    fridayClients1900.ItemsSource = fridayClients1900Data.ToList();
                }

                //пятница 19:30
                var friday1930Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:30") && (c.Day == "Friday") && c.Teacher.Id == CurrentTeacher.Id);
                var fridayClients1930Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:30") && (c.Lesson.Day == "Friday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (friday1930Data.FirstOrDefault() != null && fridayClients1930Data.FirstOrDefault() != null)
                {
                    friday1930.ItemsSource = friday1930Data.ToList();
                    fridayClients1930.ItemsSource = fridayClients1930Data.ToList();
                }

                //пятница 20:00
                var friday2000Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "20:00") && (c.Day == "Friday") && c.Teacher.Id == CurrentTeacher.Id);
                var fridayClients2000Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "20:00") && (c.Lesson.Day == "Friday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (friday2000Data.FirstOrDefault() != null && fridayClients2000Data.FirstOrDefault() != null)
                {
                    friday2000.ItemsSource = friday2000Data.ToList();
                    fridayClients2000.ItemsSource = fridayClients2000Data.ToList();
                }

                //пятница 20:30
                var friday2030Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "20:30") && (c.Day == "Friday") && c.Teacher.Id == CurrentTeacher.Id);
                var fridayClients2030Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "20:30") && (c.Lesson.Day == "Friday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (friday2030Data.FirstOrDefault() != null && fridayClients2030Data.FirstOrDefault() != null)
                {
                    friday2030.ItemsSource = friday2030Data.ToList();
                    fridayClients2030.ItemsSource = fridayClients2030Data.ToList();
                }

                //пятница 21:00
                var friday2100Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "21:00") && (c.Day == "Friday") && c.Teacher.Id == CurrentTeacher.Id);
                var fridayClients2100Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "21:00") && (c.Lesson.Day == "Friday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (friday2100Data.FirstOrDefault() != null && fridayClients2100Data.FirstOrDefault() != null)
                {
                    friday2100.ItemsSource = friday2100Data.ToList();
                    fridayClients2100.ItemsSource = fridayClients2100Data.ToList();
                }

                //пятница 21:30
                var friday2130Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "21:30") && (c.Day == "Friday") && c.Teacher.Id == CurrentTeacher.Id);
                var fridayClients2130Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "21:30") && (c.Lesson.Day == "Friday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (friday2130Data.FirstOrDefault() != null && fridayClients2130Data.FirstOrDefault() != null)
                {
                    friday2130.ItemsSource = friday2130Data.ToList();
                    fridayClients2130.ItemsSource = fridayClients2130Data.ToList();
                }

                //суббота 9:00
                var saturday900Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:00") && (c.Day == "Saturday") && c.Teacher.Id == CurrentTeacher.Id);
                var saturdayClients900Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:00") && (c.Lesson.Day == "Saturday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (saturday900Data.FirstOrDefault() != null && saturdayClients900Data.FirstOrDefault() != null)
                {
                    saturday900.ItemsSource = saturday900Data.ToList();
                    saturdayClients900.ItemsSource = saturdayClients900Data.ToList();
                }

                //суббота 9:30
                var saturday930Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:30") && (c.Day == "Saturday") && c.Teacher.Id == CurrentTeacher.Id);
                var saturdayClients930Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:30") && (c.Lesson.Day == "Saturday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (saturday930Data.FirstOrDefault() != null && saturdayClients930Data.FirstOrDefault() != null)
                {
                    saturday930.ItemsSource = saturday930Data.ToList();
                    saturdayClients930.ItemsSource = saturdayClients930Data.ToList();
                }

                //суббота 10:00
                var saturday1000Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:00") && (c.Day == "Saturday") && c.Teacher.Id == CurrentTeacher.Id);
                var saturdayClients1000Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:00") && (c.Lesson.Day == "Saturday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (saturday1000Data.FirstOrDefault() != null && saturdayClients1000Data.FirstOrDefault() != null)
                {
                    saturday1000.ItemsSource = saturday1000Data.ToList();
                    saturdayClients1000.ItemsSource = saturdayClients1000Data.ToList();
                }

                //суббота 10:30
                var saturday1030Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:30") && (c.Day == "Saturday") && c.Teacher.Id == CurrentTeacher.Id);
                var saturdayClients1030Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:30") && (c.Lesson.Day == "Saturday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (saturday1030Data.FirstOrDefault() != null && saturdayClients1030Data.FirstOrDefault() != null)
                {
                    saturday1030.ItemsSource = saturday1030Data.ToList();
                    saturdayClients1030.ItemsSource = saturdayClients1030Data.ToList();
                }

                //суббота 11:00
                var saturday1100Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:00") && (c.Day == "Saturday") && c.Teacher.Id == CurrentTeacher.Id);
                var saturdayClients1100Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:00") && (c.Lesson.Day == "Saturday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (saturday1100Data.FirstOrDefault() != null && saturdayClients1100Data.FirstOrDefault() != null)
                {
                    saturday1100.ItemsSource = saturday1100Data.ToList();
                    saturdayClients1100.ItemsSource = saturdayClients1100Data.ToList();
                }

                //суббота 11:30
                var saturday1130Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:30") && (c.Day == "Saturday") && c.Teacher.Id == CurrentTeacher.Id);
                var saturdayClients1130Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:30") && (c.Lesson.Day == "Saturday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (saturday1130Data.FirstOrDefault() != null && saturdayClients1130Data.FirstOrDefault() != null)
                {
                    saturday1130.ItemsSource = saturday1130Data.ToList();
                    saturdayClients1130.ItemsSource = saturdayClients1130Data.ToList();
                }

                //суббота 12:00
                var saturday1200Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:00") && (c.Day == "Saturday") && c.Teacher.Id == CurrentTeacher.Id);
                var saturdayClients1200Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:00") && (c.Lesson.Day == "Saturday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (saturday1200Data.FirstOrDefault() != null && saturdayClients1200Data.FirstOrDefault() != null)
                {
                    saturday1200.ItemsSource = saturday1200Data.ToList();
                    saturdayClients1200.ItemsSource = saturdayClients1200Data.ToList();
                }

                //суббота 12:30
                var saturday1230Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:30") && (c.Day == "Saturday") && c.Teacher.Id == CurrentTeacher.Id);
                var saturdayClients1230Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:30") && (c.Lesson.Day == "Saturday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (saturday1230Data.FirstOrDefault() != null && saturdayClients1230Data.FirstOrDefault() != null)
                {
                    saturday1230.ItemsSource = saturday1230Data.ToList();
                    saturdayClients1230.ItemsSource = saturdayClients1230Data.ToList();
                }

                //суббота 13:00
                var saturday1300Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:00") && (c.Day == "Saturday") && c.Teacher.Id == CurrentTeacher.Id);
                var saturdayClients1300Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:00") && (c.Lesson.Day == "Saturday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (saturday1300Data.FirstOrDefault() != null && saturdayClients1300Data.FirstOrDefault() != null)
                {
                    saturday1300.ItemsSource = saturday1300Data.ToList();
                    saturdayClients1300.ItemsSource = saturdayClients1300Data.ToList();
                }

                //суббота 13:30
                var saturday1330Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:30") && (c.Day == "Saturday") && c.Teacher.Id == CurrentTeacher.Id);
                var saturdayClients1330Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:30") && (c.Lesson.Day == "Saturday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (saturday1330Data.FirstOrDefault() != null && saturdayClients1330Data.FirstOrDefault() != null)
                {
                    saturday1330.ItemsSource = saturday1330Data.ToList();
                    saturdayClients1330.ItemsSource = saturdayClients1330Data.ToList();
                }

                //суббота 14:00
                var saturday1400Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:00") && (c.Day == "Saturday") && c.Teacher.Id == CurrentTeacher.Id);
                var saturdayClients1400Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:00") && (c.Lesson.Day == "Saturday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (saturday1400Data.FirstOrDefault() != null && saturdayClients1400Data.FirstOrDefault() != null)
                {
                    saturday1400.ItemsSource = saturday1400Data.ToList();
                    saturdayClients1400.ItemsSource = saturdayClients1400Data.ToList();
                }

                //суббота 14:30
                var saturday1430Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:30") && (c.Day == "Saturday") && c.Teacher.Id == CurrentTeacher.Id);
                var saturdayClients1430Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:30") && (c.Lesson.Day == "Saturday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (saturday1430Data.FirstOrDefault() != null && saturdayClients1430Data.FirstOrDefault() != null)
                {
                    saturday1430.ItemsSource = saturday1430Data.ToList();
                    saturdayClients1430.ItemsSource = saturdayClients1430Data.ToList();
                }

                //суббота 15:00
                var saturday1500Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:00") && (c.Day == "Saturday") && c.Teacher.Id == CurrentTeacher.Id);
                var saturdayClients1500Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:00") && (c.Lesson.Day == "Saturday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (saturday1500Data.FirstOrDefault() != null && saturdayClients1500Data.FirstOrDefault() != null)
                {
                    saturday1500.ItemsSource = saturday1500Data.ToList();
                    saturdayClients1500.ItemsSource = saturdayClients1500Data.ToList();
                }

                //суббота 15:30
                var saturday1530Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:30") && (c.Day == "Saturday") && c.Teacher.Id == CurrentTeacher.Id);
                var saturdayClients1530Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:30") && (c.Lesson.Day == "Saturday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (saturday1530Data.FirstOrDefault() != null && saturdayClients1530Data.FirstOrDefault() != null)
                {
                    saturday1530.ItemsSource = saturday1530Data.ToList();
                    saturdayClients1530.ItemsSource = saturdayClients1530Data.ToList();
                }

                //суббота 16:00
                var saturday1600Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:00") && (c.Day == "Saturday") && c.Teacher.Id == CurrentTeacher.Id);
                var saturdayClients1600Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:00") && (c.Lesson.Day == "Saturday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (saturday1600Data.FirstOrDefault() != null && saturdayClients1600Data.FirstOrDefault() != null)
                {
                    saturday1600.ItemsSource = saturday1600Data.ToList();
                    saturdayClients1600.ItemsSource = saturdayClients1600Data.ToList();
                }

                //суббота 16:30
                var saturday1630Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:30") && (c.Day == "Saturday") && c.Teacher.Id == CurrentTeacher.Id);
                var saturdayClients1630Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:30") && (c.Lesson.Day == "Saturday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (saturday1630Data.FirstOrDefault() != null && saturdayClients1630Data.FirstOrDefault() != null)
                {
                    saturday1630.ItemsSource = saturday1630Data.ToList();
                    saturdayClients1630.ItemsSource = saturdayClients1630Data.ToList();
                }

                //суббота 17:00
                var saturday1700Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:00") && (c.Day == "Saturday") && c.Teacher.Id == CurrentTeacher.Id);
                var saturdayClients1700Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:00") && (c.Lesson.Day == "Saturday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (saturday1700Data.FirstOrDefault() != null && saturdayClients1700Data.FirstOrDefault() != null)
                {
                    saturday1700.ItemsSource = saturday1700Data.ToList();
                    saturdayClients1700.ItemsSource = saturdayClients1700Data.ToList();
                }

                //суббота 17:30
                var saturday1730Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:30") && (c.Day == "Saturday") && c.Teacher.Id == CurrentTeacher.Id);
                var saturdayClients1730Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:30") && (c.Lesson.Day == "Saturday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (saturday1730Data.FirstOrDefault() != null && saturdayClients1730Data.FirstOrDefault() != null)
                {
                    saturday1730.ItemsSource = saturday1730Data.ToList();
                    saturdayClients1730.ItemsSource = saturdayClients1730Data.ToList();
                }

                //суббота 18:00
                var saturday1800Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:00") && (c.Day == "Saturday") && c.Teacher.Id == CurrentTeacher.Id);
                var saturdayClients1800Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:00") && (c.Lesson.Day == "Saturday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (saturday1800Data.FirstOrDefault() != null && saturdayClients1800Data.FirstOrDefault() != null)
                {
                    saturday1800.ItemsSource = saturday1800Data.ToList();
                    saturdayClients1800.ItemsSource = saturdayClients1800Data.ToList();
                }

                //суббота 18:30
                var saturday1830Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:30") && (c.Day == "Saturday") && c.Teacher.Id == CurrentTeacher.Id);
                var saturdayClients1830Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:30") && (c.Lesson.Day == "Saturday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (saturday1830Data.FirstOrDefault() != null && saturdayClients1830Data.FirstOrDefault() != null)
                {
                    saturday1830.ItemsSource = saturday1830Data.ToList();
                    saturdayClients1830.ItemsSource = saturdayClients1830Data.ToList();
                }

                //суббота 19:00
                var saturday1900Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:00") && (c.Day == "Saturday") && c.Teacher.Id == CurrentTeacher.Id);
                var saturdayClients1900Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:00") && (c.Lesson.Day == "Saturday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (saturday1900Data.FirstOrDefault() != null && saturdayClients1900Data.FirstOrDefault() != null)
                {
                    saturday1900.ItemsSource = saturday1900Data.ToList();
                    saturdayClients1900.ItemsSource = saturdayClients1900Data.ToList();
                }

                //суббота 19:30
                var saturday1930Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:30") && (c.Day == "Saturday") && c.Teacher.Id == CurrentTeacher.Id);
                var saturdayClients1930Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:30") && (c.Lesson.Day == "Saturday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (saturday1930Data.FirstOrDefault() != null && saturdayClients1930Data.FirstOrDefault() != null)
                {
                    saturday1930.ItemsSource = saturday1930Data.ToList();
                    saturdayClients1930.ItemsSource = saturdayClients1930Data.ToList();
                }

                //суббота 20:00
                var saturday2000Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "20:00") && (c.Day == "Saturday") && c.Teacher.Id == CurrentTeacher.Id);
                var saturdayClients2000Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "20:00") && (c.Lesson.Day == "Saturday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (saturday2000Data.FirstOrDefault() != null && saturdayClients2000Data.FirstOrDefault() != null)
                {
                    saturday2000.ItemsSource = saturday2000Data.ToList();
                    saturdayClients2000.ItemsSource = saturdayClients2000Data.ToList();
                }

                //суббота 20:30
                var saturday2030Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "20:30") && (c.Day == "Saturday") && c.Teacher.Id == CurrentTeacher.Id);
                var saturdayClients2030Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "20:30") && (c.Lesson.Day == "Saturday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (saturday2030Data.FirstOrDefault() != null && saturdayClients2030Data.FirstOrDefault() != null)
                {
                    saturday2030.ItemsSource = saturday2030Data.ToList();
                    saturdayClients2030.ItemsSource = saturdayClients2030Data.ToList();
                }

                //суббота 21:00
                var saturday2100Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "21:00") && (c.Day == "Saturday") && c.Teacher.Id == CurrentTeacher.Id);
                var saturdayClients2100Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "21:00") && (c.Lesson.Day == "Saturday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (saturday2100Data.FirstOrDefault() != null && saturdayClients2100Data.FirstOrDefault() != null)
                {
                    saturday2100.ItemsSource = saturday2100Data.ToList();
                    saturdayClients2100.ItemsSource = saturdayClients2100Data.ToList();
                }

                //суббота 21:30
                var saturday2130Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "21:30") && (c.Day == "Saturday") && c.Teacher.Id == CurrentTeacher.Id);
                var saturdayClients2130Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "21:30") && (c.Lesson.Day == "Saturday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (saturday2130Data.FirstOrDefault() != null && saturdayClients2130Data.FirstOrDefault() != null)
                {
                    saturday2130.ItemsSource = saturday2130Data.ToList();
                    saturdayClients2130.ItemsSource = saturdayClients2130Data.ToList();
                }

                //воскресенье 9:00
                var sunday900Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:00") && (c.Day == "Sunday") && c.Teacher.Id == CurrentTeacher.Id);
                var sundayClients900Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:00") && (c.Lesson.Day == "Sunday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (sunday900Data.FirstOrDefault() != null && sundayClients900Data.FirstOrDefault() != null)
                {
                    sunday900.ItemsSource = sunday900Data.ToList();
                    sundayClients900.ItemsSource = sundayClients900Data.ToList();
                }

                //воскресенье 9:30
                var sunday930Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:30") && (c.Day == "Sunday") && c.Teacher.Id == CurrentTeacher.Id);
                var sundayClients930Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:30") && (c.Lesson.Day == "Sunday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (sunday930Data.FirstOrDefault() != null && sundayClients930Data.FirstOrDefault() != null)
                {
                    sunday930.ItemsSource = sunday930Data.ToList();
                    sundayClients930.ItemsSource = sundayClients930Data.ToList();
                }

                //воскресенье 10:00
                var sunday1000Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:00") && (c.Day == "Sunday") && c.Teacher.Id == CurrentTeacher.Id);
                var sundayClients1000Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:00") && (c.Lesson.Day == "Sunday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (sunday1000Data.FirstOrDefault() != null && sundayClients1000Data.FirstOrDefault() != null)
                {
                    sunday1000.ItemsSource = sunday1000Data.ToList();
                    sundayClients1000.ItemsSource = sundayClients1000Data.ToList();
                }

                //воскресенье 10:30
                var sunday1030Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:30") && (c.Day == "Sunday") && c.Teacher.Id == CurrentTeacher.Id);
                var sundayClients1030Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:30") && (c.Lesson.Day == "Sunday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (sunday1030Data.FirstOrDefault() != null && sundayClients1030Data.FirstOrDefault() != null)
                {
                    sunday1030.ItemsSource = sunday1030Data.ToList();
                    sundayClients1030.ItemsSource = sundayClients1030Data.ToList();
                }

                //воскресенье 11:00
                var sunday1100Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:00") && (c.Day == "Sunday") && c.Teacher.Id == CurrentTeacher.Id);
                var sundayClients1100Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:00") && (c.Lesson.Day == "Sunday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (sunday1100Data.FirstOrDefault() != null && sundayClients1100Data.FirstOrDefault() != null)
                {
                    sunday1100.ItemsSource = sunday1100Data.ToList();
                    sundayClients1100.ItemsSource = sundayClients1100Data.ToList();
                }

                //воскресенье 11:30
                var sunday1130Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:30") && (c.Day == "Sunday") && c.Teacher.Id == CurrentTeacher.Id);
                var sundayClients1130Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:30") && (c.Lesson.Day == "Sunday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (sunday1130Data.FirstOrDefault() != null && sundayClients1130Data.FirstOrDefault() != null)
                {
                    sunday1130.ItemsSource = sunday1130Data.ToList();
                    sundayClients1130.ItemsSource = sundayClients1130Data.ToList();
                }

                //воскресенье 12:00
                var sunday1200Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:00") && (c.Day == "Sunday") && c.Teacher.Id == CurrentTeacher.Id);
                var sundayClients1200Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:00") && (c.Lesson.Day == "Sunday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (sunday1200Data.FirstOrDefault() != null && sundayClients1200Data.FirstOrDefault() != null)
                {
                    sunday1200.ItemsSource = sunday1200Data.ToList();
                    sundayClients1200.ItemsSource = sundayClients1200Data.ToList();
                }

                //воскресенье 12:30
                var sunday1230Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:30") && (c.Day == "Sunday") && c.Teacher.Id == CurrentTeacher.Id);
                var sundayClients1230Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:30") && (c.Lesson.Day == "Sunday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (sunday1230Data.FirstOrDefault() != null && sundayClients1230Data.FirstOrDefault() != null)
                {
                    sunday1230.ItemsSource = sunday1230Data.ToList();
                    sundayClients1230.ItemsSource = sundayClients1230Data.ToList();
                }

                //воскресенье 13:00
                var sunday1300Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:00") && (c.Day == "Sunday") && c.Teacher.Id == CurrentTeacher.Id);
                var sundayClients1300Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:00") && (c.Lesson.Day == "Sunday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (sunday1300Data.FirstOrDefault() != null && sundayClients1300Data.FirstOrDefault() != null)
                {
                    sunday1300.ItemsSource = sunday1300Data.ToList();
                    sundayClients1300.ItemsSource = sundayClients1300Data.ToList();
                }

                //воскресенье 13:30
                var sunday1330Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:30") && (c.Day == "Sunday") && c.Teacher.Id == CurrentTeacher.Id);
                var sundayClients1330Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:30") && (c.Lesson.Day == "Sunday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (sunday1330Data.FirstOrDefault() != null && sundayClients1330Data.FirstOrDefault() != null)
                {
                    sunday1330.ItemsSource = sunday1330Data.ToList();
                    sundayClients1330.ItemsSource = sundayClients1330Data.ToList();
                }

                //воскресенье 14:00
                var sunday1400Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:00") && (c.Day == "Sunday") && c.Teacher.Id == CurrentTeacher.Id);
                var sundayClients1400Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:00") && (c.Lesson.Day == "Sunday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (sunday1400Data.FirstOrDefault() != null && sundayClients1400Data.FirstOrDefault() != null)
                {
                    sunday1400.ItemsSource = sunday1400Data.ToList();
                    sundayClients1400.ItemsSource = sundayClients1400Data.ToList();
                }

                //воскресенье 14:30
                var sunday1430Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:30") && (c.Day == "Sunday") && c.Teacher.Id == CurrentTeacher.Id);
                var sundayClients1430Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:30") && (c.Lesson.Day == "Sunday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (sunday1430Data.FirstOrDefault() != null && sundayClients1430Data.FirstOrDefault() != null)
                {
                    sunday1430.ItemsSource = sunday1430Data.ToList();
                    sundayClients1430.ItemsSource = sundayClients1430Data.ToList();
                }

                //воскресенье 15:00
                var sunday1500Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:00") && (c.Day == "Sunday") && c.Teacher.Id == CurrentTeacher.Id);
                var sundayClients1500Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:00") && (c.Lesson.Day == "Sunday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (sunday1500Data.FirstOrDefault() != null && sundayClients1500Data.FirstOrDefault() != null)
                {
                    sunday1500.ItemsSource = sunday1500Data.ToList();
                    sundayClients1500.ItemsSource = sundayClients1500Data.ToList();
                }

                //воскресенье 15:30
                var sunday1530Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:30") && (c.Day == "Sunday") && c.Teacher.Id == CurrentTeacher.Id);
                var sundayClients1530Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:30") && (c.Lesson.Day == "Sunday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (sunday1530Data.FirstOrDefault() != null && sundayClients1530Data.FirstOrDefault() != null)
                {
                    sunday1530.ItemsSource = sunday1530Data.ToList();
                    sundayClients1530.ItemsSource = sundayClients1530Data.ToList();
                }

                //воскресенье 16:00
                var sunday1600Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:00") && (c.Day == "Sunday") && c.Teacher.Id == CurrentTeacher.Id);
                var sundayClients1600Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:00") && (c.Lesson.Day == "Sunday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (sunday1600Data.FirstOrDefault() != null && sundayClients1600Data.FirstOrDefault() != null)
                {
                    sunday1600.ItemsSource = sunday1600Data.ToList();
                    sundayClients1600.ItemsSource = sundayClients1600Data.ToList();
                }

                //воскресенье 16:30
                var sunday1630Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:30") && (c.Day == "Sunday") && c.Teacher.Id == CurrentTeacher.Id);
                var sundayClients1630Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:30") && (c.Lesson.Day == "Sunday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (sunday1630Data.FirstOrDefault() != null && sundayClients1630Data.FirstOrDefault() != null)
                {
                    sunday1630.ItemsSource = sunday1630Data.ToList();
                    sundayClients1630.ItemsSource = sundayClients1630Data.ToList();
                }

                //воскресенье 17:00
                var sunday1700Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:00") && (c.Day == "Sunday") && c.Teacher.Id == CurrentTeacher.Id);
                var sundayClients1700Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:00") && (c.Lesson.Day == "Sunday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (sunday1700Data.FirstOrDefault() != null && sundayClients1700Data.FirstOrDefault() != null)
                {
                    sunday1700.ItemsSource = sunday1700Data.ToList();
                    sundayClients1700.ItemsSource = sundayClients1700Data.ToList();
                }

                //воскресенье 17:30
                var sunday1730Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:30") && (c.Day == "Sunday") && c.Teacher.Id == CurrentTeacher.Id);
                var sundayClients1730Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:30") && (c.Lesson.Day == "Sunday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (sunday1730Data.FirstOrDefault() != null && sundayClients1730Data.FirstOrDefault() != null)
                {
                    sunday1730.ItemsSource = sunday1730Data.ToList();
                    sundayClients1730.ItemsSource = sundayClients1730Data.ToList();
                }

                //воскресенье 18:00
                var sunday1800Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:00") && (c.Day == "Sunday") && c.Teacher.Id == CurrentTeacher.Id);
                var sundayClients1800Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:00") && (c.Lesson.Day == "Sunday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (sunday1800Data.FirstOrDefault() != null && sundayClients1800Data.FirstOrDefault() != null)
                {
                    sunday1800.ItemsSource = sunday1800Data.ToList();
                    sundayClients1800.ItemsSource = sundayClients1800Data.ToList();
                }

                //воскресенье 18:30
                var sunday1830Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:30") && (c.Day == "Sunday") && c.Teacher.Id == CurrentTeacher.Id);
                var sundayClients1830Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:30") && (c.Lesson.Day == "Sunday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (sunday1830Data.FirstOrDefault() != null && sundayClients1830Data.FirstOrDefault() != null)
                {
                    sunday1830.ItemsSource = sunday1830Data.ToList();
                    sundayClients1830.ItemsSource = sundayClients1830Data.ToList();
                }

                //воскресенье 19:00
                var sunday1900Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:00") && (c.Day == "Sunday") && c.Teacher.Id == CurrentTeacher.Id);
                var sundayClients1900Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:00") && (c.Lesson.Day == "Sunday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (sunday1900Data.FirstOrDefault() != null && sundayClients1900Data.FirstOrDefault() != null)
                {
                    sunday1900.ItemsSource = sunday1900Data.ToList();
                    sundayClients1900.ItemsSource = sundayClients1900Data.ToList();
                }

                //воскресенье 19:30
                var sunday1930Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:30") && (c.Day == "Sunday") && c.Teacher.Id == CurrentTeacher.Id);
                var sundayClients1930Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:30") && (c.Lesson.Day == "Sunday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (sunday1930Data.FirstOrDefault() != null && sundayClients1930Data.FirstOrDefault() != null)
                {
                    sunday1930.ItemsSource = sunday1930Data.ToList();
                    sundayClients1930.ItemsSource = sundayClients1930Data.ToList();
                }

                //воскресенье 20:00
                var sunday2000Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "20:00") && (c.Day == "Sunday") && c.Teacher.Id == CurrentTeacher.Id);
                var sundayClients2000Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "20:00") && (c.Lesson.Day == "Sunday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (sunday2000Data.FirstOrDefault() != null && sundayClients2000Data.FirstOrDefault() != null)
                {
                    sunday2000.ItemsSource = sunday2000Data.ToList();
                    sundayClients2000.ItemsSource = sundayClients2000Data.ToList();
                }

                //воскресенье 20:30
                var sunday2030Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "20:30") && (c.Day == "Sunday") && c.Teacher.Id == CurrentTeacher.Id);
                var sundayClients2030Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "20:30") && (c.Lesson.Day == "Sunday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (sunday2030Data.FirstOrDefault() != null && sundayClients2030Data.FirstOrDefault() != null)
                {
                    sunday2030.ItemsSource = sunday2030Data.ToList();
                    sundayClients2030.ItemsSource = sundayClients2030Data.ToList();
                }

                //воскресенье 21:00
                var sunday2100Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "21:00") && (c.Day == "Sunday") && c.Teacher.Id == CurrentTeacher.Id);
                var sundayClients2100Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "21:00") && (c.Lesson.Day == "Sunday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (sunday2100Data.FirstOrDefault() != null && sundayClients2100Data.FirstOrDefault() != null)
                {
                    sunday2100.ItemsSource = sunday2100Data.ToList();
                    sundayClients2100.ItemsSource = sundayClients2100Data.ToList();
                }

                //воскресенье 21:30
                var sunday2130Data = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "21:30") && (c.Day == "Sunday") && c.Teacher.Id == CurrentTeacher.Id);
                var sundayClients2130Data = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "21:30") && (c.Lesson.Day == "Sunday") && c.Lesson.Teacher.Id == CurrentTeacher.Id);
                if (sunday2130Data.FirstOrDefault() != null && sundayClients2130Data.FirstOrDefault() != null)
                {
                    sunday2130.ItemsSource = sunday2130Data.ToList();
                    sundayClients2130.ItemsSource = sundayClients2130Data.ToList();
                }
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
            if (nameDate == "Monday")
            {
                Properties.Settings.Default.dayStart = "Monday";

            }
            else if (nameDate == "Tuesday")
            {
                Properties.Settings.Default.dayStart = "Tuesday";
            }
            else if (nameDate == "Wednesday")
            {
                Properties.Settings.Default.dayStart = "Wednesday";
            }
            else if (nameDate == "Thursday")
            {
                Properties.Settings.Default.dayStart = "Thursday";
            }
            else if (nameDate == "Friday")
            {
                Properties.Settings.Default.dayStart = "Friday";
            }
            else if (nameDate == "Saturday")
            {
                Properties.Settings.Default.dayStart = "Saturday";
            }
            else if (nameDate == "Sunday")
            {
                Properties.Settings.Default.dayStart = "Sunday";
            }

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

            Properties.Settings.Default.timeStart = timeMsg.TextBoxText;
            Properties.Settings.Default.dateStart = scheduleCalendar.SelectedDate.Value.ToShortDateString();



            if (resultTime == MessageBoxResult.OK)
            {
                if (timeMsg.TextBoxText == "9:00" || timeMsg.TextBoxText == "10:00" || timeMsg.TextBoxText == "11:00" || timeMsg.TextBoxText == "12:00" || timeMsg.TextBoxText == "13:00" || timeMsg.TextBoxText == "14:00" || timeMsg.TextBoxText == "15:00" || timeMsg.TextBoxText == "16:00" || timeMsg.TextBoxText == "17:00" || timeMsg.TextBoxText == "18:00" || timeMsg.TextBoxText == "19:00" || timeMsg.TextBoxText == "20:00" || timeMsg.TextBoxText == "21:00" || timeMsg.TextBoxText == "9:30" || timeMsg.TextBoxText == "10:30" || timeMsg.TextBoxText == "11:30" || timeMsg.TextBoxText == "12:30" || timeMsg.TextBoxText == "13:30" || timeMsg.TextBoxText == "14:30" || timeMsg.TextBoxText == "15:30" || timeMsg.TextBoxText == "16:30" || timeMsg.TextBoxText == "17:30" || timeMsg.TextBoxText == "18:30" || timeMsg.TextBoxText == "19:30" || timeMsg.TextBoxText == "20:30" || timeMsg.TextBoxText == "21:30")
                {
                    if (teacherComboBox.SelectedItem != null)
                    {
                        if (AppData.Context.Lesson.Where(c => c.Date == scheduleCalendar.SelectedDate && c.Time == timeMsg.TextBoxText && c.Teacher.Id == CurrentTeacher.Id).FirstOrDefault() == null)
                        {
                            NavigationService.Navigate(new editSchedulePage(null));
                        }
                        else
                        {
                            if (MessageBox.Show("В данное время уже сушествет занятие,\nхотите его редактировать?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                            {
                                Lesson CurrentLesson = AppData.Context.Lesson.Where(c => c.Date == scheduleCalendar.SelectedDate && c.Time == timeMsg.TextBoxText && c.Teacher.Id == CurrentTeacher.Id).FirstOrDefault();
                                if (CurrentLesson != null)
                                {
                                    NavigationService.Navigate(new editSchedulePage(CurrentLesson));
                                }
                            }
                        }
                    } else
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

        private void teacherComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CurrentTeacher = teacherComboBox.SelectedItem as Teacher;
            Page_Loaded(null, null);
        }
    }
}
