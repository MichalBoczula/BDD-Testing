using BDD.API.Models;

namespace BDD.API.BusinessLayer.Abstract
{
    public interface IProductsValidator
    {
        Task<(bool IsExists, Product? product)>CheckIfProductExist(int id);
    }
}
