using Microsoft.EntityFrameworkCore.Migrations;

namespace eTickets.Migrations
{
    public partial class RemovedMovieRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Movie_MovieId",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_MovieId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Movie");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Movie",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_MovieId",
                table: "Movie",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Movie_MovieId",
                table: "Movie",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
