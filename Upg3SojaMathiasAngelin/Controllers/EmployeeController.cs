using Api.DTO;
using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;
using Upg3SojaMathiasAngelin.DTO;

namespace Upg3SojaMathiasAngelin.Controllers
{

    [Route("Employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public List<ComplexEmployeeWCountDTO> ListDepWithResponsability2()
        {
            var ResultFromDTO1 = new List<ComplexEmployeeDTO>();
            var service = new EmployeeService();
            var numOfEmployees = service.NumOfEmloyees();

            foreach (var employee in service.ListEmployeeWithResponsability())
            {

                ResultFromDTO1.Add(
                    new ComplexEmployeeDTO()
                    {
                        Name = $"{employee.FirstName} {employee.LastName}",
                        IsResponsible = employee.Departments.Count != 0 ? true : false,

                    });
            }

            var NestedResults = new List<ComplexEmployeeWCountDTO>();
            NestedResults.Add(
                new ComplexEmployeeWCountDTO()
                {
                    NumOfEmployees = numOfEmployees,
                    Employees = ResultFromDTO1

                });

            return NestedResults;
        }

    }

}

