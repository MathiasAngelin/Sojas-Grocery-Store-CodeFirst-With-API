using DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductService
    {
        public List<Product> ListProductNameAndStock()
        {
            using (var context = new StoreContext())
            {
                return context.Products.OrderBy(p => p.NumberInStore).ToList();
            }
        }

        public List<Product> Lista(string depName, int maxcount)
        {
            var result = new List<Product>();
            using (var context = new StoreContext())
            {
                int DepInt = 0;
                var DepPlaceHold = context.Departments
                    .Where(d => d.Name == depName)
                    ;

                DepInt = DepPlaceHold.Select(d => d.DepartmentId).FirstOrDefault();
                var departprod = context.DepartmentProducts
                    .Where(d => d.DepartmentId == DepInt)
                    .ToList();

                foreach (var item in departprod)
                {
                    List<Product> productFilter = context.Products
                        .Where(x => x.Barcode == item.ProductId)
                        .Where(p => p.NumberInStore <= maxcount)
                        .ToList();

                    foreach (Product Product in productFilter)
                        result.Add(new Product
                        {
                            Barcode = Product.Barcode,
                            ProductName = Product.ProductName,
                            NumberInStore = Product.NumberInStore,
                            ListOfIngredients = Product.ListOfIngredients,
                            Price = Product.Price,
                            ExpirationDate = Product.ExpirationDate,
                            DateOfLastCheck = Product.DateOfLastCheck,
                            CampainId = Product.CampainId,
                            PartOfCampain = Product.PartOfCampain,
                            DepartmentProduct = Product.DepartmentProduct,
                            EmployeeId = Product.EmployeeId,
                            Employees = Product.Employees,

                        });
                }
                return result;
            }
        }

        public void UpdateProduct(int productid, int newProdcount)
        {
            using (var context = new StoreContext())
            {
                var product = context.Products.First(p => p.Barcode == productid);
                product.NumberInStore = newProdcount;
                context.SaveChanges();
            }
        }
    }
}
