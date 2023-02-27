using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Entities;

namespace MyCompany.Domain
{
  
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole 
            { 
                Id = "8e18e5ca-5f36-47d8-9d26-906851cc8327",
                Name ="admin",
                NormalizedName = "ADMIN"
            });
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "e2fe6bae-9208-4c77-863b-363c110461e7",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@gmail.com",
                NormalizedEmail = "MY@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null,"superpassword"),
                SecurityStamp = string.Empty
            });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "8e18e5ca-5f36-47d8-9d26-906851cc8327",
                UserId = "e2fe6bae-9208-4c77-863b-363c110461e7"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField 
            { 
                Id = new Guid("bd921f5f-168a-4370-86e2-cdf97588dcee"),
                CodeWord = "PageIndex",
                Title = "Main"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("709f80b2-b798-4fbb-8cf6-b5d2a793dacc"),
                CodeWord = "PageServices",
                Title = "Our services"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("8498c578-a42d-48cf-948f-242cc28f6706"),
                CodeWord = "PagesContacts",
                Title ="Contacts"
            });
        }
    }
}
