using DAL;
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
                return context.Products.ToList();
                
            }
        }

        public void UpdateProduct(Product product)
        {
            using (var context = new StoreContext())
            {
                context.Update(product);
                context.SaveChanges();
            }
        }
    }
}
