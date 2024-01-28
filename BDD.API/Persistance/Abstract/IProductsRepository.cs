using BDD.API.Models;

namespace BDD.API.Persistance.Abstract
{
    public interface IProductsRepository
    {
        Task<List<Product>> GetProducts();
        Task<Product?> GetProductById(int id);
        Task<int> AddProduct(Product product);
        Task<int> DeleteProduct(Product product);
        Task<int> UpdateProduct(Product product);
    }
}
