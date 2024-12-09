namespace Application.DTOs.CartDto
{
    public class UpdateCartDto
    {
        public string UserId { get; set; }
        public string CartId { get; set; }        
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
