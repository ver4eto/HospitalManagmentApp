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
    public class PatientDoctorConfiguration : IEntityTypeConfiguration<PatientDoctor>
    {
        public void Configure(EntityTypeBuilder<PatientDoctor> builder)
        {
            builder
                 .HasOne(pd => pd.Doctor)
                 .WithMany(d => d.DoctorPatients)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
