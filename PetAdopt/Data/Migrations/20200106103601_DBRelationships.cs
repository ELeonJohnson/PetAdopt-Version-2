using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PetAdopt.Data.Migrations
{
    public partial class DBRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adopters",
                columns: table => new
                {
                    AdopterId = table.Column<int>(nullable: false),
                    Image = table.Column<byte[]>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adopters", x => x.AdopterId);
                    table.ForeignKey(
                        name: "FK_Adopters_AspNetUsers_AdopterId",
                        column: x => x.AdopterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    OwnerId = table.Column<int>(nullable: false),
                    Image = table.Column<byte[]>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ReptileId = table.Column<int>(nullable: true),
                    DogId = table.Column<int>(nullable: true),
                    CatId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.OwnerId);
                    table.ForeignKey(
                        name: "FK_Owners_Cats_CatId",
                        column: x => x.CatId,
                        principalTable: "Cats",
                        principalColumn: "CatId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Owners_Dogs_DogId",
                        column: x => x.DogId,
                        principalTable: "Dogs",
                        principalColumn: "DogId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Owners_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Owners_Reptiles_ReptileId",
                        column: x => x.ReptileId,
                        principalTable: "Reptiles",
                        principalColumn: "ReptileId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Owners_CatId",
                table: "Owners",
                column: "CatId");

            migrationBuilder.CreateIndex(
                name: "IX_Owners_DogId",
                table: "Owners",
                column: "DogId");

            migrationBuilder.CreateIndex(
                name: "IX_Owners_ReptileId",
                table: "Owners",
                column: "ReptileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adopters");

            migrationBuilder.DropTable(
                name: "Owners");
        }
    }
}
