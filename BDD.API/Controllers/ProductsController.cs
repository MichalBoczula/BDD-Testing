using BDD.API.BusinessLayer.Abstract;
using BDD.API.DataTransferObjects.Internal;
using BDD.API.Models;
using BDD.API.Persistance.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BDD.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsManager _productsManager;

        public ProductsController(IProductsManager productsManager)
        {
            this._productsManager = productsManager;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductDto>>> GetProducts()
        {
            var products = await _productsManager.GetProducts();
            return Ok(products);
        }
    }
}
