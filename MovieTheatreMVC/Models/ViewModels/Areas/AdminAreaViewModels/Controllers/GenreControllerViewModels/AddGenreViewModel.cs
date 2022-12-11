using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieTheatreMVC.Models.ViewModels.Areas.AdminAreaViewModels.Controllers.GenreControllerViewModels
{
    public class AddGenreViewModel
    {
        [Required]
        [StringLength(60, MinimumLength = 1)]
        [DisplayName("Genre Name")]
        public string GenreName { get; set; }
    }
}
