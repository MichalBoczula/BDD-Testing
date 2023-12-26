using AutoMapper;
using BDD.API.DataTransferObjects.Internal;
using BDD.API.Models;

namespace BDD.API.Mapping.Profiles
{
    public class OrdersProfile : Profile
    {
        public OrdersProfile()
        {
            CreateMap<Order, OrderDto>()
                .ForMember(
                    dest => dest.OrderedProductsDtoList,
                    opt => opt.MapFrom(src => src.OrderedProductsList));
            CreateMap<OrderedProducts, OrderedProductsDto>();
        }
    }
}
