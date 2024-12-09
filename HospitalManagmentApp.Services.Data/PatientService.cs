using HospitalManagment.Infrastructure.Repositories.Contracts;
using HospitalManagment.ViewModels.Patient;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Security.Claims;
using System.Web.Mvc;
using static HospitalManagmentApp.Common.EntityValidationConstants;
using static HospitalManagmentApp.Common.ExceptionErrorMessages;
using Department = HospitalManagmentApp.DataModels.Department;
using Doctor = HospitalManagmentApp.DataModels.Doctor;
using Patient = HospitalManagmentApp.DataModels.Patient;
using Room = HospitalManagmentApp.DataModels.Room;
using Treatment = HospitalManagmentApp.DataModels.Treatment;

namespace HospitalManagmentApp.Services.Data
{
    public class PatientService : IPatientService
    {
        private readonly IRepository<Patient, Guid> patientRepo;
        private readonly IRepository<Doctor, Guid> doctorRepo;
        private readonly IRepository<Department, Guid> departmentRepo;
        private readonly IRepository<Room, Guid> roomRepo;
        private readonly IUserEntityService userEntityService;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IRepository<PatientDoctor, object> patientDoctorRepo;
        private readonly IRepository<Treatment, Guid> treatmentRepo;
        private readonly IRepository<PatientTreatment, object> patientTreatmentRepo;

        public PatientService(IRepository<Patient, Guid> patientRepo, IRepository<Department, Guid> departmenttRepo, IRepository<Room, Guid> roomRepo, IUserEntityService userEntityService, IHttpContextAccessor httpContextAccessor, IRepository<PatientDoctor, object> patientDoctorRepo, IRepository<Doctor, Guid> doctorRepo, IRepository<Treatment, Guid> treatmentRepo, IRepository<PatientTreatment, object> patientTreatmentRepo)
        {
            this.patientRepo = patientRepo;
            this.departmentRepo = departmenttRepo;
            this.roomRepo = roomRepo;
            this.userEntityService = userEntityService;
            this.httpContextAccessor = httpContextAccessor;
            this.patientDoctorRepo = patientDoctorRepo;
            this.doctorRepo = doctorRepo;
            this.treatmentRepo = treatmentRepo;
            this.patientTreatmentRepo = patientTreatmentRepo;
        }

        public async Task<List<PatientIndexViewModel>> GetAllPatientsAsync()
        {
            return await patientRepo.GetAllAttcahed()
         .Where(p => !p.IsDeleted)
         .Select(p => new PatientIndexViewModel
         {
             Id = p.Id,
             Name = $"{p.FirstName} {p.LastName}",
             EGN = p.EGN,
             PhoneNumber = p.PhoneNumber,
             Address = p.Address,
             Department = p.Department != null ? p.Department.Name : "Unknown",
             Room = p.Room != null ? p.Room.RoomNumber : 0,
             HasMedicalInsurance = HasMedicalInsurance(p.HasMedicalInsurance),
             EmailAddress = p.EmailAddress
         })
         .ToListAsync();
        }
        public async Task<AddPatientViewModel> PrepareAddPatientViewModelAsync()
        {
            var departments = await GetDepartments();

            AddPatientViewModel model = new AddPatientViewModel()
            {
                Departments = departments,
                Rooms = new List<System.Web.Mvc.SelectListItem>(),
                //Doctors = await GetDoctors()
            };

            var userId = httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);

           
            if (userId == null)
            {
                throw new Exception("UserId is null! HttpContext or User is not properly set.");
            }
            var isUserADoctor = httpContextAccessor.HttpContext?.User.IsInRole("Doctor") ?? false;

            if (isUserADoctor)
            {
                if (!string.IsNullOrWhiteSpace(userId) && Guid.TryParse(userId, out var doctorGuid))
                {
                    model.SelectedDoctorId = doctorGuid;
                }
            }
            else
            {

                model.Doctors = await GetDoctors();
            }
            return model;
        }

