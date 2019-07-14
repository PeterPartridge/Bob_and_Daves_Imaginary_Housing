using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.DataLayer.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PropertyDB",
                columns: table => new
                {
                    propertyId = table.Column<Guid>(nullable: false),
                    PropertyType = table.Column<string>(nullable: true),
                    FreeHolder = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyDB", x => x.propertyId);
                });

            migrationBuilder.CreateTable(
                name: "AddressDB",
                columns: table => new
                {
                    AddressId = table.Column<Guid>(nullable: false),
                    PropertyNameOrNumber = table.Column<string>(nullable: true),
                    LineOne = table.Column<string>(nullable: true),
                    LineTwo = table.Column<string>(nullable: true),
                    LineThree = table.Column<string>(nullable: true),
                    LineFour = table.Column<string>(nullable: true),
                    LineFive = table.Column<string>(nullable: true),
                    PostCode = table.Column<string>(nullable: true),
                    isCurrentlyUsed = table.Column<bool>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressDB", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_AddressDB_PropertyDB_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "PropertyDB",
                        principalColumn: "propertyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressDB_OwnerId",
                table: "AddressDB",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressDB");

            migrationBuilder.DropTable(
                name: "PropertyDB");
        }
    }
}
