using Domain.Entities.BaseEntity;

namespace Domain
{
    public class Order : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; } // Navigation property

        public string Address { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public Guid CartId { get; set; }
        public Cart Cart { get; set; }
    }
}
