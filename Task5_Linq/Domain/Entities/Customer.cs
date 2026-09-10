using Task5_Linq.Domain.Entities;

public class Customer
{
    public Customer()
    {
        Car = new List<Car>();
    }

    public int Id { get; set; }
    public string? FullName { get; set; } = default!;
    public string? Phone { get; set; }= default!;
    public string? Email { get; set; }= default!;
    public virtual ICollection<Car>? Car { get; set; }
}