using HospitalManagment.Infrastructure.Repositories.Contracts;
using HospitalManagment.ViewModels.Treatment;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data;
using MockQueryable;
using Moq;

namespace HospitalManagmentApp.Tests
{
    [TestFixture]
    public class TreatmentServiceTests
    {
        private Mock<IRepository<Treatment, Guid>> _treatmentRepo;
        private TreatmentService _treatmentService;

        [SetUp]
        public void SetUp()
        {
            _treatmentRepo = new Mock<IRepository<Treatment, Guid>>();
            _treatmentService = new TreatmentService(_treatmentRepo.Object);
        }

        [Test]
        public async Task GetAllTreatmentsAsync_ReturnsAllNonDeletedTreatments()
        {
            
            var treatments = new List<Treatment>
        {
            new Treatment
            {
                Id = Guid.NewGuid(),
                Name = "Physical Therapy",
                Price = 150.50m,
                IsDeleted = false
            },
            new Treatment
            {
                Id = Guid.NewGuid(),
                Name = "Chemotherapy",
                Price = 500.00m,
                IsDeleted = false
            },
            new Treatment
            {
                Id = Guid.NewGuid(),
                Name = "Radiotherapy",
                Price = 300.00m,
                IsDeleted = true // Deleted treatment
            }
        };

            var treatmentsMockQueryable = treatments.AsQueryable().BuildMock();

            _treatmentRepo.Setup(r => r.GetAllAttcahed())
                .Returns(treatmentsMockQueryable);

         
            var result = await _treatmentService.GetAllTreatmentsAsync();

            Assert.IsNotNull(result, "The result should not be null.");
            Assert.AreEqual(2, result.Count, "Only non-deleted treatments should be returned.");
            Assert.IsTrue(result.Any(t => t.Name == "Physical Therapy"), "Physical Therapy should be in the result.");
            Assert.IsTrue(result.Any(t => t.Name == "Chemotherapy"), "Chemotherapy should be in the result.");
            Assert.IsFalse(result.Any(t => t.Name == "Radiotherapy"), "Deleted treatments should not be included in the result.");
        }

        [Test]
        public async Task GetAllTreatmentsAsync_ReturnsEmptyList_WhenNoNonDeletedTreatmentsExist()
        {
            
            var treatments = new List<Treatment>
        {
            new Treatment
            {
                Id = Guid.NewGuid(),
                Name = "Radiotherapy",
                Price = 300.00m,
                IsDeleted = true // All treatment are deleted
            }
        };

            var treatmentsMockQueryable = treatments.AsQueryable().BuildMock();

            _treatmentRepo.Setup(r => r.GetAllAttcahed())
                .Returns(treatmentsMockQueryable);

            var result = await _treatmentService.GetAllTreatmentsAsync();

            Assert.IsNotNull(result, "The result should not be null.");
            Assert.IsEmpty(result, "The result should be an empty list when no non-deleted treatments exist.");
        }

        [Test]
        public async Task GetAllTreatmentsAsync_ReturnsEmptyList_WhenNoTreatmentsExist()
        {
            
            var treatmentsMockQueryable = new List<Treatment>().AsQueryable().BuildMock();

            _treatmentRepo.Setup(r => r.GetAllAttcahed())
                .Returns(treatmentsMockQueryable);

            
            var result = await _treatmentService.GetAllTreatmentsAsync();

         
            Assert.IsNotNull(result, "The result should not be null.");
            Assert.IsEmpty(result, "The result should be an empty list when no treatments exist.");
        }
        [Test]
        public async Task AddTreatmentAsync_ReturnsTrue_WhenTreatmentIsSuccessfullyAdded()
        {
           
            var model = new AddTreatmentViewModel
            {
                Name = "Physical Therapy",
                Price = 150.50m
            };

            _treatmentRepo.Setup(r => r.AddAsync(It.IsAny<Treatment>()))
                .Returns(Task.CompletedTask); 

           
            var result = await _treatmentService.AddTreatmentAsync(model);

            Assert.IsTrue(result, "AddTreatmentAsync should return true when a valid treatment is added.");
            _treatmentRepo.Verify(r => r.AddAsync(It.Is<Treatment>(t => t.Name == model.Name && t.Price == model.Price)), Times.Once);
        }

