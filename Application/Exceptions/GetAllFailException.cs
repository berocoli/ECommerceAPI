using System;
namespace Application.Exceptions
{
    public class GetAllFailException : Exception
    {
        public GetAllFailException() : base()
        {
        }
        public GetAllFailException(string message) : base($"Get All request failed. {message}")
        {
        }
        public GetAllFailException(string message, Exception inner) : base($"Get All request failed. {message}", inner)
        {
        }
    }
}

