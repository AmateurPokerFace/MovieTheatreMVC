using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTheatreMVC.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string ActorImagePath { get; set; }

        [Required]
        public int MovieId { get; set; }
        [NotMapped]
        public Movie Movie { get; set; }

        [ValidateNever]
        [NotMapped]
        public List<Movie> MoviesStarredIn { get; set; }

    }
}
