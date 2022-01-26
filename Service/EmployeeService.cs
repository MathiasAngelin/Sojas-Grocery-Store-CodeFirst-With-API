using DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class EmployeeService
    {

        public List<Employee> ListEmployeeWithResponsability()
        {
            using (var context = new StoreContext())
            {
               
                var res = context.Employees
                    .Include(x => x.Departments)
                    .ToList();
                return res;

            }
        }

        public int NumOfEmloyees()
        {
            using (var context = new StoreContext())
            {
                return context.Employees.Count();
            }
        }
      
    }
}
