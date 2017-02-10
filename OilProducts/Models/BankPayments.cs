using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OilProducts.Models
{
    public class BankPayments
    {
        [Required]
        public int bankPaymentsId { get; set; }
        [Required]
        public int orderId { get; set; }
        [Required]
        [Display(Name = "Payment amount")]
        public double paymentAmount { get; set; }
        [Required]
        [Display(Name = "Payment date")]
        public DateTime paymentDate { get; set; }
        [Required]
        [Display(Name = "Name of the bank")]
        public string nameBank { get; set; }
        [Required]
        [Display(Name = "Bank code SWIFT")]
        public string swift { get; set; }
        [Required]
        [Display(Name = "Account number")]
        public string accountNumber { get; set; }
        [Required]
        [Display(Name = "Passport series")]
        public string passportSeries { get; set; }
        [Required]
        [Display(Name = "Passport ID")]
        public string passportId { get; set; }

    }
}