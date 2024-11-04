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
            doctor = new Doctor {Id=new Guid("78429ef3-6e8f-441a-8224-cf9a41152a2c"), FirstName = "Alice", LastName = "Smith", Salary = 1200, Specialty = "Cardiology" };
            doctors.Add(doctor);
            doctor = new Doctor {Id=new Guid("38a0afd0-c8d6-4674-b24a-db1e6861fcc8"), FirstName = "John", LastName = "Doe", Salary = 1000, Specialty = "Neurology" };
            doctors.Add(doctor);
            doctor = new Doctor {Id=new Guid("a15998c9-52af-4c6b-a032-b135b879e5a7"), FirstName = "Sara", LastName = "Johnson", Salary = 1150, Specialty = "Pediatrics" };
            doctors.Add(doctor);
            doctor = new Doctor {Id=new Guid("0b04322a-bab8-41ca-b791-ec1abdd7e8a0"), FirstName = "Petar", LastName = "Petrov", Salary = 2150, Specialty = "Surgeon" };
            doctors.Add(doctor);
            doctor = new Doctor {Id=new Guid("18538144-c4ee-4d7d-b4eb-fd9267ca134f"), FirstName = "Ivana", LastName = "Petrova", Salary = 4150, Specialty = "Gynecologist" };
            doctors.Add(doctor);

            return doctors.ToArray();
        }
    }
}
