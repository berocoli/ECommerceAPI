namespace Application.DTOs
{
    public class CreateCartDto
    {
        public string UserId { get; set; }        
    }

    public class CreateCartItemDto
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
