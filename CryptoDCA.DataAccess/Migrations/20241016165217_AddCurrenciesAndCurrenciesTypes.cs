using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoDCA.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddCurrenciesAndCurrenciesTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GOT_CURRENCY_TYPE",
                columns: table => new
                {
                    GOT_CURRENCY_TYPE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GOT_CURRENCY_TYPE_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GOT_CURRENCY_TYPE_PROGID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GOT_CURRENCY_TYPE_DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GOT_CURRENCY_TYPE_ISACTIVE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GOT_CURRENCY_TYPE", x => x.GOT_CURRENCY_TYPE_ID);
                });

            migrationBuilder.CreateTable(
                name: "GOT_CURRENCY",
                columns: table => new
                {
                    GOT_CURRENCY_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GOT_CURRENCY_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GOT_CURRENCY_SYMBOL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GOT_CURRENCY_ISACTIVE = table.Column<bool>(type: "bit", nullable: false),
                    GOT_CURRENCY_TYPE_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GOT_CURRENCY", x => x.GOT_CURRENCY_ID);
                    table.ForeignKey(
                        name: "FK_GOT_CURRENCY_GOT_CURRENCY_TYPE_GOT_CURRENCY_TYPE_ID",
                        column: x => x.GOT_CURRENCY_TYPE_ID,
                        principalTable: "GOT_CURRENCY_TYPE",
                        principalColumn: "GOT_CURRENCY_TYPE_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GOT_CURRENCY_GOT_CURRENCY_TYPE_ID",
                table: "GOT_CURRENCY",
                column: "GOT_CURRENCY_TYPE_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GOT_CURRENCY");

            migrationBuilder.DropTable(
                name: "GOT_CURRENCY_TYPE");
        }
    }
}
