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

namespace ClassSchedule.Pages
{
    /// <summary>
    /// Логика взаимодействия для schedulePage.xaml
    /// </summary>
    public partial class schedulePage : Page
    {
        public schedulePage()
        {
            InitializeComponent();
        }

        private void scheduleCalendar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
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

        private void scheduleCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime startDate = default(DateTime);
            DateTime endDate = default(DateTime);
            DateTime selectedDate = scheduleCalendar.SelectedDate.Value;
            string nameDate = selectedDate.DayOfWeek.ToString();
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
            } else if (nameDate == "Thursday")
            {
                startDate = selectedDate.AddDays(-3);
                endDate = selectedDate.AddDays(3);
            } else if (nameDate == "Friday")
            {
                startDate = selectedDate.AddDays(-4);
                endDate = selectedDate.AddDays(2);
            } else if (nameDate == "Saturday")
            {
                startDate = selectedDate.AddDays(-5);
                endDate = selectedDate.AddDays(1);
            } else if (nameDate == "Sunday")
            {
                startDate = selectedDate.AddDays(-6);
                endDate = selectedDate;
            }
            mondayNineDataGrid.ItemsSource = AppData.Context.Lesson.Where(c => c.Date > startDate && c.Date < endDate);
            mondayTenDataGrid.ItemsSource = AppData.Context.Lesson.Where()
        }
    }


}
