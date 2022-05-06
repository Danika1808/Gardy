using AutoMapper;
using DomainModels;
using WebShop_NULL.GraphQL.Dto;

namespace WebShop_NULL.Mapper
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDto>();
        }
    }
}
