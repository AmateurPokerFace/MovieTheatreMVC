using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MovieTheatreMVC.Models
{
    public class DirectorCredit
    {
        public int Id { get; set; }

        [Required]
        public int DirectorId { get; set; }

        [ValidateNever]
        public Director Director { get; set; }

        [Required]
        public int MovieId { get; set; }

        [ValidateNever]
        public Movie Movie { get; set; }

        [Required]
        [StringLength(265, MinimumLength = 1)]
        public string MovieTitle { get; set; }
    }
}
