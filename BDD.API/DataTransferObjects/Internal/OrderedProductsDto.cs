using BDD.API.Models;

namespace BDD.API.DataTransferObjects.Internal
{
    public class OrderedProductsDto
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
