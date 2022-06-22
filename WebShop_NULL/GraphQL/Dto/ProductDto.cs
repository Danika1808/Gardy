using DomainModels;
using System.Collections.Generic;
using static WebShop_NULL.JsonDocumentExtensions;

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
        public List<IdValue> AttributeIdValue { get; set; }
        public ICollection<ReviewDto> Reviews { get; set; }
    }
}
