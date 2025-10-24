using Catalog.API.Models;

namespace Catalog.API.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProductsAsync();
        Task<List<Product>> SearchProductByNameAsync(string name);
        Task<List<Product>> GetProductsByCategory(int categoryId);
        Task<Product> GetProductByIdAsync(int id);

        Task<bool> IsProductExists(int productId);

        Task<int> CreateNewAsync(Product product);
        Task DeleteAsync(int id);
        Task UpdateAsync(Product product);





    }
}
