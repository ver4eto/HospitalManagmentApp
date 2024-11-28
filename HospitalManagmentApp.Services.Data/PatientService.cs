using HospitalManagment.Infrastructure.Repositories.Contracts;
using HospitalManagment.ViewModels.Patient;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Web.Mvc;

namespace HospitalManagmentApp.Services.Data
{
    public class PatientService : IPatientService
    {
        private readonly IRepository<Patient, Guid> patientRepo;
        private readonly IRepository<Department, Guid> departmentRepo;
        private readonly IRepository<Room, Guid> roomRepo;

        public PatientService(IRepository<Patient, Guid> patientRepo, IRepository<Department, Guid> departmenttRepo, IRepository<Room, Guid> roomRepo)
        {
            this.patientRepo = patientRepo;
            this.departmentRepo = departmenttRepo;
            this.roomRepo = roomRepo;
        }

        //TODO Refactor so it can be added with USerId
        public async Task<bool> AddPatientAsync(AddPatientViewModel model)
        {
            
            var patient = new Patient
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                EmailAddress = model.EmailAddress,
                Address = model.Address,
                DepartmentId = model.DepartmentId,
                HasMedicalInsurance = model.HasMedicalInsurance,
                EGN = model.EGN,
                PhoneNumber = model.PhoneNumber,
                RoomId = model.RoomId,
                UserId = model.EmailAddress
            };

            var room = await roomRepo.GetByIdAsync(model.RoomId);
            if (room != null)
            { 
                room.HasFreeBeds = false;
                await patientRepo.AddAsync(patient);
                return true;
            }

            return false;
            
        }

        public async Task<DischargePatientViewModel?> GetDischargePatientViewModel(Guid id)
        {
            var patient = await patientRepo.GetByIdAsync(id);
            DischargePatientViewModel? dischargePatientViewModel = new DischargePatientViewModel();
            if(patient != null)
            {
                dischargePatientViewModel.Id = id;
                dischargePatientViewModel.Name=$"{patient.FirstName} {patient.LastName}";
            }
            return dischargePatientViewModel;
        }

        public async Task<List<PatientIndexViewModel>> GetAllPatientsAsync()
        {
            return await patientRepo.GetAllAttcahed()
                 .Where(p => !p.IsDeleted)
                 .Select(p => new PatientIndexViewModel
                 {
                     Name = $"{p.FirstName} {p.LastName}",
                     EGN = p.EGN,
                     PhoneNumber = p.PhoneNumber,
                     Address = p.Address,
                     Department = p.Department.Name,
                     Room = p.Room.RoomNumber,
                     HasMedicalInsurance = HasMedicalInsurance(p.HasMedicalInsurance),
                     EmailAddress = p.EmailAddress
                 })
                 .ToListAsync();
        }

        public async Task<MovePatientToDepartmentViewModel?> GetMovePatientModelAsync(Guid id)
        {
            var patient = await patientRepo.GetAllAttcahed()
                .Include(p => p.Room)
                .Include(p => p.Department)
                .Where(p => !p.IsDeleted && p.Id == id)
                .FirstOrDefaultAsync();

            if (patient == null) return null;

            return new MovePatientToDepartmentViewModel
            {
                PatientId = id,
                Name = $"{patient.FirstName} {patient.LastName}",
                EGN = patient.EGN,
                CurrentRoom = patient.Room.RoomNumber,
                CurrentDepartment = patient.Department.Name,
                CurrentDepartmentId = patient.Department.Id,
                CurrentRoomId = patient.Room.Id,
                Departments = await GetDepartments()
            };
        }

        public async Task<bool> MovePatientAsync(MovePatientToDepartmentViewModel model)
        {
            var patient = await patientRepo.GetByIdAsync(model.PatientId);
            if (patient == null)
            {
                return false;
            }

            patient.DepartmentId = model.NewDepartmentId;
            patient.RoomId = model.NewRoomId;

            await patientRepo.UpdateAsync(patient);
            return true;
        }

        public async Task<AddPatientViewModel> PrepareAddPatientViewModelAsync()
        {
            var departments = await GetDepartments();
            return new AddPatientViewModel
            {
                Departments = departments,
                Rooms = new List<SelectListItem>()
            };
        }

        private static string HasMedicalInsurance(bool hasMedicalInsurance) =>
            hasMedicalInsurance ? "Yes" : "No";

        private async Task<IEnumerable<Department>> GetDepartments() =>
            await departmentRepo.GetAllAsync();

        public async Task<bool> DischargePatientAsync(DischargePatientViewModel model, Guid id)
        {
            var patient = await patientRepo.GetAllAttcahed()
                .Where(p => p.Id == id)
                .Where(d => d.IsDeleted == false)
                .FirstOrDefaultAsync();
                
            if(patient == null) { return false; }

            await patientRepo.UpdateAsync(patient);
            return true;
        }

        public async Task<List<PatientIndexViewModel>> Menage()
        {
            var patients= await patientRepo.GetAllAttcahed()
                .Where(p => p.IsDeleted == false)
                .Select(p => new PatientIndexViewModel()
                {
                    Id = p.Id,
                    Name = $"{p.FirstName} {p.LastName}",
                    EGN = p.EGN,
                    PhoneNumber = p.PhoneNumber,
                    Address = p.Address,
                    Department = p.Department.Name,
                    Room = p.Room.RoomNumber,
                    HasMedicalInsurance = HasMedicalInsurance(p.HasMedicalInsurance),
                    EmailAddress = p.EmailAddress,

                })
                .ToListAsync();

            return patients;
        }
    }
}
