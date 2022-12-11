using Microsoft.AspNetCore.Mvc;
using MovieTheatreMVC.Models;
using MovieTheatreMVC.Models.ViewModels.Areas.AdminAreaViewModels.Controllers.GenreControllerViewModels;

namespace MovieTheatreMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GenreController : Controller
    {
        private readonly MovieTheatreDbContext _context;
        
        public GenreController(MovieTheatreDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddGenre()
        {
            AddGenreViewModel model = new AddGenreViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddGenre(AddGenreViewModel model)
        {
            if (ModelState.IsValid)
            {
                bool dupeGenreNameFound = _context.Genres.Where(x => x.GenreName == model.GenreName).FirstOrDefault() != null;
                
                if (dupeGenreNameFound)
                {
                    // send to an error page in the future
                    return RedirectToAction(nameof(Index));
                }

                Genre genre = new Genre { GenreName = model.GenreName};
                _context.Genres.Add(genre);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index)); // send to a success page in the future
            }
            return View(model);
        }
    }
}
