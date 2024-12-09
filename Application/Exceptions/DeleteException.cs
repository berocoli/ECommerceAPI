using System;
namespace Application.Exceptions
{
    public class DeleteException : Exception
    {
        public DeleteException() : base("Delete exec failed.")
        {
        }
        public DeleteException(string message) : base($"Delete exec failed. {message}")
        {
        }
        public DeleteException(string message, Exception inner) : base($"Delete exec failed. {message}", inner)
        {
        }
    }
}

