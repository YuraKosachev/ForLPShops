using Shops.Service.Interfaces;
using Shops.Service.Services;

namespace Shops.Service
{
    public class ServiceFactory : IServiceFactory
    {
        public IProductService ProductService
        {
            get
            {
                return new ProductService();
            }
        }

        public IShopService ShopService
        {
            get
            {
                return new ShopService();
            }
        }
    }
}
