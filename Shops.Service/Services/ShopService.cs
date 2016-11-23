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
    public class ShopsServiceMapperProfile : Profile
    {

        protected override void Configure()
        {
            CreateMap<ShopServiceModel, Shop>().ReverseMap();
        }

    }
    public class ShopService : Service, IShopService
    {
        public ShopService() : base()
        {

        }
        public void Create(ShopServiceModel model)
        {
           
            Provider.ShopsProvider.Create(Mapper.Map<Shop>(model));
        }

        public void Delete(ShopServiceModel model)
        {
            Provider.ShopsProvider.Delete(model.ShopId);
        }

        public IEnumerable<ShopServiceModel> GetAll()
        {
            var list = Provider.ShopsProvider.GetAll();
            return Mapper.Map<IEnumerable<ShopServiceModel>>(list);
           
        }

        public ShopServiceModel GetItem(ShopServiceModel model)
        {

            var shop = Provider.ShopsProvider.GetItem(model.ShopId);
            return Mapper.Map<ShopServiceModel>(shop);
          
        }

        public IDictionary<int, string> GetShopsDictionary()
        {
            return Provider.ShopsProvider.GetShopsDictionary();
        }

        public void Update(ShopServiceModel model)
        {

            Provider.ShopsProvider.Update(Mapper.Map<Shop>(model));
          
        }

     
    }
}
