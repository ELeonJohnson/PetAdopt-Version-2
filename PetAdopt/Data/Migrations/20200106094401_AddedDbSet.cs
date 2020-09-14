using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PetAdopt.Data.Migrations
{
    public partial class AddedDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    CatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Age = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true),
                    FoodReq = table.Column<string>(nullable: true),
                    HabitatReq = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    RecentCheckup = table.Column<bool>(nullable: false),
                    Trained = table.Column<bool>(nullable: false),
                    Neutered = table.Column<bool>(nullable: false),
                    Declawed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "Dogs",
                columns: table => new
                {
                    DogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Age = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true),
                    FoodReq = table.Column<string>(nullable: true),
                    HabitatReq = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    RecentCheckup = table.Column<bool>(nullable: false),
                    Trained = table.Column<bool>(nullable: false),
                    Neutered = table.Column<bool>(nullable: false),
                    Declawed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.DogId);
                });

            migrationBuilder.CreateTable(
                name: "Reptiles",
                columns: table => new
                {
                    ReptileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Age = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true),
                    FoodReq = table.Column<string>(nullable: true),
                    HabitatReq = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    RecentCheckup = table.Column<bool>(nullable: false),
                    Trained = table.Column<bool>(nullable: false),
                    Neutered = table.Column<bool>(nullable: false),
                    Declawed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reptiles", x => x.ReptileId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cats");

            migrationBuilder.DropTable(
                name: "Dogs");

            migrationBuilder.DropTable(
                name: "Reptiles");
        }
    }
}
