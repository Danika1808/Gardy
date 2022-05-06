using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using WebShop_NULL.Mapper;

namespace WebShop_NULL
{
    public static class ServiceCollectionExtensions
    {
        public static void AddMapper(this IServiceCollection services)
        {
            var mapperConfiguration = new MapperConfiguration(conf =>
            {
                conf.AddProfile<ProductProfile>();
                conf.AddProfile<CategoryProfile>();
                conf.AddProfile<PropertyProfile>();
                conf.AddProfile<ReviewProfile>();
                conf.AddProfile<ShoppingCartEntryProfile>();
                conf.AddProfile<UserProfile>();
            });

            IMapper mapper = mapperConfiguration.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
