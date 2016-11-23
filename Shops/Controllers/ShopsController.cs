using System.Web.Mvc;
using Shops.Models;
using AutoMapper;
using Shops.Service.ServiceModel;

namespace Shops.Controllers
{
    public class ShopsControllerMapperProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<CreateShopViewModel, ShopServiceModel>()
                .ForMember(item => item.ShopOpeningTime, exp => exp.MapFrom(x => x.ShopOpeningTime.TimeOfDay))
                .ForMember(item => item.ShopClosingTime, exp => exp.MapFrom(x => x.ShopClosingTime.TimeOfDay));

        }

    }

    public class ShopsController : AppController
    {
        //
        public ShopsController() : base() { }
        // GET: /Shops/
        [HttpGet]
        public ActionResult AddNewShop()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewShop(CreateShopViewModel model)
        {
            if (ModelState.IsValid)
            {
                Service.ShopService.Create(Mapper.Map<ShopServiceModel>(model));
                return RedirectToAction("Index", "Home");
            }

            return View();
        }


    }
}
