using HospitalManagmentApp.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagmentApp.Data.Configuration
{
    public class NurseConfiguration : IEntityTypeConfiguration<Nurse>
    {
        public void Configure(EntityTypeBuilder<Nurse> builder)
        {
            builder.HasData(SeedNurse());
        }

        private Nurse[] SeedNurse()
        {
            ICollection<Nurse> nurses = new HashSet<Nurse>();
            Nurse nurse;
            
            nurse = new Nurse { FirstName = "Emma", LastName = "Williams", Salary = 650 };
            nurses.Add(nurse);

            nurse = new Nurse { FirstName = "Liam", LastName = "Brown", Salary = 1020 };
            nurses.Add(nurse);

            nurse = new Nurse { FirstName = "Sophia", LastName = "Davis", Salary = 67000 };
            nurses.Add(nurse);

            nurse = new Nurse { FirstName = "Noah", LastName = "Miller", Salary = 64000 };
            nurses.Add(nurse);

            nurse = new Nurse { FirstName = "Olivia", LastName = "Taylor", Salary = 66000 };
            nurses.Add(nurse);


            return nurses.ToArray();
        }
    }
}
