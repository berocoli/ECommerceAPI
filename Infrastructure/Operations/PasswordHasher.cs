using System;
using Application.Operations;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace Infrastructure.Operations
{
    public static class PasswordHasher
    {
        // Şifreyi hashleme
        public static string HashPassword(string password)
        {
            // Rastgele bir salt oluşturma
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            // Şifreyi hashleme
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8
            ));

            // Salt ve hash'i birleştirerek döndürme
            return $"{Convert.ToBase64String(salt)}.{hashed}";
        }

        // Şifreyi doğrulama
        public static bool VerifyPassword(string enteredPassword, string storedHash)
        {
            // Salt ve hash'i ayırma
            var parts = storedHash.Split('.');
            if (parts.Length != 2)
            {
                throw new FormatException("Invalid stored hash format.");
            }

            var salt = Convert.FromBase64String(parts[0]);
            var storedPasswordHash = parts[1];

            // Girilen şifreyi hashleme
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: enteredPassword,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8
            ));

            // Girilen şifrenin hash'ini saklanan hash ile karşılaştırma
            return hashed == storedPasswordHash;
        }
    }
}
