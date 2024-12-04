using HospitalManagment.Infrastructure.Repositories.Contracts;
using HospitalManagment.ViewModels.Manager;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data.Interfaces;
using HospitalManagmentApp.Views.Manager;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagmentApp.Services.Data
{
    public class ManagerService : IManagerService
    {
        private readonly IRepository<Patient, Guid> patientsRepo;
        private readonly IRepository<Nurse, Guid> nursesRepo;
        private readonly IRepository<Doctor, Guid> doctorsRepo;
        private readonly IRepository<Department, Guid> departmentsRepo;
        private readonly IRepository<Room, Guid> roomRepo;

        public ManagerService(IRepository<Patient, Guid> patients, IRepository<Nurse, Guid> nurses, IRepository<Doctor, Guid> doctors, IRepository<Department, Guid> departmentsRepo, IRepository<Room, Guid> roomRepo)
        {
            this.patientsRepo = patients;
            this.nursesRepo = nurses;
            this.doctorsRepo = doctors;
            this.departmentsRepo = departmentsRepo;
            this.roomRepo = roomRepo;
        }


        public async Task<ManagerIndexViewModel> GetIndexManagerViewModel()
        {
            var patients = await patientsRepo.GetAllAttcahed()
                .Where(p => p.IsDeleted == false)
                .ToListAsync();

            var nurses = await nursesRepo.GetAllAttcahed()
                .Where(n => n.IsDeleted == false)
                .ToListAsync();

            var departments = await departmentsRepo.GetAllAttcahed()
                .Where(d => d.IsDeleted == false)
                .ToListAsync();

            var doctors = await doctorsRepo.GetAllAttcahed()
                .Where(d => d.IsDeleted == false)
                .ToListAsync();

            // var departmentsDetails = new List<DepartmentDetailsViewModel>();

            foreach (var department in departments)
            {
                var patientsInDepartment = patients.Where(p => p.DepartmentId == department.Id).ToList();

                var doctorsInDepartment = doctors.Where(d => d.DepartmentId == department.Id).ToList();
                var nursesInDepartment = nurses.Where(n => n.DepartmentId == department.Id).ToList();

                var treatmentCosts = patientsInDepartment.Sum(p => p.PatientTreatments.Sum(t => t.Treatment.Price));
                var salaries = doctorsInDepartment.Sum(d => d.Salary) + nursesInDepartment.Sum(n => n.Salary);
                var totalExpenses = treatmentCosts + salaries;

                //// var departmentDetails = new DepartmentDetailsViewModel
                // {
                //     DepartmentName = department.Name,
                //     PatientCount = patientsInDepartment.Count,
                //     TotalExpenses = totalExpenses,
                //     Patients = patientsInDepartment.Select(p => new PatientDetailsViewModel
                //     {
                //         PatientId = p.Id,
                //         Name = $"{p.FirstName} {p.LastName}",
                //         TreatmentCosts = p.PatientTreatments.Sum(t => t.Treatment.Price)
                //     }).ToList()
                /// };

                // departmentsDetails.Add(departmentDetails);
            }

            //var model = new ManagerIndexViewModel
            //{
            //    PatientsOverview = new SectorOverviewViewModel
            //    {
            //        Name = "Patients",
            //        Count = patients.Count()
            //    },
            //    NursesOverview = new SectorOverviewViewModel
            //    {
            //        Name = "Nurses",
            //        Count = nurses.Count()
            //    },
            //    DepartmentsOverview = new SectorOverviewViewModel
            //    {
            //        Name = "Departments",
            //        Count = departments.Count()
            //    },
            //    Departments = departmentsDetails
            //};
            return new ManagerIndexViewModel();
        }

        public async Task<ManagerDepartmentReportsViewModel> GetDepartmentReportsViewModel()
        {
            var departments = await departmentsRepo.GetAllAttcahed()
                .Where(d => d.IsDeleted == false)
                .ToListAsync();

            var doctors = await doctorsRepo.GetAllAttcahed()
                .Where(d => d.IsDeleted == false)
                .ToListAsync();

            var nurses = await nursesRepo.GetAllAttcahed()
                .Where(n => n.IsDeleted == false)
                .ToListAsync();

            var patients = await patientsRepo.GetAllAttcahed()
                .Where(p => p.IsDeleted == false)
                .Include(p => p.PatientTreatments)
                .ThenInclude(pt=>pt.Treatment)
                .ToListAsync();

            var rooms = await roomRepo.GetAllAttcahed()
                .Where(r => r.IsDeleted == false)
                .ToListAsync();

            var model = new ManagerDepartmentReportsViewModel();

            foreach (var department in departments)
            {
                var nursesExpenses = department.Nurses.Sum(n => n.Salary);
                var doctorExpenses = department.DepartmentDoctors.Sum(n => n.Salary);
                var treatmentExpenses = department.Patients.Sum(p =>
      p.PatientTreatments?.Sum(pt => pt.Treatment?.Price ?? 0) ?? 0);

                var totalExpenses = nursesExpenses + doctorExpenses + treatmentExpenses;

                var departmentStats = new DepartmentStatsViewModel
                {
                    DepartmentId = department.Id,
                    DepartmentName = department.Name,
                    DoctorCount = doctors.Count(d => d.DepartmentId == department.Id),
                    NurseCount = nurses.Count(n => n.DepartmentId == department.Id),
                    PatientCount = patients.Count(p => p.DepartmentId == department.Id),
                    RoomCount = rooms.Count(r => r.DepartmnetId == department.Id),
                    TotalExpenses = totalExpenses,
                };

                model.Departments.Add(departmentStats);

                // Aggregate totals
                model.TotalDoctors += departmentStats.DoctorCount;
                model.TotalNurses += departmentStats.NurseCount;
                model.TotalPatients += departmentStats.PatientCount;
                model.TotalRooms += departmentStats.RoomCount;
                model.TotalExpenses += departmentStats.TotalExpenses;
            }

            return model;
        }


    }
}