        [Test]
        public async Task AddTreatmentAsync_ReturnsFalse_WhenModelIsNull()
        {
            
            AddTreatmentViewModel model = null;

            var result = await _treatmentService.AddTreatmentAsync(model);

            
            Assert.IsFalse(result, "AddTreatmentAsync should return false when the model is null.");
            _treatmentRepo.Verify(r => r.AddAsync(It.IsAny<Treatment>()), Times.Never);
        }

        [Test]
        public async Task AddTreatmentAsync_ReturnsFalse_WhenNameIsEmpty()
        {
          
            var model = new AddTreatmentViewModel
            {
                Name = "  ", 
                Price = 100.00m
            };

               var result = await _treatmentService.AddTreatmentAsync(model);
            
            Assert.IsFalse(result, "AddTreatmentAsync should return false when the name is empty or whitespace.");
            _treatmentRepo.Verify(r => r.AddAsync(It.IsAny<Treatment>()), Times.Never);
        }

        [Test]
        public async Task AddTreatmentAsync_ReturnsFalse_WhenPriceIsZeroOrNegative()
        {
            
            var model = new AddTreatmentViewModel
            {
                Name = "Chemotherapy",
                Price = 0 // Invalid price
            };

            var result = await _treatmentService.AddTreatmentAsync(model);

          
            Assert.IsFalse(result, "AddTreatmentAsync should return false when the price is zero or negative.");
            _treatmentRepo.Verify(r => r.AddAsync(It.IsAny<Treatment>()), Times.Never);
        }

        [Test]
        public async Task GetEditTreatmentViewModelAsync_ReturnsViewModel_WhenTreatmentExists()
        {
            
            var treatmentId = Guid.NewGuid();
            var treatment = new Treatment
            {
                Id = treatmentId,
                Name = "Chemotherapy",
                Price = 500.00m,
                IsDeleted = false
            };

            var treatments = new List<Treatment> { treatment }.AsQueryable().BuildMock();

            _treatmentRepo.Setup(r => r.GetAllAttcahed())
                .Returns(treatments);

        
            var result = await _treatmentService.GetEditTreatmentViewModelAsync(treatmentId);

         
            Assert.IsNotNull(result, "The result should not be null when the treatment exists.");
            Assert.AreEqual("Chemotherapy", result.Name, "The treatment name should match the expected value.");
            Assert.AreEqual(500.00m, result.Price, "The treatment price should match the expected value.");
        }

        [Test]
        public async Task GetEditTreatmentViewModelAsync_ReturnsNull_WhenTreatmentDoesNotExist()
        {
            
            var treatmentId = Guid.NewGuid(); // Non-existing ID
            var treatments = new List<Treatment>().AsQueryable().BuildMock();

            _treatmentRepo.Setup(r => r.GetAllAttcahed())
                .Returns(treatments);

          
            var result = await _treatmentService.GetEditTreatmentViewModelAsync(treatmentId);

          
            Assert.IsNull(result, "The result should be null when the treatment does not exist.");
        }

        [Test]
        public async Task GetEditTreatmentViewModelAsync_ReturnsNull_WhenTreatmentIsDeleted()
        {
            
            var treatmentId = Guid.NewGuid();
            var treatment = new Treatment
            {
                Id = treatmentId,
                Name = "Radiotherapy",
                Price = 300.00m,
                IsDeleted = true 
            };

            var treatments = new List<Treatment> { treatment }.AsQueryable().BuildMock();

            _treatmentRepo.Setup(r => r.GetAllAttcahed())
                .Returns(treatments);

           
            var result = await _treatmentService.GetEditTreatmentViewModelAsync(treatmentId);

         
            Assert.IsNull(result, "The result should be null when the treatment is deleted.");
        }

