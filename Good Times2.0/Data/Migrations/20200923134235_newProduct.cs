using Microsoft.EntityFrameworkCore.Migrations;

namespace Good_Times2._0.Data.Migrations
{
    public partial class newProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menukaart",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: true),
                    MenuKaartId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menukaart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: true),
                    MenuCategoryId = table.Column<int>(nullable: false),
                    MenukaartId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuCategory_Menukaart_MenukaartId",
                        column: x => x.MenukaartId,
                        principalTable: "Menukaart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: true),
                    Omschrijving = table.Column<string>(nullable: true),
                    Prijs = table.Column<double>(nullable: false),
                    MenuCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_MenuCategory_MenuCategoryId",
                        column: x => x.MenuCategoryId,
                        principalTable: "MenuCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuCategory_MenukaartId",
                table: "MenuCategory",
                column: "MenukaartId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_MenuCategoryId",
                table: "Product",
                column: "MenuCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "MenuCategory");

            migrationBuilder.DropTable(
                name: "Menukaart");
        }
    }
}
