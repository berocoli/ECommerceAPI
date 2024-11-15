using System;
namespace Application.Exceptions
{
    public class GetRequestFailedException : Exception
    {
        public GetRequestFailedException() : base()
        {
        }
        public GetRequestFailedException(string message) : base($"Get request failed. {message}")
        {

        }
        public GetRequestFailedException(string message, Exception inner) : base($"Get request failed. {message}", inner)
        {

        }
    }
}

