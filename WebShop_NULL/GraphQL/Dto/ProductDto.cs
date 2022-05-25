using DomainModels;
using System.Collections.Generic;

namespace WebShop_NULL.GraphQL.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Rating { get; set; }
        public CategoryDto Category { get; set; }
        public int ImageId { get; set; }
        public ImageMetadata Image { get; set; }
        public Dictionary<string,string> AttributeValuePairs { get; set; }
        public ICollection<ReviewDto> Reviews { get; set; }
    }
}
