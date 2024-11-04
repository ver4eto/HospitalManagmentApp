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
    public class PatientTreatmentConfiguration : IEntityTypeConfiguration<PatientTreatment>
    {
        public void Configure(EntityTypeBuilder<PatientTreatment> builder)
        {
          builder.
                HasOne(pt=>pt.Patient)
                .WithMany(p=>p.PatientTreatments)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
