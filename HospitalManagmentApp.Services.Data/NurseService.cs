using HospitalManagment.Infrastructure.Repositories.Contracts;
using HospitalManagment.ViewModels.Nurse;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagmentApp.Services.Data
{
    public class NurseService : INurseService
    {
        private readonly IRepository<Nurse, Guid> nurseRepository;
        private readonly IRepository<Department, Guid> departmentRepository;
        private readonly IUserEntityService userEntityService;

        public NurseService(IRepository<Nurse, Guid> nurseRepository, IRepository<Department, Guid> departmentRepository, IUserEntityService userEntityService)
        {
            this.nurseRepository = nurseRepository; 
            this.departmentRepository = departmentRepository;
            this.userEntityService = userEntityService;
        }
        public async Task<List<NurseIndexViewModel>> GetAllNursesAsync(string? search, string? department)
        {
            try
            {
                // Fetch nurses from the repository with base conditions
                var nursesQuery = this.nurseRepository
                    .GetAllAttcahed()
                    .Where(n => !n.IsDeleted);

                // Apply search filter if search input is provided
                if (!string.IsNullOrWhiteSpace(search))
                {
                    var searchData = search.ToLower().Trim();
                    nursesQuery = nursesQuery.Where(n =>
                        n.FirstName.ToLower().Contains(searchData) ||
                        n.LastName.ToLower().Contains(searchData));
                }
                if (!string.IsNullOrWhiteSpace(department))
                {
                    var departmentFilter = department.ToLower().Trim();
                    nursesQuery = nursesQuery.Where(d => d.Department.Name.ToLower().Contains(departmentFilter));
                }
                // Project the data to the view model
                var nurses = await nursesQuery
                    .Select(n => new NurseIndexViewModel
                    {
                        Id = n.Id,
                        FirstName = n.FirstName,
                        LastName = n.LastName,
                        Department = n.Department.Name
                    })
                    .ToListAsync();

                return nurses;
            }
            catch (Exception ex)
            {
                // Handle exceptions or log them as needed
                throw new ApplicationException("An error occurred while fetching the nurses.", ex);
            }
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
            try
            {
                if (model == null)
                {
                    throw new ArgumentNullException(nameof(model), "The model cannot be null.");
                }

                var nurseUserId = await userEntityService.CreateApplicationUserAsync(model.EmailAddress, model.Password, "Nurse");

                var nurse = new Nurse
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    EmailAddress = model.EmailAddress,
                    Salary = model.Salary,
                    DepartmentId = model.DepartmentId,
                    UserId = nurseUserId,
                    Id = new Guid(nurseUserId),
                };

                await nurseRepository.AddAsync(nurse);

                return true;
            }
            catch (Exception)
            {
                
                return false;
            }
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
