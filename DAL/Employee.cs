﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Personnumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;}



        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<Email> Emails { get; set; }
        public virtual ICollection<Telephone> Telephones { get; set; }



        public virtual ICollection<Mentorship> MentorFor { get; set; }
        public virtual ICollection<Mentorship> MentoredBy { get; set; }
    }
}
