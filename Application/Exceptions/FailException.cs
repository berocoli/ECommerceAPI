using System;
namespace Application.Exceptions
{
    public class FailException : Exception
    {
        public FailException() : base("Execution of operation failed.")
        {
        }
        public FailException(string message) : base($"Execution of operation failed. {message}")
        { 
        }
        public FailException(string message, Exception inner) : base($"Execution of operation failed. {message}", inner)
        {
        }
    }
}

