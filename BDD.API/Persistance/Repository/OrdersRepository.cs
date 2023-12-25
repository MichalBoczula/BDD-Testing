using BDD.API.Models;
using BDD.API.Persistance.Abstract;
using BDD.API.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace BDD.API.Persistance.Repository
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly BddContext _context;

        public OrdersRepository(BddContext context)
        {
            _context = context;
        }

        public async Task<List<Order>> GetOrders()
        {
            return await _context.Orders.Include(x => x.OrderedProductsList).ToListAsync();
        }
    }
}
