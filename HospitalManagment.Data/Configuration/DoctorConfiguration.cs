using HospitalManagmentApp.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagmentApp.Data.Configuration
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder
                .HasOne(d => d.Department)
                .WithMany(dd => dd.DepartmentDoctors)
                .HasForeignKey(d => d.DepartmnetId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(SeedDoctor());
        }

        private Doctor[] SeedDoctor()
        {
            ICollection<Doctor> doctors = new HashSet<Doctor>();

            Doctor doctor;
            doctor = new Doctor {Id=new Guid("78429ef3-6e8f-441a-8224-cf9a41152a2c"),DepartmnetId=Guid.Parse("43f9018c-2a02-448d-b26e-bc832bc097d3"), FirstName = "Alice", LastName = "Smith", Salary = 1200, Specialty = "Cardiology",EmailAddress="smith@abv.bg" };
            doctors.Add(doctor);
            doctor = new Doctor {Id=new Guid("38a0afd0-c8d6-4674-b24a-db1e6861fcc8"),DepartmnetId=Guid.Parse("af2f0ad4-ff86-4e51-ab19-630145898ec6"), FirstName = "John", LastName = "Doe", Salary = 1000, Specialty = "Neurology",EmailAddress= "jhondoe@abv.bg" };
            doctors.Add(doctor);
            doctor = new Doctor {Id=new Guid("a15998c9-52af-4c6b-a032-b135b879e5a7"),DepartmnetId=Guid.Parse("3a19290a-8b6d-4551-97ae-b87ecf3f2dd2"), FirstName = "Sara", LastName = "Johnson", Salary = 1150, Specialty = "Pediatrics" , EmailAddress = "jhonson@abv.bg" };
            doctors.Add(doctor);
            doctor = new Doctor {Id=new Guid("0b04322a-bab8-41ca-b791-ec1abdd7e8a0"),DepartmnetId=Guid.Parse("70dd58b3-966e-4498-806f-04411c1bbbee"), FirstName = "Petar", LastName = "Petrov", Salary = 2150, Specialty = "Surgeon", EmailAddress = "petrovp@abv.bg" };
            doctors.Add(doctor);
            doctor = new Doctor {Id=new Guid("18538144-c4ee-4d7d-b4eb-fd9267ca134f"),DepartmnetId=Guid.Parse("70dd58b3-966e-4498-806f-04411c1bbbee"), FirstName = "Ivana", LastName = "Petrova", Salary = 4150, Specialty = "Surgeon", EmailAddress = "petrovai@abv.bg" };
            doctors.Add(doctor);

            return doctors.ToArray();
        }
    }
}
