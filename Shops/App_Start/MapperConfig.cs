using AutoMapper;
using Shops.Controllers;
using Shops.Service.Services;


namespace Shops
{
    public static class MapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<ShopsControllerMapperProfile>();
                cfg.AddProfile<HomeControllerMapperProfile>();
                cfg.AddProfile<ProductsControllerMapperProfile>();
                cfg.AddProfile<ProductsServiceMapperProfile>();
                cfg.AddProfile<ShopsServiceMapperProfile>();
            });


        }
    }
}