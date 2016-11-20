using System.Collections.Generic;
using Shops.Provider.ProviderModel;

namespace Shops.Provider.Interfaces
{
    public interface IShopProvider : IProvider<Shop>
    {
        IDictionary<int, string> GetShopsDictionary();
    }
}
