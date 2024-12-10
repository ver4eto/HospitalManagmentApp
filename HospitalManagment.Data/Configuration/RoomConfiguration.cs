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
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
           
            builder.
                HasOne(r=>r.Department)
                .WithMany(d=>d.Rooms)
                .HasForeignKey(r=>r.DepartmnetId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(SeedRooms());
        }

        private Room[] SeedRooms()
        {
            ICollection<Room> rooms=new HashSet<Room>();
            Room room;

            room = new Room()
            {
                Id = new Guid("20ea1099-d9f7-4b73-a6d4-498ef5a04347"),
                BedCount = 2,
                RoomNumber = 701,
                DepartmnetId = Guid.Parse("66ff68b3-846e-5398-805f-06411c1bbdff")

            };

            room = new Room()
            {
                Id = new Guid("ee35610a-04a9-4c46-a6ed-c71564336d1b"),
                BedCount = 4,
                RoomNumber = 702,
                DepartmnetId = Guid.Parse("66ff68b3-846e-5398-805f-06411c1bbdff")

            };
            room = new Room()
            {
                Id = new Guid("20dcf42b-f8fe-444a-b17c-287b7cebe8e1"),
                BedCount = 2,
                RoomNumber = 703,
                DepartmnetId = Guid.Parse("66ff68b3-846e-5398-805f-06411c1bbdff")

            };
            room = new Room()
            {
                Id = new Guid("994355a8-add4-4d49-a52f-f610e4cb6893"),
                BedCount = 4,
                RoomNumber = 704,
                DepartmnetId = Guid.Parse("66ff68b3-846e-5398-805f-06411c1bbdff")

            };
            room = new Room()
            {
                Id=new Guid("6a746a43-8fe2-4b2f-b6a3-69104089e8ac"),
                BedCount=1,
                RoomNumber=101,
                DepartmnetId=Guid.Parse("af2f0ad4-ff86-4e51-ab19-630145898ec6")
                
            };
            rooms.Add(room);
            room = new Room()
            {
                Id = new Guid("fc4cc53a-2a34-4232-b63a-0724783fdfa3"),
                BedCount = 2,
                RoomNumber = 102,
                DepartmnetId = Guid.Parse("af2f0ad4-ff86-4e51-ab19-630145898ec6")

            };
            rooms.Add(room);

            room = new Room()
            {
                Id = new Guid("334c034e-51e8-4956-a6a5-f25ce92bf8fa"),
                BedCount = 2,
                RoomNumber = 201,
                DepartmnetId=Guid.Parse("70dd58b3-966e-4498-806f-04411c1bbbee")

            };
            rooms.Add(room);

            room = new Room()
            {
                Id = new Guid("3b85738c-1a1a-40a9-952a-465e8914a2e0"),
                BedCount = 3,
                RoomNumber = 202,
                DepartmnetId = Guid.Parse("70dd58b3-966e-4498-806f-04411c1bbbee")

            };
            rooms.Add(room);

            room = new Room()
            {
                Id = new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c"),
                BedCount = 3,
                RoomNumber = 301,
                DepartmnetId=Guid.Parse("43f9018c-2a02-448d-b26e-bc832bc097d3")

            };
            rooms.Add(room);
            room = new Room()
            {
                Id = new Guid("ff64e198-4cac-40d9-817c-ca3a62637fed"),
                BedCount = 2,
                RoomNumber = 302,
                DepartmnetId = Guid.Parse("43f9018c-2a02-448d-b26e-bc832bc097d3")

            };
            rooms.Add(room);


            return rooms.ToArray();
        }
    }
}
