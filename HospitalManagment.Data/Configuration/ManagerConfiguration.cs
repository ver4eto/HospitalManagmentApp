using HospitalManagmentApp.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentApp.Data.Configuration
{
    public class ManagerConfiguration : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder
                .HasOne(m => m.User)
                .WithMany(um => um.Managers)
                .HasForeignKey(m => m.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData
                (
                new Manager()
                {
                    Id =Guid.NewGuid(),
                    FullName="Stoian Ivanov",
                    PhoneNumber="+359883456789",
                    EmailAddress=  "ivanovst@abv.bg",
                    UserId= "ivanovst@abv.bg"
                }
                );
        }
    }
}
