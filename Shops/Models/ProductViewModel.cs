using System.ComponentModel.DataAnnotations;

namespace Shops.Models
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        [Display(Name = "Name")]
        [Required(AllowEmptyStrings = false)]
        public string ProductName { get; set; }
        [Display(Name = "Description")]
        public string ProductDescription { get; set; }
        public int ShopId { get; set; }
    }
}