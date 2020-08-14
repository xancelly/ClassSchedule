using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSchedule.Entities
{
    public partial class Client
    {
        public string fullnameClient
        {
            get
            {
                return LastName + " " + FirstName + " " + MiddleName;
            }
        }
    }
}
