using System.ComponentModel.DataAnnotations;

namespace MovieTheatreMVC.Models
{
    public class Director
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        public string Gender { get; set; }

        public int MovieId { get; set; }
        public List<Movie> MoviesDirected { get; set; }
    }
}
