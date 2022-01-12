using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace Api.Controllers
{

        //Skapa en controller för hantering av produkter.Controller:n ska mappa mot /products.
        //a.Skapa en endpoint som listar alla produkters namn och antal i lager.Listan ska vara
        //sorterad på antal i lager med lägst värde först.Mappa endpoint:en mot
        ///products/count.
        //b.Skapa en endpoint som uppdaterar antalet produkter kvar i butiken för en viss
        //produkt. Mappa endpoint:en mot /products/update.Endpoint:en ska ta emot
        //ett request-objekt som innehåller information om vilken produkt som ska
        //uppdateras som det nya antalet för den produkten.
        //Exempel på request-objekt:
        //{
        //”ProductId”: 13,
        //”NewCount”



    [Route("products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("count")]
        public List<Product> ListProductNAndS(string prodname, int instock)
        {
            var service = new ProductService();
            return service.ListProductNameAndStock();
        }

        [HttpPut("update")]
        public void UpdateProduct(int productId, Product product)
        {
          
        }
    }
}
