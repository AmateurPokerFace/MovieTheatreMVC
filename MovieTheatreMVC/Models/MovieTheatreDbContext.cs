using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MovieTheatreMVC.Models
{
    public class MovieTheatreDbContext : IdentityDbContext
    {
        public MovieTheatreDbContext(DbContextOptions<MovieTheatreDbContext> options) : base(options){}

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieTicket> Tickets { get; set; }
        public DbSet<MovieTicketPurchase> TicketPurchases { get; set; }
        public DbSet<Theatre> Theatres { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ActorCredit> CreditedActors { get; set; }
        public DbSet<DirectorCredit> CreditedDirectors { get; set; }
    }
}
