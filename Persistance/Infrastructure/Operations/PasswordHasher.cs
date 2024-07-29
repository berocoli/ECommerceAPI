using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace Infrastructure.Operations
{
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            byte[] salt = new byte[128 / 8]; // 128-bit salt
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt); // Correctly use the GetBytes method
            }

            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8
            ));
            return hashed;
        }
    }
}
