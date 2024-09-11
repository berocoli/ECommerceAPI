using System;
namespace Application.Exceptions
{
    public class SeedNotPlantedException : Exception
    {
        public SeedNotPlantedException() : base("Database seed insertion failed.")
        {
        }
        public SeedNotPlantedException(string? message) : base($"Database seed insertion failed. {message}")
        {
        }
        public SeedNotPlantedException(string? message, Exception? inner) : base($"Database seed insertion failed. {message}", inner)
        {
        }
    }
}

