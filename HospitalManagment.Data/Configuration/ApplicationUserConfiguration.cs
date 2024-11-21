using HospitalManagmentApp.DataModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentApp.Data.Configuration
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {

            builder.HasData(SeedUsers());
        }
        private ApplicationUser[] SeedUsers()
        {
            return new ApplicationUser[]
            {
                new ApplicationUser
                {
                    Id = "smith@abv.bg",
                    UserName = "smith@abv.bg",
                    NormalizedUserName = "SMITH@ABV.BG",
                    Email = "smith@abv.bg",
                    NormalizedEmail = "SMITH@ABV.BG",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Password123!"),
                    UserType="Doctor"
                },
                new ApplicationUser
                {
                    Id = "jhondoe@abv.bg",
                    UserName = "jhondoe@abv.bg",
                    NormalizedUserName = "JHONDOE@ABV.BG",
                    Email = "jhondoe@abv.bg",
                    NormalizedEmail = "JHONDOE@ABV.BG",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Password123!"),
                    UserType="Doctor"
                },
                new ApplicationUser
                {
                    Id = "jhonson@abv.bg",
                    UserName = "jhonson@abv.bg",
                    NormalizedUserName = "JHONSON@ABV.BG",
                    Email = "jhonson@abv.bg",
                    NormalizedEmail = "JHONSON@ABV.BG",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Password123!"),
                    UserType="Doctor"
                },
                new ApplicationUser
                {
                    Id = "petrovp@abv.bg",
                    UserName = "petrovp@abv.bg",
                    NormalizedUserName = "PETROVP@ABV.BG",
                    Email = "petrovp@abv.bg",
                    NormalizedEmail = "PETROVP@ABV.BG",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Password123!"),
                    UserType="Doctor"
                },
                new ApplicationUser
                {
                    Id = "petrovai@abv.bg",
                    UserName = "petrovai@abv.bg",
                    NormalizedUserName = "PETROVAI@ABV.BG",
                    Email = "petrovai@abv.bg",
                    NormalizedEmail = "PETROVAI@ABV.BG",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Password123!"),
                    UserType="Doctor"
                },

                 new ApplicationUser
        {
            Id = "williams@abv.bg",
            UserName = "williams@abv.bg",
            NormalizedUserName = "WILLIAMS@ABV.BG",
            Email = "williams@abv.bg",
            NormalizedEmail = "WILLIAMS@ABV.BG",
            EmailConfirmed = true,
            PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Password123!"),
            UserType="Nurse"
        },
        new ApplicationUser
        {
            Id = "brown@abv.bg",
            UserName = "brown@abv.bg",
            NormalizedUserName = "BROWN@ABV.BG",
            Email = "brown@abv.bg",
            NormalizedEmail = "BROWN@ABV.BG",
            EmailConfirmed = true,
            PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Password123!"),
            UserType="Nurse"
        },
        new ApplicationUser
                {
                    Id = "ivanovst@abv.bg",
                    UserName = "ivanovst@abv.bg",
                    NormalizedUserName = "IVANOVST@ABV.BG",
                    Email = "ivanovst@abv.bg",
                    NormalizedEmail =  "IVANOVST@ABV.BG",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Password123!"),
                    UserType="Manager"
                },
        new ApplicationUser
        {
            Id = "davissophia@abv.bg",
            UserName = "davissophia@abv.bg",
            NormalizedUserName = "DAVISSOPHIA@ABV.BG",
            Email = "davissophia@abv.bg",
            NormalizedEmail = "DAVISSOPHIA@ABV.BG",
            EmailConfirmed = true,
            PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Password123!"),
            UserType="Nurse"
        },
        new ApplicationUser
        {
            Id = "miller@abv.bg",
            UserName = "miller@abv.bg",
            NormalizedUserName = "MILLER@ABV.BG",
            Email = "miller@abv.bg",
            NormalizedEmail = "MILLER@ABV.BG",
            EmailConfirmed = true,
            PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Password123!"),
            UserType="Nurse"
        },
        new ApplicationUser
        {
            Id = "taylor@abv.bg",
            UserName = "taylor@abv.bg",
            NormalizedUserName = "TAYLOR@ABV.BG",
            Email = "taylor@abv.bg",
            NormalizedEmail = "TAYLOR@ABV.BG",
            EmailConfirmed = true,
            PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Password123!"),
            UserType="Nurse"
        },
          new ApplicationUser
        {
            Id = "ivanovivan@abv.bg",
            UserName = "ivanovivan@abv.bg",
            NormalizedUserName = "IVANOVIVAN@ABV.BG",
            Email = "ivanovivan@abv.bg",
            NormalizedEmail = "IVANOVIVAN@ABV.BG",
            EmailConfirmed = true,
            PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Password123!"),
            UserType="Patient"
        },
        new ApplicationUser
        {
            Id = "stefanovp@abv.bg",
            UserName = "stefanovp@abv.bg",
            NormalizedUserName = "STEFANOVP@ABV.BG",
            Email = "stefanovp@abv.bg",
            NormalizedEmail = "STEFANOVP@ABV.BG",
            EmailConfirmed = true,
            PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Password123!"),
            UserType="Patient"
        },
        new ApplicationUser
        {
            Id = "petrovlazar@abv.bg",
            UserName = "petrovlazar@abv.bg",
            NormalizedUserName = "PETROVLAZAR@ABV.BG",
            Email = "petrovlazar@abv.bg",
            NormalizedEmail = "PETROVLAZAR@ABV.BG",
            EmailConfirmed = true,
            PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Password123!"),
            UserType="Patient"
        },
        new ApplicationUser
        {
            Id = "petrovavanya@abv.bg",
            UserName = "petrovavanya@abv.bg",
            NormalizedUserName = "PETROVAVANYA@ABV.BG",
            Email = "petrovavanya@abv.bg",
            NormalizedEmail = "PETROVAVANYA@ABV.BG",
            EmailConfirmed = true,
            PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Password123!"),
            UserType="Patient"
        }
            };
        }
    }
}
