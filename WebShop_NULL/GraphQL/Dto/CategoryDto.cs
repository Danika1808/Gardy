using DomainModels;
using System.Collections.Generic;

namespace WebShop_NULL.GraphQL.Dto
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PropertyDto> Properties { get; set; }
    }
}
