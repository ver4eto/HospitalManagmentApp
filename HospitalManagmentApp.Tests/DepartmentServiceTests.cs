

using HospitalManagment.Infrastructure.Repositories.Contracts;
using HospitalManagment.ViewModels.Department;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data;
using MockQueryable;
using Moq;

namespace HospitalManagmentApp.Tests
{
    [TestFixture]
    public class DepartmentServiceTests
    {
        private Mock<IRepository<Department, Guid>> _departmentRepo;
        private DepartmentService _departmentService;

        [SetUp]
        public void SetUp()
        {
            _departmentRepo = new Mock<IRepository<Department, Guid>>();

            _departmentService = new DepartmentService(_departmentRepo.Object);
        }

        [Test]
        public async Task GetAllDepartmentsAsync_ReturnsCorrectData()
        {
           
            var departments = new List<Department>
        {
            new Department
            {
                Id = Guid.NewGuid(),
                Name = "Cardiology",
                DepartmentDoctors = new List<Doctor> { new Doctor(), new Doctor() },
                Rooms = new List<Room> { new Room(), new Room(), new Room() },
                Nurses = new List<Nurse> { new Nurse() }
            },
            new Department
            {
                Id = Guid.NewGuid(),
                Name = "Neurology",
                DepartmentDoctors = new List<Doctor> { new Doctor() },
                Rooms = new List<Room> { new Room() },
                Nurses = new List<Nurse> { new Nurse(), new Nurse() }
            }
        };

            
            _departmentRepo.Setup(r => r.GetAllAttcahed())
                .Returns(departments.AsQueryable().BuildMock());
           
            var result = await _departmentService.GetAllDepartmentsAsync();
           
            Assert.IsNotNull(result, "The result should not be null.");
            Assert.AreEqual(2, result.Count, "The number of departments should match the mock data.");

            var cardiology = result.First(d => d.Name == "Cardiology");
            Assert.AreEqual(2, cardiology.DepartmentDoctors, "Cardiology should have 2 doctors.");
            Assert.AreEqual(3, cardiology.Rooms, "Cardiology should have 3 rooms.");
            Assert.AreEqual(1, cardiology.Nurses, "Cardiology should have 1 nurse.");

            var neurology = result.First(d => d.Name == "Neurology");
            Assert.AreEqual(1, neurology.DepartmentDoctors, "Neurology should have 1 doctor.");
            Assert.AreEqual(1, neurology.Rooms, "Neurology should have 1 room.");
            Assert.AreEqual(2, neurology.Nurses, "Neurology should have 2 nurses.");
        }

        [Test]
        public async Task GetAllDepartmentsAsync_ReturnsEmptyList_WhenNoDepartmentsExist()
        {
            _departmentRepo.Setup(r => r.GetAllAttcahed())
                .Returns(new List<Department>().AsQueryable().BuildMock());

            var result = await _departmentService.GetAllDepartmentsAsync();

            Assert.IsNotNull(result, "The result should not be null.");
            Assert.IsEmpty(result, "The result should be an empty list when no departments exist.");
        }

        [Test]
        public async Task GetAllDepartmentsAsync_ExcludesDeletedDepartments()
        {
            var departments = new List<Department>
        {
            new Department
            {
                Id = Guid.NewGuid(),
                Name = "Cardiology",
                IsDeleted = false,
                DepartmentDoctors = new List<Doctor> { new Doctor() },
                Rooms = new List<Room> { new Room() },
                Nurses = new List<Nurse> { new Nurse() }
            },
            new Department
            {
                Id = Guid.NewGuid(),
                Name = "Neurology",
                IsDeleted = true, 
                DepartmentDoctors = new List<Doctor> { new Doctor() },
                Rooms = new List<Room> { new Room() },
                Nurses = new List<Nurse> { new Nurse() }
            }
        };

            _departmentRepo.Setup(r => r.GetAllAttcahed())
                .Returns(departments.AsQueryable().BuildMock());

           
            var result = await _departmentService.GetAllDepartmentsAsync();

            Assert.IsNotNull(result, "The result should not be null.");
            Assert.AreEqual(1, result.Count, "Only non-deleted departments should be returned.");
            Assert.AreEqual("Cardiology", result.First().Name, "The non-deleted department should be 'Cardiology'.");
        }

        [Test]
        public async Task UpdateDepartmentAsync_ReturnsTrue_WhenUpdateIsSuccessful()
        {
            var departmentId = Guid.NewGuid();
            var department = new Department { Id = departmentId, Name = "Old Department Name" };

            var editModel = new EditDepartmentViewModel { Name = "New Department Name" };

            _departmentRepo.Setup(r => r.GetByIdAsync(departmentId))
                .ReturnsAsync(department);

         
            var result = await _departmentService.UpdateDepartmentAsync(departmentId, editModel);

            Assert.IsTrue(result, "UpdateDepartmentAsync should return true when the update is successful.");
            _departmentRepo.Verify(r => r.UpdateAsync(It.Is<Department>(d => d.Id == departmentId && d.Name == "New Department Name")), Times.Once);
        }

