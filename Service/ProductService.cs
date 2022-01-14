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

        public List<Product> List(string department, int count)
        {
            using (var context = new StoreContext())
            {
                //var depname = context.Products.Select(p => p.DepartmentProduct.Select(p => p.Department.Name == department));
                //var prodcount = context.Products.Select(p => p.NumberInStore == count);

                return context.Products
                    .Where(p => p.NumberInStore <= count)
                    .ToList();
            }
        }



        public void UpdateProduct(int productid, int NewProdCount)
        {
            using (var context = new StoreContext())
            {
                var product = context.Products.First(p => p.Barcode == productid);
                product.NumberInStore = NewProdCount;
                context.SaveChanges();
            }
        }
    }
}
