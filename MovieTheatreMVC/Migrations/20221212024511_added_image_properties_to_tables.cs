using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieTheatreMVC.Migrations
{
    public partial class added_image_properties_to_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TheatreLogoImagePath",
                table: "Theatres",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DirectorImagePath",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ActorImagePath",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TheatreLogoImagePath",
                table: "Theatres");

            migrationBuilder.DropColumn(
                name: "DirectorImagePath",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "ActorImagePath",
                table: "Actors");
        }
    }
}