        [Test]
        public async Task UpdateDepartmentAsync_ReturnsFalse_WhenModelIsNull()
        {
            
            var departmentId = Guid.NewGuid();

            var result = await _departmentService.UpdateDepartmentAsync(departmentId, null);

            Assert.IsFalse(result, "UpdateDepartmentAsync should return false when the model is null.");
            _departmentRepo.Verify(r => r.UpdateAsync(It.IsAny<Department>()), Times.Never);
        }

        [Test]
        public async Task UpdateDepartmentAsync_ReturnsFalse_WhenModelNameIsEmpty()
        {
            var departmentId = Guid.NewGuid();
            var editModel = new EditDepartmentViewModel { Name = "  " }; 
         
            var result = await _departmentService.UpdateDepartmentAsync(departmentId, editModel);

            Assert.IsFalse(result, "UpdateDepartmentAsync should return false when the model name is empty or whitespace.");
            _departmentRepo.Verify(r => r.UpdateAsync(It.IsAny<Department>()), Times.Never);
        }

        [Test]
        public async Task UpdateDepartmentAsync_ReturnsFalse_WhenDepartmentDoesNotExist()
        {
            
            var departmentId = Guid.NewGuid();
            var editModel = new EditDepartmentViewModel { Name = "New Department Name" };

            _departmentRepo.Setup(r => r.GetByIdAsync(departmentId))
                .ReturnsAsync((Department)null); 

            
            var result = await _departmentService.UpdateDepartmentAsync(departmentId, editModel);

        
            Assert.IsFalse(result, "UpdateDepartmentAsync should return false when the department does not exist.");
            _departmentRepo.Verify(r => r.UpdateAsync(It.IsAny<Department>()), Times.Never);
        }

        [Test]
        public async Task GetEditDepartmentViewModelAsync_ReturnsCorrectViewModel_WhenDepartmentExists()
        {
         
            var departmentId = Guid.NewGuid();
            var department = new Department
            {
                Id = departmentId,
                Name = "Cardiology",
                IsDeleted = false
            };

            var departments = new List<Department> { department }.AsQueryable().BuildMock();

            _departmentRepo.Setup(r => r.GetAllAttcahed()).Returns(departments);

            var result = await _departmentService.GetEditDepartmentViewModelAsync(departmentId);

          
            Assert.IsNotNull(result, "The result should not be null when the department exists.");
            Assert.AreEqual(departmentId, result.DepartmentId, "The DepartmentId should match the existing department's ID.");
            Assert.AreEqual("Cardiology", result.Name, "The Name should match the existing department's name.");
        }

        [Test]
        public async Task GetEditDepartmentViewModelAsync_ReturnsNull_WhenDepartmentDoesNotExist()
        {
            var departmentId = Guid.NewGuid();
            var departments = new List<Department>().AsQueryable().BuildMock();

            _departmentRepo.Setup(r => r.GetAllAttcahed()).Returns(departments);

          
            var result = await _departmentService.GetEditDepartmentViewModelAsync(departmentId);

          
            Assert.IsNull(result, "The result should be null when the department does not exist.");
        }

        [Test]
        public async Task GetEditDepartmentViewModelAsync_ReturnsNull_WhenDepartmentIsDeleted()
        {
           
            var departmentId = Guid.NewGuid();
            var department = new Department
            {
                Id = departmentId,
                Name = "Neurology",
                IsDeleted = true
            };

            var departments = new List<Department> { department }.AsQueryable().BuildMock();

            _departmentRepo.Setup(r => r.GetAllAttcahed()).Returns(departments);

            var result = await _departmentService.GetEditDepartmentViewModelAsync(departmentId);

            
            Assert.IsNull(result, "The result should be null when the department is marked as deleted.");
        }

        [Test]
        public async Task GetDeleteDepartmentViewModelAsync_ReturnsCorrectViewModel_WhenDepartmentExists()
        {
            var departmentId = Guid.NewGuid();
            var department = new Department
            {
                Id = departmentId,
                Name = "Cardiology"
            };

            _departmentRepo.Setup(r => r.GetByIdAsync(departmentId))
                .ReturnsAsync(department);

           
            var result = await _departmentService.GetDeleteDepartmentViewModelAsync(departmentId);

            Assert.IsNotNull(result, "The result should not be null when the department exists.");
            Assert.AreEqual(departmentId, result.DepartmentId, "The DepartmentId should match the existing department's ID.");
            Assert.AreEqual("Cardiology", result.Name, "The Name should match the existing department's name.");
        }

