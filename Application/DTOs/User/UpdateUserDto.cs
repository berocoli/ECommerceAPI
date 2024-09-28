using System;
namespace Application.DTOs
{
    public class UpdateUserDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public bool Role { get; set; }
    }
}


