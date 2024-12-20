using Domain.Enums;

namespace Application.DTOs
{
    public class CreateUserDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public UserCountry UserCountry {get; set;}
        public PaymentCurrency PaymentCurrency { get; set; }
    }
}

