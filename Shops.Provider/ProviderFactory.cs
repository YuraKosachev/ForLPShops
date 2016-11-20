using Shops.Provider.Interfaces;
using Shops.Provider.Providers;

namespace Shops.Provider
{
    public class ProviderFactory : IProviderFactory
    {
        public IProductProvider ProductsProvider
        {
            get
            {
                return new ProductProvider();
            }
        }

        public IShopProvider ShopsProvider
        {
            get
            {
                return new ShopProvider();
            }
        }

    }
}
