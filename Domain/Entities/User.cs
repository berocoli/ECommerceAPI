using Domain.Entities.BaseEntity;
using Domain.Enums;

namespace Domain
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }

        public UserCountry Country { get; set; }

        public bool Role { get; set; }

        public PaymentCurrency PaymentCurrency { get; set; }

        public ICollection<Order>? Orders { get; set; } // Navigation property
        public ICollection<Cart>? Cart { get; set; } // Navigation property (one-to-one relationship)
    }
}
