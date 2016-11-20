using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Shops.Models
{
    public class ShopViewModel
    {

        public int ShopId { get; set; }
        [Display(Name = "Shop name")]
        public string ShopName { get; set; }
        [Display(Name = "Address")]
        public string ShopAddress { get; set; }
        [Display(Name = "Working time")]
        public string WorkingTime { get; set; }

    }
}