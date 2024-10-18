using Domain;
using Domain.Entities;
using Domain.Entities.BaseEntity;

public class Cart : BaseEntity
{
    public Guid UserId { get; set; }
    public User User { get; set; }

    public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    public Guid? OrderId { get; set; }
    public Order? Order { get; set; }
}
