using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoDCA.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BOT_INVESTMENT",
                columns: table => new
                {
                    BOT_INVESTMENT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BOT_INVESTMENT_CRYPTOCURRENCY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BOT_INVESTMENT_INVESTEDAMOUNT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BOT_INVESTMENT_CRYPTOCURRENCYAMOUNT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BOT_INVESTMENT_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BOT_INVESTMENT_CURRENTVALUE = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BOT_INVESTMENT_ROI = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOT_INVESTMENT", x => x.BOT_INVESTMENT_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BOT_INVESTMENT");
        }
    }
}
