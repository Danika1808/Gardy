using AutoMapper;
using DomainModels;
using WebShop_NULL.GraphQL.Dto;

namespace WebShop_NULL.Mapper
{
    public class ShoppingCartEntryProfile : Profile
    {
        public ShoppingCartEntryProfile()
        {
            CreateMap<ShoppingCartEntry, ShoppingCartEntryDto>();
        }
    }
}
