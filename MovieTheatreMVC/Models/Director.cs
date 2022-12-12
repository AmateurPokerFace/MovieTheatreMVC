using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTheatreMVC.Models
{
    public class Director
    {
        public Director()
        {
            MoviesDirected = new List<DirectorCredit>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string DirectorImagePath { get; set; }

        [NotMapped]
        [ValidateNever]
        public List<DirectorCredit> MoviesDirected { get; set; } 
    }
}
