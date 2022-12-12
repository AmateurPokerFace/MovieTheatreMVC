using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MovieTheatreMVC.Models.ViewModels.Areas.AdminAreaViewModels.Controllers.MovieControlleViewModels
{
    public class AddMovieViewModel
    {
        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public int RunningTimeMinutes { get; set; } = 0;

        [Required]
        public string Description { get; set; }

        [Required]
        public string Title { get; set; }

        // ADD GENRE ID

        [Required]
        public string GenreString { get; set; }

        [Required]
        public string AgeRestriction { get; set; }

        [Required]
        public bool CanPurchaseTickets { get; set; }

        [Required]
        [Display(Name = "Enter a Cover Image for the Movie")]
        public IFormFile MovieCoverImage { get; set; }
    }
}
