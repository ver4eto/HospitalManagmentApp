using HospitalManagment.Infrastructure.Repositories.Contracts;
using HospitalManagment.ViewModels.Manager;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data.Interfaces;
using HospitalManagmentApp.Views.Manager;
using Microsoft.EntityFrameworkCore;
using static HospitalManagment.ViewModels.Manager.ManagerPatientsReportViewModel;

namespace HospitalManagmentApp.Services.Data
{
    public class ManagerService : IManagerService
    {
        private readonly IRepository<Patient, Guid> patientsRepo;
        private readonly IRepository<Nurse, Guid> nursesRepo;
        private readonly IRepository<Doctor, Guid> doctorsRepo;
        private readonly IRepository<Department, Guid> departmentsRepo;
        private readonly IRepository<Room, Guid> roomRepo;
        private readonly IRepository<Manager, Guid> managerRepo;

        public ManagerService(IRepository<Patient, Guid> patients, IRepository<Nurse, Guid> nurses, IRepository<Doctor, Guid> doctors, IRepository<Department, Guid> departmentsRepo, IRepository<Room, Guid> roomRepo, IRepository<Manager, Guid> managerRepo)
        {
            this.patientsRepo = patients;
            this.nursesRepo = nurses;
            this.doctorsRepo = doctors;
            this.departmentsRepo = departmentsRepo;
            this.roomRepo = roomRepo;
            this.managerRepo = managerRepo;
        }


        public async Task<ManagerIndexViewModel> GetIndexManagerViewModel()
        {
            var patients =await GetAllPatients();

            var nurses =await GetAllNurses();

            var departments = await GetAllDepartments();

            var doctors = await GetAllDoctors();

            foreach (var department in departments)
            {
                var patientsInDepartment = patients.Where(p => p.DepartmentId == department.Id).ToList();

                var doctorsInDepartment = doctors.Where(d => d.DepartmentId == department.Id).ToList();
                var nursesInDepartment = nurses.Where(n => n.DepartmentId == department.Id).ToList();

                var treatmentCosts = patientsInDepartment.Sum(p => p.PatientTreatments.Sum(t => t.Treatment.Price));
                var salaries = doctorsInDepartment.Sum(d => d.Salary) + nursesInDepartment.Sum(n => n.Salary);
                var totalExpenses = treatmentCosts + salaries;
            }

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
                .ThenInclude(pt => pt.Treatment)
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

        public async Task<ManagerDoctorsReportsViewModel> GetDoctorsReportViewModel()
        {
            var doctors = await doctorsRepo.GetAllAttcahed()
                .Where(d => d.IsDeleted == false)
                .ToListAsync();

            var patients = await patientsRepo.GetAllAttcahed()
                .Where(p => p.IsDeleted == false)
                .ToListAsync();

            // Aggregate data
            var model = new ManagerDoctorsReportsViewModel
            {
                TotalDoctors = doctors.Count,
                TotalPatients = patients.Count,
                TotalExpenses = doctors.Sum(d => d.Salary).ToString("f2"),
                AverageSalary = (patients.Count > 0 ? doctors.Sum(d => d.Salary) / patients.Count : 0).ToString("f2")
            };

            return model;
        }

        public async Task<ManagerPatientsReportViewModel> GetPatientsReportViewModel()
        {
            List<Department> departments = await GetAllDepartments();
            List<Patient> patients = await GetAllPatients();

            // Aggregate data
            var departmentPatients = departments.Select(department =>
            {
                var patientCount = patients.Count(p => p.DepartmentId == department.Id);

                return new DepartmentPatientsViewModel
                {
                    DepartmentId = department.Id,
                    DepartmentName = department.Name,
                    PatientCount = patientCount
                };
            }).ToList();

            var totalPatients = departmentPatients.Sum(dp => dp.PatientCount);
            var averagePatientsPerDepartment = departments.Any()
                ? (double)totalPatients / departments.Count
                : 0;

            var model = new ManagerPatientsReportViewModel
            {
                TotalPatients = totalPatients,
                AveragePatientsPerDepartment = averagePatientsPerDepartment.ToString("f2"),
                Departments = departmentPatients
            };

            return model;
        }

        public async Task<ManagerGeneralReportViewModel> GetGeneralReportViewModel()
        {
            List<Nurse> nurses = await GetAllNurses();

            var doctors = await GetAllDoctors();

            // Calculate totals
            var totalEmployees = nurses.Count + doctors.Count;
            var totalExpenses = nurses.Sum(n => n.Salary) + doctors.Sum(d => d.Salary);
            var averageExpensePerEmployee = totalEmployees > 0 ? totalExpenses / totalEmployees : 0;

            // Create the view model
            var model = new ManagerGeneralReportViewModel
            {
                TotalEmployees = totalEmployees,
                TotalExpenses = totalExpenses.ToString("f2"),
                AverageExpensePerEmployee = averageExpensePerEmployee.ToString("f2")
            };

            return model;
        }

        
        private async Task<List<Doctor>> GetAllDoctors()
        {
            return await doctorsRepo.GetAllAttcahed()
                            .Where(d => d.IsDeleted == false)
                            .ToListAsync();
        }

        private async Task<List<Nurse>> GetAllNurses()
        {
            // Fetch data
            return await nursesRepo.GetAllAttcahed()
                .Where(n => n.IsDeleted == false)
                .ToListAsync();
        }

        private async Task<List<Department>> GetAllDepartments()
        {

            // Fetch data
            return await departmentsRepo.GetAllAttcahed()
                .Where(d => d.IsDeleted == false)
                .ToListAsync();
        }

        private async Task<List<Patient>> GetAllPatients()
        {
            return await patientsRepo.GetAllAttcahed()
                .Where(p => p.IsDeleted == false)
                .ToListAsync();
        }

        public async Task<IEnumerable<Manager>> GetAllManagersASync()
        {
            var managers = await managerRepo.GetAllAttcahed()
                .Where(m=>m.IsDeleted==false)
                .ToListAsync();

            return managers;
        }
    }
}