        public async Task<bool> AddPatientAsync(AddPatientViewModel model)
        {
            var patientUserId = await userEntityService.CreateApplicationUserAsync(model.EmailAddress, model.Password, "Patient");

            var userId = httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrEmpty(userId))
            {
                throw new InvalidOperationException("The current user is not logged in.");
            }


            var patient = new Patient
            {
                Id = new Guid(patientUserId),
                FirstName = model.FirstName,
                LastName = model.LastName,
                EmailAddress = model.EmailAddress,
                Address = model.Address,
                DepartmentId = model.DepartmentId,
                HasMedicalInsurance = model.HasMedicalInsurance,
                EGN = model.EGN,
                PhoneNumber = model.PhoneNumber,
                RoomId = model.RoomId,
                UserId = patientUserId,
            };



            var room = await roomRepo.GetByIdAsync(model.RoomId);
            if (room != null)
            {
                room.HasFreeBeds = false;
                await patientRepo.AddAsync(patient);

                Guid userIdGuid = new Guid(userId);

                PatientDoctor patientDoctor = await this.patientDoctorRepo
                    .FirstOrDefaultAsync(pd => pd.PatientId == patient.Id &&
                    pd.DoctorId == model.SelectedDoctorId);

                if (patientDoctor == null)
                {
                    patientDoctor = new PatientDoctor()
                    {
                        PatientId = patient.Id,
                        DoctorId = model.SelectedDoctorId,
                    };

                    await patientDoctorRepo.AddAsync(patientDoctor);

                }
                else
                {
                    throw new InvalidOperationException(string.Format(DoctorHasAlreadySuchPatientInList, patientDoctor.Doctor.LastName, patient.FirstName, patient.LastName));
                }
                return true;
            }

