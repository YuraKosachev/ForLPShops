using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shops.Service;
namespace Shops.Controllers
{
    public abstract class AppController : Controller
    {
        protected IServiceFactory Service { get; set; }
        public AppController()
        {
            Service = new ServiceFactory();
        }
       
    }
}