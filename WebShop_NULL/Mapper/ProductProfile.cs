using AutoMapper;
using DomainModels;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using WebShop_NULL.GraphQL.Dto;

namespace WebShop_NULL.Mapper
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(m => m.AttributeIdValue, options => options.MapFrom(x => x.AttributeValues.GetPropertyValues()));
        }

    }
}
