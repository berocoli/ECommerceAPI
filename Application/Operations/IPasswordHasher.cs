using System;
namespace Application.Operations
{
    public interface IPasswordHasher
    {
        string HashPassword(string password);
    }
}