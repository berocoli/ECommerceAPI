namespace Application.DTOs.Cart
{
    public class UpdateCartDto
    {
        public string CartId { get; set; }
        public string UserId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
