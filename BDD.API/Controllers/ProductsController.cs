using BDD.API.BusinessLayer.Abstract;
using BDD.API.DataTransferObjects.External;
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

        [HttpPost]
        public async Task<ActionResult<List<ProductDto>>> AddProduct([FromBody] CreateProductExternal product)
        {
            var products = await _productsManager.AddProduct(product);
            return Ok(products);
        }

        [HttpPut("/{id}")]
        public async Task<ActionResult<List<ProductDto>>> UpdateProduct([FromQuery] int id, [FromBody] UpdateProductExternal product)
        {
            var products = await _productsManager.UpdateProduct(id, product);
            return Ok(products);
        }

        [HttpDelete("/{id}")]
        public async Task<ActionResult<List<ProductDto>>> DeleteProduct([FromQuery] int id)
        {
            var products = await _productsManager.DeleteProduct(id);
            return Ok(products);
        }
    }
}
