using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OilProducts.Models
{
    public class Payments
    {
        [Required]
        public int paymentsId { get; set; }
        [Required]
        public int orderId { get; set; }
        [Required]
        [Display(Name = "Payment amount")]
        public double paymentAmount { get; set; }
        [Required]
        [Display(Name = "Payment date")]
        public DateTime paymentDate { get; set; }
        [Required]
        [Display(Name = "Card number")]
        public long cardNumber { get; set; }
        [Required]
        [Display(Name = "Card holders name")]
        public string cardHoldersName { get; set; }
        [Required]
        [Display(Name = "Card expdate")]
        public string cardExpDate { get; set; }
        [Required]
        [Display(Name = "Card autorization number")]
        public int cardAutorizationNumber { get; set; }

    }
}