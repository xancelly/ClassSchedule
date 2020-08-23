using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSchedule.Entities
{
    public partial class TeacherDayOfWeek 
    {
        public DateTime getStartTime
        {
            get
            {
                return Convert.ToDateTime($"{Properties.Settings.Default.dateStart} {StartTimeWork}:00");
            }
        }

        public DateTime getEndTime
        {
            get
            {
                return Convert.ToDateTime($"{Properties.Settings.Default.dateStart} {EndTimeWork}:00");
            }
        }
    }
}
