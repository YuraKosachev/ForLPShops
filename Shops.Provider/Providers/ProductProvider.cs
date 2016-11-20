using System;
using System.Collections.Generic;
using System.Linq;
using Shops.Provider.ProviderModel;
using Shops.Provider.Interfaces;

namespace Shops.Provider.Providers
{
    public class ProductProvider : Provider<Product>, IProductProvider
    {
        public ProductProvider() : base() { }
        public IQueryable<Product> GetShopProducts(Product model)
        { 
            return db.Products.Where(product => product.ShopId == model.ShopId);
        }
    }
}
