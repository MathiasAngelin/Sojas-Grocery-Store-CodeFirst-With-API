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
            var result = new List<ProductDTO>();
            var service = new ProductService(); 
            foreach (var product in service.ListProductNameAndStock())
            {
                result.Add(
                    new ProductDTO()
                    {
                        ProductName = product.ProductName,
                        NumberInStore = product.NumberInStore
                    }
                    );
            }
            return result;
        }

        [HttpPut("update")]
        public void UpdateProduct(int productId,int newProdcount)
        {
            var service = new ProductService();
            service.UpdateProduct(productId, newProdcount);
        }
    }
}
