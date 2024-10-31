using HospitalManagmentApp.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagmentApp.Data.Configuration
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasData(SeedDoctor());
        }

        private Doctor[] SeedDoctor()
        {
            ICollection<Doctor> doctors = new HashSet<Doctor>();

            Doctor doctor;
            doctor = new Doctor { FirstName = "Alice", LastName = "Smith", Salary = 1200, Specialty = "Cardiology" };
            doctors.Add(doctor);
            doctor = new Doctor { FirstName = "John", LastName = "Doe", Salary = 1000, Specialty = "Neurology" };
            doctors.Add(doctor);
            doctor = new Doctor { FirstName = "Sara", LastName = "Johnson", Salary = 1150, Specialty = "Pediatrics" };
            doctors.Add(doctor);
            doctor = new Doctor { FirstName = "Petar", LastName = "Petrov", Salary = 2150, Specialty = "Surgeon" };
            doctors.Add(doctor);
            doctor = new Doctor { FirstName = "Ivana", LastName = "Petrova", Salary = 4150, Specialty = "Gynecologist" };
            doctors.Add(doctor);

            return doctors.ToArray();
        }
    }
}
