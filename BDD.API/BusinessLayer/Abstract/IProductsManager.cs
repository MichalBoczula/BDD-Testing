using BDD.API.DataTransferObjects.Internal;
using BDD.API.Models;

namespace BDD.API.BusinessLayer.Abstract
{
    public interface IProductsManager
    {
        Task<List<ProductDto>> GetProducts();
    }
}
