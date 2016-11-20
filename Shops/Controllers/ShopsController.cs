using System.Web.Mvc;
using Shops.Models;
using AutoMapper;
using Shops.Service.ServiceModel;

namespace Shops.Controllers
{
   

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
                var shop = new ShopServiceModel
                {
                    ShopAddress = model.ShopAddress,
                    ShopClosingTime = model.ShopClosingTime.TimeOfDay,
                    ShopOpeningTime = model.ShopOpeningTime.TimeOfDay,
                    ShopId = model.ShopId,
                    ShopName = model.ShopName
                };
                Service.ShopService.Create(shop);
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

       
    }
}
