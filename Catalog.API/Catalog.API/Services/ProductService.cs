using Catalog.API.Models;

namespace Catalog.API.Services
{
    public class ProductService : IProductService
    {
        private List<Product> products = new List<Product>()
              {
                new(){ Id=1, Name="Ürün A", Price=5},
                new(){ Id=2, Name="Ürün B", Price=15},

              };

        public List<Product> GetProducts() => products;

    }
}
