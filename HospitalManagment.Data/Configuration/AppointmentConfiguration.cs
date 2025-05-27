using HospitalManagmentApp.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Globalization;

namespace HospitalManagmentApp.Data.Configuration
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(a => a.Doctor)
                 .WithMany(d => d.Appointments)
                 .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Patient)
                .WithMany(p => p.Appointments)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(a => a.Start)
          .IsRequired()
          .HasColumnType("datetime2");

            builder.Property(a => a.End)
                   .IsRequired()
                   .HasColumnType("datetime2");

            builder.ToTable(tb => tb
                .HasCheckConstraint(
            "CK_Appointment_StartBeforeEnd",
            "[Start] < [End]"));

            builder.HasData(
                new Appointment
                {
                    Id=Guid.Parse("425262b5-2ef6-4de3-a7ab-230252dc1c5c"),
                    DoctorId = Guid.Parse("78429ef3-6e8f-441a-8224-cf9a41152a2c"),
                    PatientId = Guid.Parse("dd5538d3-1f68-412f-9949-94edde16d8a2"),
                    Start = DateTime.ParseExact(
                             "09.05.2025 13:30",
                             "dd.MM.yyyy HH:mm",
                             CultureInfo.InvariantCulture),
                    End = DateTime.ParseExact(
                             "09.05.2025 14:00",
                             "dd.MM.yyyy HH:mm",
                    CultureInfo.InvariantCulture),

                },
                new Appointment
                {
                    Id=Guid.Parse("5cef2e11-6c21-4034-a020-6fbae170e056"),
                    DoctorId = Guid.Parse("38a0afd0-c8d6-4674-b24a-db1e6861fcc8"),
                    PatientId = Guid.Parse("17e9933d-2a1b-467b-b6a2-79297246b8b3"),
                    Start = DateTime.ParseExact(
                             "05.05.2025 10:00",
                             "dd.MM.yyyy HH:mm",
                             CultureInfo.InvariantCulture),
                    End = DateTime.ParseExact(
                             "05.05.2025 11:00",
                             "dd.MM.yyyy HH:mm",
                             CultureInfo.InvariantCulture),

                },
                new Appointment
                {
                    Id=Guid.Parse("4c0b7041-206d-45e5-b4ab-6ad0eb83baad"),
                    DoctorId = Guid.Parse("a15998c9-52af-4c6b-a032-b135b879e5a7"),
                    PatientId = Guid.Parse("a001bd24-5c2a-4f7a-b000-5f7bd233cd12"),
                    Start = DateTime.ParseExact(
                             "06.05.2025 11:00",
                             "dd.MM.yyyy HH:mm",
                             CultureInfo.InvariantCulture),
                    End = DateTime.ParseExact(
                             "06.05.2025 11:30",
                             "dd.MM.yyyy HH:mm",
                             CultureInfo.InvariantCulture),

                },
                 new Appointment
                 {
                     Id=Guid.Parse("50dada77-19e6-4ff1-9b15-8d37a1e677ca"),
                     DoctorId = Guid.Parse("a15998c9-52af-4c6b-a032-b135b879e5a7"),
                     PatientId = Guid.Parse("134d8ce3-4c26-434a-90b4-f59ae5457a01"),
                     Start = DateTime.ParseExact(
                             "07.05.2025 12:30",
                             "dd.MM.yyyy HH:mm",
                             CultureInfo.InvariantCulture),
                     End = DateTime.ParseExact(
                             "07.05.2025 13:00",
                             "dd.MM.yyyy HH:mm",
                             CultureInfo.InvariantCulture),

                 });

        }
    }
}
