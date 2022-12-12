using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MovieTheatreMVC.Models.ViewModels.Areas.AdminAreaViewModels.Controllers.MovieControlleViewModels
{
    public class MoviesViewModel
    {
        public int Id { get; set; } 

        public DateTime ReleaseDate { get; set; }

        public int RunningTimeMinutes { get; set; } = 0;
         
        public string Description { get; set; }
         
        public string Title { get; set; }
         
        public string GenreName { get; set; }

        [ValidateNever]
        public List<Actor> Cast { get; set; }

        public string AgeRestriction { get; set; }

        public string MovieCoverImagePath { get; set; }
         
        public bool CanPurchaseTickets { get; set; }

        public TimeSpan RunTime { get; set; }
    }
}
