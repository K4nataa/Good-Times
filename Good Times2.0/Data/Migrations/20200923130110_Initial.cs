using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Good_Times2._0.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservering",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telefoonnummer = table.Column<string>(nullable: true),
                    AantalPersonen = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Begintijd = table.Column<DateTime>(nullable: false),
                    Eindtijd = table.Column<DateTime>(nullable: false),
                    Opmerkingen = table.Column<string>(nullable: true),
                    MedewerkerId = table.Column<string>(nullable: true),
                    DatumAangemaakt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservering", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservering_AspNetUsers_MedewerkerId",
                        column: x => x.MedewerkerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservering_MedewerkerId",
                table: "Reservering",
                column: "MedewerkerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservering");
        }
    }
}
