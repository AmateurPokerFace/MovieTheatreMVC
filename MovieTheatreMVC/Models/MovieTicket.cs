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

        
    }
}
