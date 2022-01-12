using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }



        public ICollection<DepartmentProduct> DepartmentProduct { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employees { get; set; }
    }
}
