using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VRBike.Migrations
{
    /// <inheritdoc />
    public partial class collectionbugfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "IX_ToursCollection_TourCollectionID",
                table: "ToursCollection");

            migrationBuilder.DropIndex(
                name: "IX_ToursCollection_TourID",
                table: "ToursCollection");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "ToursCollection");

            migrationBuilder.DropColumn(
                name: "TourCollectionID",
                table: "ToursCollection");

            migrationBuilder.RenameColumn(
                name: "TourID",
                table: "ToursCollection",
                newName: "RaccoltaID");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "ToursCollection",
                newName: "Risorse");

            migrationBuilder.RenameColumn(
                name: "Link",
                table: "ToursCollection",
                newName: "Raccolta");

            migrationBuilder.RenameColumn(
                name: "Icon",
                table: "ToursCollection",
                newName: "Percorso");

            migrationBuilder.RenameColumn(
                name: "BikeappID",
                table: "ToursCollection",
                newName: "ID");

            migrationBuilder.AddColumn<string>(
                name: "PageTitle",
                table: "ToursCollection",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Bikeapp",
                columns: table => new
                {
                    BikeappID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TourID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    TourCollectionID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bikeapp", x => x.BikeappID);
                    table.ForeignKey(
                        name: "FK_Bikeapp_Tour_TourID",
                        column: x => x.TourID,
                        principalTable: "Tour",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bikeapp_ToursCollection_TourCollectionID",
                        column: x => x.TourCollectionID,
                        principalTable: "ToursCollection",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bikeapp_TourCollectionID",
                table: "Bikeapp",
                column: "TourCollectionID");

            migrationBuilder.CreateIndex(
                name: "IX_Bikeapp_TourID",
                table: "Bikeapp",
                column: "TourID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tour_ToursCollection_TourCollectionID",
                table: "Tour",
                column: "TourCollectionID",
                principalTable: "ToursCollection",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Video_ToursCollection_TourCollectionID",
                table: "Video",
                column: "TourCollectionID",
                principalTable: "ToursCollection",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tour_ToursCollection_TourCollectionID",
                table: "Tour");

            migrationBuilder.DropForeignKey(
                name: "FK_Video_ToursCollection_TourCollectionID",
                table: "Video");

            migrationBuilder.DropTable(
                name: "Bikeapp");

            migrationBuilder.DropColumn(
                name: "PageTitle",
                table: "ToursCollection");

            migrationBuilder.RenameColumn(
                name: "Risorse",
                table: "ToursCollection",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "RaccoltaID",
                table: "ToursCollection",
                newName: "TourID");

            migrationBuilder.RenameColumn(
                name: "Raccolta",
                table: "ToursCollection",
                newName: "Link");

            migrationBuilder.RenameColumn(
                name: "Percorso",
                table: "ToursCollection",
                newName: "Icon");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "ToursCollection",
                newName: "BikeappID");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "ToursCollection",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TourCollectionID",
                table: "ToursCollection",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ToursCollections",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Percorso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Raccolta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RaccoltaID = table.Column<int>(type: "int", nullable: false),
                    Risorse = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToursCollections", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ToursCollection_TourCollectionID",
                table: "ToursCollection",
                column: "TourCollectionID");

            migrationBuilder.CreateIndex(
                name: "IX_ToursCollection_TourID",
                table: "ToursCollection",
                column: "TourID");

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
    }
}
