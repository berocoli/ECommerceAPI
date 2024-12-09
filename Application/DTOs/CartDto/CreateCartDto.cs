namespace Application.DTOs
{
    public class CreateCartDto
    {
        public string UserId { get; set; }
        public bool IsModifyable { get; set; } = true;
    }

    public class CreateCartItemDto
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
