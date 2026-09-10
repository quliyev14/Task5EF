namespace Task5_Linq.Domain.Entities
{
    public class Sale
    {
        public int Id { get; set; }
        public int SalesPrice { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime? SaleDate { get; set; }
    }
}

