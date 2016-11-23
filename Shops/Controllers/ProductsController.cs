using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shops.Models;
using AutoMapper;
using Shops.Service.ServiceModel;
namespace Shops.Controllers
{
    public class ProductsControllerMapperProfile : Profile
    {

        protected override void Configure()
        {
            CreateMap<ProductServiceModel, ProductViewModel>().ReverseMap();
        }

    }

    public class ProductsController : AppController
    {
        //
        // GET: /Products/
        public ProductsController() : base() { }
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddProduct(int id)
        {
            var item = new ProductViewModel { ShopId = id };
            return View(item);
        }
        [HttpPost]
        public ActionResult AddProduct(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                Service.ProductService.Create(Mapper.Map<ProductServiceModel>(model));
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        public ActionResult GetShopProducts(int id)
        {
            var list = Service.ProductService.GetShopProducts(new ProductServiceModel { ShopId = id });
            return PartialView(Mapper.Map<IEnumerable<ProductViewModel>>(list));
        }


    }
}
