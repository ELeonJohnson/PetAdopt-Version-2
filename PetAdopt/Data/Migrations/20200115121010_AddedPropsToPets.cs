using Microsoft.EntityFrameworkCore.Migrations;

namespace PetAdopt.Data.Migrations
{
    public partial class AddedPropsToPets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "GoodWithKids",
                table: "Reptiles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "GoodWithRept",
                table: "Reptiles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "GoodWithCats",
                table: "Dogs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "GoodWithDogs",
                table: "Dogs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "GoodWithKids",
                table: "Dogs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "GoodWithCats",
                table: "Cats",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "GoodWithDogs",
                table: "Cats",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "GoodWithKids",
                table: "Cats",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoodWithKids",
                table: "Reptiles");

            migrationBuilder.DropColumn(
                name: "GoodWithRept",
                table: "Reptiles");

            migrationBuilder.DropColumn(
                name: "GoodWithCats",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "GoodWithDogs",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "GoodWithKids",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "GoodWithCats",
                table: "Cats");

            migrationBuilder.DropColumn(
                name: "GoodWithDogs",
                table: "Cats");

            migrationBuilder.DropColumn(
                name: "GoodWithKids",
                table: "Cats");
        }
    }
}
