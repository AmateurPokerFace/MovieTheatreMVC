using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MovieTheatreMVC.Models
{
    public class Movie
    {
        public Movie()
        {
            Cast= new List<Actor>();
            Directors = new List<Director>();
        }

        [Key]
        public int Id { get; set; }
        
        public DateTime ReleaseDate { get; set; }
        
        public int RunningTimeMinutes { get; set; }
        
        public string Description { get; set; }

        public string Title { get; set; }

        public Genre Genre { get; set; }

        public int ActorId { get; set; }
        [ValidateNever]
        public List<Actor> Cast { get; set; }

        public List<Director> Directors { get; set; }

        public string AgeRestriction { get; set; }

        public string ImagePath { get; set; }

        public bool CanPurchaseTickets { get; set; }

        public decimal  BoxOffice { get; set; }
    }
}
