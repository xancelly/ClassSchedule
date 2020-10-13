using ClassSchedule.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для testPage.xaml
    /// </summary>
    public partial class testPage : Page
    {
        TimeSpan[] time;
        string[] day;
        Teacher CurrentTeacher = null;
        public testPage()
        {
            InitializeComponent();

            teacherComboBox.ItemsSource = AppData.Context.Teacher.Where(c => c.IsDeleted == false).ToList();

            time = new TimeSpan[] { TimeSpan.Parse("09:00"), TimeSpan.Parse("09:30"), TimeSpan.Parse("10:00"), TimeSpan.Parse("10:30"), TimeSpan.Parse("11:00"), TimeSpan.Parse("11:30"), TimeSpan.Parse("12:00"), TimeSpan.Parse("12:30"), TimeSpan.Parse("13:00"), TimeSpan.Parse("13:30"), TimeSpan.Parse("14:00"), TimeSpan.Parse("14:30"), TimeSpan.Parse("15:00"), TimeSpan.Parse("15:30"), TimeSpan.Parse("16:00"), TimeSpan.Parse("16:30"), TimeSpan.Parse("17:00"), TimeSpan.Parse("17:30"), TimeSpan.Parse("18:00"), TimeSpan.Parse("18:30"), TimeSpan.Parse("19:00"), TimeSpan.Parse("19:30"), TimeSpan.Parse("20:00"), TimeSpan.Parse("20:30"), TimeSpan.Parse("21:00"), TimeSpan.Parse("21:30") };
            day = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
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
                DateTime CurrentDate = startDate;

                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = @"data source=DESKTOP-SJAS45C;initial catalog=ClassSchedule;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework;";
                    try
                    {
                        connection.Open();
                        for (int i = 0; i < day.Length; i++)
                        {
                            string CurrentDay = day[i];
                            for (int j = 0; j < time.Length; j++)
                            {
                                TimeSpan CurrentTime = time[i];
                                var IdTextBlock = (TextBlock)this.FindName($"{CurrentDay}{CurrentTime.ToString().Remove(2, 1).Remove(4, 3)}Id");
                                IdTextBlock.Text = "";
                                var TypeLessonTextBlock = (TextBlock)this.FindName($"{CurrentDay}{CurrentTime.ToString().Remove(2, 1).Remove(4, 3)}TypeLesson");
                                TypeLessonTextBlock.Text = "";
                                var LessonTimeTextBlock = (TextBlock)this.FindName($"{CurrentDay}{CurrentTime.ToString().Remove(2, 1).Remove(4, 3)}LessonTime");
                                LessonTimeTextBlock.Text = "";
                                var PaidTextBlock = (TextBlock)this.FindName($"{CurrentDay}{CurrentTime.ToString().Remove(2, 1).Remove(4, 3)}Paid");
                                PaidTextBlock.Text = "";
                                var AttendanceTextBlock = (TextBlock)this.FindName($"{CurrentDay}{CurrentTime.ToString().Remove(2, 1).Remove(4, 3)}Attendance");
                                AttendanceTextBlock.Text = "";
                                using (SqlCommand cmd = new SqlCommand("GetLesson", connection))
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    // Входной параметр.
                                    SqlParameter param = new SqlParameter();
                                    param.ParameterName = "@Date";
                                    param.SqlDbType = SqlDbType.DateTime;
                                    param.Value = CurrentDate;
                                    param.Direction = ParameterDirection.Input;
                                    cmd.Parameters.Add(param);

                                    param = new SqlParameter();
                                    param.ParameterName = "@Time";
                                    param.SqlDbType = SqlDbType.Time;
                                    param.Value = CurrentTime;
                                    param.Direction = ParameterDirection.Input;
                                    cmd.Parameters.Add(param);

                                    param = new SqlParameter();
                                    param.ParameterName = "@Teacher";
                                    param.SqlDbType = SqlDbType.Int;
                                    param.Value = CurrentTeacher.Id;
                                    param.Direction = ParameterDirection.Input;
                                    cmd.Parameters.Add(param);

                                    // Выходной параметр.
                                    param = new SqlParameter();
                                    param.ParameterName = "@IdLesson";
                                    param.SqlDbType = SqlDbType.NVarChar;
                                    param.Size = 10;
                                    param.Direction = ParameterDirection.Output;
                                    cmd.Parameters.Add(param);

                                    param = new SqlParameter();
                                    param.ParameterName = "@Count";
                                    param.SqlDbType = SqlDbType.NVarChar;
                                    param.Size = 10;
                                    param.Direction = ParameterDirection.Output;
                                    cmd.Parameters.Add(param);

                                    param = new SqlParameter();
                                    param.ParameterName = "@LessonTime";
                                    param.SqlDbType = SqlDbType.NVarChar;
                                    param.Size = 10;
                                    param.Direction = ParameterDirection.Output;
                                    cmd.Parameters.Add(param);

                                    param = new SqlParameter();
                                    param.ParameterName = "@TypeLesson";
                                    param.SqlDbType = SqlDbType.NVarChar;
                                    param.Size = 10;
                                    param.Direction = ParameterDirection.Output;
                                    cmd.Parameters.Add(param);

                                    param = new SqlParameter();
                                    param.ParameterName = "@IsPaid";
                                    param.SqlDbType = SqlDbType.NVarChar;
                                    param.Size = 10;
                                    param.Direction = ParameterDirection.Output;
                                    cmd.Parameters.Add(param);

                                    param = new SqlParameter();
                                    param.ParameterName = "@IsAttendance";
                                    param.SqlDbType = SqlDbType.NVarChar;
                                    param.Size = 10;
                                    param.Direction = ParameterDirection.Output;
                                    cmd.Parameters.Add(param);

                                    // Выполнение хранимой процедуры.
                                    cmd.ExecuteNonQuery();
                                    // Возврат выходного параметра.
                                    if (!DBNull.Value.Equals(cmd.Parameters["@IdLesson"].Value) && !DBNull.Value.Equals(cmd.Parameters["@TypeLesson"].Value) && !DBNull.Value.Equals(cmd.Parameters["@LessonTime"].Value) && !DBNull.Value.Equals(cmd.Parameters["@IsPaid"].Value) && !DBNull.Value.Equals(cmd.Parameters["@IsAttendance"].Value) && !DBNull.Value.Equals(cmd.Parameters["@Count"].Value))
                                    {
                                        IdTextBlock.Text = ((string)cmd.Parameters["@IdLesson"].Value).Trim();
                                        TypeLessonTextBlock.Text = ((string)cmd.Parameters["@TypeLesson"].Value).Trim();
                                        LessonTimeTextBlock.Text = ((string)cmd.Parameters["@LessonTime"].Value).Trim();
                                        PaidTextBlock.Text = $"{((string)cmd.Parameters["@IsPaid"].Value).Trim()}/{((string)cmd.Parameters["@Count"].Value).Trim()}";
                                        AttendanceTextBlock.Text = $"{((string)cmd.Parameters["@IsAttendance"].Value).Trim()}/{((string)cmd.Parameters["@Count"].Value).Trim()}";
                                    }

                                }
                            }
                            CurrentDate.AddDays(1);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }


        private void showLesson(object sender, MouseButtonEventArgs e)
        {
            //int ItemId = Int32.Parse(((TextBlock)this.FindName($"{((ListViewItem)((ListView)sender).SelectedItem).Name}Id")).Text);
            //Lesson CurrentLesson = AppData.Context.Lesson.Where(c => c.Id == ItemId).FirstOrDefault();
            //if (CurrentLesson != null)
            //{
                
            //}
        }

        private void teacherComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CurrentTeacher = teacherComboBox.SelectedItem as Teacher;
            updateData();
        }

        private void scheduleCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            updateData();
        }
    }
}
