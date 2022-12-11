using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieTheatreMVC.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 1)]
        [DisplayName("Genre Name")]
        public string GenreName { get; set; }
    }
}
