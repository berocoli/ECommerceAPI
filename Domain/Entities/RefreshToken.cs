using Domain.Entities.BaseEntity;
namespace Domain
{
    public class RefreshToken : BaseEntity
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public string UserId { get; set; }
        public DateTime Expires { get; set; }
        public bool IsRevoked { get; set; }
        public DateTime CreatedAt { get; set; } 
        public string ReplacedByToken { get; set; }

        public User User { get; set; }
    }
}
