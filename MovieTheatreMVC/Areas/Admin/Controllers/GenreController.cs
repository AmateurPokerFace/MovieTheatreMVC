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

        public IActionResult Genres() 
        {
            List<Genre> genres = _context.Genres.ToList();

            if (genres != null && genres.Count > 0)
            {
                genres = genres.OrderBy(x => x.GenreName).ToList();
                return View(genres);
            }

            // send to an error page in the future
            return RedirectToAction(nameof(Index));
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

        public IActionResult EditGenreName(int id) 
        {
            Genre genre = _context.Genres.Find(id);
            if (genre == null) 
            {
                // send to an error page in the future
                return RedirectToAction(nameof(Genres));
            }
            return View(genre);
        }

        [HttpPost]
        public IActionResult EditGenreName(Genre genre)
        {
            if (ModelState.IsValid)
            {
                _context.Genres.Update(genre);
                _context.SaveChanges();

                return RedirectToAction(nameof(Genres)); // send to a success page in the future
            }

            return View(genre);
        }
    }
}
