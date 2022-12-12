using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MovieTheatreMVC.Models
{
    public class ActorCredit
    {
        public int Id { get; set; }

        public string RoleName { get; set; }

        [Required]
        public int ActorId { get; set; }

        [ValidateNever]
        public Actor Actor { get; set; }

        [Required]
        public int MovieId { get; set; }

        [ValidateNever]
        public Movie Movie { get; set; }
         
        [Required]
        [StringLength(265, MinimumLength = 1)]
        public string MovieTitle { get; set; }
    }
}
