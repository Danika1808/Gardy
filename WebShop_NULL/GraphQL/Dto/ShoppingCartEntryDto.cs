namespace WebShop_NULL.GraphQL.Dto
{
    public class ShoppingCartEntryDto
    {
        public int Id { get; set; }
        public ProductDto Product { get; set; }
        public UserDto User { get; set; }
        public int Quantity { get; set; }
    }
}
