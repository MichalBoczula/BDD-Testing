using BDD.API.DataTransferObjects.Internal;

namespace BDD.API.BusinessLayer.Abstract
{
    public interface IOrderManager
    {
        Task<List<OrderDto>> GetOrders();
    }
}
