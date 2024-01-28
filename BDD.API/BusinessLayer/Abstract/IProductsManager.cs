using BDD.API.DataTransferObjects.External;
using BDD.API.DataTransferObjects.Internal;
using BDD.API.Models;

namespace BDD.API.BusinessLayer.Abstract
{
    public interface IProductsManager
    {
        Task<int> AddProduct(CreateProductExternal product);
        Task<bool> DeleteProduct(int id);
        Task<List<ProductDto>> GetProducts();
        Task<bool> UpdateProduct(int id, UpdateProductExternal product);
    }
}
