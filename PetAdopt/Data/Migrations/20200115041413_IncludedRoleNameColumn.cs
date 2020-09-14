using Microsoft.EntityFrameworkCore.Migrations;

namespace PetAdopt.Data.Migrations
{
    public partial class IncludedRoleNameColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Owners",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Owners",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RoleName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Adopters",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Adopters",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "RoleName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Adopters");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Adopters");
        }
    }
}
