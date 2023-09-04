using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VRBike.Migrations
{
    /// <inheritdoc />
    public partial class collectFKbug2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CollectionID",
                table: "Tour");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CollectionID",
                table: "Tour",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
