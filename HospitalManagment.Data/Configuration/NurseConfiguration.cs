using HospitalManagmentApp.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagmentApp.Data.Configuration
{
    public class NurseConfiguration : IEntityTypeConfiguration<Nurse>
    {
        public void Configure(EntityTypeBuilder<Nurse> builder)
        {
            builder
                .HasOne(n => n.User)
                .WithMany(nu => nu.Nurses)
                .HasForeignKey(nu => nu.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(SeedNurse());
        }

        private Nurse[] SeedNurse()
        {
            ICollection<Nurse> nurses = new HashSet<Nurse>();
            Nurse nurse;
            
            nurse = new Nurse {Id=new Guid("2c5c4962-15bb-4282-bfbf-5a0cd30ba664"), FirstName = "Emma", LastName = "Williams", Salary = 650,DepartmentId=Guid.Parse("70dd58b3-966e-4498-806f-04411c1bbbee"), EmailAddress = "williams@abv.bg",UserId= "2c5c4962-15bb-4282-bfbf-5a0cd30ba664" };
            nurses.Add(nurse);

            nurse = new Nurse {Id=new Guid("0f1babbe-d5db-49b9-9624-47b9d69df236"), FirstName = "Liam", LastName = "Brown", Salary = 1020,DepartmentId = Guid.Parse("70dd58b3-966e-4498-806f-04411c1bbbee"), EmailAddress = "brown@abv.bg",UserId= "0f1babbe-d5db-49b9-9624-47b9d69df236" };
            nurses.Add(nurse);

            nurse = new Nurse {Id=new Guid("af558d53-8adc-45ba-bfdd-1ca9e11e7185"), FirstName = "Sophia", LastName = "Davis", Salary = 670,DepartmentId= Guid.Parse("3a19290a-8b6d-4551-97ae-b87ecf3f2dd2"), EmailAddress = "davissophia@abv.bg",UserId= "af558d53-8adc-45ba-bfdd-1ca9e11e7185" };
            nurses.Add(nurse);

            nurse = new Nurse {Id=new Guid("c55b3e3f-6604-4bf4-a9c8-014d0c146003"), FirstName = "Noah", LastName = "Miller", Salary = 640 , DepartmentId = Guid.Parse("43f9018c-2a02-448d-b26e-bc832bc097d3"), EmailAddress = "miller@abv.bg",UserId= "c55b3e3f-6604-4bf4-a9c8-014d0c146003" };
            nurses.Add(nurse);

            nurse = new Nurse {Id=new Guid("3c8870b2-58cf-4341-8ea1-d024520563d0"), FirstName = "Olivia", LastName = "Taylor", Salary = 660 , DepartmentId = Guid.Parse("af2f0ad4-ff86-4e51-ab19-630145898ec6") , EmailAddress = "taylor@abv.bg",UserId= "3c8870b2-58cf-4341-8ea1-d024520563d0" };
            nurses.Add(nurse);

            nurse = new Nurse { Id = new Guid("7c032bc0-04e2-4111-bbfb-a59d46791529"), FirstName = "Olga", LastName = "Taskova", Salary = 680, DepartmentId = Guid.Parse("66ff68b3-846e-5398-805f-06411c1bbdff"), EmailAddress = "taskovao@abv.bg", UserId = "7c032bc0-04e2-4111-bbfb-a59d46791529" };
            nurses.Add(nurse);

            nurse = new Nurse { Id = new Guid("23fbee5b-fbe0-49a4-b312-6a5471f79dca"), FirstName = "Paola", LastName = "Nikolova", Salary = 680, DepartmentId = Guid.Parse("66ff68b3-846e-5398-805f-06411c1bbdff"), EmailAddress = "nikolovapa@abv.bg", UserId = "23fbee5b-fbe0-49a4-b312-6a5471f79dca" };
            nurses.Add(nurse);

            return nurses.ToArray();
        }
    }
}
