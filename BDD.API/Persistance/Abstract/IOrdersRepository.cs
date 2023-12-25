using BDD.API.Models;

namespace BDD.API.Persistance.Abstract
{
    public interface IOrdersRepository
    {
        Task<List<Order>> GetOrders();
    }
}
