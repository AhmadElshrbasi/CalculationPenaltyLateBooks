using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleTouchTask.Server.Migrations
{
    /// <inheritdoc />
    public partial class PenaltyValueOneDayProp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "PenaltyValueOneDay",
                table: "libraryCountries",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "libraryCountries",
                keyColumn: "Id",
                keyValue: 1,
                column: "PenaltyValueOneDay",
                value: 40f);

            migrationBuilder.UpdateData(
                table: "libraryCountries",
                keyColumn: "Id",
                keyValue: 2,
                column: "PenaltyValueOneDay",
                value: 5f);

            migrationBuilder.UpdateData(
                table: "libraryCountries",
                keyColumn: "Id",
                keyValue: 3,
                column: "PenaltyValueOneDay",
                value: 6f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PenaltyValueOneDay",
                table: "libraryCountries");
        }
    }
}
