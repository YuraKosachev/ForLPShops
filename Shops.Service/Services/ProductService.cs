using System;
using System.Collections.Generic;
using System.Linq;
using Shops.Service.Interfaces;
using Shops.Service.ServiceModel;
using Shops.Provider.ProviderModel;
using AutoMapper;

namespace Shops.Service.Services
{
    public class ProductService : Service, IProductService
    {
        public ProductService() : base() { }

        public void Create(ProductServiceModel model)
        {
            var providerModel = new Product {
                ProductId = model.ProductId,
                ProductDescription = model.ProductDescription,
                ProductName = model.ProductName,
                ShopId = model.ShopId
            };
            Provider.ProductsProvider.Create(Mapper.Map<Product>(model));
        }

        public void Delete(ProductServiceModel model)
        {
            Provider.ProductsProvider.Delete(model.ProductId);
        }

        public IEnumerable<ProductServiceModel> GetAll()
        {
            return Provider.ProductsProvider.GetAll().Select(product => new ProductServiceModel {
                ProductId = product.ProductId,
                ProductDescription = product.ProductDescription,
                ProductName = product.ProductName,
                ShopId = product.ProductId
            });
        }

        public ProductServiceModel GetItem(ProductServiceModel model)
        {

            var item = Provider.ProductsProvider.GetItem(model.ProductId);
            return new ProductServiceModel {
                ProductId = item.ProductId,
                ProductDescription = item.ProductDescription,
                ProductName = item.ProductName,
                ShopId = item.ProductId
            };
        }

        public IEnumerable<ProductServiceModel> GetShopProducts(ProductServiceModel model)
        {
            var modelProvider = new Product { ShopId = model.ShopId };
            var list = Provider.ProductsProvider.GetShopProducts(modelProvider).Select(product => new ProductServiceModel {ProductId = product.ProductId,
                                                                                                                            ShopId=product.ShopId,
            ProductDescription = product.ProductDescription,
            ProductName=product.ProductName});
            return list;
        }

        public void Update(ProductServiceModel model)
        {
            var providerModel = new Product
            {
                ProductId = model.ProductId,
                ProductDescription = model.ProductDescription,
                ProductName = model.ProductName,
                ShopId = model.ProductId
            };
            Provider.ProductsProvider.Update(providerModel);
        }

      
    }
}
