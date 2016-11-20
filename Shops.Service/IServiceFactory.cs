using Shops.Service.Interfaces;

namespace Shops.Service
{
    public interface IServiceFactory
    {
        IShopService ShopService { get; }
        IProductService ProductService { get; }
    }
}
