using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace OilProducts.Models
{
    public class ShippingMethods
    {
        [Required]
        public int shippingMethodsId { get; set; }
        [Required]
        [Display(Name = "Shipping method name")]
        public string shippingMethodName { get; set; }
        [Required]
        [Display(Name = "Taxe rate")]
        public string taxeRate { get; set; }

    }
}