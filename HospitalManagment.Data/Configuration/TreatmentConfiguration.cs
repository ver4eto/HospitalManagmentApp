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
    public class TreatmentConfiguration : IEntityTypeConfiguration<Treatment>
    {
        public void Configure(EntityTypeBuilder<Treatment> builder)
        {
            builder.HasData(SeedTreatments());
        }

        private Treatment[] SeedTreatments()
        {
            ICollection<Treatment> treatments = new HashSet<Treatment>();
            Treatment treatment = new Treatment();

            treatment = new Treatment { Id = Guid.NewGuid(), Name = "Physical Therapy", Price = 100.0m };
            treatments.Add(treatment);

            treatment = new Treatment { Id = Guid.NewGuid(), Name = "Massage Therapy", Price = 80.0m };
            treatments.Add(treatment);

            treatment = new Treatment { Id = Guid.NewGuid(), Name = "Chiropractic Adjustment", Price = 120.0m };
            treatments.Add(treatment);

            treatment = new Treatment { Id = Guid.NewGuid(), Name = "Manual therapy", Price = 170.0m };
            treatments.Add(treatment);

            return treatments.ToArray();
        }
    }
}
