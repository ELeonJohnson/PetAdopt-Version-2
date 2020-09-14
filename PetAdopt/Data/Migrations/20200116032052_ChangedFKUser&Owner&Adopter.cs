using Microsoft.EntityFrameworkCore.Migrations;

namespace PetAdopt.Data.Migrations
{
    public partial class ChangedFKUserOwnerAdopter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adopters_AspNetUsers_AdopterId",
                table: "Adopters");

            migrationBuilder.DropForeignKey(
                name: "FK_Owners_AspNetUsers_OwnerId",
                table: "Owners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Owners",
                table: "Owners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adopters",
                table: "Adopters");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Owners",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Adopters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Owners",
                table: "Owners",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adopters",
                table: "Adopters",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Adopters_AspNetUsers_Id",
                table: "Adopters",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_AspNetUsers_Id",
                table: "Owners",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adopters_AspNetUsers_Id",
                table: "Adopters");

            migrationBuilder.DropForeignKey(
                name: "FK_Owners_AspNetUsers_Id",
                table: "Owners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Owners",
                table: "Owners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adopters",
                table: "Adopters");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Adopters");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Owners",
                table: "Owners",
                column: "OwnerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adopters",
                table: "Adopters",
                column: "AdopterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adopters_AspNetUsers_AdopterId",
                table: "Adopters",
                column: "AdopterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_AspNetUsers_OwnerId",
                table: "Owners",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
