using DomainModels;
using System;

namespace WebShop_NULL.GraphQL.Dto
{
    public class ReviewDto
    {
        public int Id { get; set; }
        public ProductDto Product { get; set; }
        public UserDto User { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public DateTime Date { get; set; }
    }
}
