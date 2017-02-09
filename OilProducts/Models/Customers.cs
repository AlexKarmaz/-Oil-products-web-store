using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OilProducts.Models
{
    public class Customers
    {
        [Required]
        public int customersId { get; set; }
        [Required]
        [Display(Name = "First name")]
        public string firstName { get; set; }
        [Required]
        [Display(Name = "Last name")]
        public string lastName { get; set; }
        [Required]
        [Display(Name = "Company name")]
        public string companyName { get; set; }
        [Required]
        [Display(Name = "Country")]
        public string country { get; set; }
        [Required]
        [Display(Name = "State")]
        public string state { get; set; }
        [Required]
        [Display(Name = "City")]
        public string city { get; set; }
        [Required]
        [Display(Name = "Postal code")]
        public string postalCode{ get; set; }
        [Required]
        [Display(Name = "Address")]
        public string address { get; set; }
        [Required]
        [Display(Name = "Phone number")]
        public string phoneNumber { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string email { get; set; }
    }
}