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
   
    public class HomeController : AppController
    {
        //
        // GET: /Home/
        public HomeController() : base() { }
        public ActionResult Index()
        {

            var list = Service.ShopService.GetAll()
                .Select(shop => new ShopViewModel
                {
                    ShopAddress = shop.ShopAddress,
                    ShopId = shop.ShopId,
                    ShopName = shop.ShopName,
                    WorkingTime = String.Format("{0} - {1}", shop.ShopOpeningTime, shop.ShopClosingTime)
                });
            return View(list);
        }

    }
}
