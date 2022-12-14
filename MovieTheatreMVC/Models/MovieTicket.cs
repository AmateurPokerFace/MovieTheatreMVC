using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MovieTheatreMVC.Models
{
    public class MovieTicket
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal TicketCost { get; set; }

        [Required]
        public int MaximumPerTransaction { get; set; }

        [Required]
        public bool HasPromoCode { get; set; }

        public int MovieId { get; set; }
        [ValidateNever]
        public Movie Movie { get; set; }

        public int TheatreId { get; set; }
        [ValidateNever]
        public Theatre Theatre { get; set; }
    }
}
