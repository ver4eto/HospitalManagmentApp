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
                    Id = "78429ef3-6e8f-441a-8224-cf9a41152a2c",
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
                    Id = "38a0afd0-c8d6-4674-b24a-db1e6861fcc8",
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
                    Id = "a15998c9-52af-4c6b-a032-b135b879e5a7",
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
                    Id = "0b04322a-bab8-41ca-b791-ec1abdd7e8a0",
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
                    Id = "18538144-c4ee-4d7d-b4eb-fd9267ca134f",
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
            Id = "2c5c4962-15bb-4282-bfbf-5a0cd30ba664",
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
            Id = "0f1babbe-d5db-49b9-9624-47b9d69df236",
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
                    Id = "06ea23a1-095e-475f-937e-cb3e34c4def2",
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
            Id = "af558d53-8adc-45ba-bfdd-1ca9e11e7185",
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
            Id = "c55b3e3f-6604-4bf4-a9c8-014d0c146003",
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
            Id = "3c8870b2-58cf-4341-8ea1-d024520563d0",
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
            Id = "17e9933d-2a1b-467b-b6a2-79297246b8b3",
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
            Id = "57c0a3b2-bf91-4c97-9a31-cb7b454c1415",
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
            Id = "621fb5c5-b634-405d-951b-3088891c3d5c",
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
            Id = "dd5538d3-1f68-412f-9949-94edde16d8a2",
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
