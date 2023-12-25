using BDD.API.Models;

namespace BDD.API.Persistance.Abstract
{
    public interface IProductsRepository
    {
        Task<List<Product>> GetProducts();
    }
}
