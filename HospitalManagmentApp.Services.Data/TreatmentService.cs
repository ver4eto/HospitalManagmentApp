using HospitalManagment.Infrastructure.Repositories.Contracts;
using HospitalManagment.ViewModels.Treatment;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace HospitalManagmentApp.Services.Data
{
    public class TreatmentService : ITreatmentService
    {
        private readonly IRepository<Treatment,Guid> treatmentRepo;

        public TreatmentService(IRepository<Treatment, Guid> treatmentRepo)
        {
            this.treatmentRepo = treatmentRepo;
        }

        public async Task<List<TreatmentIndexViewModel>> GetAllTreatmentsAsync()
        {
            return await treatmentRepo.GetAllAttcahed()
                .Where(t => !t.IsDeleted)
                .Select(t => new TreatmentIndexViewModel
                {
                    Id = t.Id,
                    Name = t.Name,
                    Price = t.Price.ToString("f2")
                })
                .ToListAsync();
        }

        public async Task<bool> AddTreatmentAsync(AddTreatmentViewModel model)
        {
            if (model == null || string.IsNullOrWhiteSpace(model.Name) || model.Price <= 0)
            {
                return false;
            }

            var treatment = new Treatment
            {
                Name = model.Name,
                Price = model.Price
            };

            await treatmentRepo.AddAsync(treatment);
           
            return true;
        }

        public async Task<EditTreatmentViewModel> GetEditTreatmentViewModelAsync(Guid id)
        {
            var treatment = await treatmentRepo.GetAllAttcahed()
                .Where(t => t.Id == id && !t.IsDeleted)
                .FirstOrDefaultAsync();

            if (treatment == null)
            {
                return null;
            }

            return new EditTreatmentViewModel
            {
                Name = treatment.Name,
                Price = treatment.Price
            };
        }

        public async Task<bool> UpdateTreatmentAsync(Guid id, EditTreatmentViewModel model)
        {
            if (model == null || string.IsNullOrWhiteSpace(model.Name) || model.Price <= 0)
            {
                return false;
            }

            var treatment = await treatmentRepo.GetByIdAsync(id);
            if (treatment == null)
            {
                return false;
            }

            treatment.Name = model.Name;
            treatment.Price = model.Price;

            await treatmentRepo.UpdateAsync(treatment);
            return true;
        }

        public async Task<DeleteTreatmentViewModel> GetDeleteTreatmentViewModelAsync(Guid id)
        {
            var treatment = await treatmentRepo.GetByIdAsync(id);
            if (treatment == null)
            {
                return null;
            }

            return new DeleteTreatmentViewModel
            {
                TreatmentId = treatment.Id,
                Name = treatment.Name
            };
        }

        public async Task<bool> DeleteTreatmentAsync(Guid id)
        {
            var treatment = await treatmentRepo.GetAllAttcahed()
                .Where(t => t.Id == id && !t.IsDeleted)
                .FirstOrDefaultAsync();

            if (treatment == null)
            {
                return false;
            }

            treatment.IsDeleted = true;
            await treatmentRepo.UpdateAsync(treatment);
            return true;
        }

    }
}
