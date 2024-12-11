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

            treatment = new Treatment { Id = new Guid("64e59e91-8492-41a1-a6b5-2e98f6b5f667"), Name = "Manual Therapy", Price = 100.0m };
            treatments.Add(treatment);

            treatment = new Treatment { Id = new Guid("39bf20f4-81c8-4cd6-9262-61184c8d6b9a"), Name = "Massage Therapy", Price = 80.0m };
            treatments.Add(treatment);

            treatment = new Treatment { Id = new Guid("bb26ac70-f9dc-426f-9c36-d6105537e909"), Name = "Chiropractic Adjustment", Price = 120.0m };
            treatments.Add(treatment);

            treatment = new Treatment { Id = new Guid("273f30d9-6c5f-49fa-84a7-734dbdc4a1d2"), Name = "Dialysis", Price = 170.0m };
            treatments.Add(treatment);

            treatment = new Treatment { Id =new Guid("1e472cfa-5488-49f7-bc90-87bcd37b85c0"), Name = "Physical Therapy", Price = 200.0m };
            treatments.Add(treatment);

            treatment = new Treatment { Id = new Guid("2a24b3e3-93db-487d-8074-3e5a51217d8c"), Name = "Vaccination", Price = 20.0m };
            treatments.Add(treatment);

            return treatments.ToArray();
        }
    }
}
