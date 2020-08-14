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
        public schedulePage()
        {
            InitializeComponent();
            
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
            mondayNineDataGrid.ItemsSource = null;
            mondayNineClientsDataGrid.ItemsSource = null;
            mondayTenDataGrid.ItemsSource = null;
            mondayTenClientsDataGrid.ItemsSource = null;
            mondayElevenDataGrid.ItemsSource = null;
            mondayElevenClientsDataGrid.ItemsSource = null;
            mondayTwelveDataGrid.ItemsSource = null;
            mondayTwelveClientsDataGrid.ItemsSource = null;
            mondayThirteenDataGrid.ItemsSource = null;
            mondayThirteenClientsDataGrid.ItemsSource = null;
            mondayFourteenDataGrid.ItemsSource = null;
            mondayFourteenClientsDataGrid.ItemsSource = null;
            mondayFifteenDataGrid.ItemsSource = null;
            mondayFifteenClientsDataGrid.ItemsSource = null;
            mondaySixteenDataGrid.ItemsSource = null;
            mondaySixteenClientsDataGrid.ItemsSource = null;
            mondaySeventeenDataGrid.ItemsSource = null;
            mondaySeventeenClientsDataGrid.ItemsSource = null;
            mondayEighteenDataGrid.ItemsSource = null;
            mondayEighteenClientsDataGrid.ItemsSource = null;
            mondayNineteenDataGrid.ItemsSource = null;
            mondayNineteenClientsDataGrid.ItemsSource = null;
            mondayNineteenHalfDataGrid.ItemsSource = null;
            mondayNineteenHalfClientsDataGrid.ItemsSource = null;
            tuesdayNineDataGrid.ItemsSource = null;
            tuesdayNineClientsDataGrid.ItemsSource = null;
            tuesdayTenDataGrid.ItemsSource = null;
            tuesdayTenClientsDataGrid.ItemsSource = null;
            tuesdayElevenDataGrid.ItemsSource = null;
            tuesdayElevenClientsDataGrid.ItemsSource = null;
            tuesdayTwelveDataGrid.ItemsSource = null;
            tuesdayTwelveClientsDataGrid.ItemsSource = null;
            tuesdayThirteenDataGrid.ItemsSource = null;
            tuesdayThirteenClientsDataGrid.ItemsSource = null;
            tuesdayFourteenDataGrid.ItemsSource = null;
            tuesdayFourteenClientsDataGrid.ItemsSource = null;
            tuesdayFifteenDataGrid.ItemsSource = null;
            tuesdayFifteenClientsDataGrid.ItemsSource = null;
            tuesdaySixteenDataGrid.ItemsSource = null;
            tuesdaySixteenClientsDataGrid.ItemsSource = null;
            tuesdaySeventeenDataGrid.ItemsSource = null;
            tuesdaySeventeenClientsDataGrid.ItemsSource = null;
            tuesdayEighteenDataGrid.ItemsSource = null;
            tuesdayEighteenClientsDataGrid.ItemsSource = null;
            tuesdayNineteenDataGrid.ItemsSource = null;
            tuesdayNineteenClientsDataGrid.ItemsSource = null;
            tuesdayNineteenHalfDataGrid.ItemsSource = null;
            tuesdayNineteenHalfClientsDataGrid.ItemsSource = null;
            wednesdayNineDataGrid.ItemsSource = null;
            wednesdayNineClientsDataGrid.ItemsSource = null;
            wednesdayTenDataGrid.ItemsSource = null;
            wednesdayTenClientsDataGrid.ItemsSource = null;
            wednesdayElevenDataGrid.ItemsSource = null;
            wednesdayElevenClientsDataGrid.ItemsSource = null;
            wednesdayTwelveDataGrid.ItemsSource = null;
            wednesdayTwelveClientsDataGrid.ItemsSource = null;
            wednesdayThirteenDataGrid.ItemsSource = null;
            wednesdayThirteenClientsDataGrid.ItemsSource = null;
            wednesdayFourteenDataGrid.ItemsSource = null;
            wednesdayFourteenClientsDataGrid.ItemsSource = null;
            wednesdayFifteenDataGrid.ItemsSource = null;
            wednesdayFifteenClientsDataGrid.ItemsSource = null;
            wednesdaySixteenDataGrid.ItemsSource = null;
            wednesdaySixteenClientsDataGrid.ItemsSource = null;
            wednesdaySeventeenDataGrid.ItemsSource = null;
            wednesdaySeventeenClientsDataGrid.ItemsSource = null;
            wednesdayEighteenDataGrid.ItemsSource = null;
            wednesdayEighteenClientsDataGrid.ItemsSource = null;
            wednesdayNineteenDataGrid.ItemsSource = null;
            wednesdayNineteenClientsDataGrid.ItemsSource = null;
            wednesdayNineteenHalfDataGrid.ItemsSource = null;
            wednesdayNineteenHalfClientsDataGrid.ItemsSource = null;
            thursdayNineDataGrid.ItemsSource = null;
            thursdayNineClientsDataGrid.ItemsSource = null;
            thursdayTenDataGrid.ItemsSource = null;
            thursdayTenClientsDataGrid.ItemsSource = null;
            thursdayElevenDataGrid.ItemsSource = null;
            thursdayElevenClientsDataGrid.ItemsSource = null;
            thursdayTwelveDataGrid.ItemsSource = null;
            thursdayTwelveClientsDataGrid.ItemsSource = null;
            thursdayThirteenDataGrid.ItemsSource = null;
            thursdayThirteenClientsDataGrid.ItemsSource = null;
            thursdayFourteenDataGrid.ItemsSource = null;
            thursdayFourteenClientsDataGrid.ItemsSource = null;
            thursdayFifteenDataGrid.ItemsSource = null;
            thursdayFifteenClientsDataGrid.ItemsSource = null;
            thursdaySixteenDataGrid.ItemsSource = null;
            thursdaySixteenClientsDataGrid.ItemsSource = null;
            thursdaySeventeenDataGrid.ItemsSource = null;
            thursdaySeventeenClientsDataGrid.ItemsSource = null;
            thursdayEighteenDataGrid.ItemsSource = null;
            thursdayEighteenClientsDataGrid.ItemsSource = null;
            thursdayNineteenDataGrid.ItemsSource = null;
            thursdayNineteenClientsDataGrid.ItemsSource = null;
            thursdayNineteenHalfDataGrid.ItemsSource = null;
            thursdayNineteenHalfClientsDataGrid.ItemsSource = null;
            fridayNineDataGrid.ItemsSource = null;
            fridayNineClientsDataGrid.ItemsSource = null;
            fridayTenDataGrid.ItemsSource = null;
            fridayTenClientsDataGrid.ItemsSource = null;
            fridayElevenDataGrid.ItemsSource = null;
            fridayElevenClientsDataGrid.ItemsSource = null;
            fridayTwelveDataGrid.ItemsSource = null;
            fridayTwelveClientsDataGrid.ItemsSource = null;
            fridayThirteenDataGrid.ItemsSource = null;
            fridayThirteenClientsDataGrid.ItemsSource = null;
            fridayFourteenDataGrid.ItemsSource = null;
            fridayFourteenClientsDataGrid.ItemsSource = null;
            fridayFifteenDataGrid.ItemsSource = null;
            fridayFifteenClientsDataGrid.ItemsSource = null;
            fridaySixteenDataGrid.ItemsSource = null;
            fridaySixteenClientsDataGrid.ItemsSource = null;
            fridaySeventeenDataGrid.ItemsSource = null;
            fridaySeventeenClientsDataGrid.ItemsSource = null;
            fridayEighteenDataGrid.ItemsSource = null;
            fridayEighteenClientsDataGrid.ItemsSource = null;
            fridayNineteenDataGrid.ItemsSource = null;
            fridayNineteenClientsDataGrid.ItemsSource = null;
            fridayNineteenHalfDataGrid.ItemsSource = null;
            fridayNineteenHalfClientsDataGrid.ItemsSource = null;
            saturdayNineDataGrid.ItemsSource = null;
            saturdayNineClientsDataGrid.ItemsSource = null;
            saturdayTenDataGrid.ItemsSource = null;
            saturdayTenClientsDataGrid.ItemsSource = null;
            saturdayElevenDataGrid.ItemsSource = null;
            saturdayElevenClientsDataGrid.ItemsSource = null;
            saturdayTwelveDataGrid.ItemsSource = null;
            saturdayTwelveClientsDataGrid.ItemsSource = null;
            saturdayThirteenDataGrid.ItemsSource = null;
            saturdayThirteenClientsDataGrid.ItemsSource = null;
            saturdayFourteenDataGrid.ItemsSource = null;
            saturdayFourteenClientsDataGrid.ItemsSource = null;
            saturdayFifteenDataGrid.ItemsSource = null;
            saturdayFifteenClientsDataGrid.ItemsSource = null;
            saturdaySixteenDataGrid.ItemsSource = null;
            saturdaySixteenClientsDataGrid.ItemsSource = null;
            saturdaySeventeenDataGrid.ItemsSource = null;
            saturdaySeventeenClientsDataGrid.ItemsSource = null;
            saturdayEighteenDataGrid.ItemsSource = null;
            saturdayEighteenClientsDataGrid.ItemsSource = null;
            saturdayNineteenDataGrid.ItemsSource = null;
            saturdayNineteenClientsDataGrid.ItemsSource = null;
            saturdayNineteenHalfDataGrid.ItemsSource = null;
            saturdayNineteenHalfClientsDataGrid.ItemsSource = null;
            sundayNineDataGrid.ItemsSource = null;
            sundayNineClientsDataGrid.ItemsSource = null;
            sundayTenDataGrid.ItemsSource = null;
            sundayTenClientsDataGrid.ItemsSource = null;
            sundayElevenDataGrid.ItemsSource = null;
            sundayElevenClientsDataGrid.ItemsSource = null;
            sundayTwelveDataGrid.ItemsSource = null;
            sundayTwelveClientsDataGrid.ItemsSource = null;
            sundayThirteenDataGrid.ItemsSource = null;
            sundayThirteenClientsDataGrid.ItemsSource = null;
            sundayFourteenDataGrid.ItemsSource = null;
            sundayFourteenClientsDataGrid.ItemsSource = null;
            sundayFifteenDataGrid.ItemsSource = null;
            sundayFifteenClientsDataGrid.ItemsSource = null;
            sundaySixteenDataGrid.ItemsSource = null;
            sundaySixteenClientsDataGrid.ItemsSource = null;
            sundaySeventeenDataGrid.ItemsSource = null;
            sundaySeventeenClientsDataGrid.ItemsSource = null;
            sundayEighteenDataGrid.ItemsSource = null;
            sundayEighteenClientsDataGrid.ItemsSource = null;
            sundayNineteenDataGrid.ItemsSource = null;
            sundayNineteenClientsDataGrid.ItemsSource = null;
            sundayNineteenHalfDataGrid.ItemsSource = null;
            sundayNineteenHalfClientsDataGrid.ItemsSource = null;

            DateTime startDate = default(DateTime);
            DateTime endDate = default(DateTime);
            DateTime selectedDate = scheduleCalendar.SelectedDate.Value;
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
            var mondayNine = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:00") && c.Day == "Monday");
            var mondayNineClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:00") && c.Lesson.Day == "Monday");
            if (mondayNine.FirstOrDefault() != null && mondayNineClients.FirstOrDefault() != null)
            {
                mondayNineDataGrid.ItemsSource = mondayNine.ToList();
                mondayNineClientsDataGrid.ItemsSource = mondayNineClients.ToList();
            }
            //понедельник 10:00
            var mondayTen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:00") && c.Day == "Monday");
            var mondayTenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:00") && c.Lesson.Day == "Monday");
            if (mondayTen.FirstOrDefault() != null && mondayTenClients.FirstOrDefault() != null)
            {
                mondayTenDataGrid.ItemsSource = mondayTen.ToList();
                mondayTenClientsDataGrid.ItemsSource = mondayTenClients.ToList();
            }
            //понедельник 11:00
            var mondayEleven = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:00") && c.Day == "Monday");
            var mondayElevenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:00") && c.Lesson.Day == "Monday");
            if (mondayEleven.FirstOrDefault() != null && mondayElevenClients.FirstOrDefault() != null)
            {
                mondayElevenDataGrid.ItemsSource = mondayEleven.ToList();
                mondayElevenClientsDataGrid.ItemsSource = mondayElevenClients.ToList();
            }
            //понедельник 12:00
            var mondayTwelve = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:00") && c.Day == "Monday");
            var mondayTwelveClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:00") && c.Lesson.Day == "Monday");
            if (mondayTwelve.FirstOrDefault() != null && mondayTwelveClients.FirstOrDefault() != null)
            {
                mondayTwelveDataGrid.ItemsSource = mondayTwelve.ToList();
                mondayTwelveClientsDataGrid.ItemsSource = mondayTwelveClients.ToList();
            }
            //понедельник 13:00
            var mondayThirteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:00") && c.Day == "Monday");
            var mondayThirteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:00") && c.Lesson.Day == "Monday");
            if (mondayThirteen.FirstOrDefault() != null && mondayThirteenClients.FirstOrDefault() != null)
            {
                mondayThirteenDataGrid.ItemsSource = mondayThirteen.ToList();
                mondayThirteenClientsDataGrid.ItemsSource = mondayThirteenClients.ToList();
            }
            //понедельник 14:00
            var mondayFourteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:00") && c.Day == "Monday");
            var mondayFourteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:00") && c.Lesson.Day == "Monday");
            if (mondayFourteen.FirstOrDefault() != null && mondayFourteenClients.FirstOrDefault() != null)
            {
                mondayFourteenDataGrid.ItemsSource = mondayFourteen.ToList();
                mondayFourteenClientsDataGrid.ItemsSource = mondayFourteenClients.ToList();
            }
            //понедельник 15:00
            var mondayFifteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:00") && c.Day == "Monday");
            var mondayFifteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:00") && c.Lesson.Day == "Monday");
            if (mondayFifteen.FirstOrDefault() != null && mondayFifteenClients.FirstOrDefault() != null)
            {
                mondayFifteenDataGrid.ItemsSource = mondayFifteen.ToList();
                mondayFifteenClientsDataGrid.ItemsSource = mondayFifteenClients.ToList();
            }
            //понедельник 16:00
            var mondaySixteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:00") && c.Day == "Monday");
            var mondaySixteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:00") && c.Lesson.Day == "Monday");
            if (mondaySixteen.FirstOrDefault() != null && mondaySixteenClients.FirstOrDefault() != null)
            {
                mondaySixteenDataGrid.ItemsSource = mondaySixteen.ToList();
                mondaySixteenClientsDataGrid.ItemsSource = mondaySixteenClients.ToList();
            }
            //понедельник 17:00
            var mondaySeventeen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:00") && c.Day == "Monday");
            var mondaySeventeenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:00") && c.Lesson.Day == "Monday");
            if (mondaySeventeen.FirstOrDefault() != null && mondaySeventeenClients.FirstOrDefault() != null)
            {
                mondaySeventeenDataGrid.ItemsSource = mondaySeventeen.ToList();
                mondaySeventeenClientsDataGrid.ItemsSource = mondaySeventeenClients.ToList();
            }
            //понедельник 18:00
            var mondayEighteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:00") && c.Day == "Monday");
            var mondayEighteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:00") && c.Lesson.Day == "Monday");
            if (mondayEighteen.FirstOrDefault() != null && mondayEighteenClients.FirstOrDefault() != null)
            {
                mondayEighteenDataGrid.ItemsSource = mondayEighteen.ToList();
                mondayEighteenClientsDataGrid.ItemsSource = mondayEighteenClients.ToList();
            }
            //понедельник 19:00
            var mondayNineteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:00") && c.Day == "Monday");
            var mondayNineteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:00") && c.Lesson.Day == "Monday");
            if (mondayNineteen.FirstOrDefault() != null && mondayNineteenClients.FirstOrDefault() != null)
            {
                mondayNineteenDataGrid.ItemsSource = mondayNineteen.ToList();
                mondayNineteenClientsDataGrid.ItemsSource = mondayNineteenClients.ToList();
            }
            //понедельник 19:30
            var mondayNineteenHalf = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:30") && c.Day == "Monday");
            var mondayNineteenHalfClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:30") && c.Lesson.Day == "Monday");
            if (mondayNineteenHalf.FirstOrDefault() != null && mondayNineteenHalfClients.FirstOrDefault() != null)
            {
                mondayNineteenHalfDataGrid.ItemsSource = mondayNineteenHalf.ToList();
                mondayNineteenHalfClientsDataGrid.ItemsSource = mondayNineteenHalfClients.ToList();
            }
            //вторник 9:00
            var tuesdayNine = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:00") && c.Day == "Tuesday");
            var tuesdayNineClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:00") && c.Lesson.Day == "Tuesday");
            if (tuesdayNine.FirstOrDefault() != null && tuesdayNineClients.FirstOrDefault() != null)
            {
                tuesdayNineDataGrid.ItemsSource = tuesdayNine.ToList();
                tuesdayNineClientsDataGrid.ItemsSource = tuesdayNineClients.ToList();
            }
            //вторник 10:00
            var tuesdayTen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:00") && c.Day == "Tuesday");
            var tuesdayTenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:00") && c.Lesson.Day == "Tuesday");
            if (tuesdayTen.FirstOrDefault() != null && tuesdayTenClients.FirstOrDefault() != null)
            {
                tuesdayTenDataGrid.ItemsSource = tuesdayTen.ToList();
                tuesdayTenClientsDataGrid.ItemsSource = tuesdayTenClients.ToList();
            }
            //вторник 11:00
            var tuesdayEleven = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:00") && c.Day == "Tuesday");
            var tuesdayElevenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:00") && c.Lesson.Day == "Tuesday");
            if (tuesdayEleven.FirstOrDefault() != null && tuesdayElevenClients.FirstOrDefault() != null)
            {
                tuesdayElevenDataGrid.ItemsSource = tuesdayEleven.ToList();
                tuesdayElevenClientsDataGrid.ItemsSource = tuesdayElevenClients.ToList();
            }
            //вторник 12:00
            var tuesdayTwelve = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:00") && c.Day == "Tuesday");
            var tuesdayTwelveClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:00") && c.Lesson.Day == "Tuesday");
            if (tuesdayTwelve.FirstOrDefault() != null && tuesdayTwelveClients.FirstOrDefault() != null)
            {
                tuesdayTwelveDataGrid.ItemsSource = tuesdayTwelve.ToList();
                tuesdayTwelveClientsDataGrid.ItemsSource = tuesdayTwelveClients.ToList();
            }
            //вторник 13:00
            var tuesdayThirteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:00") && c.Day == "Tuesday");
            var tuesdayThirteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:00") && c.Lesson.Day == "Tuesday");
            if (tuesdayThirteen.FirstOrDefault() != null && tuesdayThirteenClients.FirstOrDefault() != null)
            {
                tuesdayThirteenDataGrid.ItemsSource = tuesdayThirteen.ToList();
                tuesdayThirteenClientsDataGrid.ItemsSource = tuesdayThirteenClients.ToList();
            }
            //вторник 14:00
            var tuesdayFourteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:00") && c.Day == "Tuesday");
            var tuesdayFourteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:00") && c.Lesson.Day == "Tuesday");
            if (tuesdayFourteen.FirstOrDefault() != null && tuesdayFourteenClients.FirstOrDefault() != null)
            {
                tuesdayFourteenDataGrid.ItemsSource = tuesdayFourteen.ToList();
                tuesdayFourteenClientsDataGrid.ItemsSource = tuesdayFourteenClients.ToList();
            }
            //вторник 15:00
            var tuesdayFifteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:00") && c.Day == "Tuesday");
            var tuesdayFifteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:00") && c.Lesson.Day == "Tuesday");
            if (tuesdayFifteen.FirstOrDefault() != null && tuesdayFifteenClients.FirstOrDefault() != null)
            {
                tuesdayFifteenDataGrid.ItemsSource = tuesdayFifteen.ToList();
                tuesdayFifteenClientsDataGrid.ItemsSource = tuesdayFifteenClients.ToList();
            }
            //вторник 16:00
            var tuesdaySixteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:00") && c.Day == "Tuesday");
            var tuesdaySixteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:00") && c.Lesson.Day == "Tuesday");
            if (tuesdaySixteen.FirstOrDefault() != null && tuesdaySixteenClients.FirstOrDefault() != null)
            {
                tuesdaySixteenDataGrid.ItemsSource = tuesdaySixteen.ToList();
                tuesdaySixteenClientsDataGrid.ItemsSource = tuesdaySixteenClients.ToList();
            }
            //вторник 17:00
            var tuesdaySeventeen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:00") && c.Day == "Tuesday");
            var tuesdaySeventeenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:00") && c.Lesson.Day == "Tuesday");
            if (tuesdaySeventeen.FirstOrDefault() != null && tuesdaySeventeenClients.FirstOrDefault() != null)
            {
                tuesdaySeventeenDataGrid.ItemsSource = tuesdaySeventeen.ToList();
                tuesdaySeventeenClientsDataGrid.ItemsSource = tuesdaySeventeenClients.ToList();
            }
            //вторник 18:00
            var tuesdayEighteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:00") && c.Day == "Tuesday");
            var tuesdayEighteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:00") && c.Lesson.Day == "Tuesday");
            if (tuesdayEighteen.FirstOrDefault() != null && tuesdayEighteenClients.FirstOrDefault() != null)
            {
                tuesdayEighteenDataGrid.ItemsSource = tuesdayEighteen.ToList();
                tuesdayEighteenClientsDataGrid.ItemsSource = tuesdayEighteenClients.ToList();
            }
            //вторник 19:00
            var tuesdayNineteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:00") && c.Day == "Tuesday");
            var tuesdayNineteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:00") && c.Lesson.Day == "Tuesday");
            if (tuesdayNineteen.FirstOrDefault() != null && tuesdayNineteenClients.FirstOrDefault() != null)
            {
                tuesdayNineteenDataGrid.ItemsSource = tuesdayNineteen.ToList();
                tuesdayNineteenClientsDataGrid.ItemsSource = tuesdayNineteenClients.ToList();
            }
            //вторник 19:30
            var tuesdayNineteenHalf = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:30") && c.Day == "Tuesday");
            var tuesdayNineteenHalfClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:30") && c.Lesson.Day == "Tuesday");
            if (tuesdayNineteenHalf.FirstOrDefault() != null && tuesdayNineteenHalfClients.FirstOrDefault() != null)
            {
                tuesdayNineteenHalfDataGrid.ItemsSource = tuesdayNineteenHalf.ToList();
                tuesdayNineteenHalfClientsDataGrid.ItemsSource = tuesdayNineteenHalfClients.ToList();
            }
            //среда 9:00
            var wednesdayNine = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:00") && c.Day == "Wednesday");
            var wednesdayNineClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:00") && c.Lesson.Day == "Wednesday");
            if (wednesdayNine.FirstOrDefault() != null && wednesdayNineClients.FirstOrDefault() != null)
            {
                wednesdayNineDataGrid.ItemsSource = wednesdayNine.ToList();
                wednesdayNineClientsDataGrid.ItemsSource = wednesdayNineClients.ToList();
            }
            //среда 10:00
            var wednesdayTen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:00") && c.Day == "Wednesday");
            var wednesdayTenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:00") && c.Lesson.Day == "Wednesday");
            if (wednesdayTen.FirstOrDefault() != null && wednesdayTenClients.FirstOrDefault() != null)
            {
                wednesdayTenDataGrid.ItemsSource = wednesdayTen.ToList();
                wednesdayTenClientsDataGrid.ItemsSource = wednesdayTenClients.ToList();
            }
            //среда 11:00
            var wednesdayEleven = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:00") && c.Day == "Wednesday");
            var wednesdayElevenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:00") && c.Lesson.Day == "Wednesday");
            if (wednesdayEleven.FirstOrDefault() != null && wednesdayElevenClients.FirstOrDefault() != null)
            {
                wednesdayElevenDataGrid.ItemsSource = wednesdayEleven.ToList();
                wednesdayElevenClientsDataGrid.ItemsSource = wednesdayElevenClients.ToList();
            }
            //среда 12:00
            var wednesdayTwelve = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:00") && c.Day == "Wednesday");
            var wednesdayTwelveClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:00") && c.Lesson.Day == "Wednesday");
            if (wednesdayTwelve.FirstOrDefault() != null && wednesdayTwelveClients.FirstOrDefault() != null)
            {
                wednesdayTwelveDataGrid.ItemsSource = wednesdayTwelve.ToList();
                wednesdayTwelveClientsDataGrid.ItemsSource = wednesdayTwelveClients.ToList();
            }
            //среда 13:00
            var wednesdayThirteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:00") && c.Day == "Wednesday");
            var wednesdayThirteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:00") && c.Lesson.Day == "Wednesday");
            if (wednesdayThirteen.FirstOrDefault() != null && wednesdayThirteenClients.FirstOrDefault() != null)
            {
                wednesdayThirteenDataGrid.ItemsSource = wednesdayThirteen.ToList();
                wednesdayThirteenClientsDataGrid.ItemsSource = wednesdayThirteenClients.ToList();
            }
            //среда 14:00
            var wednesdayFourteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:00") && c.Day == "Wednesday");
            var wednesdayFourteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:00") && c.Lesson.Day == "Wednesday");
            if (wednesdayFourteen.FirstOrDefault() != null && wednesdayFourteenClients.FirstOrDefault() != null)
            {
                wednesdayFourteenDataGrid.ItemsSource = wednesdayFourteen.ToList();
                wednesdayFourteenClientsDataGrid.ItemsSource = wednesdayFourteenClients.ToList();
            }
            //среда 15:00
            var wednesdayFifteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:00") && c.Day == "Wednesday");
            var wednesdayFifteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:00") && c.Lesson.Day == "Wednesday");
            if (wednesdayFifteen.FirstOrDefault() != null && wednesdayFifteenClients.FirstOrDefault() != null)
            {
                wednesdayFifteenDataGrid.ItemsSource = wednesdayFifteen.ToList();
                wednesdayFifteenClientsDataGrid.ItemsSource = wednesdayFifteenClients.ToList();
            }
            //среда 16:00
            var wednesdaySixteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:00") && c.Day == "Wednesday");
            var wednesdaySixteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:00") && c.Lesson.Day == "Wednesday");
            if (wednesdaySixteen.FirstOrDefault() != null && wednesdaySixteenClients.FirstOrDefault() != null)
            {
                wednesdaySixteenDataGrid.ItemsSource = wednesdaySixteen.ToList();
                wednesdaySixteenClientsDataGrid.ItemsSource = wednesdaySixteenClients.ToList();
            }
            //среда 17:00
            var wednesdaySeventeen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:00") && c.Day == "Wednesday");
            var wednesdaySeventeenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:00") && c.Lesson.Day == "Wednesday");
            if (wednesdaySeventeen.FirstOrDefault() != null && wednesdaySeventeenClients.FirstOrDefault() != null)
            {
                wednesdaySeventeenDataGrid.ItemsSource = wednesdaySeventeen.ToList();
                wednesdaySeventeenClientsDataGrid.ItemsSource = wednesdaySeventeenClients.ToList();
            }
            //среда 18:00
            var wednesdayEighteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:00") && c.Day == "Wednesday");
            var wednesdayEighteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:00") && c.Lesson.Day == "Wednesday");
            if (wednesdayEighteen.FirstOrDefault() != null && wednesdayEighteenClients.FirstOrDefault() != null)
            {
                wednesdayEighteenDataGrid.ItemsSource = wednesdayEighteen.ToList();
                wednesdayEighteenClientsDataGrid.ItemsSource = wednesdayEighteenClients.ToList();
            }
            //среда 19:00
            var wednesdayNineteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:00") && c.Day == "Wednesday");
            var wednesdayNineteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:00") && c.Lesson.Day == "Wednesday");
            if (wednesdayNineteen.FirstOrDefault() != null && wednesdayNineteenClients.FirstOrDefault() != null)
            {
                wednesdayNineteenDataGrid.ItemsSource = wednesdayNineteen.ToList();
                wednesdayNineteenClientsDataGrid.ItemsSource = wednesdayNineteenClients.ToList();
            }
            //среда 19:30
            var wednesdayNineteenHalf = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:30") && c.Day == "Wednesday");
            var wednesdayNineteenHalfClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:30") && c.Lesson.Day == "Wednesday");
            if (wednesdayNineteenHalf.FirstOrDefault() != null && wednesdayNineteenHalfClients.FirstOrDefault() != null)
            {
                wednesdayNineteenHalfDataGrid.ItemsSource = wednesdayNineteenHalf.ToList();
                wednesdayNineteenHalfClientsDataGrid.ItemsSource = wednesdayNineteenHalfClients.ToList();
            }
            //четверг 9:00
            var thursdayNine = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:00") && c.Day == "Thursday");
            var thursdayNineClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:00") && c.Lesson.Day == "Thursday");
            if (thursdayNine.FirstOrDefault() != null && thursdayNineClients.FirstOrDefault() != null)
            {
                thursdayNineDataGrid.ItemsSource = thursdayNine.ToList();
                thursdayNineClientsDataGrid.ItemsSource = thursdayNineClients.ToList();
            }
            //четверг 10:00
            var thursdayTen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:00") && c.Day == "Thursday");
            var thursdayTenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:00") && c.Lesson.Day == "Thursday");
            if (thursdayTen.FirstOrDefault() != null && thursdayTenClients.FirstOrDefault() != null)
            {
                thursdayTenDataGrid.ItemsSource = thursdayTen.ToList();
                thursdayTenClientsDataGrid.ItemsSource = thursdayTenClients.ToList();
            }
            //четверг 11:00
            var thursdayEleven = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:00") && c.Day == "Thursday");
            var thursdayElevenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:00") && c.Lesson.Day == "Thursday");
            if (thursdayEleven.FirstOrDefault() != null && thursdayElevenClients.FirstOrDefault() != null)
            {
                thursdayElevenDataGrid.ItemsSource = thursdayEleven.ToList();
                thursdayElevenClientsDataGrid.ItemsSource = thursdayElevenClients.ToList();
            }
            //четверг 12:00
            var thursdayTwelve = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:00") && c.Day == "Thursday");
            var thursdayTwelveClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:00") && c.Lesson.Day == "Thursday");
            if (thursdayTwelve.FirstOrDefault() != null && thursdayTwelveClients.FirstOrDefault() != null)
            {
                thursdayTwelveDataGrid.ItemsSource = thursdayTwelve.ToList();
                thursdayTwelveClientsDataGrid.ItemsSource = thursdayTwelveClients.ToList();
            }
            //четверг 13:00
            var thursdayThirteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:00") && c.Day == "Thursday");
            var thursdayThirteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:00") && c.Lesson.Day == "Thursday");
            if (thursdayThirteen.FirstOrDefault() != null && thursdayThirteenClients.FirstOrDefault() != null)
            {
                thursdayThirteenDataGrid.ItemsSource = thursdayThirteen.ToList();
                thursdayThirteenClientsDataGrid.ItemsSource = thursdayThirteenClients.ToList();
            }
            //четверг 14:00
            var thursdayFourteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:00") && c.Day == "Thursday");
            var thursdayFourteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:00") && c.Lesson.Day == "Thursday");
            if (thursdayFourteen.FirstOrDefault() != null && thursdayFourteenClients.FirstOrDefault() != null)
            {
                thursdayFourteenDataGrid.ItemsSource = thursdayFourteen.ToList();
                thursdayFourteenClientsDataGrid.ItemsSource = thursdayFourteenClients.ToList();
            }
            //четверг 15:00
            var thursdayFifteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:00") && c.Day == "Thursday");
            var thursdayFifteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:00") && c.Lesson.Day == "Thursday");
            if (thursdayFifteen.FirstOrDefault() != null && thursdayFifteenClients.FirstOrDefault() != null)
            {
                thursdayFifteenDataGrid.ItemsSource = thursdayFifteen.ToList();
                thursdayFifteenClientsDataGrid.ItemsSource = thursdayFifteenClients.ToList();
            }
            //четверг 16:00
            var thursdaySixteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:00") && c.Day == "Thursday");
            var thursdaySixteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:00") && c.Lesson.Day == "Thursday");
            if (thursdaySixteen.FirstOrDefault() != null && thursdaySixteenClients.FirstOrDefault() != null)
            {
                thursdaySixteenDataGrid.ItemsSource = thursdaySixteen.ToList();
                thursdaySixteenClientsDataGrid.ItemsSource = thursdaySixteenClients.ToList();
            }
            //четверг 17:00
            var thursdaySeventeen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:00") && c.Day == "Thursday");
            var thursdaySeventeenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:00") && c.Lesson.Day == "Thursday");
            if (thursdaySeventeen.FirstOrDefault() != null && thursdaySeventeenClients.FirstOrDefault() != null)
            {
                thursdaySeventeenDataGrid.ItemsSource = thursdaySeventeen.ToList();
                thursdaySeventeenClientsDataGrid.ItemsSource = thursdaySeventeenClients.ToList();
            }
            //четверг 18:00
            var thursdayEighteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:00") && c.Day == "Thursday");
            var thursdayEighteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:00") && c.Lesson.Day == "Thursday");
            if (thursdayEighteen.FirstOrDefault() != null && thursdayEighteenClients.FirstOrDefault() != null)
            {
                thursdayEighteenDataGrid.ItemsSource = thursdayEighteen.ToList();
                thursdayEighteenClientsDataGrid.ItemsSource = thursdayEighteenClients.ToList();
            }
            //четверг 19:00
            var thursdayNineteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:00") && c.Day == "Thursday");
            var thursdayNineteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:00") && c.Lesson.Day == "Thursday");
            if (thursdayNineteen.FirstOrDefault() != null && thursdayNineteenClients.FirstOrDefault() != null)
            {
                thursdayNineteenDataGrid.ItemsSource = thursdayNineteen.ToList();
                thursdayNineteenClientsDataGrid.ItemsSource = thursdayNineteenClients.ToList();
            }
            //четверг 19:30
            var thursdayNineteenHalf = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:30") && c.Day == "Thursday");
            var thursdayNineteenHalfClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:30") && c.Lesson.Day == "Thursday");
            if (thursdayNineteenHalf.FirstOrDefault() != null && thursdayNineteenHalfClients.FirstOrDefault() != null)
            {
                thursdayNineteenHalfDataGrid.ItemsSource = thursdayNineteenHalf.ToList();
                thursdayNineteenHalfClientsDataGrid.ItemsSource = thursdayNineteenHalfClients.ToList();
            }
            //пятница 9:00
            var fridayNine = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:00") && c.Day == "Friday");
            var fridayNineClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:00") && c.Lesson.Day == "Friday");
            if (fridayNine.FirstOrDefault() != null && fridayNineClients.FirstOrDefault() != null)
            {
                fridayNineDataGrid.ItemsSource = fridayNine.ToList();
                fridayNineClientsDataGrid.ItemsSource = fridayNineClients.ToList();
            }
            //пятница 10:00
            var fridayTen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:00") && c.Day == "Friday");
            var fridayTenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:00") && c.Lesson.Day == "Friday");
            if (fridayTen.FirstOrDefault() != null && fridayTenClients.FirstOrDefault() != null)
            {
                fridayTenDataGrid.ItemsSource = fridayTen.ToList();
                fridayTenClientsDataGrid.ItemsSource = fridayTenClients.ToList();
            }
            //пятница 11:00
            var fridayEleven = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:00") && c.Day == "Friday");
            var fridayElevenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:00") && c.Lesson.Day == "Friday");
            if (fridayEleven.FirstOrDefault() != null && fridayElevenClients.FirstOrDefault() != null)
            {
                fridayElevenDataGrid.ItemsSource = fridayEleven.ToList();
                fridayElevenClientsDataGrid.ItemsSource = fridayElevenClients.ToList();
            }
            //пятница 12:00
            var fridayTwelve = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:00") && c.Day == "Friday");
            var fridayTwelveClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:00") && c.Lesson.Day == "Friday");
            if (fridayTwelve.FirstOrDefault() != null && fridayTwelveClients.FirstOrDefault() != null)
            {
                fridayTwelveDataGrid.ItemsSource = fridayTwelve.ToList();
                fridayTwelveClientsDataGrid.ItemsSource = fridayTwelveClients.ToList();
            }
            //пятница 13:00
            var fridayThirteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:00") && c.Day == "Friday");
            var fridayThirteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:00") && c.Lesson.Day == "Friday");
            if (fridayThirteen.FirstOrDefault() != null && fridayThirteenClients.FirstOrDefault() != null)
            {
                fridayThirteenDataGrid.ItemsSource = fridayThirteen.ToList();
                fridayThirteenClientsDataGrid.ItemsSource = fridayThirteenClients.ToList();
            }
            //пятница 14:00
            var fridayFourteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:00") && c.Day == "Friday");
            var fridayFourteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:00") && c.Lesson.Day == "Friday");
            if (fridayFourteen.FirstOrDefault() != null && fridayFourteenClients.FirstOrDefault() != null)
            {
                fridayFourteenDataGrid.ItemsSource = fridayFourteen.ToList();
                fridayFourteenClientsDataGrid.ItemsSource = fridayFourteenClients.ToList();
            }
            //пятница 15:00
            var fridayFifteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:00") && c.Day == "Friday");
            var fridayFifteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:00") && c.Lesson.Day == "Friday");
            if (fridayFifteen.FirstOrDefault() != null && fridayFifteenClients.FirstOrDefault() != null)
            {
                fridayFifteenDataGrid.ItemsSource = fridayFifteen.ToList();
                fridayFifteenClientsDataGrid.ItemsSource = fridayFifteenClients.ToList();
            }
            //пятница 16:00
            var fridaySixteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:00") && c.Day == "Friday");
            var fridaySixteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:00") && c.Lesson.Day == "Friday");
            if (fridaySixteen.FirstOrDefault() != null && fridaySixteenClients.FirstOrDefault() != null)
            {
                fridaySixteenDataGrid.ItemsSource = fridaySixteen.ToList();
                fridaySixteenClientsDataGrid.ItemsSource = fridaySixteenClients.ToList();
            }
            //пятница 17:00
            var fridaySeventeen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:00") && c.Day == "Friday");
            var fridaySeventeenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:00") && c.Lesson.Day == "Friday");
            if (fridaySeventeen.FirstOrDefault() != null && fridaySeventeenClients.FirstOrDefault() != null)
            {
                fridaySeventeenDataGrid.ItemsSource = fridaySeventeen.ToList();
                fridaySeventeenClientsDataGrid.ItemsSource = fridaySeventeenClients.ToList();
            }
            //пятница 18:00
            var fridayEighteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:00") && c.Day == "Friday");
            var fridayEighteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:00") && c.Lesson.Day == "Friday");
            if (fridayEighteen.FirstOrDefault() != null && fridayEighteenClients.FirstOrDefault() != null)
            {
                fridayEighteenDataGrid.ItemsSource = fridayEighteen.ToList();
                fridayEighteenClientsDataGrid.ItemsSource = fridayEighteenClients.ToList();
            }
            //пятница 19:00
            var fridayNineteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:00") && c.Day == "Friday");
            var fridayNineteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:00") && c.Lesson.Day == "Friday");
            if (fridayNineteen.FirstOrDefault() != null && fridayNineteenClients.FirstOrDefault() != null)
            {
                fridayNineteenDataGrid.ItemsSource = fridayNineteen.ToList();
                fridayNineteenClientsDataGrid.ItemsSource = fridayNineteenClients.ToList();
            }
            //пятница 19:30
            var fridayNineteenHalf = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:30") && c.Day == "Friday");
            var fridayNineteenHalfClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:30") && c.Lesson.Day == "Friday");
            if (fridayNineteenHalf.FirstOrDefault() != null && fridayNineteenHalfClients.FirstOrDefault() != null)
            {
                fridayNineteenHalfDataGrid.ItemsSource = fridayNineteenHalf.ToList();
                fridayNineteenHalfClientsDataGrid.ItemsSource = fridayNineteenHalfClients.ToList();
            }
            //суббота 9:00
            var saturdayNine = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:00") && c.Day == "Saturday");
            var saturdayNineClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:00") && c.Lesson.Day == "Saturday");
            if (saturdayNine.FirstOrDefault() != null && saturdayNineClients.FirstOrDefault() != null)
            {
                saturdayNineDataGrid.ItemsSource = saturdayNine.ToList();
                saturdayNineClientsDataGrid.ItemsSource = saturdayNineClients.ToList();
            }
            //суббота 10:00
            var saturdayTen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:00") && c.Day == "Saturday");
            var saturdayTenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:00") && c.Lesson.Day == "Saturday");
            if (saturdayTen.FirstOrDefault() != null && saturdayTenClients.FirstOrDefault() != null)
            {
                saturdayTenDataGrid.ItemsSource = saturdayTen.ToList();
                saturdayTenClientsDataGrid.ItemsSource = saturdayTenClients.ToList();
            }
            //суббота 11:00
            var saturdayEleven = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:00") && c.Day == "Saturday");
            var saturdayElevenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:00") && c.Lesson.Day == "Saturday");
            if (saturdayEleven.FirstOrDefault() != null && saturdayElevenClients.FirstOrDefault() != null)
            {
                saturdayElevenDataGrid.ItemsSource = saturdayEleven.ToList();
                saturdayElevenClientsDataGrid.ItemsSource = saturdayElevenClients.ToList();
            }
            //суббота 12:00
            var saturdayTwelve = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:00") && c.Day == "Saturday");
            var saturdayTwelveClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:00") && c.Lesson.Day == "Saturday");
            if (saturdayTwelve.FirstOrDefault() != null && saturdayTwelveClients.FirstOrDefault() != null)
            {
                saturdayTwelveDataGrid.ItemsSource = saturdayTwelve.ToList();
                saturdayTwelveClientsDataGrid.ItemsSource = saturdayTwelveClients.ToList();
            }
            //суббота 13:00
            var saturdayThirteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:00") && c.Day == "Saturday");
            var saturdayThirteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:00") && c.Lesson.Day == "Saturday");
            if (saturdayThirteen.FirstOrDefault() != null && saturdayThirteenClients.FirstOrDefault() != null)
            {
                saturdayThirteenDataGrid.ItemsSource = saturdayThirteen.ToList();
                saturdayThirteenClientsDataGrid.ItemsSource = saturdayThirteenClients.ToList();
            }
            //суббота 14:00
            var saturdayFourteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:00") && c.Day == "Saturday");
            var saturdayFourteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:00") && c.Lesson.Day == "Saturday");
            if (saturdayFourteen.FirstOrDefault() != null && saturdayFourteenClients.FirstOrDefault() != null)
            {
                saturdayFourteenDataGrid.ItemsSource = saturdayFourteen.ToList();
                saturdayFourteenClientsDataGrid.ItemsSource = saturdayFourteenClients.ToList();
            }
            //суббота 15:00
            var saturdayFifteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:00") && c.Day == "Saturday");
            var saturdayFifteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:00") && c.Lesson.Day == "Saturday");
            if (saturdayFifteen.FirstOrDefault() != null && saturdayFifteenClients.FirstOrDefault() != null)
            {
                saturdayFifteenDataGrid.ItemsSource = saturdayFifteen.ToList();
                saturdayFifteenClientsDataGrid.ItemsSource = saturdayFifteenClients.ToList();
            }
            //суббота 16:00
            var saturdaySixteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:00") && c.Day == "Saturday");
            var saturdaySixteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:00") && c.Lesson.Day == "Saturday");
            if (saturdaySixteen.FirstOrDefault() != null && saturdaySixteenClients.FirstOrDefault() != null)
            {
                saturdaySixteenDataGrid.ItemsSource = saturdaySixteen.ToList();
                saturdaySixteenClientsDataGrid.ItemsSource = saturdaySixteenClients.ToList();
            }
            //суббота 17:00
            var saturdaySeventeen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:00") && c.Day == "Saturday");
            var saturdaySeventeenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:00") && c.Lesson.Day == "Saturday");
            if (saturdaySeventeen.FirstOrDefault() != null && saturdaySeventeenClients.FirstOrDefault() != null)
            {
                saturdaySeventeenDataGrid.ItemsSource = saturdaySeventeen.ToList();
                saturdaySeventeenClientsDataGrid.ItemsSource = saturdaySeventeenClients.ToList();
            }
            //суббота 18:00
            var saturdayEighteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:00") && c.Day == "Saturday");
            var saturdayEighteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:00") && c.Lesson.Day == "Saturday");
            if (saturdayEighteen.FirstOrDefault() != null && saturdayEighteenClients.FirstOrDefault() != null)
            {
                saturdayEighteenDataGrid.ItemsSource = saturdayEighteen.ToList();
                saturdayEighteenClientsDataGrid.ItemsSource = saturdayEighteenClients.ToList();
            }
            //суббота 19:00
            var saturdayNineteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:00") && c.Day == "Saturday");
            var saturdayNineteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:00") && c.Lesson.Day == "Saturday");
            if (saturdayNineteen.FirstOrDefault() != null && saturdayNineteenClients.FirstOrDefault() != null)
            {
                saturdayNineteenDataGrid.ItemsSource = saturdayNineteen.ToList();
                saturdayNineteenClientsDataGrid.ItemsSource = saturdayNineteenClients.ToList();
            }
            //суббота 19:30
            var saturdayNineteenHalf = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:30") && c.Day == "Saturday");
            var saturdayNineteenHalfClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:30") && c.Lesson.Day == "Saturday");
            if (saturdayNineteenHalf.FirstOrDefault() != null && saturdayNineteenHalfClients.FirstOrDefault() != null)
            {
                saturdayNineteenHalfDataGrid.ItemsSource = saturdayNineteenHalf.ToList();
                saturdayNineteenHalfClientsDataGrid.ItemsSource = saturdayNineteenHalfClients.ToList();
            }
            //воскресенье 9:00
            var sundayNine = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:00") && c.Day == "Sunday");
            var sundayNineClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:00") && c.Lesson.Day == "Sunday");
            if (sundayNine.FirstOrDefault() != null && sundayNineClients.FirstOrDefault() != null)
            {
                sundayNineDataGrid.ItemsSource = sundayNine.ToList();
                sundayNineClientsDataGrid.ItemsSource = sundayNineClients.ToList();
            }
            //воскресенье 10:00
            var sundayTen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:00") && c.Day == "Sunday");
            var sundayTenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:00") && c.Lesson.Day == "Sunday");
            if (sundayTen.FirstOrDefault() != null && sundayTenClients.FirstOrDefault() != null)
            {
                sundayTenDataGrid.ItemsSource = sundayTen.ToList();
                sundayTenClientsDataGrid.ItemsSource = sundayTenClients.ToList();
            }
            //воскресенье 11:00
            var sundayEleven = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:00") && c.Day == "Sunday");
            var sundayElevenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:00") && c.Lesson.Day == "Sunday");
            if (sundayEleven.FirstOrDefault() != null && sundayElevenClients.FirstOrDefault() != null)
            {
                sundayElevenDataGrid.ItemsSource = sundayEleven.ToList();
                sundayElevenClientsDataGrid.ItemsSource = sundayElevenClients.ToList();
            }
            //воскресенье 12:00
            var sundayTwelve = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:00") && c.Day == "Sunday");
            var sundayTwelveClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:00") && c.Lesson.Day == "Sunday");
            if (sundayTwelve.FirstOrDefault() != null && sundayTwelveClients.FirstOrDefault() != null)
            {
                sundayTwelveDataGrid.ItemsSource = sundayTwelve.ToList();
                sundayTwelveClientsDataGrid.ItemsSource = sundayTwelveClients.ToList();
            }
            //воскресенье 13:00
            var sundayThirteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:00") && c.Day == "Sunday");
            var sundayThirteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:00") && c.Lesson.Day == "Sunday");
            if (sundayThirteen.FirstOrDefault() != null && sundayThirteenClients.FirstOrDefault() != null)
            {
                sundayThirteenDataGrid.ItemsSource = sundayThirteen.ToList();
                sundayThirteenClientsDataGrid.ItemsSource = sundayThirteenClients.ToList();
            }
            //воскресенье 14:00
            var sundayFourteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:00") && c.Day == "Sunday");
            var sundayFourteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:00") && c.Lesson.Day == "Sunday");
            if (sundayFourteen.FirstOrDefault() != null && sundayFourteenClients.FirstOrDefault() != null)
            {
                sundayFourteenDataGrid.ItemsSource = sundayFourteen.ToList();
                sundayFourteenClientsDataGrid.ItemsSource = sundayFourteenClients.ToList();
            }
            //воскресенье 15:00
            var sundayFifteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:00") && c.Day == "Sunday");
            var sundayFifteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:00") && c.Lesson.Day == "Sunday");
            if (sundayFifteen.FirstOrDefault() != null && sundayFifteenClients.FirstOrDefault() != null)
            {
                sundayFifteenDataGrid.ItemsSource = sundayFifteen.ToList();
                sundayFifteenClientsDataGrid.ItemsSource = sundayFifteenClients.ToList();
            }
            //воскресенье 16:00
            var sundaySixteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:00") && c.Day == "Sunday");
            var sundaySixteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:00") && c.Lesson.Day == "Sunday");
            if (sundaySixteen.FirstOrDefault() != null && sundaySixteenClients.FirstOrDefault() != null)
            {
                sundaySixteenDataGrid.ItemsSource = sundaySixteen.ToList();
                sundaySixteenClientsDataGrid.ItemsSource = sundaySixteenClients.ToList();
            }
            //воскресенье 17:00
            var sundaySeventeen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:00") && c.Day == "Sunday");
            var sundaySeventeenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:00") && c.Lesson.Day == "Sunday");
            if (sundaySeventeen.FirstOrDefault() != null && sundaySeventeenClients.FirstOrDefault() != null)
            {
                sundaySeventeenDataGrid.ItemsSource = sundaySeventeen.ToList();
                sundaySeventeenClientsDataGrid.ItemsSource = sundaySeventeenClients.ToList();
            }
            //воскресенье 18:00
            var sundayEighteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:00") && c.Day == "Sunday");
            var sundayEighteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:00") && c.Lesson.Day == "Sunday");
            if (sundayEighteen.FirstOrDefault() != null && sundayEighteenClients.FirstOrDefault() != null)
            {
                sundayEighteenDataGrid.ItemsSource = sundayEighteen.ToList();
                sundayEighteenClientsDataGrid.ItemsSource = sundayEighteenClients.ToList();
            }
            //воскресенье 19:00
            var sundayNineteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:00") && c.Day == "Sunday");
            var sundayNineteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:00") && c.Lesson.Day == "Sunday");
            if (sundayNineteen.FirstOrDefault() != null && sundayNineteenClients.FirstOrDefault() != null)
            {
                sundayNineteenDataGrid.ItemsSource = sundayNineteen.ToList();
                sundayNineteenClientsDataGrid.ItemsSource = sundayNineteenClients.ToList();
            }
            //воскресенье 19:30
            var sundayNineteenHalf = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:30") && c.Day == "Sunday");
            var sundayNineteenHalfClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:30") && c.Lesson.Day == "Sunday");
            if (sundayNineteenHalf.FirstOrDefault() != null && sundayNineteenHalfClients.FirstOrDefault() != null)
            {
                sundayNineteenHalfDataGrid.ItemsSource = sundayNineteenHalf.ToList();
                sundayNineteenHalfClientsDataGrid.ItemsSource = sundayNineteenHalfClients.ToList();
            }

        }

        private void scheduleCalendar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
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
            Properties.Settings.Default.dateStart = scheduleCalendar.SelectedDate.ToString();

            if (resultTime == MessageBoxResult.OK)
            {
                if (timeMsg.TextBoxText == "9:00" || timeMsg.TextBoxText == "10:00" || timeMsg.TextBoxText == "11:00" || timeMsg.TextBoxText == "12:00" || timeMsg.TextBoxText == "13:00" || timeMsg.TextBoxText == "14:00" || timeMsg.TextBoxText == "15:00" || timeMsg.TextBoxText == "16:00" || timeMsg.TextBoxText == "17:00" || timeMsg.TextBoxText == "18:00" || timeMsg.TextBoxText == "19:00" || timeMsg.TextBoxText == "19:30") {
                    if (AppData.Context.Lesson.Where(c => c.Date == scheduleCalendar.SelectedDate && c.Time == timeMsg.TextBoxText).FirstOrDefault() == null)
                    {
                        NavigationService.Navigate(new editSchedulePage(null));
                    } else
                    {
                        Lesson CurrentLesson = AppData.Context.Lesson.Where(c => c.Date == scheduleCalendar.SelectedDate && c.Time == timeMsg.TextBoxText).FirstOrDefault();
                        if (CurrentLesson != null)
                        {
                            NavigationService.Navigate(new editSchedulePage(CurrentLesson));
                        }
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
            if (Properties.Settings.Default.dateStart == "0")
            {
                scheduleCalendar.SelectedDate = DateTime.Today;
            } else
            {
                scheduleCalendar.SelectedDate = Convert.ToDateTime(Properties.Settings.Default.dateStart);
            }
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
            //понедельник 9:00
            var mondayNine = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:00") && c.Day == "Monday");
            var mondayNineClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:00") && c.Lesson.Day == "Monday");
            if (mondayNine.FirstOrDefault() != null && mondayNineClients.FirstOrDefault() != null)
            {
                mondayNineDataGrid.ItemsSource = mondayNine.ToList();
                mondayNineClientsDataGrid.ItemsSource = mondayNineClients.ToList();
            }
            //понедельник 10:00
            var mondayTen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:00") && c.Day == "Monday");
            var mondayTenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:00") && c.Lesson.Day == "Monday");
            if (mondayTen.FirstOrDefault() != null && mondayTenClients.FirstOrDefault() != null)
            {
                mondayTenDataGrid.ItemsSource = mondayTen.ToList();
                mondayTenClientsDataGrid.ItemsSource = mondayTenClients.ToList();
            }
            //понедельник 11:00
            var mondayEleven = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:00") && c.Day == "Monday");
            var mondayElevenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:00") && c.Lesson.Day == "Monday");
            if (mondayEleven.FirstOrDefault() != null && mondayElevenClients.FirstOrDefault() != null)
            {
                mondayElevenDataGrid.ItemsSource = mondayEleven.ToList();
                mondayElevenClientsDataGrid.ItemsSource = mondayElevenClients.ToList();
            }
            //понедельник 12:00
            var mondayTwelve = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:00") && c.Day == "Monday");
            var mondayTwelveClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:00") && c.Lesson.Day == "Monday");
            if (mondayTwelve.FirstOrDefault() != null && mondayTwelveClients.FirstOrDefault() != null)
            {
                mondayTwelveDataGrid.ItemsSource = mondayTwelve.ToList();
                mondayTwelveClientsDataGrid.ItemsSource = mondayTwelveClients.ToList();
            }
            //понедельник 13:00
            var mondayThirteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:00") && c.Day == "Monday");
            var mondayThirteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:00") && c.Lesson.Day == "Monday");
            if (mondayThirteen.FirstOrDefault() != null && mondayThirteenClients.FirstOrDefault() != null)
            {
                mondayThirteenDataGrid.ItemsSource = mondayThirteen.ToList();
                mondayThirteenClientsDataGrid.ItemsSource = mondayThirteenClients.ToList();
            }
            //понедельник 14:00
            var mondayFourteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:00") && c.Day == "Monday");
            var mondayFourteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:00") && c.Lesson.Day == "Monday");
            if (mondayFourteen.FirstOrDefault() != null && mondayFourteenClients.FirstOrDefault() != null)
            {
                mondayFourteenDataGrid.ItemsSource = mondayFourteen.ToList();
                mondayFourteenClientsDataGrid.ItemsSource = mondayFourteenClients.ToList();
            }
            //понедельник 15:00
            var mondayFifteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:00") && c.Day == "Monday");
            var mondayFifteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:00") && c.Lesson.Day == "Monday");
            if (mondayFifteen.FirstOrDefault() != null && mondayFifteenClients.FirstOrDefault() != null)
            {
                mondayFifteenDataGrid.ItemsSource = mondayFifteen.ToList();
                mondayFifteenClientsDataGrid.ItemsSource = mondayFifteenClients.ToList();
            }
            //понедельник 16:00
            var mondaySixteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:00") && c.Day == "Monday");
            var mondaySixteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:00") && c.Lesson.Day == "Monday");
            if (mondaySixteen.FirstOrDefault() != null && mondaySixteenClients.FirstOrDefault() != null)
            {
                mondaySixteenDataGrid.ItemsSource = mondaySixteen.ToList();
                mondaySixteenClientsDataGrid.ItemsSource = mondaySixteenClients.ToList();
            }
            //понедельник 17:00
            var mondaySeventeen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:00") && c.Day == "Monday");
            var mondaySeventeenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:00") && c.Lesson.Day == "Monday");
            if (mondaySeventeen.FirstOrDefault() != null && mondaySeventeenClients.FirstOrDefault() != null)
            {
                mondaySeventeenDataGrid.ItemsSource = mondaySeventeen.ToList();
                mondaySeventeenClientsDataGrid.ItemsSource = mondaySeventeenClients.ToList();
            }
            //понедельник 18:00
            var mondayEighteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:00") && c.Day == "Monday");
            var mondayEighteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:00") && c.Lesson.Day == "Monday");
            if (mondayEighteen.FirstOrDefault() != null && mondayEighteenClients.FirstOrDefault() != null)
            {
                mondayEighteenDataGrid.ItemsSource = mondayEighteen.ToList();
                mondayEighteenClientsDataGrid.ItemsSource = mondayEighteenClients.ToList();
            }
            //понедельник 19:00
            var mondayNineteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:00") && c.Day == "Monday");
            var mondayNineteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:00") && c.Lesson.Day == "Monday");
            if (mondayNineteen.FirstOrDefault() != null && mondayNineteenClients.FirstOrDefault() != null)
            {
                mondayNineteenDataGrid.ItemsSource = mondayNineteen.ToList();
                mondayNineteenClientsDataGrid.ItemsSource = mondayNineteenClients.ToList();
            }
            //понедельник 19:30
            var mondayNineteenHalf = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:30") && c.Day == "Monday");
            var mondayNineteenHalfClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:30") && c.Lesson.Day == "Monday");
            if (mondayNineteenHalf.FirstOrDefault() != null && mondayNineteenHalfClients.FirstOrDefault() != null)
            {
                mondayNineteenHalfDataGrid.ItemsSource = mondayNineteenHalf.ToList();
                mondayNineteenHalfClientsDataGrid.ItemsSource = mondayNineteenHalfClients.ToList();
            }
            //вторник 9:00
            var tuesdayNine = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:00") && c.Day == "Tuesday");
            var tuesdayNineClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:00") && c.Lesson.Day == "Tuesday");
            if (tuesdayNine.FirstOrDefault() != null && tuesdayNineClients.FirstOrDefault() != null)
            {
                tuesdayNineDataGrid.ItemsSource = tuesdayNine.ToList();
                tuesdayNineClientsDataGrid.ItemsSource = tuesdayNineClients.ToList();
            }
            //вторник 10:00
            var tuesdayTen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:00") && c.Day == "Tuesday");
            var tuesdayTenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:00") && c.Lesson.Day == "Tuesday");
            if (tuesdayTen.FirstOrDefault() != null && tuesdayTenClients.FirstOrDefault() != null)
            {
                tuesdayTenDataGrid.ItemsSource = tuesdayTen.ToList();
                tuesdayTenClientsDataGrid.ItemsSource = tuesdayTenClients.ToList();
            }
            //вторник 11:00
            var tuesdayEleven = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:00") && c.Day == "Tuesday");
            var tuesdayElevenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:00") && c.Lesson.Day == "Tuesday");
            if (tuesdayEleven.FirstOrDefault() != null && tuesdayElevenClients.FirstOrDefault() != null)
            {
                tuesdayElevenDataGrid.ItemsSource = tuesdayEleven.ToList();
                tuesdayElevenClientsDataGrid.ItemsSource = tuesdayElevenClients.ToList();
            }
            //вторник 12:00
            var tuesdayTwelve = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:00") && c.Day == "Tuesday");
            var tuesdayTwelveClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:00") && c.Lesson.Day == "Tuesday");
            if (tuesdayTwelve.FirstOrDefault() != null && tuesdayTwelveClients.FirstOrDefault() != null)
            {
                tuesdayTwelveDataGrid.ItemsSource = tuesdayTwelve.ToList();
                tuesdayTwelveClientsDataGrid.ItemsSource = tuesdayTwelveClients.ToList();
            }
            //вторник 13:00
            var tuesdayThirteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:00") && c.Day == "Tuesday");
            var tuesdayThirteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:00") && c.Lesson.Day == "Tuesday");
            if (tuesdayThirteen.FirstOrDefault() != null && tuesdayThirteenClients.FirstOrDefault() != null)
            {
                tuesdayThirteenDataGrid.ItemsSource = tuesdayThirteen.ToList();
                tuesdayThirteenClientsDataGrid.ItemsSource = tuesdayThirteenClients.ToList();
            }
            //вторник 14:00
            var tuesdayFourteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:00") && c.Day == "Tuesday");
            var tuesdayFourteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:00") && c.Lesson.Day == "Tuesday");
            if (tuesdayFourteen.FirstOrDefault() != null && tuesdayFourteenClients.FirstOrDefault() != null)
            {
                tuesdayFourteenDataGrid.ItemsSource = tuesdayFourteen.ToList();
                tuesdayFourteenClientsDataGrid.ItemsSource = tuesdayFourteenClients.ToList();
            }
            //вторник 15:00
            var tuesdayFifteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:00") && c.Day == "Tuesday");
            var tuesdayFifteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:00") && c.Lesson.Day == "Tuesday");
            if (tuesdayFifteen.FirstOrDefault() != null && tuesdayFifteenClients.FirstOrDefault() != null)
            {
                tuesdayFifteenDataGrid.ItemsSource = tuesdayFifteen.ToList();
                tuesdayFifteenClientsDataGrid.ItemsSource = tuesdayFifteenClients.ToList();
            }
            //вторник 16:00
            var tuesdaySixteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:00") && c.Day == "Tuesday");
            var tuesdaySixteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:00") && c.Lesson.Day == "Tuesday");
            if (tuesdaySixteen.FirstOrDefault() != null && tuesdaySixteenClients.FirstOrDefault() != null)
            {
                tuesdaySixteenDataGrid.ItemsSource = tuesdaySixteen.ToList();
                tuesdaySixteenClientsDataGrid.ItemsSource = tuesdaySixteenClients.ToList();
            }
            //вторник 17:00
            var tuesdaySeventeen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:00") && c.Day == "Tuesday");
            var tuesdaySeventeenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:00") && c.Lesson.Day == "Tuesday");
            if (tuesdaySeventeen.FirstOrDefault() != null && tuesdaySeventeenClients.FirstOrDefault() != null)
            {
                tuesdaySeventeenDataGrid.ItemsSource = tuesdaySeventeen.ToList();
                tuesdaySeventeenClientsDataGrid.ItemsSource = tuesdaySeventeenClients.ToList();
            }
            //вторник 18:00
            var tuesdayEighteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:00") && c.Day == "Tuesday");
            var tuesdayEighteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:00") && c.Lesson.Day == "Tuesday");
            if (tuesdayEighteen.FirstOrDefault() != null && tuesdayEighteenClients.FirstOrDefault() != null)
            {
                tuesdayEighteenDataGrid.ItemsSource = tuesdayEighteen.ToList();
                tuesdayEighteenClientsDataGrid.ItemsSource = tuesdayEighteenClients.ToList();
            }
            //вторник 19:00
            var tuesdayNineteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:00") && c.Day == "Tuesday");
            var tuesdayNineteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:00") && c.Lesson.Day == "Tuesday");
            if (tuesdayNineteen.FirstOrDefault() != null && tuesdayNineteenClients.FirstOrDefault() != null)
            {
                tuesdayNineteenDataGrid.ItemsSource = tuesdayNineteen.ToList();
                tuesdayNineteenClientsDataGrid.ItemsSource = tuesdayNineteenClients.ToList();
            }
            //вторник 19:30
            var tuesdayNineteenHalf = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:30") && c.Day == "Tuesday");
            var tuesdayNineteenHalfClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:30") && c.Lesson.Day == "Tuesday");
            if (tuesdayNineteenHalf.FirstOrDefault() != null && tuesdayNineteenHalfClients.FirstOrDefault() != null)
            {
                tuesdayNineteenHalfDataGrid.ItemsSource = tuesdayNineteenHalf.ToList();
                tuesdayNineteenHalfClientsDataGrid.ItemsSource = tuesdayNineteenHalfClients.ToList();
            }
            //среда 9:00
            var wednesdayNine = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:00") && c.Day == "Wednesday");
            var wednesdayNineClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:00") && c.Lesson.Day == "Wednesday");
            if (wednesdayNine.FirstOrDefault() != null && wednesdayNineClients.FirstOrDefault() != null)
            {
                wednesdayNineDataGrid.ItemsSource = wednesdayNine.ToList();
                wednesdayNineClientsDataGrid.ItemsSource = wednesdayNineClients.ToList();
            }
            //среда 10:00
            var wednesdayTen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:00") && c.Day == "Wednesday");
            var wednesdayTenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:00") && c.Lesson.Day == "Wednesday");
            if (wednesdayTen.FirstOrDefault() != null && wednesdayTenClients.FirstOrDefault() != null)
            {
                wednesdayTenDataGrid.ItemsSource = wednesdayTen.ToList();
                wednesdayTenClientsDataGrid.ItemsSource = wednesdayTenClients.ToList();
            }
            //среда 11:00
            var wednesdayEleven = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:00") && c.Day == "Wednesday");
            var wednesdayElevenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:00") && c.Lesson.Day == "Wednesday");
            if (wednesdayEleven.FirstOrDefault() != null && wednesdayElevenClients.FirstOrDefault() != null)
            {
                wednesdayElevenDataGrid.ItemsSource = wednesdayEleven.ToList();
                wednesdayElevenClientsDataGrid.ItemsSource = wednesdayElevenClients.ToList();
            }
            //среда 12:00
            var wednesdayTwelve = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:00") && c.Day == "Wednesday");
            var wednesdayTwelveClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:00") && c.Lesson.Day == "Wednesday");
            if (wednesdayTwelve.FirstOrDefault() != null && wednesdayTwelveClients.FirstOrDefault() != null)
            {
                wednesdayTwelveDataGrid.ItemsSource = wednesdayTwelve.ToList();
                wednesdayTwelveClientsDataGrid.ItemsSource = wednesdayTwelveClients.ToList();
            }
            //среда 13:00
            var wednesdayThirteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:00") && c.Day == "Wednesday");
            var wednesdayThirteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:00") && c.Lesson.Day == "Wednesday");
            if (wednesdayThirteen.FirstOrDefault() != null && wednesdayThirteenClients.FirstOrDefault() != null)
            {
                wednesdayThirteenDataGrid.ItemsSource = wednesdayThirteen.ToList();
                wednesdayThirteenClientsDataGrid.ItemsSource = wednesdayThirteenClients.ToList();
            }
            //среда 14:00
            var wednesdayFourteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:00") && c.Day == "Wednesday");
            var wednesdayFourteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:00") && c.Lesson.Day == "Wednesday");
            if (wednesdayFourteen.FirstOrDefault() != null && wednesdayFourteenClients.FirstOrDefault() != null)
            {
                wednesdayFourteenDataGrid.ItemsSource = wednesdayFourteen.ToList();
                wednesdayFourteenClientsDataGrid.ItemsSource = wednesdayFourteenClients.ToList();
            }
            //среда 15:00
            var wednesdayFifteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:00") && c.Day == "Wednesday");
            var wednesdayFifteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:00") && c.Lesson.Day == "Wednesday");
            if (wednesdayFifteen.FirstOrDefault() != null && wednesdayFifteenClients.FirstOrDefault() != null)
            {
                wednesdayFifteenDataGrid.ItemsSource = wednesdayFifteen.ToList();
                wednesdayFifteenClientsDataGrid.ItemsSource = wednesdayFifteenClients.ToList();
            }
            //среда 16:00
            var wednesdaySixteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:00") && c.Day == "Wednesday");
            var wednesdaySixteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:00") && c.Lesson.Day == "Wednesday");
            if (wednesdaySixteen.FirstOrDefault() != null && wednesdaySixteenClients.FirstOrDefault() != null)
            {
                wednesdaySixteenDataGrid.ItemsSource = wednesdaySixteen.ToList();
                wednesdaySixteenClientsDataGrid.ItemsSource = wednesdaySixteenClients.ToList();
            }
            //среда 17:00
            var wednesdaySeventeen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:00") && c.Day == "Wednesday");
            var wednesdaySeventeenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:00") && c.Lesson.Day == "Wednesday");
            if (wednesdaySeventeen.FirstOrDefault() != null && wednesdaySeventeenClients.FirstOrDefault() != null)
            {
                wednesdaySeventeenDataGrid.ItemsSource = wednesdaySeventeen.ToList();
                wednesdaySeventeenClientsDataGrid.ItemsSource = wednesdaySeventeenClients.ToList();
            }
            //среда 18:00
            var wednesdayEighteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:00") && c.Day == "Wednesday");
            var wednesdayEighteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:00") && c.Lesson.Day == "Wednesday");
            if (wednesdayEighteen.FirstOrDefault() != null && wednesdayEighteenClients.FirstOrDefault() != null)
            {
                wednesdayEighteenDataGrid.ItemsSource = wednesdayEighteen.ToList();
                wednesdayEighteenClientsDataGrid.ItemsSource = wednesdayEighteenClients.ToList();
            }
            //среда 19:00
            var wednesdayNineteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:00") && c.Day == "Wednesday");
            var wednesdayNineteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:00") && c.Lesson.Day == "Wednesday");
            if (wednesdayNineteen.FirstOrDefault() != null && wednesdayNineteenClients.FirstOrDefault() != null)
            {
                wednesdayNineteenDataGrid.ItemsSource = wednesdayNineteen.ToList();
                wednesdayNineteenClientsDataGrid.ItemsSource = wednesdayNineteenClients.ToList();
            }
            //среда 19:30
            var wednesdayNineteenHalf = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:30") && c.Day == "Wednesday");
            var wednesdayNineteenHalfClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:30") && c.Lesson.Day == "Wednesday");
            if (wednesdayNineteenHalf.FirstOrDefault() != null && wednesdayNineteenHalfClients.FirstOrDefault() != null)
            {
                wednesdayNineteenHalfDataGrid.ItemsSource = wednesdayNineteenHalf.ToList();
                wednesdayNineteenHalfClientsDataGrid.ItemsSource = wednesdayNineteenHalfClients.ToList();
            }
            //четверг 9:00
            var thursdayNine = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:00") && c.Day == "Thursday");
            var thursdayNineClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:00") && c.Lesson.Day == "Thursday");
            if (thursdayNine.FirstOrDefault() != null && thursdayNineClients.FirstOrDefault() != null)
            {
                thursdayNineDataGrid.ItemsSource = thursdayNine.ToList();
                thursdayNineClientsDataGrid.ItemsSource = thursdayNineClients.ToList();
            }
            //четверг 10:00
            var thursdayTen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:00") && c.Day == "Thursday");
            var thursdayTenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:00") && c.Lesson.Day == "Thursday");
            if (thursdayTen.FirstOrDefault() != null && thursdayTenClients.FirstOrDefault() != null)
            {
                thursdayTenDataGrid.ItemsSource = thursdayTen.ToList();
                thursdayTenClientsDataGrid.ItemsSource = thursdayTenClients.ToList();
            }
            //четверг 11:00
            var thursdayEleven = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:00") && c.Day == "Thursday");
            var thursdayElevenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:00") && c.Lesson.Day == "Thursday");
            if (thursdayEleven.FirstOrDefault() != null && thursdayElevenClients.FirstOrDefault() != null)
            {
                thursdayElevenDataGrid.ItemsSource = thursdayEleven.ToList();
                thursdayElevenClientsDataGrid.ItemsSource = thursdayElevenClients.ToList();
            }
            //четверг 12:00
            var thursdayTwelve = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:00") && c.Day == "Thursday");
            var thursdayTwelveClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:00") && c.Lesson.Day == "Thursday");
            if (thursdayTwelve.FirstOrDefault() != null && thursdayTwelveClients.FirstOrDefault() != null)
            {
                thursdayTwelveDataGrid.ItemsSource = thursdayTwelve.ToList();
                thursdayTwelveClientsDataGrid.ItemsSource = thursdayTwelveClients.ToList();
            }
            //четверг 13:00
            var thursdayThirteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:00") && c.Day == "Thursday");
            var thursdayThirteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:00") && c.Lesson.Day == "Thursday");
            if (thursdayThirteen.FirstOrDefault() != null && thursdayThirteenClients.FirstOrDefault() != null)
            {
                thursdayThirteenDataGrid.ItemsSource = thursdayThirteen.ToList();
                thursdayThirteenClientsDataGrid.ItemsSource = thursdayThirteenClients.ToList();
            }
            //четверг 14:00
            var thursdayFourteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:00") && c.Day == "Thursday");
            var thursdayFourteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:00") && c.Lesson.Day == "Thursday");
            if (thursdayFourteen.FirstOrDefault() != null && thursdayFourteenClients.FirstOrDefault() != null)
            {
                thursdayFourteenDataGrid.ItemsSource = thursdayFourteen.ToList();
                thursdayFourteenClientsDataGrid.ItemsSource = thursdayFourteenClients.ToList();
            }
            //четверг 15:00
            var thursdayFifteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:00") && c.Day == "Thursday");
            var thursdayFifteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:00") && c.Lesson.Day == "Thursday");
            if (thursdayFifteen.FirstOrDefault() != null && thursdayFifteenClients.FirstOrDefault() != null)
            {
                thursdayFifteenDataGrid.ItemsSource = thursdayFifteen.ToList();
                thursdayFifteenClientsDataGrid.ItemsSource = thursdayFifteenClients.ToList();
            }
            //четверг 16:00
            var thursdaySixteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:00") && c.Day == "Thursday");
            var thursdaySixteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:00") && c.Lesson.Day == "Thursday");
            if (thursdaySixteen.FirstOrDefault() != null && thursdaySixteenClients.FirstOrDefault() != null)
            {
                thursdaySixteenDataGrid.ItemsSource = thursdaySixteen.ToList();
                thursdaySixteenClientsDataGrid.ItemsSource = thursdaySixteenClients.ToList();
            }
            //четверг 17:00
            var thursdaySeventeen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:00") && c.Day == "Thursday");
            var thursdaySeventeenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:00") && c.Lesson.Day == "Thursday");
            if (thursdaySeventeen.FirstOrDefault() != null && thursdaySeventeenClients.FirstOrDefault() != null)
            {
                thursdaySeventeenDataGrid.ItemsSource = thursdaySeventeen.ToList();
                thursdaySeventeenClientsDataGrid.ItemsSource = thursdaySeventeenClients.ToList();
            }
            //четверг 18:00
            var thursdayEighteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:00") && c.Day == "Thursday");
            var thursdayEighteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:00") && c.Lesson.Day == "Thursday");
            if (thursdayEighteen.FirstOrDefault() != null && thursdayEighteenClients.FirstOrDefault() != null)
            {
                thursdayEighteenDataGrid.ItemsSource = thursdayEighteen.ToList();
                thursdayEighteenClientsDataGrid.ItemsSource = thursdayEighteenClients.ToList();
            }
            //четверг 19:00
            var thursdayNineteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:00") && c.Day == "Thursday");
            var thursdayNineteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:00") && c.Lesson.Day == "Thursday");
            if (thursdayNineteen.FirstOrDefault() != null && thursdayNineteenClients.FirstOrDefault() != null)
            {
                thursdayNineteenDataGrid.ItemsSource = thursdayNineteen.ToList();
                thursdayNineteenClientsDataGrid.ItemsSource = thursdayNineteenClients.ToList();
            }
            //четверг 19:30
            var thursdayNineteenHalf = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:30") && c.Day == "Thursday");
            var thursdayNineteenHalfClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:30") && c.Lesson.Day == "Thursday");
            if (thursdayNineteenHalf.FirstOrDefault() != null && thursdayNineteenHalfClients.FirstOrDefault() != null)
            {
                thursdayNineteenHalfDataGrid.ItemsSource = thursdayNineteenHalf.ToList();
                thursdayNineteenHalfClientsDataGrid.ItemsSource = thursdayNineteenHalfClients.ToList();
            }
            //пятница 9:00
            var fridayNine = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:00") && c.Day == "Friday");
            var fridayNineClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:00") && c.Lesson.Day == "Friday");
            if (fridayNine.FirstOrDefault() != null && fridayNineClients.FirstOrDefault() != null)
            {
                fridayNineDataGrid.ItemsSource = fridayNine.ToList();
                fridayNineClientsDataGrid.ItemsSource = fridayNineClients.ToList();
            }
            //пятница 10:00
            var fridayTen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:00") && c.Day == "Friday");
            var fridayTenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:00") && c.Lesson.Day == "Friday");
            if (fridayTen.FirstOrDefault() != null && fridayTenClients.FirstOrDefault() != null)
            {
                fridayTenDataGrid.ItemsSource = fridayTen.ToList();
                fridayTenClientsDataGrid.ItemsSource = fridayTenClients.ToList();
            }
            //пятница 11:00
            var fridayEleven = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:00") && c.Day == "Friday");
            var fridayElevenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:00") && c.Lesson.Day == "Friday");
            if (fridayEleven.FirstOrDefault() != null && fridayElevenClients.FirstOrDefault() != null)
            {
                fridayElevenDataGrid.ItemsSource = fridayEleven.ToList();
                fridayElevenClientsDataGrid.ItemsSource = fridayElevenClients.ToList();
            }
            //пятница 12:00
            var fridayTwelve = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:00") && c.Day == "Friday");
            var fridayTwelveClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:00") && c.Lesson.Day == "Friday");
            if (fridayTwelve.FirstOrDefault() != null && fridayTwelveClients.FirstOrDefault() != null)
            {
                fridayTwelveDataGrid.ItemsSource = fridayTwelve.ToList();
                fridayTwelveClientsDataGrid.ItemsSource = fridayTwelveClients.ToList();
            }
            //пятница 13:00
            var fridayThirteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:00") && c.Day == "Friday");
            var fridayThirteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:00") && c.Lesson.Day == "Friday");
            if (fridayThirteen.FirstOrDefault() != null && fridayThirteenClients.FirstOrDefault() != null)
            {
                fridayThirteenDataGrid.ItemsSource = fridayThirteen.ToList();
                fridayThirteenClientsDataGrid.ItemsSource = fridayThirteenClients.ToList();
            }
            //пятница 14:00
            var fridayFourteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:00") && c.Day == "Friday");
            var fridayFourteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:00") && c.Lesson.Day == "Friday");
            if (fridayFourteen.FirstOrDefault() != null && fridayFourteenClients.FirstOrDefault() != null)
            {
                fridayFourteenDataGrid.ItemsSource = fridayFourteen.ToList();
                fridayFourteenClientsDataGrid.ItemsSource = fridayFourteenClients.ToList();
            }
            //пятница 15:00
            var fridayFifteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:00") && c.Day == "Friday");
            var fridayFifteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:00") && c.Lesson.Day == "Friday");
            if (fridayFifteen.FirstOrDefault() != null && fridayFifteenClients.FirstOrDefault() != null)
            {
                fridayFifteenDataGrid.ItemsSource = fridayFifteen.ToList();
                fridayFifteenClientsDataGrid.ItemsSource = fridayFifteenClients.ToList();
            }
            //пятница 16:00
            var fridaySixteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:00") && c.Day == "Friday");
            var fridaySixteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:00") && c.Lesson.Day == "Friday");
            if (fridaySixteen.FirstOrDefault() != null && fridaySixteenClients.FirstOrDefault() != null)
            {
                fridaySixteenDataGrid.ItemsSource = fridaySixteen.ToList();
                fridaySixteenClientsDataGrid.ItemsSource = fridaySixteenClients.ToList();
            }
            //пятница 17:00
            var fridaySeventeen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:00") && c.Day == "Friday");
            var fridaySeventeenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:00") && c.Lesson.Day == "Friday");
            if (fridaySeventeen.FirstOrDefault() != null && fridaySeventeenClients.FirstOrDefault() != null)
            {
                fridaySeventeenDataGrid.ItemsSource = fridaySeventeen.ToList();
                fridaySeventeenClientsDataGrid.ItemsSource = fridaySeventeenClients.ToList();
            }
            //пятница 18:00
            var fridayEighteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:00") && c.Day == "Friday");
            var fridayEighteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:00") && c.Lesson.Day == "Friday");
            if (fridayEighteen.FirstOrDefault() != null && fridayEighteenClients.FirstOrDefault() != null)
            {
                fridayEighteenDataGrid.ItemsSource = fridayEighteen.ToList();
                fridayEighteenClientsDataGrid.ItemsSource = fridayEighteenClients.ToList();
            }
            //пятница 19:00
            var fridayNineteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:00") && c.Day == "Friday");
            var fridayNineteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:00") && c.Lesson.Day == "Friday");
            if (fridayNineteen.FirstOrDefault() != null && fridayNineteenClients.FirstOrDefault() != null)
            {
                fridayNineteenDataGrid.ItemsSource = fridayNineteen.ToList();
                fridayNineteenClientsDataGrid.ItemsSource = fridayNineteenClients.ToList();
            }
            //пятница 19:30
            var fridayNineteenHalf = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:30") && c.Day == "Friday");
            var fridayNineteenHalfClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:30") && c.Lesson.Day == "Friday");
            if (fridayNineteenHalf.FirstOrDefault() != null && fridayNineteenHalfClients.FirstOrDefault() != null)
            {
                fridayNineteenHalfDataGrid.ItemsSource = fridayNineteenHalf.ToList();
                fridayNineteenHalfClientsDataGrid.ItemsSource = fridayNineteenHalfClients.ToList();
            }
            //суббота 9:00
            var saturdayNine = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:00") && c.Day == "Saturday");
            var saturdayNineClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:00") && c.Lesson.Day == "Saturday");
            if (saturdayNine.FirstOrDefault() != null && saturdayNineClients.FirstOrDefault() != null)
            {
                saturdayNineDataGrid.ItemsSource = saturdayNine.ToList();
                saturdayNineClientsDataGrid.ItemsSource = saturdayNineClients.ToList();
            }
            //суббота 10:00
            var saturdayTen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:00") && c.Day == "Saturday");
            var saturdayTenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:00") && c.Lesson.Day == "Saturday");
            if (saturdayTen.FirstOrDefault() != null && saturdayTenClients.FirstOrDefault() != null)
            {
                saturdayTenDataGrid.ItemsSource = saturdayTen.ToList();
                saturdayTenClientsDataGrid.ItemsSource = saturdayTenClients.ToList();
            }
            //суббота 11:00
            var saturdayEleven = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:00") && c.Day == "Saturday");
            var saturdayElevenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:00") && c.Lesson.Day == "Saturday");
            if (saturdayEleven.FirstOrDefault() != null && saturdayElevenClients.FirstOrDefault() != null)
            {
                saturdayElevenDataGrid.ItemsSource = saturdayEleven.ToList();
                saturdayElevenClientsDataGrid.ItemsSource = saturdayElevenClients.ToList();
            }
            //суббота 12:00
            var saturdayTwelve = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:00") && c.Day == "Saturday");
            var saturdayTwelveClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:00") && c.Lesson.Day == "Saturday");
            if (saturdayTwelve.FirstOrDefault() != null && saturdayTwelveClients.FirstOrDefault() != null)
            {
                saturdayTwelveDataGrid.ItemsSource = saturdayTwelve.ToList();
                saturdayTwelveClientsDataGrid.ItemsSource = saturdayTwelveClients.ToList();
            }
            //суббота 13:00
            var saturdayThirteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:00") && c.Day == "Saturday");
            var saturdayThirteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:00") && c.Lesson.Day == "Saturday");
            if (saturdayThirteen.FirstOrDefault() != null && saturdayThirteenClients.FirstOrDefault() != null)
            {
                saturdayThirteenDataGrid.ItemsSource = saturdayThirteen.ToList();
                saturdayThirteenClientsDataGrid.ItemsSource = saturdayThirteenClients.ToList();
            }
            //суббота 14:00
            var saturdayFourteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:00") && c.Day == "Saturday");
            var saturdayFourteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:00") && c.Lesson.Day == "Saturday");
            if (saturdayFourteen.FirstOrDefault() != null && saturdayFourteenClients.FirstOrDefault() != null)
            {
                saturdayFourteenDataGrid.ItemsSource = saturdayFourteen.ToList();
                saturdayFourteenClientsDataGrid.ItemsSource = saturdayFourteenClients.ToList();
            }
            //суббота 15:00
            var saturdayFifteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:00") && c.Day == "Saturday");
            var saturdayFifteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:00") && c.Lesson.Day == "Saturday");
            if (saturdayFifteen.FirstOrDefault() != null && saturdayFifteenClients.FirstOrDefault() != null)
            {
                saturdayFifteenDataGrid.ItemsSource = saturdayFifteen.ToList();
                saturdayFifteenClientsDataGrid.ItemsSource = saturdayFifteenClients.ToList();
            }
            //суббота 16:00
            var saturdaySixteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:00") && c.Day == "Saturday");
            var saturdaySixteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:00") && c.Lesson.Day == "Saturday");
            if (saturdaySixteen.FirstOrDefault() != null && saturdaySixteenClients.FirstOrDefault() != null)
            {
                saturdaySixteenDataGrid.ItemsSource = saturdaySixteen.ToList();
                saturdaySixteenClientsDataGrid.ItemsSource = saturdaySixteenClients.ToList();
            }
            //суббота 17:00
            var saturdaySeventeen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:00") && c.Day == "Saturday");
            var saturdaySeventeenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:00") && c.Lesson.Day == "Saturday");
            if (saturdaySeventeen.FirstOrDefault() != null && saturdaySeventeenClients.FirstOrDefault() != null)
            {
                saturdaySeventeenDataGrid.ItemsSource = saturdaySeventeen.ToList();
                saturdaySeventeenClientsDataGrid.ItemsSource = saturdaySeventeenClients.ToList();
            }
            //суббота 18:00
            var saturdayEighteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:00") && c.Day == "Saturday");
            var saturdayEighteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:00") && c.Lesson.Day == "Saturday");
            if (saturdayEighteen.FirstOrDefault() != null && saturdayEighteenClients.FirstOrDefault() != null)
            {
                saturdayEighteenDataGrid.ItemsSource = saturdayEighteen.ToList();
                saturdayEighteenClientsDataGrid.ItemsSource = saturdayEighteenClients.ToList();
            }
            //суббота 19:00
            var saturdayNineteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:00") && c.Day == "Saturday");
            var saturdayNineteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:00") && c.Lesson.Day == "Saturday");
            if (saturdayNineteen.FirstOrDefault() != null && saturdayNineteenClients.FirstOrDefault() != null)
            {
                saturdayNineteenDataGrid.ItemsSource = saturdayNineteen.ToList();
                saturdayNineteenClientsDataGrid.ItemsSource = saturdayNineteenClients.ToList();
            }
            //суббота 19:30
            var saturdayNineteenHalf = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:30") && c.Day == "Saturday");
            var saturdayNineteenHalfClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:30") && c.Lesson.Day == "Saturday");
            if (saturdayNineteenHalf.FirstOrDefault() != null && saturdayNineteenHalfClients.FirstOrDefault() != null)
            {
                saturdayNineteenHalfDataGrid.ItemsSource = saturdayNineteenHalf.ToList();
                saturdayNineteenHalfClientsDataGrid.ItemsSource = saturdayNineteenHalfClients.ToList();
            }
            //воскресенье 9:00
            var sundayNine = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "9:00") && c.Day == "Sunday");
            var sundayNineClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "9:00") && c.Lesson.Day == "Sunday");
            if (sundayNine.FirstOrDefault() != null && sundayNineClients.FirstOrDefault() != null)
            {
                sundayNineDataGrid.ItemsSource = sundayNine.ToList();
                sundayNineClientsDataGrid.ItemsSource = sundayNineClients.ToList();
            }
            //воскресенье 10:00
            var sundayTen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "10:00") && c.Day == "Sunday");
            var sundayTenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "10:00") && c.Lesson.Day == "Sunday");
            if (sundayTen.FirstOrDefault() != null && sundayTenClients.FirstOrDefault() != null)
            {
                sundayTenDataGrid.ItemsSource = sundayTen.ToList();
                sundayTenClientsDataGrid.ItemsSource = sundayTenClients.ToList();
            }
            //воскресенье 11:00
            var sundayEleven = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "11:00") && c.Day == "Sunday");
            var sundayElevenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "11:00") && c.Lesson.Day == "Sunday");
            if (sundayEleven.FirstOrDefault() != null && sundayElevenClients.FirstOrDefault() != null)
            {
                sundayElevenDataGrid.ItemsSource = sundayEleven.ToList();
                sundayElevenClientsDataGrid.ItemsSource = sundayElevenClients.ToList();
            }
            //воскресенье 12:00
            var sundayTwelve = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "12:00") && c.Day == "Sunday");
            var sundayTwelveClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "12:00") && c.Lesson.Day == "Sunday");
            if (sundayTwelve.FirstOrDefault() != null && sundayTwelveClients.FirstOrDefault() != null)
            {
                sundayTwelveDataGrid.ItemsSource = sundayTwelve.ToList();
                sundayTwelveClientsDataGrid.ItemsSource = sundayTwelveClients.ToList();
            }
            //воскресенье 13:00
            var sundayThirteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "13:00") && c.Day == "Sunday");
            var sundayThirteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "13:00") && c.Lesson.Day == "Sunday");
            if (sundayThirteen.FirstOrDefault() != null && sundayThirteenClients.FirstOrDefault() != null)
            {
                sundayThirteenDataGrid.ItemsSource = sundayThirteen.ToList();
                sundayThirteenClientsDataGrid.ItemsSource = sundayThirteenClients.ToList();
            }
            //воскресенье 14:00
            var sundayFourteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "14:00") && c.Day == "Sunday");
            var sundayFourteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "14:00") && c.Lesson.Day == "Sunday");
            if (sundayFourteen.FirstOrDefault() != null && sundayFourteenClients.FirstOrDefault() != null)
            {
                sundayFourteenDataGrid.ItemsSource = sundayFourteen.ToList();
                sundayFourteenClientsDataGrid.ItemsSource = sundayFourteenClients.ToList();
            }
            //воскресенье 15:00
            var sundayFifteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "15:00") && c.Day == "Sunday");
            var sundayFifteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "15:00") && c.Lesson.Day == "Sunday");
            if (sundayFifteen.FirstOrDefault() != null && sundayFifteenClients.FirstOrDefault() != null)
            {
                sundayFifteenDataGrid.ItemsSource = sundayFifteen.ToList();
                sundayFifteenClientsDataGrid.ItemsSource = sundayFifteenClients.ToList();
            }
            //воскресенье 16:00
            var sundaySixteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "16:00") && c.Day == "Sunday");
            var sundaySixteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "16:00") && c.Lesson.Day == "Sunday");
            if (sundaySixteen.FirstOrDefault() != null && sundaySixteenClients.FirstOrDefault() != null)
            {
                sundaySixteenDataGrid.ItemsSource = sundaySixteen.ToList();
                sundaySixteenClientsDataGrid.ItemsSource = sundaySixteenClients.ToList();
            }
            //воскресенье 17:00
            var sundaySeventeen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "17:00") && c.Day == "Sunday");
            var sundaySeventeenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "17:00") && c.Lesson.Day == "Sunday");
            if (sundaySeventeen.FirstOrDefault() != null && sundaySeventeenClients.FirstOrDefault() != null)
            {
                sundaySeventeenDataGrid.ItemsSource = sundaySeventeen.ToList();
                sundaySeventeenClientsDataGrid.ItemsSource = sundaySeventeenClients.ToList();
            }
            //воскресенье 18:00
            var sundayEighteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "18:00") && c.Day == "Sunday");
            var sundayEighteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "18:00") && c.Lesson.Day == "Sunday");
            if (sundayEighteen.FirstOrDefault() != null && sundayEighteenClients.FirstOrDefault() != null)
            {
                sundayEighteenDataGrid.ItemsSource = sundayEighteen.ToList();
                sundayEighteenClientsDataGrid.ItemsSource = sundayEighteenClients.ToList();
            }
            //воскресенье 19:00
            var sundayNineteen = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:00") && c.Day == "Sunday");
            var sundayNineteenClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:00") && c.Lesson.Day == "Sunday");
            if (sundayNineteen.FirstOrDefault() != null && sundayNineteenClients.FirstOrDefault() != null)
            {
                sundayNineteenDataGrid.ItemsSource = sundayNineteen.ToList();
                sundayNineteenClientsDataGrid.ItemsSource = sundayNineteenClients.ToList();
            }
            //воскресенье 19:30
            var sundayNineteenHalf = AppData.Context.Lesson.Where(c => (c.Date >= startDate && c.Date <= endDate) && (c.Time == "19:30") && c.Day == "Sunday");
            var sundayNineteenHalfClients = AppData.Context.ClientLesson.Where(c => (c.Lesson.Date >= startDate && c.Lesson.Date <= endDate) && (c.Lesson.Time == "19:30") && c.Lesson.Day == "Sunday");
            if (sundayNineteenHalf.FirstOrDefault() != null && sundayNineteenHalfClients.FirstOrDefault() != null)
            {
                sundayNineteenHalfDataGrid.ItemsSource = sundayNineteenHalf.ToList();
                sundayNineteenHalfClientsDataGrid.ItemsSource = sundayNineteenHalfClients.ToList();
            }
        }
    }


}
