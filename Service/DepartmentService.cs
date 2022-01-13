using DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class DepartmentService
    {
        public List<Department> ListDepartmentAndName()
        {
            using (var context = new StoreContext())
            {
                return context.Departments
                    .Include(x => x.Employees)
                    .ThenInclude(x => x.Emails)
                    .ToList();

            }
        }
    }
}
