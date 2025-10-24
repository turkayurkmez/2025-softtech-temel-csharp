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

        public Task<int> CreateNewAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public Task<List<Product>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetProductsByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsProductExists(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> SearchProductByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
