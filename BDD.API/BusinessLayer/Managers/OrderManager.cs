using AutoMapper;
using BDD.API.BusinessLayer.Abstract;
using BDD.API.DataTransferObjects.Internal;
using BDD.API.Persistance.Abstract;

namespace BDD.API.BusinessLayer.Managers
{
    public class OrderManager : IOrderManager
    {
        private readonly IOrdersRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrderManager(IOrdersRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<List<OrderDto>> GetOrders()
        {
            var orders = await _orderRepository.GetOrders();
            var result = _mapper.Map<List<OrderDto>>(orders);
            return result;
        }
    }
}
