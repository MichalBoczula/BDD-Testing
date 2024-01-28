using BDD.API.BusinessLayer.Abstract;
using BDD.API.Models;
using BDD.API.Persistance.Abstract;

namespace BDD.API.BusinessLayer.Validators
{
    public class ProductsValidator : IProductsValidator
    {
        private readonly IProductsRepository _productRepository;

        public ProductsValidator(IProductsRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<(bool IsExists, Product? product)> CheckIfProductExist(int id)
        {
            var product = await _productRepository.GetProductById(id);

            if(product == null)
            {
                return (false, null);
            } 
            else
            {
                return(true, product);
            }
        }
    }
}
