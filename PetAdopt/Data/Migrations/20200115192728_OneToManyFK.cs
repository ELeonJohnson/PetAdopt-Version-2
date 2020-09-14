using Microsoft.EntityFrameworkCore.Migrations;

namespace PetAdopt.Data.Migrations
{
    public partial class OneToManyFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cats_Owners_OwnerId",
                table: "Cats");

            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_Owners_OwnerId",
                table: "Dogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Reptiles_Owners_OwnerId",
                table: "Reptiles");

            migrationBuilder.DropIndex(
                name: "IX_Reptiles_OwnerId",
                table: "Reptiles");

            migrationBuilder.DropIndex(
                name: "IX_Dogs_OwnerId",
                table: "Dogs");

            migrationBuilder.DropIndex(
                name: "IX_Cats_OwnerId",
                table: "Cats");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Reptiles");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Cats");

            migrationBuilder.AddColumn<int>(
                name: "CatId",
                table: "Owners",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DogId",
                table: "Owners",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReptileId",
                table: "Owners",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Cats_CatId",
                table: "Owners",
                column: "CatId",
                principalTable: "Cats",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Dogs_DogId",
                table: "Owners",
                column: "DogId",
                principalTable: "Dogs",
                principalColumn: "DogId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Reptiles_ReptileId",
                table: "Owners",
                column: "ReptileId",
                principalTable: "Reptiles",
                principalColumn: "ReptileId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Cats_CatId",
                table: "Owners");

            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Dogs_DogId",
                table: "Owners");

            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Reptiles_ReptileId",
                table: "Owners");

            migrationBuilder.DropIndex(
                name: "IX_Owners_CatId",
                table: "Owners");

            migrationBuilder.DropIndex(
                name: "IX_Owners_DogId",
                table: "Owners");

            migrationBuilder.DropIndex(
                name: "IX_Owners_ReptileId",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "CatId",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "DogId",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "ReptileId",
                table: "Owners");

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Reptiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Dogs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Cats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reptiles_OwnerId",
                table: "Reptiles",
                column: "OwnerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_OwnerId",
                table: "Dogs",
                column: "OwnerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cats_OwnerId",
                table: "Cats",
                column: "OwnerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cats_Owners_OwnerId",
                table: "Cats",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "OwnerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_Owners_OwnerId",
                table: "Dogs",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "OwnerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reptiles_Owners_OwnerId",
                table: "Reptiles",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "OwnerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
