using System;
namespace Application.DTOs.Token
{
    public class TokenModel
    {
        public string Access { get; set; }
        // public string RefreshToken { get; set; }
        public DateTime Expiration { get; set; } 
    }
}

