﻿using DAL;
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






















        //public List<Employee> ListAllEmployees()
        //{
        //    using (var context = new StoreContext())
        //    {
        //        return context.Employees
        //            .ToList();
        //    }
        //}

        //public Employee GetEmployee(int EmployeeId)
        //{
        //    using (var context = new StoreContext())
        //    {
        //        return context.Employees.Find(EmployeeId);
        //    }
        //}

        //public void CreateEmployee(Employee employee)
        //{
        //    using (var context = new StoreContext())
        //    {
        //        context.Employees.Add(employee);
        //        context.SaveChanges();
        //    }
        //}

        //public void UpdateEmployee(Employee employee)
        //{
        //    using (var context = new StoreContext())
        //    {
        //        context.Update(employee);
        //        context.SaveChanges();
        //    }
        //}

        //public void DeleteEmployee(int employeeId)
        //{
        //    using (var context = new StoreContext())
        //    {
        //        var employee = context.Employees.First(e => e.EmployeeId == employeeId);
        //        context.Employees.Remove(employee);
        //        context.SaveChanges();
        //    }
        //}
    }
}
