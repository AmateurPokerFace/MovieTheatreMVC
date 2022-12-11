using Microsoft.EntityFrameworkCore;

namespace MovieTheatreMVC.Models
{
    public class MovieTheatreDbContext : DbContext
    {
        public MovieTheatreDbContext(MovieTheatreDbContext options) : base()
        {

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieTicket> Tickets { get; set; }
        public DbSet<MovieTicketPurchase> TicketPurchases { get; set; }
        public DbSet<MovieTicketSales> TicketSales { get; set; }
        public DbSet<Theatre> Theatres { get; set; }
    }
}
