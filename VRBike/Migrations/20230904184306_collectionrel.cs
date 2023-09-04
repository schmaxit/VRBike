using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VRBike.Migrations
{
    /// <inheritdoc />
    public partial class collectionrel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tour_ToursCollection_TourCollectionID",
                table: "Tour");

            migrationBuilder.AlterColumn<int>(
                name: "TourCollectionID",
                table: "Tour",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tour_ToursCollection_TourCollectionID",
                table: "Tour",
                column: "TourCollectionID",
                principalTable: "ToursCollection",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tour_ToursCollection_TourCollectionID",
                table: "Tour");

            migrationBuilder.AlterColumn<int>(
                name: "TourCollectionID",
                table: "Tour",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Tour_ToursCollection_TourCollectionID",
                table: "Tour",
                column: "TourCollectionID",
                principalTable: "ToursCollection",
                principalColumn: "ID");
        }
    }
}
