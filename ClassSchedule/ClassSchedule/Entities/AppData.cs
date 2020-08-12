using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSchedule.Entities
{
    class AppData
    {
        public static ClassScheduleEntities Context
        {
            get; set;
        } = new ClassScheduleEntities();
    }
}
