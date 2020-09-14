using Microsoft.EntityFrameworkCore.Migrations;

namespace PetAdopt.Data.Migrations
{
    public partial class TestingFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cats_Owners_OwnerForeignKey",
                table: "Cats");

            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_Owners_OwnerForeignKey",
                table: "Dogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Reptiles_Owners_OwnerForeignKey",
                table: "Reptiles");

            migrationBuilder.RenameColumn(
                name: "OwnerForeignKey",
                table: "Reptiles",
                newName: "OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Reptiles_OwnerForeignKey",
                table: "Reptiles",
                newName: "IX_Reptiles_OwnerId");

            migrationBuilder.RenameColumn(
                name: "OwnerForeignKey",
                table: "Dogs",
                newName: "OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Dogs_OwnerForeignKey",
                table: "Dogs",
                newName: "IX_Dogs_OwnerId");

            migrationBuilder.RenameColumn(
                name: "OwnerForeignKey",
                table: "Cats",
                newName: "OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Cats_OwnerForeignKey",
                table: "Cats",
                newName: "IX_Cats_OwnerId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Reptiles",
                newName: "OwnerForeignKey");

            migrationBuilder.RenameIndex(
                name: "IX_Reptiles_OwnerId",
                table: "Reptiles",
                newName: "IX_Reptiles_OwnerForeignKey");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Dogs",
                newName: "OwnerForeignKey");

            migrationBuilder.RenameIndex(
                name: "IX_Dogs_OwnerId",
                table: "Dogs",
                newName: "IX_Dogs_OwnerForeignKey");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Cats",
                newName: "OwnerForeignKey");

            migrationBuilder.RenameIndex(
                name: "IX_Cats_OwnerId",
                table: "Cats",
                newName: "IX_Cats_OwnerForeignKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Cats_Owners_OwnerForeignKey",
                table: "Cats",
                column: "OwnerForeignKey",
                principalTable: "Owners",
                principalColumn: "OwnerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_Owners_OwnerForeignKey",
                table: "Dogs",
                column: "OwnerForeignKey",
                principalTable: "Owners",
                principalColumn: "OwnerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reptiles_Owners_OwnerForeignKey",
                table: "Reptiles",
                column: "OwnerForeignKey",
                principalTable: "Owners",
                principalColumn: "OwnerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
