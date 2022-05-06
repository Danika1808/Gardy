using AutoMapper;
using DomainModels;
using WebShop_NULL.GraphQL.Dto;

namespace WebShop_NULL.Mapper
{
    public class ReviewProfile : Profile
    { 
        public ReviewProfile()
        {
            CreateMap<Review, ReviewDto>();
        }
    }
}
