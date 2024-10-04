using System;

namespace Application.DTOs
{
    public class GetCartsDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public List<GetCartItemsDto> CartItems { get; set; }
    }
}


