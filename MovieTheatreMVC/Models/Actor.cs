﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTheatreMVC.Models
{
    public class Actor
    {

        public Actor()
        {
            CreditedMovies = new List<ActorCredit>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string? ActorImagePath { get; set; }

        [ValidateNever]
        [NotMapped]
        public List<ActorCredit> CreditedMovies { get; set; }

    }
}
