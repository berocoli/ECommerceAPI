using Domain;
using Domain.Entities.BaseEntity;

public class Cart : BaseEntity
{
    public Guid UserId { get; set; }
    public User User { get; set; }

    public ICollection<Product> Product { get; set; }

    public Guid? OrderId { get; set; }
    public Order? Order { get; set; } 

    public int Quantity { get; set; }
}
