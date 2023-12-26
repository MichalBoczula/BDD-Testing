using BDD.API.Models;

namespace BDD.API.DataTransferObjects.Internal
{
    public class OrderDto
    {
        public int Id { get; set; }
        public Guid Identifier { get; set; }
        public string? Name { get; set; }
        public List<OrderedProductsDto> OrderedProductsDtoList { get; set; }
    }
}
