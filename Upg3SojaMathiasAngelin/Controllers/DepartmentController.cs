using Api.DTO;
using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;
using System.Linq;

namespace Api.Controllers
{
    [Route("departments")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        [HttpGet]
        public List<DepartmentEmailDTO> ListDepWithName()
        {
            var result = new List<DepartmentEmailDTO>();
            var service = new DepartmentService();
            foreach (var department in service.ListDepartmentAndName())
            {
                result.Add(
                    new DepartmentEmailDTO()
                    {
                        DeparmentName = department.Name,
                        Responsible = department.Employees.FirstName,
                        Emails = department.Employees.Emails.Select(m => m.EmailAddress).ToList()
                    });
                     
            }
            return result;
        }
    }
}
