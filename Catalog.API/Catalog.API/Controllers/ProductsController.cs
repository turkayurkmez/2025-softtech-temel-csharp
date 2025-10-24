using Catalog.API.Models;
using Catalog.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
           // var productService = new ProductService();
            var products = productService.GetProducts();
            return Ok(products);
        }


    }
}
