using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PetAdopt.Data.Migrations
{
    public partial class DeletedOwnerAdopter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adopters");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.AddColumn<int>(
                name: "CatId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DogId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReptileId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CatId",
                table: "AspNetUsers",
                column: "CatId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DogId",
                table: "AspNetUsers",
                column: "DogId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ReptileId",
                table: "AspNetUsers",
                column: "ReptileId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Cats_CatId",
                table: "AspNetUsers",
                column: "CatId",
                principalTable: "Cats",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Dogs_DogId",
                table: "AspNetUsers",
                column: "DogId",
                principalTable: "Dogs",
                principalColumn: "DogId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Reptiles_ReptileId",
                table: "AspNetUsers",
                column: "ReptileId",
                principalTable: "Reptiles",
                principalColumn: "ReptileId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Cats_CatId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Dogs_DogId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Reptiles_ReptileId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CatId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DogId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ReptileId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CatId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DogId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ReptileId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "State",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "Adopters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    AdopterId = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adopters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adopters_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CatId = table.Column<int>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    DogId = table.Column<int>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    OwnerId = table.Column<int>(nullable: false),
                    ReptileId = table.Column<int>(nullable: true),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
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
                        name: "FK_Owners_AspNetUsers_Id",
                        column: x => x.Id,
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
    }
}
