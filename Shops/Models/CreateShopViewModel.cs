using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shops.Models
{
    public class CreateShopViewModel
    {
        public int ShopId { get; set; }
        [Display(Name = "Shop name")]
        [Required(AllowEmptyStrings = false)]
        public string ShopName { get; set; }
        [Display(Name = "Address")]
        [Required(AllowEmptyStrings = false)]
        public string ShopAddress { get; set; }
        [Display(Name = "Opening time")]
        public DateTime ShopOpeningTime { get; set; }
        [Display(Name = "Closing time")]
        public DateTime ShopClosingTime { get; set; }
    }
}