using HospitalManagmentApp.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentApp.Data.Configuration
{
    public class ManagerConfiguration : IEntityTypeConfiguration<Menager>
    {
        public void Configure(EntityTypeBuilder<Menager> builder)
        {
            builder.HasData
                (
                new Menager()
                {
                    Id =Guid.NewGuid(),
                    FullName="Stoian Ivanov",
                    PhoneNumber="+359883456789"
                }
                );
        }
    }
}
