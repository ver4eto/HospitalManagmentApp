using HospitalManagmentApp.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentApp.Data.Configuration
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder
                .HasOne(p => p.Room)
                .WithMany(p => p.Patients)
                .HasForeignKey(p => p.RoomId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
        .HasOne(p => p.Department)
        .WithMany(d => d.Patients)
        .HasForeignKey(p => p.DepartmentId)
        .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(SeedPatients());
        }

        private Patient[] SeedPatients()
        {
            ICollection<Patient> patients = new HashSet<Patient>();
            Patient patient;

            patient = new Patient()
            {
                Id = Guid.NewGuid(),
                FirstName = "Ivan",
                LastName = "Ivanov",
                EGN = "4810234567",
                Address = "Sofi, ul.Rezovo 13, et.2, ap.6",
                DepartmentId = Guid.Parse("af2f0ad4-ff86-4e51-ab19-630145898ec6"),
                RoomId = Guid.Parse("6a746a43-8fe2-4b2f-b6a3-69104089e8ac")
            };
            patients.Add(patient);

            patient = new Patient()
            {
                Id = Guid.NewGuid(),
                FirstName = "Petar",
                LastName = "Stefanov",
                EGN = "6212094475",
                Address = "Sofi, ul.Belomorska, et.7, ap.16",
                DepartmentId = Guid.Parse("43f9018c-2a02-448d-b26e-bc832bc097d3"),
                RoomId = Guid.Parse("9f415f68-1979-4d9f-ba39-8586cc1d6c4c")
            };
            patients.Add(patient);

            patient = new Patient()
            {
                Id = Guid.NewGuid(),
                FirstName = "Lazar",
                LastName = "Petrov",
                EGN = "6102193476",
                Address = "Sofi, bul.Vitosha 123, et.7, ap.16",
                DepartmentId = Guid.Parse("43f9018c-2a02-448d-b26e-bc832bc097d3"),
               RoomId = Guid.Parse("9f415f68-1979-4d9f-ba39-8586cc1d6c4c")
            };
            patients.Add(patient);


            patient = new Patient()
            {
                Id = Guid.NewGuid(),
                FirstName = "Vanya",
                LastName = "Petrova",
                EGN = "8302198562",
                Address = "Sofi, bul.Vitosha 3, et.7, ap.16",
                DepartmentId = Guid.Parse("70dd58b3-966e-4498-806f-04411c1bbbee"),
                RoomId = Guid.Parse("3b85738c-1a1a-40a9-952a-465e8914a2e0")
            };
            patients.Add(patient);


            return patients.ToArray();
        }
    }
}
