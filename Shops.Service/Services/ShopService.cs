using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shops.Service.Interfaces;
using Shops.Service.ServiceModel;
using Shops.Provider.ProviderModel;
using AutoMapper;


namespace Shops.Service.Services
{
    public class ShopService : Service, IShopService
    {
        public ShopService() : base()
        {

        }
        public void Create(ShopServiceModel model)
        {
            var providerModel = new Shop
            {
                ShopAddress = model.ShopAddress,
                ShopClosingTime = model.ShopClosingTime,
                ShopId = model.ShopId,
                ShopName = model.ShopName,
                ShopOpeningTime = model.ShopOpeningTime
            };
            Provider.ShopsProvider.Create(providerModel);
        }

        public void Delete(ShopServiceModel model)
        {
            Provider.ShopsProvider.Delete(model.ShopId);
        }

        public IEnumerable<ShopServiceModel> GetAll()
        {
            return Provider.ShopsProvider.GetAll().Select(shop => new ShopServiceModel
            {
                ShopAddress = shop.ShopAddress,
                ShopClosingTime = shop.ShopClosingTime,
                ShopId = shop.ShopId,
                ShopName = shop.ShopName,
                ShopOpeningTime = shop.ShopOpeningTime
            });
        }

        public ShopServiceModel GetItem(ShopServiceModel model)
        {

            var item = Provider.ShopsProvider.GetItem(model.ShopId);
            return new ShopServiceModel
            {
                ShopAddress = item.ShopAddress,
                ShopClosingTime = item.ShopClosingTime,
                ShopId = item.ShopId,
                ShopName = item.ShopName,
                ShopOpeningTime = item.ShopOpeningTime
            }; 
        }

        public IDictionary<int, string> GetShopsDictionary()
        {
            return Provider.ShopsProvider.GetShopsDictionary();
        }

        public void Update(ShopServiceModel model)
        {
            Provider.ShopsProvider.Update(new Shop
            {
                ShopAddress = model.ShopAddress,
                ShopClosingTime = model.ShopClosingTime,
                ShopId = model.ShopId,
                ShopName = model.ShopName,
                ShopOpeningTime = model.ShopOpeningTime
            } );
        }

     
    }
}
