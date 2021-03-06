﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetAdopt.Data;

namespace PetAdopt.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200115171935_TestingFKTwo")]
    partial class TestingFKTwo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PetAdopt.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("RoleName");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("PetAdopt.Models.Adopter", b =>
                {
                    b.Property<int>("AdopterId");

                    b.Property<string>("City");

                    b.Property<string>("FirstName");

                    b.Property<byte[]>("Image");

                    b.Property<string>("LastName");

                    b.Property<string>("State");

                    b.HasKey("AdopterId");

                    b.ToTable("Adopters");
                });

            modelBuilder.Entity("PetAdopt.Models.Cat", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Age");

                    b.Property<string>("Color");

                    b.Property<bool>("Declawed");

                    b.Property<string>("FoodReq");

                    b.Property<string>("Gender");

                    b.Property<bool>("GoodWithCats");

                    b.Property<bool>("GoodWithDogs");

                    b.Property<bool>("GoodWithKids");

                    b.Property<string>("HabitatReq");

                    b.Property<byte[]>("Image");

                    b.Property<string>("Name");

                    b.Property<bool>("Neutered");

                    b.Property<int>("OwnerId");

                    b.Property<bool>("RecentCheckup");

                    b.Property<string>("Size");

                    b.Property<bool>("Trained");

                    b.Property<string>("Type");

                    b.HasKey("CatId");

                    b.HasIndex("OwnerId")
                        .IsUnique();

                    b.ToTable("Cats");
                });

            modelBuilder.Entity("PetAdopt.Models.Dog", b =>
                {
                    b.Property<int>("DogId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Age");

                    b.Property<string>("Color");

                    b.Property<bool>("Declawed");

                    b.Property<string>("FoodReq");

                    b.Property<string>("Gender");

                    b.Property<bool>("GoodWithCats");

                    b.Property<bool>("GoodWithDogs");

                    b.Property<bool>("GoodWithKids");

                    b.Property<string>("HabitatReq");

                    b.Property<byte[]>("Image");

                    b.Property<string>("Name");

                    b.Property<bool>("Neutered");

                    b.Property<int>("OwnerId");

                    b.Property<bool>("RecentCheckup");

                    b.Property<string>("Size");

                    b.Property<bool>("Trained");

                    b.Property<string>("Type");

                    b.HasKey("DogId");

                    b.HasIndex("OwnerId")
                        .IsUnique();

                    b.ToTable("Dogs");
                });

            modelBuilder.Entity("PetAdopt.Models.Owner", b =>
                {
                    b.Property<int>("OwnerId");

                    b.Property<string>("City");

                    b.Property<string>("FirstName");

                    b.Property<byte[]>("Image");

                    b.Property<string>("LastName");

                    b.Property<string>("State");

                    b.HasKey("OwnerId");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("PetAdopt.Models.Reptile", b =>
                {
                    b.Property<int>("ReptileId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Age");

                    b.Property<string>("Color");

                    b.Property<bool>("Declawed");

                    b.Property<string>("FoodReq");

                    b.Property<string>("Gender");

                    b.Property<bool>("GoodWithKids");

                    b.Property<bool>("GoodWithRept");

                    b.Property<string>("HabitatReq");

                    b.Property<byte[]>("Image");

                    b.Property<string>("Name");

                    b.Property<bool>("Neutered");

                    b.Property<int>("OwnerId");

                    b.Property<bool>("RecentCheckup");

                    b.Property<string>("Size");

                    b.Property<bool>("Trained");

                    b.Property<string>("Type");

                    b.HasKey("ReptileId");

                    b.HasIndex("OwnerId")
                        .IsUnique();

                    b.ToTable("Reptiles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("PetAdopt.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("PetAdopt.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PetAdopt.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("PetAdopt.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PetAdopt.Models.Adopter", b =>
                {
                    b.HasOne("PetAdopt.ApplicationUser", "ApplicationUser")
                        .WithOne("Adopter")
                        .HasForeignKey("PetAdopt.Models.Adopter", "AdopterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PetAdopt.Models.Cat", b =>
                {
                    b.HasOne("PetAdopt.Models.Owner", "Owner")
                        .WithOne("Cat")
                        .HasForeignKey("PetAdopt.Models.Cat", "OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PetAdopt.Models.Dog", b =>
                {
                    b.HasOne("PetAdopt.Models.Owner", "Owner")
                        .WithOne("Dog")
                        .HasForeignKey("PetAdopt.Models.Dog", "OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PetAdopt.Models.Owner", b =>
                {
                    b.HasOne("PetAdopt.ApplicationUser", "ApplicationUser")
                        .WithOne("Owner")
                        .HasForeignKey("PetAdopt.Models.Owner", "OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PetAdopt.Models.Reptile", b =>
                {
                    b.HasOne("PetAdopt.Models.Owner", "Owner")
                        .WithOne("Reptile")
                        .HasForeignKey("PetAdopt.Models.Reptile", "OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
