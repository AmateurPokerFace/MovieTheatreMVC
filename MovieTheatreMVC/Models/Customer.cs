using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MovieTheatreMVC.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public int MovieTicketPurchaseId { get; set; }
        [ValidateNever]
        public List<MovieTicketPurchase> MovieTicketPurchases { get; set; }
    }
}
