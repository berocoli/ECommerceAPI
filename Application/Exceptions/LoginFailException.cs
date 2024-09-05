using System;
namespace Application.Exceptions
{
    public class LoginFailException : Exception
    {
        public LoginFailException() : base("Login failed.")
        {
        }
        public LoginFailException(string? message) : base(message)
        {
        }
        public LoginFailException(string? message, Exception inner) : base(message, inner)
        {
        }
     }
}

