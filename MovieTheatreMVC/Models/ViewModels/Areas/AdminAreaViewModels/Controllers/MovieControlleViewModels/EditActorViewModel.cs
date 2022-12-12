using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MovieTheatreMVC.Models.ViewModels.Areas.AdminAreaViewModels.Controllers.MovieControlleViewModels
{
    public class EditActorViewModel
    {
        [Required]
        public int ActorId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Display(Name = "Click the Browse Button to Enter a Profile Image for the Selected Actor (optional)")]
        public IFormFile? ActorProfileImage { get; set; }
    }
}
