using AutoMapper;
using BDD.API.BusinessLayer.Abstract;
using BDD.API.DataTransferObjects.External;
using BDD.API.DataTransferObjects.Internal;
using BDD.API.Models;
using BDD.API.Persistance.Abstract;

namespace BDD.API.BusinessLayer.Managers
{
    public class ProductsManager : IProductsManager
    {
        private readonly IProductsRepository _productRepository;
        private readonly IProductsValidator _productValidator;
        private readonly IMapper _mapper;

        public ProductsManager(IProductsRepository productRepository, IMapper mapper, IProductsValidator productValidator)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _productValidator = productValidator;
        }

        public async Task<List<ProductDto>> GetProducts()
        {
            var products = await _productRepository.GetProducts();
            var result = _mapper.Map<List<ProductDto>>(products);
            return result;
        }

        public async Task<int> AddProduct(CreateProductExternal productExternal)
        {
            var product = _mapper.Map<Product>(productExternal);
            var result = await _productRepository.AddProduct(product);
            return product.Id;
        }

        public async Task<bool> DeleteProduct(int id)
        {
            var result = await _productValidator.CheckIfProductExist(id);
            if (result.IsExists && result.product != null)
            {
                await _productRepository.DeleteProduct(result.product);
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateProduct(int id, UpdateProductExternal productExternal)
        {
            var result = await _productValidator.CheckIfProductExist(id);
            if (result.IsExists && result.product != null)
            {
                result.product.Price = productExternal.Price;
                result.product.Name = productExternal.Name;

                await _productRepository.UpdateProduct(result.product);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
