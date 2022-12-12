using Microsoft.AspNetCore.Mvc;
using MovieTheatreMVC.Models;
using MovieTheatreMVC.Models.ViewModels.Areas.AdminAreaViewModels.Controllers.MovieControlleViewModels;

namespace MovieTheatreMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MovieController : Controller
    {
        private readonly MovieTheatreDbContext _context;

        public MovieController(MovieTheatreDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Movies() 
        {
            return View();
        }

        public IActionResult AddMovie() 
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(AddMovieViewModel model)
        {
            if (ModelState.IsValid)
            {

            }

            return View(model);
        }

        public IActionResult EditMovie()
        {
            return View();
        }

        public IActionResult DeleteMovie() 
        {
            return View();
        }
    }
}
