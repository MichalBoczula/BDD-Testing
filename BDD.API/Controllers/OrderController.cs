using BDD.API.Models;
using BDD.API.Persistance.Abstract;
using BDD.API.Persistance.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BDD.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrdersRepository _ordersRepository;

        public OrderController(IOrdersRepository ordersRepository)
        {
            this._ordersRepository = ordersRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetOrders()
        {
            var orders = await _ordersRepository.GetOrders();
            return Ok(orders);
        }
    }
}
