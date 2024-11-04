using HospitalManagmentApp.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentApp.Data.Configuration
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder
                .HasData(SeedDepartments());
        }

        private Department[] SeedDepartments()
        {
            ICollection<Department> departments=new HashSet<Department>();
            Department department;

            department = new Department()
            {
                Id = new Guid("af2f0ad4-ff86-4e51-ab19-630145898ec6"),
                Name = "Neurology"

            };    

            departments.Add(department);
            department = new Department()
            {
                Id=new Guid("70dd58b3-966e-4498-806f-04411c1bbbee"),
                Name = "Surgery"

            };
            departments.Add(department);

            department = new Department()
            {
                Id=new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"),
                Name = "Internal"

            };
            departments.Add (department);
            department = new Department()
            {
                Id=new Guid("3a19290a-8b6d-4551-97ae-b87ecf3f2dd2"),
                Name = "Pediatrics"

            };
            departments.Add(department);

            return departments.ToArray();
        }
    }
}
