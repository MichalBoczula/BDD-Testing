using BDD.API.Models;
using BDD.API.Persistance.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BDD.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsRepository _productsRepository;

        public ProductsController(IProductsRepository productsRepository)
        {
            this._productsRepository = productsRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _productsRepository.GetProducts();
            return Ok(products);
        }
    }
}
