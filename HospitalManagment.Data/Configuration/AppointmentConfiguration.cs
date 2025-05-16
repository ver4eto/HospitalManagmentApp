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
            builder.HasOne(a => a.Doctor)
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
            "[StartTime] < [EndTime]"));

            builder.HasData(
                new Appointment
                {
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
                    DoctorId = Guid.Parse("38a0afd0-c8d6-4674-b24a-db1e6861fcc8"),
                    PatientId = Guid.Parse("17e9933d-2a1b-467b-b6a2-79297246b8b32"),
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
