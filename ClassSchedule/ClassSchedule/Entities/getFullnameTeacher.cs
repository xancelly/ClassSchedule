using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSchedule.Entities
{
    public partial class Teacher
    {
        public string fullnameTeacher
        {
            get
            {
                return LastName + " " + FirstName + " " + MiddleName;
            }
        }
    }
}
