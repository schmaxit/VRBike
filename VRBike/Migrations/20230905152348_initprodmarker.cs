using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VRBike.Migrations
{
    /// <inheritdoc />
    public partial class initprodmarker : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TourMarker_TourID",
                table: "TourMarker",
                column: "TourID");

            migrationBuilder.AddForeignKey(
                name: "FK_TourMarker_Tour_TourID",
                table: "TourMarker",
                column: "TourID",
                principalTable: "Tour",
                principalColumn: "TourID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TourMarker_Tour_TourID",
                table: "TourMarker");

            migrationBuilder.DropIndex(
                name: "IX_TourMarker_TourID",
                table: "TourMarker");
        }
    }
}