            return false;

        }

        public async Task<DischargePatientViewModel?> GetDischargePatientViewModel(Guid id)
        {
            var patient = await patientRepo.GetByIdAsync(id);
            DischargePatientViewModel? dischargePatientViewModel = new DischargePatientViewModel();
            if (patient == null)
            {
                return null; // Return null if patient does not exist
            }
            return new DischargePatientViewModel
            {
                Id = id,
                Name = $"{patient.FirstName} {patient.LastName}"
            };

        }
        public async Task<bool> DischargePatientAsync(DischargePatientViewModel model, Guid id)
        {
            var patient = await patientRepo.GetAllAttcahed()
                .Where(p => p.Id == id)
                .Where(d => d.IsDeleted == false)
                .FirstOrDefaultAsync();

            if (patient == null) { return false; }

            patient.IsDeleted = true;

            await patientRepo.UpdateAsync(patient);
            return true;
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

        public async Task<List<PatientIndexViewModel>> Menage()
        {
            var patients = await patientRepo.GetAllAttcahed()
                .Where(p => p.IsDeleted == false)
                .Select(p => new PatientIndexViewModel()
                {
                    Id = p.Id,
                    Name = $"{p.FirstName} {p.LastName}",
                    EGN = p.EGN,
                    PhoneNumber = p.PhoneNumber,
                    Address = p.Address,
                    Department = p.Department != null ? p.Department.Name : "N/A", // Handle null Department
                    Room = p.Room != null ? p.Room.RoomNumber : 0,
                    HasMedicalInsurance = HasMedicalInsurance(p.HasMedicalInsurance),
                    EmailAddress = p.EmailAddress,

                })
                .ToListAsync();

            return patients;
        }

        public async Task<PatientMedicalInfoViewModel?> SeePatientMedicalInfo(Guid patientId)
        {
            var model = new PatientMedicalInfoViewModel();

            var patient = await patientRepo.GetAllAttcahed()
        .Include(p => p.Department)
        .Include(p => p.PatientTreatments)
        .ThenInclude(t => t.Treatment)
        .FirstOrDefaultAsync(p => p.Id == patientId);

            if (patient != null)
            {
                model = new PatientMedicalInfoViewModel()
                {
                    PatientId = patientId,
                    FirstName = patient.FirstName,
                    LastName = patient.LastName,
                    DepartmentName = patient.Department.Name,
                    Treatments = patient.PatientTreatments
                        .Where(pt => pt.PatientId == patientId && pt.Treatment != null)
                        .Select(t => t.Treatment.Name)
                        .DefaultIfEmpty("No treatments available")
                        .ToList(),
                };
            }

            return model;
        }
        private static string HasMedicalInsurance(bool hasMedicalInsurance) =>
            hasMedicalInsurance ? "Yes" : "No";

        private async Task<IEnumerable<Department>> GetDepartments() =>
            await departmentRepo.GetAllAsync();

        private async Task<List<SelectListItem>> GetDoctors()
        {
            var doctors = await doctorRepo.GetAllAttcahed()
                .Select(d => new SelectListItem
                {
                    Value = d.Id.ToString(),
                    Text = d.LastName,
                }).ToListAsync();

            return doctors;
        }
        public async Task<List<SelectListItem>> GetFreeRoomsAsync(Guid departmentId)
        {
            // Fetch free rooms based on the given department ID
            var freeRooms = await roomRepo.GetAllAttcahed()
                .Where(r => r.DepartmnetId == departmentId && r.HasFreeBeds)
                .Select(r => new System.Web.Mvc.SelectListItem
                {
                    Value = r.Id.ToString(),
                    Text = r.RoomNumber.ToString()
                })
                .ToListAsync();

            if (!freeRooms.Any())
            {
                return new List<System.Web.Mvc.SelectListItem> { new System.Web.Mvc.SelectListItem { Text = "No free rooms available", Value = "" } };
            }

            return freeRooms;
        }

        public async Task<List<SelectListItem>> GetFreeRoomsOnMoveAsync(Guid departmentId)
        {
            var freeRooms = await roomRepo.GetAllAttcahed()
                .Where(r => r.DepartmnetId == departmentId && !r.Patients.Any())
                .Select(r => new System.Web.Mvc.SelectListItem
                {
                    Value = r.Id.ToString(),
                    Text = r.RoomNumber.ToString()
                })
                .ToListAsync();

            if (!freeRooms.Any())
            {
                return new List<System.Web.Mvc.SelectListItem> { new System.Web.Mvc.SelectListItem { Text = "No free rooms available", Value = "" } };
            }

            return freeRooms;
        }


        public async Task<AddTreatmentToPatientViewModel> GetAddTreatmentToPatientViewModel(Guid patientId)
        {
            var model = new AddTreatmentToPatientViewModel();

            var patient = await patientRepo.GetAllAttcahed()
                            .Include(p => p.Department)
                            .Include(p => p.PatientTreatments)
                            .ThenInclude(pt => pt.Treatment)
                            .FirstOrDefaultAsync(p => p.Id == patientId);

            if (patient != null)
            {
                //    var treatments = await treatmentRepo.GetAllAsync();

                //    var assignedTreatmentIds = patient.PatientTreatments
                //   .Select(pt => pt.TreatmentId)
                //   .ToHashSet();

                //    var availableTreatments = treatments
                //.Where(t => !assignedTreatmentIds.Contains(t.Id))
                //.ToList();

                var treatmentOptions = GetUnassignedTreatments(patient);

                model = new AddTreatmentToPatientViewModel
                {
                    PatientId = patient.Id,
                    FirstName = patient.FirstName,
                    LastName = patient.LastName,
                    DepartmentName = patient.Department?.Name ?? "No department assigned",
                    AvailableTreatments = await treatmentOptions,
                };
            }

            return model;
        }

        public async Task<bool> AddTreatmentToPatientAsync(AddTreatmentToPatientViewModel model)
        {
            var patient = await patientRepo.GetByIdAsync(model.PatientId);
            if (patient == null)
            {
                return false;
            }

            var patientTreatments = await patientTreatmentRepo.GetAllAttcahed()
                                         .Where(pt => pt.PatientId == patient.Id)
                                         .ToListAsync();

            var existingTreatmentIds = new HashSet<Guid>(patientTreatments.Select(pt => pt.TreatmentId));


            foreach (var treatmentId in model.SelectedTreatmentIds)
            {
                if (!existingTreatmentIds.Contains(treatmentId))
                {
                    var treatmentAssignment = new PatientTreatment
                    {
                        PatientId = model.PatientId,
                        TreatmentId = treatmentId
                    };

                    await patientTreatmentRepo.AddAsync(treatmentAssignment);
                }
            }
            return true;
        }

        public async Task<ChangeTreatmentsViewModel> GetChangeTreatmentViewModel(Guid patientId)
        {
            var model = new ChangeTreatmentsViewModel();

            var patient = await patientRepo.GetAllAttcahed()
                 .Include(p => p.Department)
                 .Include(p => p.PatientTreatments)
                 .ThenInclude(pt => pt.Treatment)
                 .FirstOrDefaultAsync(p => p.Id == patientId);

            if (patient != null)
            {
                List<SelectListItem> unassignedTreatments = await GetUnassignedTreatments(patient);

                var assignedTreatments = patient.PatientTreatments
                    .Select(pt => new SelectListItem
                    {
                        Value = pt.TreatmentId.ToString(),
                        Text = pt.Treatment.Name
                    })
                    .ToList();

                model = new ChangeTreatmentsViewModel
                {
                    PatientId = patient.Id,
                    FirstName = patient.FirstName,
                    LastName = patient.LastName,
                    DepartmentName = patient.Department?.Name ?? "No department assigned",
                    AssignedTreatments = assignedTreatments,
                    AvailableTreatments = unassignedTreatments
                };

            }

            return model;

        }
        
        public async Task<bool> ChangeTreatmentsAsync(ChangeTreatmentsViewModel model)
        {
            
            var patient = await patientRepo.GetAllAttcahed()
                .Where(p => p.Id == model.PatientId)
               .Include(p => p.PatientTreatments)
               .ThenInclude(pt => pt.Treatment)
               .FirstOrDefaultAsync();
          
            if (patient == null)
            {
                return false;
            }
            
           
            if (model.NewTreatmentIds != null && model.NewTreatmentIds.Any())
            {
                foreach (var treatment in model.NewTreatmentIds)
                {
                    if(await this.treatmentRepo.GetByIdAsync(treatment) == null)
                    {
                        return false;
                    }
                }
                foreach (var treatmentId in model.NewTreatmentIds)
                {
                    var isAlreadyAssigned = await patientTreatmentRepo.AnyAsync(pt =>
                        pt.PatientId == model.PatientId && pt.TreatmentId == treatmentId);

                    if (!isAlreadyAssigned)
                    {
                        var treatmentAssignment = new PatientTreatment
                        {
                            PatientId = model.PatientId,
                            TreatmentId = treatmentId
                        };

                        await patientTreatmentRepo.AddAsync(treatmentAssignment);
                    }
                }
            }
           
            
            if (model.RemovedTreatmentIds != null && model.RemovedTreatmentIds.Any())
            {
                foreach (var treatment in model.RemovedTreatmentIds)
                {
                    if (await this.treatmentRepo.GetByIdAsync(treatment) == null)
                    {
                        return false;
                    }
                }
                foreach (var treatmentId in model.RemovedTreatmentIds)
                {
                    var patientTreatment = await patientTreatmentRepo.FirstOrDefaultAsync(pt =>
                        pt.PatientId == model.PatientId && pt.TreatmentId == treatmentId);

                    if (patientTreatment != null)
                    {
                        await patientTreatmentRepo.DeleteAsync(patientTreatment);
                    }
                }
            }
            
            return true;
        }


        private async Task<List<SelectListItem>> GetUnassignedTreatments(Patient? patient)
        {
            var allTreatments = await treatmentRepo.GetAllAsync();

            var assignedTreatmentIds = patient.PatientTreatments
                .Select(pt => pt.TreatmentId)
                .ToHashSet();

            var unassignedTreatments = allTreatments
                .Where(t => !assignedTreatmentIds.Contains(t.Id))
                .Select(t => new SelectListItem
                {
                    Value = t.Id.ToString(),
                    Text = t.Name
                })
                .ToList();
            return unassignedTreatments;
        }


    }
}
