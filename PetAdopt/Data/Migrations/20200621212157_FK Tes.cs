using Microsoft.EntityFrameworkCore.Migrations;

namespace PetAdopt.Data.Migrations
{
    public partial class FKTes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "DogId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ReptileId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserId",
                table: "Reptiles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Reptiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserId",
                table: "Dogs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Dogs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserId",
                table: "Cats",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Cats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reptiles_ApplicationUserId",
                table: "Reptiles",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_ApplicationUserId",
                table: "Dogs",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cats_ApplicationUserId",
                table: "Cats",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cats_AspNetUsers_ApplicationUserId",
                table: "Cats",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_AspNetUsers_ApplicationUserId",
                table: "Dogs",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reptiles_AspNetUsers_ApplicationUserId",
                table: "Reptiles",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cats_AspNetUsers_ApplicationUserId",
                table: "Cats");

            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_AspNetUsers_ApplicationUserId",
                table: "Dogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Reptiles_AspNetUsers_ApplicationUserId",
                table: "Reptiles");

            migrationBuilder.DropIndex(
                name: "IX_Reptiles_ApplicationUserId",
                table: "Reptiles");

            migrationBuilder.DropIndex(
                name: "IX_Dogs_ApplicationUserId",
                table: "Dogs");

            migrationBuilder.DropIndex(
                name: "IX_Cats_ApplicationUserId",
                table: "Cats");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Reptiles");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Reptiles");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Cats");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Cats");

            migrationBuilder.AddColumn<int>(
                name: "CatId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DogId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReptileId",
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
    }
}
