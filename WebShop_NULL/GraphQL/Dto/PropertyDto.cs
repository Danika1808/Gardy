using DomainModels;

namespace WebShop_NULL.GraphQL.Dto
{
    public class PropertyDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PropertyType PropertyType { get; set; }
    }
}
