using AutoMapper;
using DomainModels;
using WebShop_NULL.GraphQL.Dto;

namespace WebShop_NULL.Mapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}