        [Test]
        public async Task UpdateTreatmentAsync_ReturnsTrue_WhenUpdateIsSuccessful()
        {
           
            var treatmentId = Guid.NewGuid();
            var existingTreatment = new Treatment
            {
                Id = treatmentId,
                Name = "Radiotherapy",
                Price = 300.00m,
                IsDeleted = false
            };

            var model = new EditTreatmentViewModel
            {
                Name = "Updated Radiotherapy",
                Price = 350.00m
            };

            _treatmentRepo.Setup(r => r.GetByIdAsync(treatmentId))
                .ReturnsAsync(existingTreatment);

            _treatmentRepo.Setup(r => r.UpdateAsync(It.IsAny<Treatment>()))
                .Returns(Task.FromResult(true)); 

            var result = await _treatmentService.UpdateTreatmentAsync(treatmentId, model);

           
            Assert.IsTrue(result, "UpdateTreatmentAsync should return true when the update is successful.");
            _treatmentRepo.Verify(r => r.UpdateAsync(It.Is<Treatment>(t =>
                t.Id == treatmentId &&
                t.Name == model.Name &&
                t.Price == model.Price)), Times.Once);
        }

        [Test]
        public async Task UpdateTreatmentAsync_ReturnsFalse_WhenModelIsNull()
        {
            
            EditTreatmentViewModel model = null;
            var treatmentId = Guid.NewGuid();

            
            var result = await _treatmentService.UpdateTreatmentAsync(treatmentId, model);

            Assert.IsFalse(result, "UpdateTreatmentAsync should return false when the model is null.");
            _treatmentRepo.Verify(r => r.UpdateAsync(It.IsAny<Treatment>()), Times.Never);
        }

        [Test]
        public async Task UpdateTreatmentAsync_ReturnsFalse_WhenNameIsEmpty()
        {
           
            var treatmentId = Guid.NewGuid();
            var model = new EditTreatmentViewModel
            {
                Name = " ",
                Price = 200.00m
            };

          
            var result = await _treatmentService.UpdateTreatmentAsync(treatmentId, model);

         
            Assert.IsFalse(result, "UpdateTreatmentAsync should return false when the name is empty or whitespace.");
            _treatmentRepo.Verify(r => r.UpdateAsync(It.IsAny<Treatment>()), Times.Never);
        }

        [Test]
        public async Task UpdateTreatmentAsync_ReturnsFalse_WhenPriceIsZeroOrNegative()
        {
            
            var treatmentId = Guid.NewGuid();
            var model = new EditTreatmentViewModel
            {
                Name = "Valid Name",
                Price = 0 
            };

           
            var result = await _treatmentService.UpdateTreatmentAsync(treatmentId, model);

           
            Assert.IsFalse(result, "UpdateTreatmentAsync should return false when the price is zero or negative.");
            _treatmentRepo.Verify(r => r.UpdateAsync(It.IsAny<Treatment>()), Times.Never);
        }

        [Test]
        public async Task UpdateTreatmentAsync_ReturnsFalse_WhenTreatmentDoesNotExist()
        {
            
            var treatmentId = Guid.NewGuid();
            var model = new EditTreatmentViewModel
            {
                Name = "Updated Name",
                Price = 300.00m
            };

            _treatmentRepo.Setup(r => r.GetByIdAsync(treatmentId))
                .ReturnsAsync((Treatment)null); // No treatment found

          
            var result = await _treatmentService.UpdateTreatmentAsync(treatmentId, model);

           
            Assert.IsFalse(result, "UpdateTreatmentAsync should return false when the treatment does not exist.");
            _treatmentRepo.Verify(r => r.UpdateAsync(It.IsAny<Treatment>()), Times.Never);
        }

