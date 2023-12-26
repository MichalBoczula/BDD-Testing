using AutoMapper;
using BDD.API.DataTransferObjects.Internal;
using BDD.API.Models;

namespace BDD.API.Mapping.Profiles
{
    public class ProductsProfile : Profile
    {
        public ProductsProfile()
        {
            CreateMap<Product, ProductDto>();
        }
    }
}
