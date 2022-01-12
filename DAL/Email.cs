using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Email
    {
        public int EmailId { get; set; }
        public string EmailAddress { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }

}
