using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoDCA.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedPeriodsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GOT_INVEST_PERIOD",
                columns: table => new
                {
                    GOT_INVEST_PERIOD_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GOT_INVEST_PERIOD_PROGID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GOT_INVEST_PERIOD_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GOT_INVEST_PERIOD_DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GOT_INVEST_PERIOD_ISACTIVE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GOT_INVEST_PERIOD", x => x.GOT_INVEST_PERIOD_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GOT_INVEST_PERIOD");
        }
    }
}
