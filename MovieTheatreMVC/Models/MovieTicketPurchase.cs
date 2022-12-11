using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MovieTheatreMVC.Models
{
    public class MovieTicketPurchase
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal TotalCost { get; set; }

        [Required]
        public DateTime DatePurchased { get; set; }

        [Required]
        public int PurchasedAdultQuantity { get; set; }

        [Required]
        public int PurchasedChildQuantity { get; set; }

        [Required]
        public int PurchasedSeniorQuantity { get; set; }

        [Required]
        public string MovieTitle { get; set; }

        [Required]
        public string MovieShowTime { get; set; }

        //Table relationships beginning
        public int CustomerId { get; set; }
        [ValidateNever]
        public List<Customer> Customers { get; set; }

        public int MovieId { get; set; }
        [ValidateNever]
        public Movie Movie { get; set; }

        public int TheatreId { get; set; }
        [ValidateNever]
        public Theatre Theatre { get; set; }

        //Table relationships end

    }
}
