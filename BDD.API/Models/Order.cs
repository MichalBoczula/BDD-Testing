namespace BDD.API.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Guid Identifier { get; set; }
        public string? Name { get; set; }
        public List<OrderedProducts> OrderedProductsList { get; set; }
    }
}
