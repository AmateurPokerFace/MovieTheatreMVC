﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieTheatreMVC.Models;

#nullable disable

namespace MovieTheatreMVC.Migrations
{
    [DbContext(typeof(MovieTheatreDbContext))]
    partial class MovieTheatreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ActorMovie", b =>
                {
                    b.Property<int>("CastId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesStarredInId")
                        .HasColumnType("int");

                    b.HasKey("CastId", "MoviesStarredInId");

                    b.HasIndex("MoviesStarredInId");

                    b.ToTable("ActorMovie");
                });

            modelBuilder.Entity("DirectorMovie", b =>
                {
                    b.Property<int>("DirectorsId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesDirectedId")
                        .HasColumnType("int");

                    b.HasKey("DirectorsId", "MoviesDirectedId");

                    b.HasIndex("MoviesDirectedId");

                    b.ToTable("DirectorMovie");
                });

            modelBuilder.Entity("MovieTheatreMVC.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("MovieTheatreMVC.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("MovieTheatreMVC.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MovieTicketPurchaseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("MovieTheatreMVC.Models.Director", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Directors");
                });

            modelBuilder.Entity("MovieTheatreMVC.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("MovieTheatreMVC.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<string>("AgeRestriction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("BoxOffice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("CanPurchaseTickets")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RunningTimeMinutes")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MovieTheatreMVC.Models.MovieTicket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("HasPromoCode")
                        .HasColumnType("bit");

                    b.Property<int>("MaximumPerTransaction")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("TheatreId")
                        .HasColumnType("int");

                    b.Property<decimal>("TicketCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("TheatreId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("MovieTheatreMVC.Models.MovieTicketPurchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatePurchased")
                        .HasColumnType("datetime2");

                    b.Property<string>("MovieShowTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PurchasedAdultQuantity")
                        .HasColumnType("int");

                    b.Property<int>("PurchasedChildQuantity")
                        .HasColumnType("int");

                    b.Property<int>("PurchasedSeniorQuantity")
                        .HasColumnType("int");

                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TicketId");

                    b.ToTable("TicketPurchases");
                });

            modelBuilder.Entity("MovieTheatreMVC.Models.Theatre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TheatreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Theatres");
                });

            modelBuilder.Entity("ActorMovie", b =>
                {
                    b.HasOne("MovieTheatreMVC.Models.Actor", null)
                        .WithMany()
                        .HasForeignKey("CastId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieTheatreMVC.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesStarredInId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DirectorMovie", b =>
                {
                    b.HasOne("MovieTheatreMVC.Models.Director", null)
                        .WithMany()
                        .HasForeignKey("DirectorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieTheatreMVC.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesDirectedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieTheatreMVC.Models.Genre", b =>
                {
                    b.HasOne("MovieTheatreMVC.Models.Movie", null)
                        .WithMany("Genres")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("MovieTheatreMVC.Models.MovieTicket", b =>
                {
                    b.HasOne("MovieTheatreMVC.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieTheatreMVC.Models.Theatre", "Theatre")
                        .WithMany()
                        .HasForeignKey("TheatreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Theatre");
                });

            modelBuilder.Entity("MovieTheatreMVC.Models.MovieTicketPurchase", b =>
                {
                    b.HasOne("MovieTheatreMVC.Models.Customer", "Customer")
                        .WithMany("MovieTicketPurchases")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieTheatreMVC.Models.MovieTicket", "Ticket")
                        .WithMany()
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("MovieTheatreMVC.Models.Customer", b =>
                {
                    b.Navigation("MovieTicketPurchases");
                });

            modelBuilder.Entity("MovieTheatreMVC.Models.Movie", b =>
                {
                    b.Navigation("Genres");
                });
#pragma warning restore 612, 618
        }
    }
}
