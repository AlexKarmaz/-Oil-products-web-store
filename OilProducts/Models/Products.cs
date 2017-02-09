using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OilProducts.Models
{
    public class Products
    {
        [Required]
        [Display(Name = "Product Id")]
        public int productsId { get; set; }
        [Required]
        [Display(Name = "Product name")]
        public string productName { get; set; }
        [Required]
        [Display(Name = "Price")]
        public int price { get; set; }

    }
}