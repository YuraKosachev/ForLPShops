using System;
using System.Collections.Generic;
using System.Linq;
using Shops.Provider.ProviderModel;
using Shops.Provider.Interfaces;

namespace Shops.Provider.Providers
{
    public class ShopProvider : Provider<Shop>, IShopProvider
    {
        public IDictionary<int, string> GetShopsDictionary()
        {
            return db.Shops.ToDictionary(k => k.ShopId, v => v.ShopName);
        }
    }
}
