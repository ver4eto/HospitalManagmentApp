using HospitalManagmentApp.Data.Configuration;
using HospitalManagmentApp.DataModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagmentApp.Data
{
    public class HMDbContext : IdentityDbContext<IdentityUser>
    {
        public HMDbContext(DbContextOptions<HMDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Nurse> Nurses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Treatment> Treatments { get; set; }

        public virtual DbSet<PatientTreatment> PatientsTreatments { get; set; }
        public virtual DbSet<PatientDoctor> PatientsDoctors { get; set; }

        public virtual DbSet<Manager> Managers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new DepartmentConfiguration());
            builder.ApplyConfiguration(new DoctorConfiguration());
            builder.ApplyConfiguration(new NurseConfiguration());
            builder.ApplyConfiguration(new RoomConfiguration());
            builder.ApplyConfiguration(new TreatmentConfiguration());
            builder.ApplyConfiguration(new PatientConfiguration());
            builder.ApplyConfiguration(new PatientTreatmentConfiguration());
            builder.ApplyConfiguration(new ManagerConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
