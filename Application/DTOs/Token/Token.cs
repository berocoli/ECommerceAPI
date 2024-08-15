using System;
namespace Application.DTOs.Token
{
    public class Token
    {
        public string Access { get; set; }
        public DateTime Expiration { get; set; }
        public string RefreshToken { get; set; }
    }
}

