using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MovieTheatreMVC.Models;
using MovieTheatreMVC.Models.ViewModels.Areas.AdminAreaViewModels.Controllers.MovieControlleViewModels;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace MovieTheatreMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MovieController : Controller
    {
        private readonly MovieTheatreDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public MovieController(MovieTheatreDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Movies() 
        {
            List<Movie> movies = _context.Movies.ToList();

            if (movies != null && movies.Count > 0)
            {
                movies = movies.OrderByDescending(x => x.ReleaseDate).ToList();
            }
            return View(movies);
        }

        public IActionResult AddMovie() 
        {
            AddMovieViewModel model = new AddMovieViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddMovie(AddMovieViewModel model)
        {
            Genre genre = _context.Genres.Where(x => x.GenreName.ToLower() == model.GenreString.ToLower()).FirstOrDefault();
            if (ModelState.IsValid)
            {
                if (model.MovieCoverImage != null)
                {
                    
                    string folder = "movies/covers/";
                    folder += Guid.NewGuid().ToString() + "_" + model.MovieCoverImage.FileName ; 

                    string serverFoler = Path.Combine(_webHostEnvironment.WebRootPath, folder);

                    await model.MovieCoverImage.CopyToAsync(new FileStream(serverFoler, FileMode.Create));

                    Movie movie = new Movie
                    {
                        MovieCoverImagePath = $"/{folder}",
                        AgeRestriction = model.AgeRestriction,
                        BoxOffice = 0,
                        CanPurchaseTickets= model.CanPurchaseTickets,
                        Title= model.Title,
                        Description = model.Description,
                        ReleaseDate= model.ReleaseDate,
                        RunningTimeMinutes= model.RunningTimeMinutes,
                        GenreId= genre.Id,
                    };

                    await _context.Movies.AddAsync(movie);
                    await _context.SaveChangesAsync();
                }
                 
            }

            return View(model); // return an error in the future
        }

        public IActionResult EditMovie()
        {
            return View();
        }

        public IActionResult DeleteMovie()
        {
            return View();
        }

        public IActionResult AddActor()
        {
            return View();
        }

        [HttpPost]
        public async Task< IActionResult> AddActor(string dummy)
        {
            //List<Actor> actors = new List<Actor>
            //{
            //    new Actor { FirstName = "Martin", LastName = "Freeman" },
            //    new Actor { FirstName = "Lupita", LastName = "Nyong'o" },
            //    new Actor { FirstName = "Angela", LastName = "Bassett" },
            //    new Actor { FirstName = "Winston", LastName = "Duke" },
            //    new Actor { FirstName = "Danai", LastName = "Gurira" },
            //    new Actor { FirstName = "Letitia", LastName = "Wright" },
            //    new Actor { FirstName = "Tenoch", LastName = "Huerta" },
            //    new Actor { FirstName = "Nicholas", LastName = "Hoult" },
            //    new Actor { FirstName = "Ralph", LastName = "Fiennes" },
            //    new Actor { FirstName = "Anya", LastName = "Taylor-Joy" },
            //    new Actor { FirstName = "John", LastName = "Leguizamo" },
            //    new Actor { FirstName = "Judith", LastName = "Light" },
            //    new Actor { FirstName = "Hong ", LastName = "Chau" },
            //    new Actor { FirstName =               "Janet"   ,                         LastName =           "McTeer"},
            //        new Actor { FirstName =         "Pierce"    ,                        LastName =            "Brosnan"},
            //       new Actor { FirstName =          "Dwayne"   ,                        LastName =             "Johnson"},
            //         new Actor { FirstName =        "Aldis"     ,                         LastName =           "Hodge"},
            //         new Actor { FirstName =        "Marwan"    ,                         LastName =           "Kenzari"},
            //         new Actor { FirstName =        "Noah"     ,                          LastName =       "Centineo"},
            //        new Actor { FirstName =    "Sarah"        ,                          LastName =     "Shahi"},
            //         new Actor { FirstName =   "Quintessa"     ,                         LastName =        "Swindell"},
            //         new Actor { FirstName =   "Kate"         ,                          LastName =    "Winslet"},
            //         new Actor { FirstName =   "Zoe"         ,                           LastName =    "Saldana"},
            //        new Actor { FirstName =    "David "       ,                          LastName =    "Thewlis"},
            //         new Actor { FirstName =   "Cliff"     ,                            LastName =     "Curtis"},
            //         new Actor { FirstName =   "Stephen"    ,                            LastName =        "Lang"},
            //          new Actor { FirstName =  "Sigourney"  ,                            LastName =         "Weaver"},
            //          new Actor { FirstName =  "Sam"   ,                                 LastName =    "Worthington"},
            //         new Actor { FirstName =   "Oona"   ,                                LastName =     "Chaplin"},
            //          new Actor { FirstName =  "Giovanni" ,                              LastName =        "Ribisi"},
            //          new Actor { FirstName =  "Edie"   ,                                LastName =     "Falco"},
            //     new Actor { FirstName =       "Joel"  ,                                 LastName =    "David Moore"},
            //         new Actor { FirstName =   "Gerard" ,                                LastName =        "Butler"},
            //        new Actor { FirstName =    "Mike"  ,                                 LastName =    "Colter"},
            //        new Actor { FirstName =    "Paul" ,                                  LastName =    "Ben - Victor"},
            //        new Actor { FirstName =    "Tony"  ,                                 LastName =    "Goldwyn"},
            //       new Actor { FirstName =     "Daniella",                               LastName =        "Pineda"},
            //        new Actor { FirstName =    "Kelly" ,                                 LastName =    "Gale"},
            //new Actor { FirstName = "Brendan"               ,                 LastName = "Fraser" },
            //      new Actor { FirstName =      "Samantha" ,                              LastName =        "Morton"},
            //       new Actor { FirstName =     "Ty"     ,                                LastName =    "Simpkins"},
            //      new Actor { FirstName =      "Hong"   ,                                LastName =    "Chau"},
            //       new Actor { FirstName =     "Sadie"  ,                                LastName =    "Sink"},
            //new Actor { FirstName = "Antonio"           ,                     LastName = "Banderas" },
            //new Actor { FirstName = "Salma"           ,                       LastName = "Hayek" },
            //        new Actor { FirstName =    "Florence" ,                              LastName =         "Pugh"},
            //       new Actor { FirstName =     "Harvey",                                 LastName =        "Guillen"},
            //      new Actor { FirstName =      "Olivia" ,                                LastName =     "Colman"},
            //      new Actor { FirstName =      "John"  ,                                  LastName =   "Mulaney"},
            //      new Actor { FirstName =      "Samson" ,                                 LastName =       "Kayo"},

            //};





            //foreach (var actor in actors)
            //{
            //    Actor actor1 = new Actor { FirstName = actor.FirstName, LastName = actor.LastName };
            //    _context.Actors.Add(actor1);
                
            //    await _context.SaveChangesAsync();
            //}
                 
            return RedirectToAction(nameof(Index));
        }
    }
}
