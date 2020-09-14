using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetAdopt.Models;


namespace PetAdopt.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Reptile> Reptiles { get; set; }
        public DbSet<Cat> Cats { get; set; }
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>()
                .HasMany(r => r.Reptiles)
                .WithOne(u => u.ApplicationUser)
                .IsRequired();

            builder.Entity<ApplicationUser>()
                .HasMany(r => r.Dogs)
                .WithOne(u => u.ApplicationUser)
                .IsRequired();

            builder.Entity<ApplicationUser>()
                .HasMany(r => r.Cats)
                .WithOne(u => u.ApplicationUser)
                .IsRequired();

                

            base.OnModelCreating(builder);
        }


    }
}
