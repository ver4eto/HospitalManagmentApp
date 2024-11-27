using HospitalManagment.Infrastructure.Repositories.Contracts;
using HospitalManagment.ViewModels.Nurse;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagmentApp.Services.Data
{
    public class NurseService : INurseService
    {
        private IRepository<Nurse, Guid> nurseRepository;
        private IRepository<Department, Guid> departmentRepository;

        public NurseService(IRepository<Nurse, Guid> nurseRepository, IRepository<Department, Guid> departmentRepository)
        {
            this.nurseRepository = nurseRepository; 
            this.departmentRepository = departmentRepository;
        }
        public async Task<List<NurseIndexViewModel>> GetAllNursesAsync()
        {
            return await nurseRepository.GetAllAttcahed()
                .Where(n => !n.IsDeleted)
                .Select(n => new NurseIndexViewModel
                {
                    Id = n.Id,
                    FirstName = n.FirstName,
                    LastName = n.LastName,
                    Department = n.Department.Name
                })
                .ToListAsync();
        }

        public async Task<AddNurseViewModel> GetAddNurseViewModelAsync()
        {
            return new AddNurseViewModel
            {
                Departments = await GetAllDepartmentsAsync()
            };
        }

        public async Task<bool> AddNurseAsync(AddNurseViewModel model)
        {
            var nurse = new Nurse
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                EmailAddress = model.EmailAddress,
                Salary = model.Salary,
                DepartmentId = model.DepartmentId,
                UserId = model.EmailAddress
            };

            await nurseRepository.AddAsync(nurse);
            
            return true;
        }

        public async Task<EditNurseViewModel> GetEditNurseViewModelAsync(Guid id)
        {
            var nurse = await nurseRepository.GetAllAttcahed()
                .Where(n => n.Id == id && !n.IsDeleted)
                .Include(n => n.Department)
                .FirstOrDefaultAsync();

            if (nurse == null) return null;

            return new EditNurseViewModel
            {
                Id = nurse.Id,
                FirstName = nurse.FirstName,
                LastName = nurse.LastName,
                EmailAddress = nurse.EmailAddress,
                Salary = nurse.Salary,
                DepartmentId = nurse.Department.Id,
                Departments = await GetAllDepartmentsAsync()
            };
        }

        public async Task<bool> UpdateNurseAsync(Guid id, EditNurseViewModel model)
        {
            var nurse = await nurseRepository.GetByIdAsync(id);
            if (nurse == null) return false;

            nurse.FirstName = model.FirstName;
            nurse.LastName = model.LastName;
            nurse.EmailAddress = model.EmailAddress;
            nurse.Salary = model.Salary;
            nurse.DepartmentId = model.DepartmentId;

            await nurseRepository.UpdateAsync(nurse);
            return true;
        }

        public async Task<DeleteNurseViewModel> GetDeleteNurseViewModelAsync(Guid id)
        {
            var nurse = await nurseRepository.GetAllAttcahed()
                .Include(n => n.Department)
                .FirstOrDefaultAsync(n => n.Id == id);

            if (nurse == null) return null;

            return new DeleteNurseViewModel
            {
                Id = nurse.Id,
                FirstName = nurse.FirstName,
                LastName = nurse.LastName,
                DepartmentName = nurse.Department.Name
            };
        }

        public async Task<bool> DeleteNurseAsync(Guid id)
        {
            var nurse = await nurseRepository.GetAllAttcahed()
                .Where(n => n.Id == id && !n.IsDeleted)
                .FirstOrDefaultAsync();

            if (nurse == null) return false;

            nurse.IsDeleted = true;
            await nurseRepository.UpdateAsync(nurse);
            return true;
        }

        public async Task<AddNurseToDepartmentViewModel> GetAddNurseToDepartmentViewModelAsync(Guid departmentId)
        {
            var department = await departmentRepository.GetByIdAsync(departmentId);
            if (department == null) return null;

            var nurses = await nurseRepository.GetAllAttcahed()
                .Where(n => !n.IsDeleted && n.DepartmentId != departmentId)
                .ToListAsync();

            return new AddNurseToDepartmentViewModel
            {
                DepartmentId = departmentId,
                DepartmentName = department.Name,
                Nurses = nurses
            };
        }

        public async Task<bool> AddNurseToDepartmentAsync(Guid departmentId, Guid selectedNurseId)
        {
            var nurse = await nurseRepository.GetByIdAsync(selectedNurseId);
            if (nurse == null) return false;

            nurse.DepartmentId = departmentId;
            await nurseRepository.UpdateAsync(nurse);
            return true;
        }

        public async Task<IEnumerable<Department>> GetAllDepartmentsAsync()
        {
            return await departmentRepository.GetAllAsync();
        }
    }
}
