using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VRBike.Migrations
{
    /// <inheritdoc />
    public partial class tourCollection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bikeapp_Tour_TourID",
                table: "Bikeapp");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bikeapp",
                table: "Bikeapp");

            migrationBuilder.RenameTable(
                name: "Bikeapp",
                newName: "ToursCollection");

            migrationBuilder.RenameIndex(
                name: "IX_Bikeapp_TourID",
                table: "ToursCollection",
                newName: "IX_ToursCollection_TourID");

            migrationBuilder.AddColumn<int>(
                name: "TourCollectionID",
                table: "Video",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TourCollectionID",
                table: "Tour",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TourCollectionID",
                table: "ToursCollection",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToursCollection",
                table: "ToursCollection",
                column: "BikeappID");

            migrationBuilder.CreateTable(
                name: "ToursCollections",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Percorso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Raccolta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Risorse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RaccoltaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToursCollections", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Video_TourCollectionID",
                table: "Video",
                column: "TourCollectionID");

            migrationBuilder.CreateIndex(
                name: "IX_Tour_TourCollectionID",
                table: "Tour",
                column: "TourCollectionID");

            migrationBuilder.CreateIndex(
                name: "IX_ToursCollection_TourCollectionID",
                table: "ToursCollection",
                column: "TourCollectionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tour_ToursCollections_TourCollectionID",
                table: "Tour",
                column: "TourCollectionID",
                principalTable: "ToursCollections",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ToursCollection_Tour_TourID",
                table: "ToursCollection",
                column: "TourID",
                principalTable: "Tour",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ToursCollection_ToursCollections_TourCollectionID",
                table: "ToursCollection",
                column: "TourCollectionID",
                principalTable: "ToursCollections",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Video_ToursCollections_TourCollectionID",
                table: "Video",
                column: "TourCollectionID",
                principalTable: "ToursCollections",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tour_ToursCollections_TourCollectionID",
                table: "Tour");

            migrationBuilder.DropForeignKey(
                name: "FK_ToursCollection_Tour_TourID",
                table: "ToursCollection");

            migrationBuilder.DropForeignKey(
                name: "FK_ToursCollection_ToursCollections_TourCollectionID",
                table: "ToursCollection");

            migrationBuilder.DropForeignKey(
                name: "FK_Video_ToursCollections_TourCollectionID",
                table: "Video");

            migrationBuilder.DropTable(
                name: "ToursCollections");

            migrationBuilder.DropIndex(
                name: "IX_Video_TourCollectionID",
                table: "Video");

            migrationBuilder.DropIndex(
                name: "IX_Tour_TourCollectionID",
                table: "Tour");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ToursCollection",
                table: "ToursCollection");

            migrationBuilder.DropIndex(
                name: "IX_ToursCollection_TourCollectionID",
                table: "ToursCollection");

            migrationBuilder.DropColumn(
                name: "TourCollectionID",
                table: "Video");

            migrationBuilder.DropColumn(
                name: "TourCollectionID",
                table: "Tour");

            migrationBuilder.DropColumn(
                name: "TourCollectionID",
                table: "ToursCollection");

            migrationBuilder.RenameTable(
                name: "ToursCollection",
                newName: "Bikeapp");

            migrationBuilder.RenameIndex(
                name: "IX_ToursCollection_TourID",
                table: "Bikeapp",
                newName: "IX_Bikeapp_TourID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bikeapp",
                table: "Bikeapp",
                column: "BikeappID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bikeapp_Tour_TourID",
                table: "Bikeapp",
                column: "TourID",
                principalTable: "Tour",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
