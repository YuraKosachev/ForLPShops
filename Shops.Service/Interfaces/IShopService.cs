using System.Collections.Generic;
using Shops.Service.ServiceModel;

namespace Shops.Service.Interfaces
{
    public interface IShopService : IService<ShopServiceModel>
    {
        IDictionary<int, string> GetShopsDictionary();
    }
}
