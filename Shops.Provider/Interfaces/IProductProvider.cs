using System.Linq;
using Shops.Provider.ProviderModel;

namespace Shops.Provider.Interfaces
{
    public interface IProductProvider : IProvider<Product>
    {
        IQueryable<Product> GetShopProducts(Product model);
    }
}
