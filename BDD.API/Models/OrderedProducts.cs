namespace BDD.API.Models
{
    public class OrderedProducts
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order OrderRef { get; set; }
        public int ProductId { get; set; }
        public Product ProductRef { get; set; }
    }
}
