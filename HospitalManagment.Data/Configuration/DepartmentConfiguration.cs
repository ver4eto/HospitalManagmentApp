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

            department=new Department()
            {
                Name="Neurology",

            };    

            departments.Add(department);
            department = new Department()
            {
                Name = "Surgery",

            };
            departments.Add(department);

            department = new Department()
            {
                Name = "Internal",

            };
            departments.Add (department);
            department = new Department()
            {
                Name = "Pediatrics",

            };
            departments.Add(department);

            return departments.ToArray();
        }
    }
}
