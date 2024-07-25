using Domain.Entities.BaseEntity;

namespace Domain
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}

