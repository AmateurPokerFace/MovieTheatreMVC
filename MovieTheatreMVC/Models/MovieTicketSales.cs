using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MovieTheatreMVC.Models
{
    public class MovieTicketSales
    {
        public MovieTicketSales()
        {
            MovieGenres = new List<string>();
            MovieDirectors = new List<string>();
        }

        [Key]
        public int Id { get; set; }
        
        [Required]
        public string MovieTitle { get; set; }

        [Required]
        public DateTime MovieReleaseDate { get; set; }

        [Required]
        public List<string> MovieGenres { get; set; }

        [Required]
        public List<string> MovieDirectors { get; set; }

        [Required]
        public decimal GrossSales { get; set; }

        //table relationships beginning
        public int MovieId { get; set; }
        [ValidateNever]
        public Movie Movie { get; set; }

        public int CustomerId { get; set; }
        [ValidateNever]
        public List<Customer> Customers { get; set; }

        public int MovieTicketPurchaseId { get; set; }
        [ValidateNever]
        public List<MovieTicketPurchase> MovieTicketPurchase { get; set; }

        public int MovieTicketId { get; set; }
        [ValidateNever]
        public MovieTicket MovieTicket { get; set; }
        //table relationships ending



        public void SubtractFromGrossSales(decimal amountToSubtract) 
        {
            GrossSales -= amountToSubtract;
        }

        public void AddToGrossSales(decimal amountToAdd) 
        {
            GrossSales += amountToAdd;
        }
    }
}
