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
    public class PatientDoctorConfiguration : IEntityTypeConfiguration<PatientDoctor>
    {
        public void Configure(EntityTypeBuilder<PatientDoctor> builder)
        {
            builder
                 .HasOne(pd => pd.Doctor)
                 .WithMany(d => d.DoctorPatients)
                 .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(new List<PatientDoctor>()
            {
                new PatientDoctor()
                {
                    PatientId=Guid.Parse("dd5538d3-1f68-412f-9949-94edde16d8a2"),
                    DoctorId=Guid.Parse("78429ef3-6e8f-441a-8224-cf9a41152a2c")
                },

                new PatientDoctor()
                {
                    PatientId=Guid.Parse("17e9933d-2a1b-467b-b6a2-79297246b8b3"),
                    DoctorId=Guid.Parse("38a0afd0-c8d6-4674-b24a-db1e6861fcc8")
                },

                  new PatientDoctor()
                {
                    PatientId=Guid.Parse("a001bd24-5c2a-4f7a-b000-5f7bd233cd12"),
                    DoctorId=Guid.Parse("a15998c9-52af-4c6b-a032-b135b879e5a7")
                },

                     new PatientDoctor()
                {
                    PatientId=Guid.Parse("134d8ce3-4c26-434a-90b4-f59ae5457a01"),
                    DoctorId=Guid.Parse("a15998c9-52af-4c6b-a032-b135b879e5a7")
                },

                        new PatientDoctor()
 {
     PatientId=Guid.Parse("17139a72-76d4-4362-aa27-18a64cc8d285"),
     DoctorId=Guid.Parse("78429ef3-6e8f-441a-8224-cf9a41152a2c")
 },

                           new PatientDoctor()
 {
     PatientId=Guid.Parse("15050ff2-ed6c-475f-8831-f61d54a29175"),
     DoctorId=Guid.Parse("a15998c9-52af-4c6b-a032-b135b879e5a7")
 },

                              new PatientDoctor()
 {
     PatientId=Guid.Parse("76222e29-cbf5-4335-b2e4-fa6a77afeab1"),
     DoctorId=Guid.Parse("0b04322a-bab8-41ca-b791-ec1abdd7e8a0")
 },

                                 new PatientDoctor()
 {
     PatientId=Guid.Parse("3110d510-2d4d-4e84-9f69-84794965586d"),
     DoctorId=Guid.Parse("0b04322a-bab8-41ca-b791-ec1abdd7e8a0")
 },

                                    new PatientDoctor()
 {
     PatientId=Guid.Parse("d8d0d177-60a0-4925-b4ed-bb36aebb48c4"),
     DoctorId=Guid.Parse("18538144-c4ee-4d7d-b4eb-fd9267ca134f")
 },
            });
        }
    }
}
