using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MovieTheatreMVC.Models
{
    public class MovieTicketSales
    {
        public MovieTicketSales()
        {
            MovieGenres = new List<string>();
            MovieDirectors = new List<string>();
        }

        [Key]
        public int Id { get; set; }
        
        [Required]
        public string MovieTitle { get; set; }

        [Required]
        public DateTime MovieReleaseDate { get; set; }

        [Required]
        public List<string> MovieGenres { get; set; }

        [Required]
        public List<string> MovieDirectors { get; set; }

        [Required]
        public decimal GrossSales { get; set; }

        public void SubtractFromGrossSales(decimal amountToSubtract) 
        {
            GrossSales -= amountToSubtract;
        }

        public void AddToGrossSales(decimal amountToAdd) 
        {
            GrossSales += amountToAdd;
        }
    }
}
