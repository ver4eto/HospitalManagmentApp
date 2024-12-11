using HospitalManagment.Infrastructure.Repositories.Contracts;
using HospitalManagment.ViewModels.Department;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using static HospitalManagmentApp.Common.EntityValidationConstants;
using Department = HospitalManagmentApp.DataModels.Department;

namespace HospitalManagmentApp.Services.Data
{
    public class DepartmentService : IDepartmentService
    {
       
        private IRepository<Department, Guid> departmentRepository;
        public DepartmentService(IRepository<Department, Guid> departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }
        public async Task<bool> AddDepartmentAsync(AddDepartmentViewModel model)
        {
            if (model == null || string.IsNullOrWhiteSpace(model.Name))
            {
                return false;
            }

            var department = new Department
            {
                Name = model.Name
            };

            await departmentRepository.AddAsync(department);
           
            return true;
        }

        public async Task<bool> DeleteDepartmentAsync(Guid id)
        {
            var department = await departmentRepository.GetAllAttcahed()
            .Where(d => d.Id == id && !d.IsDeleted)
            .FirstOrDefaultAsync();

            if (department == null)
            {
                return false;
            }

            department.IsDeleted = true;
            await departmentRepository.UpdateAsync(department);
            return true;
        }

        public async Task<List<DepartmentIndexViewModel>> GetAllDepartmentsAsync()
        {
            return await departmentRepository.GetAllAttcahed()
             .Where(d => !d.IsDeleted)
             .Select(d => new DepartmentIndexViewModel
             {
                 Id = d.Id,
                 Name = d.Name,
                 DepartmentDoctors = d.DepartmentDoctors.Count(),
                 Rooms = d.Rooms.Count(),
                 Nurses = d.Nurses.Count()
             })
             .ToListAsync();
        }

        public async Task<DeleteDepartmentViewModel> GetDeleteDepartmentViewModelAsync(Guid id)
        {
            var department = await departmentRepository.GetByIdAsync(id);
            if (department == null)
            {
                return null;
            }

            DeleteDepartmentViewModel deleteModel=new DeleteDepartmentViewModel()
            {
                DepartmentId = department.Id,
                Name = department.Name
            };
            return deleteModel;
        }

        public async Task<EditDepartmentViewModel> GetEditDepartmentViewModelAsync(Guid id)
        {
            var department = await departmentRepository.GetAllAttcahed()
            .Where(d => d.Id == id && !d.IsDeleted)
            .FirstOrDefaultAsync();

            if (department == null)
            {
                return null;
            }

            return new EditDepartmentViewModel
            {
                DepartmentId = department.Id,
                Name = department.Name
            };
        }

        public async Task<bool> UpdateDepartmentAsync(Guid id, EditDepartmentViewModel model)
        {
            if (model == null || string.IsNullOrWhiteSpace(model.Name))
            {
                return false;
            }

            var department = await departmentRepository.GetByIdAsync(id);
            if (department == null)
            {
                return false;
            }

            department.Name = model.Name;
            await departmentRepository.UpdateAsync(department);
            return true;
        }
    }
}
