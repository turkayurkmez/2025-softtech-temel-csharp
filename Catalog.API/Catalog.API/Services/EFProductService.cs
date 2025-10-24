using Catalog.API.Data;
using Catalog.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Catalog.API.Services
{
    public class EFProductService : IProductService
    {
        private readonly SampleDBContext sampleDBContext;

        public EFProductService(SampleDBContext sampleDBContext)
        {
            this.sampleDBContext = sampleDBContext;
        }

        public async Task<int> CreateNewAsync(Product product)
        {
            await sampleDBContext.Products.AddAsync(product);
            await sampleDBContext.SaveChangesAsync();
            return product.Id;
        }

        public async Task DeleteAsync(int id)
        {
            var product = await sampleDBContext.Products.FirstOrDefaultAsync(p => p.Id == id);
            sampleDBContext.Products.Remove(product);
            await sampleDBContext.SaveChangesAsync();
      
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await sampleDBContext.Products.FirstOrDefaultAsync(p => p.Id == id);
        }

        public List<Product> GetProducts()
        {
            return sampleDBContext.Products.ToList();
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await sampleDBContext.Products.ToListAsync();
        }

        public async Task<List<Product>> GetProductsByCategory(int categoryId)
        {
            return await sampleDBContext.Products
                .Where(p => p.CategoryId == categoryId)
                .ToListAsync();
        }

        public async Task<bool> IsProductExists(int productId)
        {
            return await  sampleDBContext.Products.AnyAsync(p => p.Id == productId);
        }

        public async Task<List<Product>> SearchProductByNameAsync(string name)
        {
            return await sampleDBContext.Products.Where(p => p.Name.Contains(name))
                                                  .ToListAsync();
        }

        public async Task UpdateAsync(Product product)
        {
            sampleDBContext.Products.Update(product);
            await sampleDBContext.SaveChangesAsync();
        }
    }
}
