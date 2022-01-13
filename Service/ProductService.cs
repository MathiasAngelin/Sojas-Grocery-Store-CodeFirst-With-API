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
               
                return context.Products.OrderBy(p => p.NumberInStore).ToList();
                    
            }
        }

        public void UpdateProduct(int productid, int NewProdCount)
        {
            using (var context = new StoreContext())
            {
                var product = context.Products.First(p => p.ProductId == productid);
                product.NumberInStore = NewProdCount;
                context.SaveChanges();
            }
        }
    }
}
