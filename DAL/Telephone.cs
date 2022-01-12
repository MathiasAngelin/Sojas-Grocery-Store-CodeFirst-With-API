using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Telephone
    {
        public int TelephoneId { get; set; }
        public string PhoneNumber { get; set; }




        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
