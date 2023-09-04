using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VRBike.Migrations
{
    /// <inheritdoc />
    public partial class collectFKbug6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "ToursCollection",
                newName: "TourCollectionID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Tour",
                newName: "TourID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TourCollectionID",
                table: "ToursCollection",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "TourID",
                table: "Tour",
                newName: "ID");
        }
    }
}
