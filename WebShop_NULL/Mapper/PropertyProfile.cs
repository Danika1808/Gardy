using AutoMapper;
using DomainModels;
using WebShop_NULL.GraphQL.Dto;

namespace WebShop_NULL.Mapper
{
    public class PropertyProfile : Profile
    {
        public PropertyProfile()
        {
            CreateMap<Property, PropertyDto>();
        }
    }
}
