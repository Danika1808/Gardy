using AutoMapper;
using AutoMapper.QueryableExtensions;
using DomainModels;
using HotChocolate.Data;
using HotChocolate.Types;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebShop_FSharp.ViewModels;
using WebShop_FSharp.ViewModels.CatalogModels;
using WebShop_NULL.GraphQL.Dto;
using WebShop_NULL.Infrastructure.Filters;
using WebShop_NULL.Models;

namespace WebShop_NULL.GraphQL
{
    public class Queries
    {
        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public IQueryable<ProductDto> GetProducts([FromServices] ApplicationContext _dbContext, [FromServices] IMapper _mapper)
        {
            return _dbContext.Products.Include(x => x.Category).ThenInclude(x => x.Properties).ProjectTo<ProductDto>(_mapper.ConfigurationProvider);
        }
    }
}