        [Test]
        public async Task GetDeleteTreatmentViewModelAsync_ReturnsViewModel_WhenTreatmentExists()
        {
           
            var treatmentId = Guid.NewGuid();
            var treatment = new Treatment
            {
                Id = treatmentId,
                Name = "Chemotherapy",
                Price = 500.00m,
                IsDeleted = false
            };

            _treatmentRepo.Setup(r => r.GetByIdAsync(treatmentId))
                .ReturnsAsync(treatment);

            
            var result = await _treatmentService.GetDeleteTreatmentViewModelAsync(treatmentId);

           
            Assert.IsNotNull(result, "The result should not be null when the treatment exists.");
            Assert.AreEqual(treatmentId, result.TreatmentId, "The treatment ID should match the expected value.");
            Assert.AreEqual("Chemotherapy", result.Name, "The treatment name should match the expected value.");
        }

        [Test]
        public async Task GetDeleteTreatmentViewModelAsync_ReturnsNull_WhenTreatmentDoesNotExist()
        {
           
            var treatmentId = Guid.NewGuid();
            _treatmentRepo.Setup(r => r.GetByIdAsync(treatmentId))
                .ReturnsAsync((Treatment)null); // No treatment found

           
            var result = await _treatmentService.GetDeleteTreatmentViewModelAsync(treatmentId);

           
            Assert.IsNull(result, "The result should be null when the treatment does not exist.");
        }

        [Test]
        public async Task DeleteTreatmentAsync_ReturnsTrue_WhenDeletionIsSuccessful()
        {
          
            var treatmentId = Guid.NewGuid();
            var treatment = new Treatment
            {
                Id = treatmentId,
                Name = "Chemotherapy",
                Price = 500.00m,
                IsDeleted = false
            };

            var treatments = new List<Treatment> { treatment }.AsQueryable().BuildMock();

            _treatmentRepo.Setup(r => r.GetAllAttcahed())
                .Returns(treatments);

            _treatmentRepo.Setup(r => r.UpdateAsync(It.IsAny<Treatment>()))
                .Returns(Task.FromResult(true));

          
            var result = await _treatmentService.DeleteTreatmentAsync(treatmentId);

           
            Assert.IsTrue(result, "DeleteTreatmentAsync should return true when the deletion is successful.");
            _treatmentRepo.Verify(r => r.UpdateAsync(It.Is<Treatment>(t => t.Id == treatmentId && t.IsDeleted)), Times.Once);
        }

        [Test]
        public async Task DeleteTreatmentAsync_ReturnsFalse_WhenTreatmentDoesNotExist()
        {
            
            var treatmentId = Guid.NewGuid();
            var treatments = new List<Treatment>().AsQueryable().BuildMock(); // No treatments available

            _treatmentRepo.Setup(r => r.GetAllAttcahed())
                .Returns(treatments);

            
            var result = await _treatmentService.DeleteTreatmentAsync(treatmentId);

          
            Assert.IsFalse(result, "DeleteTreatmentAsync should return false when the treatment does not exist.");
            _treatmentRepo.Verify(r => r.UpdateAsync(It.IsAny<Treatment>()), Times.Never);
        }

        [Test]
        public async Task DeleteTreatmentAsync_ReturnsFalse_WhenTreatmentIsAlreadyDeleted()
        {
           
            var treatmentId = Guid.NewGuid();
            var treatment = new Treatment
            {
                Id = treatmentId,
                Name = "Chemotherapy",
                Price = 500.00m,
                IsDeleted = true // Already deleted
            };

            var treatments = new List<Treatment> { treatment }.AsQueryable().BuildMock();

            _treatmentRepo.Setup(r => r.GetAllAttcahed())
                .Returns(treatments);

          
            var result = await _treatmentService.DeleteTreatmentAsync(treatmentId);

          
            Assert.IsFalse(result, "DeleteTreatmentAsync should return false when the treatment is already deleted.");
            _treatmentRepo.Verify(r => r.UpdateAsync(It.IsAny<Treatment>()), Times.Never);
        }
    }
}
