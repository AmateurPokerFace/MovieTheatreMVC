using System.ComponentModel.DataAnnotations;

namespace MovieTheatreMVC.Models
{
    public class Theatre
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string StreetAddress { get; set; }

        [Required]
        public string ZipCode { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string TheatreName { get; set; }

        public string TheatreLogoImagePath { get; set; }
    }
}
