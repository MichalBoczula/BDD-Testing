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
        private readonly IMapper _mapper;

        public ProductsManager(IProductsRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
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
            return result;
        }

        public async Task<bool> DeleteProduct(int id)
        {


            await _productRepository.DeleteProduct(null);
            return true;
        }

        public async Task<bool> UpdateProduct(int id, UpdateProductExternal productExternal)
        {
            var product = _mapper.Map<Product>(productExternal);
            await _productRepository.UpdateProduct(product);
            return true;
        }
    }
}
