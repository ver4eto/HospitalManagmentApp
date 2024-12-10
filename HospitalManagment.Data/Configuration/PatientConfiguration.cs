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
               /* .OnDelete(DeleteBehavior.Restrict)*/;

            builder
        .HasOne(p => p.Department)
        .WithMany(d => d.Patients)
        .HasForeignKey(p => p.DepartmentId)
        .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(p=>p.User)
                .WithMany(up=>up.Patients)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(SeedPatients());
        }

        private Patient[] SeedPatients()
        {
            ICollection<Patient> patients = new HashSet<Patient>();
            Patient patient;

            patient = new Patient()
            {
                Id =new Guid("45ff5a3c-c27e-4e62-8c90-4954281d46d0"),
                FirstName = "Ivan",
                LastName = "Ivanov",
                EGN = "4810234567",
                Address = "Sofi, ul.Rezovo 13, et.2, ap.6",
                DepartmentId = Guid.Parse("af2f0ad4-ff86-4e51-ab19-630145898ec6"),
                RoomId = Guid.Parse("6a746a43-8fe2-4b2f-b6a3-69104089e8ac"),
                EmailAddress = "ivanovivan@abv.bg",
                UserId= "45ff5a3c-c27e-4e62-8c90-4954281d46d0"
            };
            patients.Add(patient);

            patient = new Patient()
            {
                Id = new Guid("57c0a3b2-bf91-4c97-9a31-cb7b454c1415"),
                FirstName = "Petar",
                LastName = "Stefanov",
                EGN = "6212094475",
                Address = "Sofi, ul.Belomorska, et.7, ap.16",
                DepartmentId = Guid.Parse("43f9018c-2a02-448d-b26e-bc832bc097d3"),
                RoomId = Guid.Parse("9f415f68-1979-4d9f-ba39-8586cc1d6c4c"),
                EmailAddress = "stefanovp@abv.bg",
                UserId= "57c0a3b2-bf91-4c97-9a31-cb7b454c1415"
            };
            patients.Add(patient);

            patient = new Patient()
            {
                Id = new Guid("621fb5c5-b634-405d-951b-3088891c3d5c"),
                FirstName = "Lazar",
                LastName = "Petrov",
                EGN = "6102193476",
                Address = "Sofi, bul.Vitosha 123, et.7, ap.16",
                DepartmentId = Guid.Parse("43f9018c-2a02-448d-b26e-bc832bc097d3"),
               RoomId = Guid.Parse("9f415f68-1979-4d9f-ba39-8586cc1d6c4c"),
                EmailAddress = "petrovlazar@abv.bg",
                UserId= "621fb5c5-b634-405d-951b-3088891c3d5c"
            };
            patients.Add(patient);


            patient = new Patient()
            {
                Id = new Guid("dd5538d3-1f68-412f-9949-94edde16d8a2"),
                FirstName = "Vanya",
                LastName = "Petrova",
                EGN = "8302198562",
                Address = "Sofi, bul.Vitosha 3, et.7, ap.16",
                DepartmentId = Guid.Parse("70dd58b3-966e-4498-806f-04411c1bbbee"),
                RoomId = Guid.Parse("3b85738c-1a1a-40a9-952a-465e8914a2e0"),
                EmailAddress = "petrovavanya@abv.bg",
                UserId= "dd5538d3-1f68-412f-9949-94edde16d8a2"
            };
            patients.Add(patient);

            patient = new Patient()
            {
                Id = new Guid("17e9933d-2a1b-467b-b6a2-79297246b8b3"),
                FirstName = "Ivan",
                LastName = "Ivanov",
                EGN = "4810234567",
                Address = "Sofi, ul.Rezovo 13, et.2, ap.6",
                DepartmentId = Guid.Parse("af2f0ad4-ff86-4e51-ab19-630145898ec6"),
                RoomId = Guid.Parse("6a746a43-8fe2-4b2f-b6a3-69104089e8ac"),
                EmailAddress = "ivanovivan@abv.bg",
                UserId = "17e9933d-2a1b-467b-b6a2-79297246b8b3"
            };
            patients.Add(patient);
            patient = new Patient()
            {
                Id = new Guid("a001bd24-5c2a-4f7a-b000-5f7bd233cd12"),
                FirstName = "James",
                LastName = "Anderson",
                EGN = "1234567890",
                EmailAddress = "james.anderson@example.com",
                Address = "123 Elm Street",
                DepartmentId = Guid.Parse("43f9018c-2a02-448d-b26e-bc832bc097d3"),
                RoomId = Guid.Parse("ff64e198-4cac-40d9-817c-ca3a62637fed"),
                UserId = "a001bd24-5c2a-4f7a-b000-5f7bd233cd12",
            };
            patients.Add(patient);

            patient = new Patient()
            {
                Id = new Guid("134d8ce3-4c26-434a-90b4-f59ae5457a01"),
                FirstName = "Mary",
                LastName = "Johnson",
                EGN = "2345678901",
                EmailAddress = "mary.johnson@example.com",
                Address = "456 Maple Avenue",
                DepartmentId = Guid.Parse("43f9018c-2a02-448d-b26e-bc832bc097d3"),
                RoomId = Guid.Parse("ff64e198-4cac-40d9-817c-ca3a62637fed"),
                UserId = "134d8ce3-4c26-434a-90b4-f59ae5457a01",
            };
            patients.Add(patient);

            patient = new Patient()
            {
                Id = new Guid("17139a72-76d4-4362-aa27-18a64cc8d285"),
                FirstName = "Robert",
                LastName = "Williams",
                EGN = "3456789012",
                EmailAddress = "robert.williams@example.com",
                Address = "789 Oak Boulevard",
                DepartmentId = Guid.Parse("43f9018c-2a02-448d-b26e-bc832bc097d3"),
                RoomId = Guid.Parse("9f415f68-1979-4d9f-ba39-8586cc1d6c4c"),
                UserId = "17139a72-76d4-4362-aa27-18a64cc8d285",
            };
            patients.Add(patient);

            patient = new Patient()
            {
                Id = new Guid("15050ff2-ed6c-475f-8831-f61d54a29175"),
                FirstName = "Patricia",
                LastName = "Brown",
                EGN = "4567890123",
                EmailAddress = "patricia.brown@example.com",
                Address = "321 Pine Lane",
                DepartmentId = Guid.Parse("43f9018c-2a02-448d-b26e-bc832bc097d3"),
                RoomId = Guid.Parse("9f415f68-1979-4d9f-ba39-8586cc1d6c4c"),
                UserId = "15050ff2-ed6c-475f-8831-f61d54a29175",
            };
            patients.Add(patient);

            patient = new Patient()
            {
                Id = new Guid("76222e29-cbf5-4335-b2e4-fa6a77afeab1"),
                FirstName = "Jennifer",
                LastName = "Miller",
                EGN = "6789012345",
                Address = "987 Birch Road",
                DepartmentId = Guid.Parse("70dd58b3-966e-4498-806f-04411c1bbbee"),
                RoomId = Guid.Parse("3b85738c-1a1a-40a9-952a-465e8914a2e0"),
                EmailAddress = "jennifer.miller@example.com",
                UserId = "76222e29-cbf5-4335-b2e4-fa6a77afeab1"
            };
            patients.Add(patient);

            patient = new Patient()
            {
                Id = new Guid("3110d510-2d4d-4e84-9f69-84794965586d"),
                FirstName = "Michael",
                LastName = "Wilson",
                EGN = "7890123456",
                Address = "159 Walnut Avenue",
                DepartmentId = Guid.Parse("70dd58b3-966e-4498-806f-04411c1bbbee"),
                RoomId = Guid.Parse("3b85738c-1a1a-40a9-952a-465e8914a2e0"),
                EmailAddress = "michael.wilson@example.com",
                UserId = "3110d510-2d4d-4e84-9f69-84794965586d"
            };
            patients.Add(patient);

            patient = new Patient()
            {
                Id = new Guid("d8d0d177-60a0-4925-b4ed-bb36aebb48c4"),
                FirstName = "Elizabeth",
                LastName = "Moore",
                EGN = "8901234567",
                Address = "159 Walnut Avenue",
                DepartmentId = Guid.Parse("70dd58b3-966e-4498-806f-04411c1bbbee"),
                RoomId = Guid.Parse("3b85738c-1a1a-40a9-952a-465e8914a2e0"),
                EmailAddress = "elizabeth.moore@example.com",
                UserId = "d8d0d177-60a0-4925-b4ed-bb36aebb48c4"
            };
            patients.Add(patient);

            patient = new Patient()
            {
                Id = new Guid("82c99b5d-6573-4514-81eb-183ace313419"),
                FirstName = "David",
                LastName = "Moore",
                EGN = "9012345678",
                Address = "159 Walnut Avenue",
                DepartmentId = Guid.Parse("70dd58b3-966e-4498-806f-04411c1bbbee"),
                RoomId = Guid.Parse("3b85738c-1a1a-40a9-952a-465e8914a2e0"),
                EmailAddress = "david.taylor@example.com",
                UserId = "82c99b5d-6573-4514-81eb-183ace313419"
            };
            patients.Add(patient);

            patient = new Patient()
            {
                Id = new Guid("a8d287e8-357a-40f3-893a-ed507ed6a85d"),
                FirstName = "Susan",
                LastName = "Anderson",
                EGN = "0123456789",
                Address = "123 Elm Court",
                DepartmentId = Guid.Parse("66ff68b3-846e-5398-805f-06411c1bbdff"),
                RoomId = Guid.Parse("994355a8-add4-4d49-a52f-f610e4cb6893"),
                EmailAddress = "susan.anderson@example.com",
                UserId = "a8d287e8-357a-40f3-893a-ed507ed6a85d"
            };
            patients.Add(patient);

            return patients.ToArray();
        }
    }
}
