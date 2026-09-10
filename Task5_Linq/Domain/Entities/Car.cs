namespace Task5_Linq.Domain.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string? Marka { get; set; } = default!;
        public string? Model { get; set; } = default!;
        public int Year { get; set; }
        public int Price { get; set; }
        public Color? Color { get; set; } //Enum verdim
        public bool IsNew { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; } = default!;
    }
}