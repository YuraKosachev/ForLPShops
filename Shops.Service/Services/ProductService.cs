using System;
using System.Collections.Generic;
using System.Linq;
using Shops.Service.Interfaces;
using Shops.Service.ServiceModel;
using Shops.Provider.ProviderModel;
using AutoMapper;

namespace Shops.Service.Services
{
    public class ProductsServiceMapperProfile : Profile
    {

        protected override void Configure()
        {
            CreateMap<ProductServiceModel, Product>().ReverseMap();
        }

    }
    public class ProductService : Service, IProductService
    {
        public ProductService() : base() { }

        public void Create(ProductServiceModel model)
        {
          
            Provider.ProductsProvider.Create(Mapper.Map<Product>(model));
        }

        public void Delete(ProductServiceModel model)
        {
            Provider.ProductsProvider.Delete(model.ProductId);
        }

        public IEnumerable<ProductServiceModel> GetAll()
        {
            var list = Provider.ProductsProvider.GetAll();
            return Mapper.Map<IEnumerable<ProductServiceModel>>(list);
          
        }

        public ProductServiceModel GetItem(ProductServiceModel model)
        {

            var product = Provider.ProductsProvider.GetItem(model.ProductId);
            return Mapper.Map<ProductServiceModel>(product);
         
        }

        public IEnumerable<ProductServiceModel> GetShopProducts(ProductServiceModel model)
        {
            var modelProvider = Mapper.Map<Product>(model);
            var list = Provider.ProductsProvider.GetShopProducts(modelProvider);
            
            return Mapper.Map<IEnumerable<ProductServiceModel>>(list);
        }

        public void Update(ProductServiceModel model)
        {
            
            Provider.ProductsProvider.Update(Mapper.Map<Product>(model));
        }


    }
}
