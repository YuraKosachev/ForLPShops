using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shops.Models;
using Shops.Service.ServiceModel;
using AutoMapper;

namespace Shops.Controllers
{
    public class HomeControllerMapperProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<ShopServiceModel, ShopViewModel>()
               .ForMember(item => item.WorkingTime, exp => exp.MapFrom(src => String.Format("{0} - {1}", src.ShopOpeningTime, src.ShopClosingTime)));

        }

    }

    public class HomeController : AppController
    {
        //
        // GET: /Home/
        public HomeController() : base() { }
        public ActionResult Index()
        {
            var list = Service.ShopService.GetAll();
            return View(Mapper.Map<IEnumerable<ShopViewModel>>(list));
        }

    }
}
