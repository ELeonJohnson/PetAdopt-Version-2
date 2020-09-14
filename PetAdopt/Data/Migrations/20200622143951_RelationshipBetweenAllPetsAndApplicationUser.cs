using Microsoft.EntityFrameworkCore.Migrations;

namespace PetAdopt.Data.Migrations
{
    public partial class RelationshipBetweenAllPetsAndApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Reptiles");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Cats");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "Reptiles",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "Dogs",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "Cats",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cats_AspNetUsers_ApplicationUserId",
                table: "Cats",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_AspNetUsers_ApplicationUserId",
                table: "Dogs",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reptiles_AspNetUsers_ApplicationUserId",
                table: "Reptiles",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "Reptiles",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Reptiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "Dogs",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Dogs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "Cats",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Cats",
                nullable: false,
                defaultValue: 0);

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
    }
}
