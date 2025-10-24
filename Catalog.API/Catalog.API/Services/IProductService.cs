using Catalog.API.Models;

namespace Catalog.API.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
