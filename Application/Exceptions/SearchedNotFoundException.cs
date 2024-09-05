using System;
namespace Application.Exceptions
{
    public class SearchedNotFoundException : Exception
    {
        public SearchedNotFoundException() : base("Could not find the content you were looking for.")
        {
        }
        public SearchedNotFoundException(string? message) : base(message)
        {
        }
        public SearchedNotFoundException(string? message, Exception inner) : base(message, inner)
        {
        }
    }
}

