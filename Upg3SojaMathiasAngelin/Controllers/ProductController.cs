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
        public virtual List<ProdWithNumConectToDepDTO> Listed(string department, int count)
        {
            var result = new List<ProdWithNumConectToDepDTO>();
            var service = new ProductService();  
            foreach(var product in service.Lista(department, count))
            {
                result.Add(
                    new ProdWithNumConectToDepDTO
                    {
                        ProductName = product.ProductName,
                        NumberInStore = product.NumberInStore,
                    });
            }
            return result;
        }

        [HttpPut("update")]
        public void UpdateThisProduct(UpdateProdWithCountDTO update)
        {
            int productid = 0;
            int newProdcount = 0;

            productid = update.productid;
            newProdcount = update.newProdcount;

            var service = new ProductService();
            service.UpdateProduct(productid, newProdcount);
        }
    }
}
