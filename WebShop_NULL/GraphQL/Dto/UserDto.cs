using DomainModels;
using System.Collections.Generic;

namespace WebShop_NULL.GraphQL.Dto
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public int ImageId { get; set; }
        public ImageMetadata ImageMetadata { get; set; }
        public UserRole Role { get; set; }
        public decimal TotalPayment { get; set; }
        public ICollection<ShoppingCartEntryDto> Basket { get; set; }
        public bool IsConfirmed { get; set; } 
    }
}
