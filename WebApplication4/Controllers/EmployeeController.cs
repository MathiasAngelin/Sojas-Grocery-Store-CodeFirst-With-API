using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;
using Upg3SojaMathiasAngelin.DTO;


namespace Upg3SojaMathiasAngelin.Controllers
{
    [Route("person")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public List<Employee> List()
        {
            var service = new EmployeeService();
            return service.ListAllEmployees();
        }

        //Lägger till "Person/{Id PÅ employee}"
        [HttpGet("{EmployeeID}")]
        public Employee GetEmployee(int EmployeeId)
        {
            var service = new EmployeeService();
            return service.GetEmployee(EmployeeId);
        }

        [HttpPost]
        public void Create(EmployeeDTO employee)
        {
            var service = new EmployeeService();
            service.CreateEmployee(
                new Employee()
                {
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    Personnumber = employee.Personnumber
                });
        }

        [HttpPut("{EmployeeId")]
        public void Update(int employeeid, EmployeeDTO employee)
        {
            var service = new EmployeeService();
            service.UpdateEmployee(
                new Employee()
                {
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    Personnumber = employee.Personnumber
                });
        }

        [HttpDelete("{EmployeeId}")]
        public void Delete(int employeeId)
        {
            var service = new EmployeeService();
            service.DeleteEmployee(employeeId);
                
        }

    }
}
