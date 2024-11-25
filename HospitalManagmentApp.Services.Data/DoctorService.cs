using HospitalManagment.Infrastructure.Repositories.Contracts;
using HospitalManagment.ViewModels.Doctor;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data.Interfaces;
using HospitalManagmentApp.Services.Mapping;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagmentApp.Services.Data
{
    public class DoctorService : IDoctorService
    {
        private IRepository<Doctor, Guid> doctorsRepository;

        public DoctorService(IRepository<Doctor, Guid> repository)
        {
            this.doctorsRepository = repository;
        }
        public Task AddDoctorAsync(AddDoctorViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddDoctorToDepartmentAsync(AddDoctorViewModel model, Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteDoctorAsync(DeleteDoctorViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditDoctorAsync(EditDoctorViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<AddDoctorToDepartmentViewModel> GetAddDoctorToDepartmentViewModel(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteDoctorViewModel> GetDeleteDoctorViewModel(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<EditDoctorViewModel> GetEditDoctorViewModel(Guid id)
        {
            throw new NotImplementedException();
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

        public Task<IActionResult> MenageDoctor(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