        [Test]
        public async Task GetDeleteDepartmentViewModelAsync_ReturnsNull_WhenDepartmentDoesNotExist()
        {
           
            var departmentId = Guid.NewGuid();

            _departmentRepo.Setup(r => r.GetByIdAsync(departmentId))
                .ReturnsAsync((Department)null); 
            
            var result = await _departmentService.GetDeleteDepartmentViewModelAsync(departmentId);

           
            Assert.IsNull(result, "The result should be null when the department does not exist.");
        }

        [Test]
        public async Task DeleteDepartmentAsync_ReturnsTrue_WhenDeletionIsSuccessful()
        {
            var departmentId = Guid.NewGuid();
            var department = new Department
            {
                Id = departmentId,
                Name = "Cardiology",
                IsDeleted = false
            };

            var departments = new List<Department> { department }.AsQueryable().BuildMock();

            _departmentRepo.Setup(r => r.GetAllAttcahed())
                .Returns(departments);
            _departmentRepo.Setup(r => r.UpdateAsync(It.IsAny<Department>()))
    .Returns(Task.FromResult(true)); 

            var result = await _departmentService.DeleteDepartmentAsync(departmentId);

          
            Assert.IsTrue(result, "DeleteDepartmentAsync should return true when the deletion is successful.");
            _departmentRepo.Verify(r => r.UpdateAsync(It.Is<Department>(d => d.Id == departmentId && d.IsDeleted)), Times.Once);
        }

        [Test]
        public async Task DeleteDepartmentAsync_ReturnsFalse_WhenDepartmentDoesNotExist()
        {
            
            var departmentId = Guid.NewGuid();
            var departments = new List<Department>().AsQueryable().BuildMock();

            _departmentRepo.Setup(r => r.GetAllAttcahed())
                .Returns(departments);

          
            var result = await _departmentService.DeleteDepartmentAsync(departmentId);

         
            Assert.IsFalse(result, "DeleteDepartmentAsync should return false when the department does not exist.");
            _departmentRepo.Verify(r => r.UpdateAsync(It.IsAny<Department>()), Times.Never);
        }

        [Test]
        public async Task DeleteDepartmentAsync_ReturnsFalse_WhenDepartmentIsAlreadyDeleted()
        {
            
            var departmentId = Guid.NewGuid();
            var department = new Department
            {
                Id = departmentId,
                Name = "Neurology",
                IsDeleted = true 
            };

            var departments = new List<Department> { department }.AsQueryable().BuildMock();

            _departmentRepo.Setup(r => r.GetAllAttcahed())
                .Returns(departments);

          
            var result = await _departmentService.DeleteDepartmentAsync(departmentId);

           
            Assert.IsFalse(result, "DeleteDepartmentAsync should return false when the department is already deleted.");
            _departmentRepo.Verify(r => r.UpdateAsync(It.IsAny<Department>()), Times.Never);
        }

        [Test]
        public async Task AddDepartmentAsync_ReturnsTrue_WhenDepartmentIsSuccessfullyAdded()
        {
           
            var model = new AddDepartmentViewModel
            {
                Name = "Cardiology"
            };

            _departmentRepo.Setup(r => r.AddAsync(It.IsAny<Department>()))
                .Returns(Task.CompletedTask); // Mock AddAsync to return Task.CompletedTask

            
            var result = await _departmentService.AddDepartmentAsync(model);

          
            Assert.IsTrue(result, "AddDepartmentAsync should return true when a valid department is added.");
            _departmentRepo.Verify(r => r.AddAsync(It.Is<Department>(d => d.Name == model.Name)), Times.Once);
        }

        [Test]
        public async Task AddDepartmentAsync_ReturnsFalse_WhenModelIsNull()
        {
            
            AddDepartmentViewModel model = null;

          
            var result = await _departmentService.AddDepartmentAsync(model);

            
            Assert.IsFalse(result, "AddDepartmentAsync should return false when the model is null.");
            _departmentRepo.Verify(r => r.AddAsync(It.IsAny<Department>()), Times.Never);
        }

        [Test]
        public async Task AddDepartmentAsync_ReturnsFalse_WhenNameIsEmpty()
        {
            
            var model = new AddDepartmentViewModel
            {
                Name = "  "
            };

            
            var result = await _departmentService.AddDepartmentAsync(model);

        
            Assert.IsFalse(result, "AddDepartmentAsync should return false when the name is empty or whitespace.");
            _departmentRepo.Verify(r => r.AddAsync(It.IsAny<Department>()), Times.Never);
        }
    }

}
