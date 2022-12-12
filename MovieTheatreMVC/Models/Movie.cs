﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MovieTheatreMVC.Models
{
    public class Movie
    {
        public Movie()
        {
            Cast= new List<Actor>();
            Directors = new List<Director>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public int RunningTimeMinutes { get; set; } = 0;

        [Required]
        public string Description { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [ValidateNever]
        public List<Actor> Cast { get; set; }

        [ValidateNever]
        public List<Director> Directors { get; set; }

        [Required]
        public string AgeRestriction { get; set; }

        public string ImagePath { get; set; }

        [Required]
        public bool CanPurchaseTickets { get; set; }

        [Required]
        public decimal BoxOffice { get; set; } = 0;
    }
}
