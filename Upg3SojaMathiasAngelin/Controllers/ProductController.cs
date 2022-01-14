using Api.DTO;
using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace Api.Controllers
{


    [Route("products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("count")]
        public List<ProductDTO> ListProductNAndS()
        {
            string prodstatus = "";
            var result = new List<ProductDTO>();
            var service = new ProductService(); 
            foreach (var product in service.ListProductNameAndStock())
            {
                if (product.NumberInStore > 3)
                    prodstatus = "Ok";
                else if (product.NumberInStore < 1)
                    prodstatus = "Slut";
                else prodstatus = "Snart slut";

                result.Add(
                    new ProductDTO()
                    {
                        ProductName = product.ProductName,
                        NumberInStore = product.NumberInStore,
                        status = prodstatus
                    }
                    );
            }
            return result;
        }


        [HttpGet("list")]
        public List<Product> Listed(string department, int count)
        {
            var result = new List<ProductDTO>();
            var service = new ProductService();
            foreach (var product in service.ListProductNameAndStock())
            {
                result.Add(
                    new ProductDTO()
                    {
                        ProductName = product.ProductName,
                        NumberInStore = product.NumberInStore,
                        status = "Hej"
                    }
                    );
            }
           
            return service.List(department,count);
           
        }

        [HttpPut("update")]
        public void UpdateProduct(int productId,int newProdcount)
        {
            var service = new ProductService();
            service.UpdateProduct(productId, newProdcount);
        }
    }
}
