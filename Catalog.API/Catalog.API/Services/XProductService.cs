using Catalog.API.Models;

namespace Catalog.API.Services
{
    public class XProductService : IProductService
    {
        private List<Product> products = new List<Product>()
              {
                new(){ Id=10, Name="Ürün X", Price=25},
                new(){ Id=20, Name="Ürün B", Price=35},

              };
        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
