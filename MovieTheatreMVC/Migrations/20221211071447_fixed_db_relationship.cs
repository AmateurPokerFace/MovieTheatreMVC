using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieTheatreMVC.Migrations
{
    public partial class fixed_db_relationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TicketPurchases_Movies_MovieId",
                table: "TicketPurchases");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketPurchases_Theatres_TheatreId",
                table: "TicketPurchases");

            migrationBuilder.DropIndex(
                name: "IX_TicketPurchases_MovieId",
                table: "TicketPurchases");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "TicketPurchases");

            migrationBuilder.RenameColumn(
                name: "TheatreId",
                table: "TicketPurchases",
                newName: "TicketId");

            migrationBuilder.RenameIndex(
                name: "IX_TicketPurchases_TheatreId",
                table: "TicketPurchases",
                newName: "IX_TicketPurchases_TicketId");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TheatreId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_MovieId",
                table: "Tickets",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TheatreId",
                table: "Tickets",
                column: "TheatreId");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketPurchases_Tickets_TicketId",
                table: "TicketPurchases",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Movies_MovieId",
                table: "Tickets",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Theatres_TheatreId",
                table: "Tickets",
                column: "TheatreId",
                principalTable: "Theatres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TicketPurchases_Tickets_TicketId",
                table: "TicketPurchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Movies_MovieId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Theatres_TheatreId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_MovieId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_TheatreId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "TheatreId",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "TicketId",
                table: "TicketPurchases",
                newName: "TheatreId");

            migrationBuilder.RenameIndex(
                name: "IX_TicketPurchases_TicketId",
                table: "TicketPurchases",
                newName: "IX_TicketPurchases_TheatreId");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "TicketPurchases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TicketPurchases_MovieId",
                table: "TicketPurchases",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketPurchases_Movies_MovieId",
                table: "TicketPurchases",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketPurchases_Theatres_TheatreId",
                table: "TicketPurchases",
                column: "TheatreId",
                principalTable: "Theatres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
