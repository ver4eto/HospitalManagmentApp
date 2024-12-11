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
    public class PatientTreatmentConfiguration : IEntityTypeConfiguration<PatientTreatment>
    {
        public void Configure(EntityTypeBuilder<PatientTreatment> builder)
        {
          builder.
                HasOne(pt=>pt.Patient)
                .WithMany(p=>p.PatientTreatments)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(new List<PatientTreatment>(){
                new PatientTreatment()
            {
                PatientId = new Guid("57C0A3B2-BF91-4C97-9A31-CB7B454C1415"),
                TreatmentId= new Guid("bb26ac70-f9dc-426f-9c36-d6105537e909"),
            },
            new PatientTreatment()
            {
                PatientId = new Guid("57C0A3B2-BF91-4C97-9A31-CB7B454C1415"),
                TreatmentId= new Guid("273f30d9-6c5f-49fa-84a7-734dbdc4a1d2"),
            },
            new PatientTreatment()
            {
                PatientId = new Guid("57C0A3B2-BF91-4C97-9A31-CB7B454C1415"),
                TreatmentId= new Guid("1e472cfa-5488-49f7-bc90-87bcd37b85c0"),

            },
            new PatientTreatment()
            {
                PatientId = new Guid("76222e29-cbf5-4335-b2e4-fa6a77afeab1"),
                TreatmentId= new Guid("273f30d9-6c5f-49fa-84a7-734dbdc4a1d2"),
            },
                new PatientTreatment()
            {
                PatientId = new Guid("76222e29-cbf5-4335-b2e4-fa6a77afeab1"),
                TreatmentId= new Guid("1e472cfa-5488-49f7-bc90-87bcd37b85c0"),
            },
                new PatientTreatment()
            {
                PatientId = new Guid("17E9933D-2A1B-467B-B6A2-79297246B8B3"),
                TreatmentId= new Guid("2a24b3e3-93db-487d-8074-3e5a51217d8c"),
            },
                new PatientTreatment()
            {
                PatientId = new Guid("17E9933D-2A1B-467B-B6A2-79297246B8B3"),
                TreatmentId= new Guid("64e59e91-8492-41a1-a6b5-2e98f6b5f667"),
            },
                new PatientTreatment()
            {
                PatientId = new Guid("621fb5c5-b634-405d-951b-3088891c3d5c"),
                TreatmentId= new Guid("2a24b3e3-93db-487d-8074-3e5a51217d8c"),
            },
                new PatientTreatment()
            {
                PatientId = new Guid("621fb5c5-b634-405d-951b-3088891c3d5c"),
                TreatmentId= new Guid("64e59e91-8492-41a1-a6b5-2e98f6b5f667"),
            },
                new PatientTreatment()
            {
                PatientId = new Guid("621fb5c5-b634-405d-951b-3088891c3d5c"),
                TreatmentId= new Guid("1e472cfa-5488-49f7-bc90-87bcd37b85c0"),
            },

                new PatientTreatment()
            {
                PatientId = new Guid("DD5538D3-1F68-412F-9949-94EDDE16D8A2"),
                TreatmentId= new Guid("2a24b3e3-93db-487d-8074-3e5a51217d8c"),
            },
                new PatientTreatment()
            {
                PatientId = new Guid("DD5538D3-1F68-412F-9949-94EDDE16D8A2"),
                TreatmentId= new Guid("39bf20f4-81c8-4cd6-9262-61184c8d6b9a"),
            },
            new PatientTreatment()
            {
                PatientId = new Guid("DD5538D3-1F68-412F-9949-94EDDE16D8A2"),
                TreatmentId= new Guid("bb26ac70-f9dc-426f-9c36-d6105537e909"),
            }});
        }
    }
}
