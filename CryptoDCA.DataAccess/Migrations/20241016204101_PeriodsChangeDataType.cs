using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoDCA.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PeriodsChangeDataType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "GOT_INVEST_PERIOD_DAYS",
                table: "GOT_INVEST_PERIOD",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "GOT_INVEST_PERIOD_DAYS",
                table: "GOT_INVEST_PERIOD",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
