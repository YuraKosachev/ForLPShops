using System.Collections.Generic;
using Shops.Service.ServiceModel;

namespace Shops.Service.Interfaces
{
    public interface IProductService : IService<ProductServiceModel>
    {
        IEnumerable<ProductServiceModel> GetShopProducts(ProductServiceModel model);
    }
}
