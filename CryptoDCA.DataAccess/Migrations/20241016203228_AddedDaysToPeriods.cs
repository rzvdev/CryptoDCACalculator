using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoDCA.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedDaysToPeriods : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GOT_INVEST_PERIOD_DAYS",
                table: "GOT_INVEST_PERIOD",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GOT_INVEST_PERIOD_DAYS",
                table: "GOT_INVEST_PERIOD");
        }
    }
}
