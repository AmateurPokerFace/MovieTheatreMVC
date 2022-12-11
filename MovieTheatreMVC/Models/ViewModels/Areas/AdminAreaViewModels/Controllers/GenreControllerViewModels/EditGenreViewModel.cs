using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MovieTheatreMVC.Models.ViewModels.Areas.AdminAreaViewModels.Controllers.GenreControllerViewModels
{
    public class EditGenreViewModel
    {
        [Required]
        [StringLength(60, MinimumLength = 1)]
        [DisplayName("Genre Name")]
        public string GenreName { get; set; }
    }
}
