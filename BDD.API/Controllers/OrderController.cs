using BDD.API.BusinessLayer.Abstract;
using BDD.API.DataTransferObjects.Internal;
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
        private readonly IOrderManager _ordersManager;

        public OrderController(IOrderManager ordersManager)
        {
            _ordersManager = ordersManager;
        }

        [HttpGet]
        public async Task<ActionResult<List<OrderDto>>> GetOrders()
        {
            var orders = await _ordersManager.GetOrders();
            return Ok(orders);
        }
    }
}
