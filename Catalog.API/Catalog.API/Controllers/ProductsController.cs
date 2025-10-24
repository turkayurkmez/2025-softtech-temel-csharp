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
        public async Task<IActionResult> GetProductsAsync()
        {
           // var productService = new ProductService();
            var products = await productService.GetProductsAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await productService.GetProductByIdAsync(id);
            return Ok(product);
        }

        [HttpGet("[action]/{name}")]
        public async Task<IActionResult> Search(string name)
        {
            var products = await productService.SearchProductByNameAsync(name);
            return Ok(products);

        }

        [HttpGet("[action]/{id:int}")]
        public async Task<IActionResult> GetByCategory(int id)
        {
            var products = await productService.GetProductsByCategory(id);
            return Ok(products);

        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {
              var createdProductId =  await productService.CreateNewAsync(product);
                return CreatedAtAction(nameof(GetProduct), routeValues: new { id = createdProductId },value: product);

            }

            return BadRequest();

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Product product)
        {
            if (await productService.IsProductExists(id))
            {
                if (ModelState.IsValid)
                {
                    await productService.UpdateAsync(product);
                    return Ok();
                }
                return BadRequest();
            }

            return NotFound(new { Reason = "Güncellenecek ürün db'de bulunamadı" });


        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await productService.DeleteAsync(id);
            return Ok();
        }






    }
}
