using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class _3rd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "airline",
                table: "Flights",
                newName: "airline_logo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "airline_logo",
                table: "Flights",
                newName: "airline");
        }
    }
}
