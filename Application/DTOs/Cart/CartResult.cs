namespace Application.DTOs.Cart
{
    public class CartResult
    {
        public string CartCreated { get; set; }
    }
    public class CartExistsResult : CartResult
    {
        public string CartExists { get; set; }
    }
    public class CartErrorResult : CartResult
    {
        public string Error { get; set; }
    }

}
