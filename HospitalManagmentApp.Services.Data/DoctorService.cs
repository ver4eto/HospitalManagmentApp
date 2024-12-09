using HospitalManagment.Infrastructure.Repositories.Contracts;
using HospitalManagment.ViewModels.Doctor;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data.Interfaces;
using HospitalManagmentApp.Services.Mapping;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Department = HospitalManagmentApp.DataModels.Department;
using Doctor = HospitalManagmentApp.DataModels.Doctor;

namespace HospitalManagmentApp.Services.Data
{
    public class DoctorService : IDoctorService
    {
        private IRepository<Doctor, Guid> doctorsRepository;
        private IRepository<Department, Guid> departmentRepository;
        public readonly IUserEntityService userEntityService;

        public DoctorService(IRepository<Doctor, Guid> repository, IRepository<Department, Guid> departmentRepo, IUserEntityService userEntityService)
        {
            this.doctorsRepository = repository;
            this.departmentRepository = departmentRepo;
            this.userEntityService = userEntityService;
        }
        public async Task AddDoctorAsync(AddDoctorViewModel model)
        {
            Doctor doctor = new Doctor();
            try
            {
                var isUserCreated = await userEntityService.CreateApplicationUserAsync(model.EmailAddress, model.Password, "Doctor");


                doctor.Id = new Guid(isUserCreated);
                doctor.FirstName = model.FirstName;
                doctor.LastName = model.LastName;
                doctor.EmailAddress = model.EmailAddress;
                doctor.Salary = model.Salary;
                doctor.DepartmentId = model.DepartmentId;
                doctor.UserId = isUserCreated;
                doctor.Specialty = model.Specialty;

                await this.doctorsRepository.AddAsync(doctor);
            }
            catch (Exception ex)
            {

                throw;
            }


        }


        public async Task<bool> DeleteDoctorAsync(DeleteDoctorViewModel model, Guid id)
        {
            var doctor = await doctorsRepository.GetAllAttcahed()
                .Where(d => d.Id == id && d.IsDeleted == false)
                .FirstOrDefaultAsync();

            if (doctor == null) return false;

            doctor.IsDeleted = true;
            await doctorsRepository.UpdateAsync(doctor);

            return true;
        }

        public async Task<bool> EditDoctorAsync(EditDoctorViewModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model), "Model cannot be null.");
            }

            var doctor = await doctorsRepository.GetByIdAsync(model.Id);

            if (doctor == null)
            {
                return false; // Doctor not found
            }

            doctor.FirstName = model.FirstName;
            doctor.LastName = model.LastName;
            doctor.Specialty = model.Specialty;
            doctor.EmailAddress = model.EmailAddress;
            doctor.Salary = model.Salary;
            doctor.DepartmentId = model.DepartmentId;

            return await doctorsRepository.UpdateAsync(doctor);
        }

        public async Task<bool> GetAddDoctorToDepartmentAsync(AddDoctorToDepartmentViewModel model, Guid depId)
        {
            var department = await departmentRepository.GetByIdAsync(depId);
            if (department == null)
            {
                return false; // Department not found
            }

            // Find the doctor
            var doctor = await doctorsRepository.GetByIdAsync(model.SelectedDoctorId);
            if (doctor == null)
            {
                return false; // Doctor not found
            }

            // Update the doctor's department
            doctor.DepartmentId = department.Id;

            // Save changes
            await doctorsRepository.UpdateAsync(doctor);

            return true; // Successfully added doctor to department
        }

        public async Task<AddDoctorToDepartmentViewModel> GetAddDoctorToDepartmentViewModel(Guid id)
        {
            AddDoctorToDepartmentViewModel model = null;

            var department = await departmentRepository.GetByIdAsync(id);

            if (department == null)
            {
                throw new ArgumentException("Department not found");
            }


            var doctors = await doctorsRepository.GetAllAttcahed()
                .Where(d => !d.IsDeleted && d.DepartmentId != department.Id)
                .ToListAsync();


            model = new AddDoctorToDepartmentViewModel
            {
                DepartmentId = department.Id,
                DepartmentName = department.Name,
                Doctors = doctors
            };


            return model;
        }

        public async Task<AddDoctorViewModel> GetAddDoctorViewModel()
        {
            AddDoctorViewModel model = new AddDoctorViewModel();
            model.Departents = await GetDepartments();
            return model;
        }

        public async Task<DeleteDoctorViewModel> GetDeleteDoctorViewModel(Guid id)
        {
            DeleteDoctorViewModel? model = null;

            var doctor = await doctorsRepository.GetAllAttcahed()
                .Where(d => d.Id == id && d.IsDeleted == false)
                .Include(d => d.Department)
                .FirstOrDefaultAsync();

            if (doctor == null)
            {
                return model;
            }

            model = new()
            {
                Id = doctor.Id,
                FirstName = doctor.FirstName,
                LastName = doctor.LastName,
                Specialty = doctor.Specialty,

            };


            return model;
        }



        public async Task<EditDoctorViewModel?> GetEditDoctorViewModel(Guid id)
        {
            EditDoctorViewModel? model = null;

            var doctor = await doctorsRepository.GetAllAttcahed()
                .Where(d => d.Id == id && d.IsDeleted == false)
                .Include(d => d.Department)
                .FirstOrDefaultAsync();

            if (doctor == null)
            {
                return model;
            }

            model = new()
            {
                Id = doctor.Id,
                FirstName = doctor.FirstName,
                LastName = doctor.LastName,
                Specialty = doctor.Specialty,
                EmailAddress = doctor.EmailAddress,
                Salary = doctor.Salary,
                DepartmentId = doctor.Department.Id,
                Departments = await GetDepartments(),
                UserId = doctor.EmailAddress, //Todo: update with userclaims!!!!
            };

            return model;
        }

        public async Task<IEnumerable<DoctorIndexViewModel>> IndexGetAllDoctorsAsync()
        {
            try
            {
                var doctors = await this.doctorsRepository
       .GetAllAttcahed()
       .Where(d => !d.IsDeleted)
       .Select(d => new DoctorIndexViewModel
       {
           Id = d.Id,
           FirstName = d.FirstName,
           LastName = d.LastName,
           DepartmentName = d.Department.Name,
           Specialty = d.Specialty
       })
       .ToArrayAsync();

                if (doctors == null || !doctors.Any())
                {
                    throw new NullReferenceException("No doctors available!");
                }

                return doctors;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }

        public async Task<MenageDoctorViewModel?> MenageDoctor(Guid id)
        {
            MenageDoctorViewModel? model = null;

            var doctor = await this.doctorsRepository.GetAllAttcahed()
            .Where(d => d.IsDeleted == false && d.Id == id)
            .Include(d => d.Department)
            .FirstOrDefaultAsync();

            if (doctor.IsDeleted == false)
            {
                model = new()
                {
                    Id = doctor.Id,
                    FirstName = doctor.FirstName,
                    LastName = doctor.LastName,
                    Specialty = doctor.Specialty,
                    EmailAddress = doctor.EmailAddress,
                    Salary = doctor.Salary,
                    DepartmentName = doctor.Department.Name,
                    UserId = doctor.UserId,
                };
                
            }
            return model;
        }
        private async Task<IEnumerable<DataModels.Department>> GetDepartments()
        {
            return await departmentRepository.GetAllAsync();
        }
    }
}
