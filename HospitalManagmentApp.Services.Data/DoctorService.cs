using HospitalManagment.Infrastructure.Repositories.Contracts;
using HospitalManagment.ViewModels.Doctor;
using HospitalManagmentApp.Services.Data.Interfaces;
using HospitalManagmentApp.Services.Mapping;
using Microsoft.EntityFrameworkCore;
using Department = HospitalManagmentApp.DataModels.Department;
using Doctor = HospitalManagmentApp.DataModels.Doctor;

namespace HospitalManagmentApp.Services.Data
{
    public class DoctorService : IDoctorService
    {
        private IRepository<Doctor, Guid> doctorsRepository;
        private IRepository<Department, Guid> departmentRepository;

        public DoctorService(IRepository<Doctor, Guid> repository,IRepository<Department,Guid> departmentRepo)
        {
            this.doctorsRepository = repository;
            this.departmentRepository = departmentRepo;
        }
        public async Task AddDoctorAsync(AddDoctorViewModel model)
        {
            Doctor doctor = new Doctor();
            AutoMapperConfig.MapperInstance.Map(model, doctor);

           await this.doctorsRepository.AddAsync(doctor);
        }

       
        public async Task<bool> DeleteDoctorAsync(DeleteDoctorViewModel model,Guid id)
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
            Doctor doctor=AutoMapperConfig.MapperInstance
                .Map<EditDoctorViewModel,Doctor>(model);

            bool result = await this.doctorsRepository .UpdateAsync(doctor);
            return result;
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

           
            model= new AddDoctorToDepartmentViewModel
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
            model.Departents =await GetDepartments();
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

            //model = new()
            //{
            //    Id = doctor.Id,
            //    FirstName = doctor.FirstName,
            //    LastName = doctor.LastName,
            //    Specialty = doctor.Specialty,

            //};
            AutoMapperConfig.MapperInstance.Map(model, doctor);

            return model;
        }

        

        public async Task<EditDoctorViewModel?> GetEditDoctorViewModel(Guid id)
        {
            EditDoctorViewModel? model=null;

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
                UserId=doctor.EmailAddress, //Todo: update with userclaims!!!!
            };

            return model;
        }

        public async Task<IEnumerable<DoctorIndexViewModel>> IndexGetAllDoctorsAsync()
        {
            var doctors = await this.doctorsRepository
               .GetAllAttcahed()
               .Where(d => d.IsDeleted == false)
               .To<DoctorIndexViewModel>(AutoMapperConfig.MapperInstance.ConfigurationProvider)
               .ToArrayAsync();

            return doctors;
        }

        public async Task<MenageDoctorViewModel?> MenageDoctor(Guid id)
        {
            MenageDoctorViewModel? model = null;

            var doctor = await this.doctorsRepository.GetAllAttcahed()
            .Where(d => d.IsDeleted == false && d.Id == id)
            .Include(d=>d.Department)
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
                //AutoMapperConfig.MapperInstance.Map(doctor, model);
            }
            return model;
        }
        private async Task<IEnumerable<DataModels.Department>> GetDepartments()
        {
            return await departmentRepository.GetAllAsync();
        }
    }
}
