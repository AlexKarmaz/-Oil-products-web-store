using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OilProducts.Models
{
    public class OrderDetails
    {
        [Required]
        public int orderDetailsId { get; set; }
        [Required]
        public int orderId { get; set; }
        [Required]
        [Display(Name = "Product ")]
        public string productName { get; set; }
        [Required]
        [Display(Name = "Unit price")]
        public int UnitPrice { get; set; }
        [Required]
        [Display(Name = "Quantity")]
        public int quantity { get; set; }
        [Required]
        [Display(Name = "Discount")]
        public double discount { get; set; }

    }
}