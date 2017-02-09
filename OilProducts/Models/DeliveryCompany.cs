using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace OilProducts.Models
{
    public class DeliveryCompany
    {
        [Required]
        [Display(Name = "Company Id")]
        public int deliveryCompanyId { get; set; }
        [Required]
        [Display(Name = "Company name")]
        public string companyName { get; set; }
        [Required]
        [Display(Name = "Company email")]
        public string companyEmail { get; set; }
        [Required]
        [Display(Name = "Company phone")]
        public string companyPhone { get; set; }
        [Display(Name = "Logo")]
        public string logo { get; set; }
    }
}