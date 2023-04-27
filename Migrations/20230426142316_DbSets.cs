using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HayvanBakımıDb.Migrations
{
    public partial class DbSets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bakicilar",
                columns: table => new
                {
                    BakiciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bakicilar", x => x.BakiciId);
                });

            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    SahipID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.SahipID);
                });

            migrationBuilder.CreateTable(
                name: "Yiyecekler",
                columns: table => new
                {
                    YiyecekID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YiyecekAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YiyecekIcerigi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kalori = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yiyecekler", x => x.YiyecekID);
                });

            migrationBuilder.CreateTable(
                name: "Hayvanlar",
                columns: table => new
                {
                    HayID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cinsiyet = table.Column<int>(type: "int", nullable: false),
                    SahibiVarMi = table.Column<bool>(type: "bit", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kilo = table.Column<double>(type: "float", nullable: false),
                    Tur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cins = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SahipId = table.Column<int>(type: "int", nullable: false),
                    BakId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hayvanlar", x => x.HayID);
                    table.ForeignKey(
                        name: "FK_Hayvanlar_Bakicilar_BakId",
                        column: x => x.BakId,
                        principalTable: "Bakicilar",
                        principalColumn: "BakiciId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hayvanlar_Owner_SahipId",
                        column: x => x.SahipId,
                        principalTable: "Owner",
                        principalColumn: "SahipID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HayvanYiyecek",
                columns: table => new
                {
                    HayvanlarHayID = table.Column<int>(type: "int", nullable: false),
                    YiyeceklerYiyecekID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HayvanYiyecek", x => new { x.HayvanlarHayID, x.YiyeceklerYiyecekID });
                    table.ForeignKey(
                        name: "FK_HayvanYiyecek_Hayvanlar_HayvanlarHayID",
                        column: x => x.HayvanlarHayID,
                        principalTable: "Hayvanlar",
                        principalColumn: "HayID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HayvanYiyecek_Yiyecekler_YiyeceklerYiyecekID",
                        column: x => x.YiyeceklerYiyecekID,
                        principalTable: "Yiyecekler",
                        principalColumn: "YiyecekID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hayvanlar_BakId",
                table: "Hayvanlar",
                column: "BakId");

            migrationBuilder.CreateIndex(
                name: "IX_Hayvanlar_SahipId",
                table: "Hayvanlar",
                column: "SahipId");

            migrationBuilder.CreateIndex(
                name: "IX_HayvanYiyecek_YiyeceklerYiyecekID",
                table: "HayvanYiyecek",
                column: "YiyeceklerYiyecekID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HayvanYiyecek");

            migrationBuilder.DropTable(
                name: "Hayvanlar");

            migrationBuilder.DropTable(
                name: "Yiyecekler");

            migrationBuilder.DropTable(
                name: "Bakicilar");

            migrationBuilder.DropTable(
                name: "Owner");
        }
    }
}
