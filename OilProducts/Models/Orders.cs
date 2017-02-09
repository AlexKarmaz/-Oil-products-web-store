using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OilProducts.Models
{
    public class Orders
    {
        [Required]
        public int ordersId { get; set; }
        [Required]
        public int customerId { get; set; }
        [Required]
        [Display(Name = "Delivery company")]
        public int deliveryCompanyId { get; set; }
        [Required]
        [Display(Name = "Order date")]
        public DateTime orderDate { get; set; }
        [Required]
        [Display(Name = "Order number")]
        public int orderNumber { get; set; }
        [Required]
        [Display(Name = "Ship name")]
        public string shipName { get; set; }
        [Required]
        [Display(Name = "Ship country")]
        public string shipCountry { get; set; }
        [Required]
        [Display(Name = "Ship state")]
        public string shipState { get; set; }
        [Required]
        [Display(Name = "Ship city")]
        public string shipCity { get; set; }
        [Required]
        [Display(Name = "Ship postal code")]
        public string shipPostalCode { get; set; }
        [Required]
        [Display(Name = "Ship address")]
        public string shipAddress { get; set; }
        [Required]
        [Display(Name = "Ship phone number")]
        public string shipPhoneNumber { get; set; }
        [Required]
        [Display(Name = "Ship date")]
        public string shipDate { get; set; }
        [Required]
        [Display(Name = "Shipping method")]
        public int shippingMethodId { get; set; }
        [Required]
        [Display(Name = "Freight charge")]
        public int freightCharge { get; set; }
        [Required]
        [Display(Name = "Total price")]
        public double totalPrice { get; set; }
        [Required]
        public int paymentsId { get; set; }

    }
}