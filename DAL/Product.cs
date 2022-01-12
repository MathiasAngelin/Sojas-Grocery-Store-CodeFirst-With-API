using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ListOfIngredients { get; set; }
        public DateTime ExpirationDate { get; set; }
        public float Price { get; set; }

        public int NumberInStore { get; set; }



        public ICollection<DepartmentProduct> DepartmentProduct { get; set; }
        public DateTime DateOfLastCheck { get; set; }

        public int? EmployeeId { get; set; }
        public Employee? Employees { get; set; }

        public int? CampainId { get; set; }
        public Campain? PartOfCampain { get; set; }
    }
}
