using System.ComponentModel.DataAnnotations.Schema;
using Domain;
using Domain.Entities;
using Domain.Entities.BaseEntity;

namespace Domain
{
    public class Cart : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }

        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

        public bool IsModifyable { get; set; } = true;
        public string Note { get; set; }

        public Guid? OrderId { get; set; }
        public Order? Order { get; set; }
    }
}