using System.ComponentModel.DataAnnotations;

namespace MovieTheatreMVC.Models
{
    public class Movie
    {
        public Movie()
        {
            Genres = new List<string>();
            Cast= new List<string>();
            Directors = new List<string>();
            AgeRestriction = new List<string>();
            ViewingOptions = new List<string>();
        }

        [Key]
        public int Id { get; set; }
        
        public DateOnly ReleaseDate { get; set; }
        
        public TimeOnly RunningTime { get; set; }
        
        public string Description { get; set; }

        public string Title { get; set; }

        public List<string> Genres { get; set; }
        
        public List<string> Cast { get; set; }

        public List<string> Directors { get; set; }

        public List<string> AgeRestriction { get; set; }

        public List<string> ViewingOptions { get; set; }

        public string ImagePath { get; set; }
    }
}
