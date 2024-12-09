using HospitalManagment.Infrastructure.Repositories.Contracts;
using HospitalManagment.ViewModels.Nurse;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data;
using HospitalManagmentApp.Services.Data.Interfaces;
using MockQueryable;
using Moq;

namespace HospitalManagmentApp.Tests
{
    [TestFixture]
    public class NurseServiceTests
    {
        private Mock<IRepository<Nurse, Guid>> _nurseRepo;
        private Mock<IRepository<Department, Guid>> _departmentRepo;
        private Mock<IUserEntityService> _userEntityService;
        private NurseService _nurseService;

        private List<Nurse> _nurseData;
        private List<Department> _departmentData;

        [SetUp]
        public void SetUp()
        {
            _nurseRepo = new Mock<IRepository<Nurse, Guid>>();
            _departmentRepo = new Mock<IRepository<Department, Guid>>();

            _userEntityService = new Mock<IUserEntityService>();
            _nurseService = new NurseService(
           _nurseRepo.Object,
           _departmentRepo.Object,
           _userEntityService.Object
       );

            _departmentData = new List<Department>
        {
            new Department { Id = Guid.NewGuid(), Name = "Neurology" },
            new Department { Id = Guid.NewGuid(), Name = "Cardiology" }
        };

            _nurseData = new List<Nurse>
        {
            new Nurse
            {
                Id = Guid.NewGuid(),
                FirstName = "Alice",
                LastName = "Johnson",
                EmailAddress = "alice.johnson@example.com",
                Salary = 50000,
                Department = _departmentData[0],
                IsDeleted = false
            },
            new Nurse
            {
                Id = Guid.NewGuid(),
                FirstName = "Bob",
                LastName = "Smith",
                EmailAddress = "bob.smith@example.com",
                Salary = 55000,
                Department = _departmentData[1],
                IsDeleted = true // Deleted nurse
            }

            };

        }

        [Test]
        public async Task GetAllNursesAsync_ReturnsNurses_WhenNursesExist()
        {
            // Arrange
            var nurses = new List<Nurse>
        {
            new Nurse
            {
                Id = Guid.NewGuid(),
                FirstName = "Alice",
                LastName = "Johnson",
                IsDeleted = false,
                Department = new Department { Name = "Cardiology" }
            },
            new Nurse
            {
                Id = Guid.NewGuid(),
                FirstName = "Bob",
                LastName = "Smith",
                IsDeleted = false,
                Department = new Department { Name = "Neurology" }
            }
        };

            var mockNursesQueryable = nurses.AsQueryable().BuildMock();
            _nurseRepo.Setup(r => r.GetAllAttcahed()).Returns(mockNursesQueryable);

            // Act
            var result = await _nurseService.GetAllNursesAsync();

            // Assert
            Assert.IsNotNull(result, "The result should not be null when nurses exist.");
            Assert.AreEqual(2, result.Count, "The result should contain two nurses.");
            Assert.AreEqual("Alice", result.First().FirstName, "The first nurse's first name should match.");
            Assert.AreEqual("Cardiology", result.First().Department, "The first nurse's department should match.");
        }

        [Test]
        public async Task GetAllNursesAsync_ReturnsEmptyList_WhenNoNursesExist()
        {
            // Arrange
            var emptyNurses = new List<Nurse>();
            var mockNursesQueryable = emptyNurses.AsQueryable().BuildMock();
            _nurseRepo.Setup(r => r.GetAllAttcahed()).Returns(mockNursesQueryable);

            // Act
            var result = await _nurseService.GetAllNursesAsync();

            // Assert
            Assert.IsNotNull(result, "The result should not be null even when no nurses exist.");
            Assert.IsEmpty(result, "The result should be an empty list when no nurses exist.");
        }

        [Test]
        public async Task GetAllNursesAsync_ExcludesDeletedNurses()
        {
            // Arrange
            var nurses = new List<Nurse>
        {
            new Nurse
            {
                Id = Guid.NewGuid(),
                FirstName = "Alice",
                LastName = "Johnson",
                IsDeleted = false,
                Department = new Department { Name = "Cardiology" }
            },
            new Nurse
            {
                Id = Guid.NewGuid(),
                FirstName = "Bob",
                LastName = "Smith",
                IsDeleted = true, // Deleted nurse
                Department = new Department { Name = "Neurology" }
            }
        };

            var mockNursesQueryable = nurses.AsQueryable().BuildMock();
            _nurseRepo.Setup(r => r.GetAllAttcahed()).Returns(mockNursesQueryable);

            // Act
            var result = await _nurseService.GetAllNursesAsync();

            // Assert
            Assert.IsNotNull(result, "The result should not be null when nurses exist.");
            Assert.AreEqual(1, result.Count, "The result should contain only non-deleted nurses.");
            Assert.AreEqual("Alice", result.First().FirstName, "The first nurse's first name should match.");
            Assert.AreEqual("Cardiology", result.First().Department, "The first nurse's department should match.");
        }

        [Test]
        public async Task GetAddNurseViewModelAsync_ReturnsViewModel_WithDepartments()
        {
            // Arrange
            var departments = new List<Department>
        {
            new Department { Id = Guid.NewGuid(), Name = "Cardiology" },
            new Department { Id = Guid.NewGuid(), Name = "Neurology" }
        };

            // Mock department repository to return departments
            _departmentRepo.Setup(r => r.GetAllAsync()).ReturnsAsync(departments);

            // Act
            var result = await _nurseService.GetAddNurseViewModelAsync();

            // Assert
            Assert.IsNotNull(result, "The result should not be null.");
            Assert.IsNotNull(result.Departments, "The Departments property should not be null.");
            Assert.AreEqual(2, result.Departments.Count(), "The number of departments should match.");
            Assert.AreEqual("Cardiology", result.Departments.First().Name, "The first department's name should match.");
        }

        [Test]
        public async Task GetAddNurseViewModelAsync_ReturnsEmptyDepartments_WhenNoDepartmentsExist()
        {
            // Arrange
            var emptyDepartments = new List<Department>();

            // Mock department repository to return an empty list
            _departmentRepo.Setup(r => r.GetAllAsync()).ReturnsAsync(emptyDepartments);

            // Act
            var result = await _nurseService.GetAddNurseViewModelAsync();

            // Assert
            Assert.IsNotNull(result, "The result should not be null.");
            Assert.IsNotNull(result.Departments, "The Departments property should not be null.");
            Assert.IsEmpty(result.Departments, "The Departments property should be empty when no departments exist.");
        }

        [Test]
        public async Task AddNurseAsync_ReturnsTrue_WhenNurseIsSuccessfullyAdded()
        {
            // Arrange
            var nurseUserId = Guid.NewGuid().ToString();
            var nurseModel = new AddNurseViewModel
            {
                FirstName = "Alice",
                LastName = "Johnson",
                EmailAddress = "alice.johnson@example.com",
                Password = "SecurePassword123!",
                Salary = 50000,
                DepartmentId = Guid.NewGuid()
            };

            var userEntityServiceMock = new Mock<IUserEntityService>();
            userEntityServiceMock
                .Setup(s => s.CreateApplicationUserAsync(
                    nurseModel.EmailAddress,
                    nurseModel.Password,
                    "Nurse"))
                .ReturnsAsync(nurseUserId);

            var nurseRepoMock = new Mock<IRepository<Nurse, Guid>>();
            nurseRepoMock
                .Setup(r => r.AddAsync(It.IsAny<Nurse>()))
                .Returns(Task.CompletedTask);
            var departmentRepoMock = new Mock<IRepository<Department, Guid>>();
            departmentRepoMock
                .Setup(r => r.GetByIdAsync(It.IsAny<Guid>()))
                .ReturnsAsync(new Department { Id = nurseModel.DepartmentId, Name = "Test Department" });

            // Inject all dependencies
            var nurseService = new NurseService(nurseRepoMock.Object, departmentRepoMock.Object, userEntityServiceMock.Object);

            // Act
            var result = await nurseService.AddNurseAsync(nurseModel);

            // Assert
            Assert.IsTrue(result, "AddNurseAsync should return true when the nurse is successfully added.");
            userEntityServiceMock.Verify(s => s.CreateApplicationUserAsync(
                nurseModel.EmailAddress,
                nurseModel.Password,
                "Nurse"), Times.Once);
            nurseRepoMock.Verify(r => r.AddAsync(It.Is<Nurse>(n =>
                n.FirstName == nurseModel.FirstName &&
                n.LastName == nurseModel.LastName &&
                n.EmailAddress == nurseModel.EmailAddress &&
                n.Salary == nurseModel.Salary &&
                n.DepartmentId == nurseModel.DepartmentId &&
                n.UserId == nurseUserId)), Times.Once);
        }

        [Test]
        public async Task AddNurseAsync_ReturnsFalse_WhenUserCreationFails()
        {
            var nurseModel = new AddNurseViewModel
            {
                FirstName = "Alice",
                LastName = "Johnson",
                EmailAddress = "alice.johnson@example.com",
                Password = "SecurePassword123!",
                Salary = 50000,
                DepartmentId = Guid.NewGuid()
            };

            _userEntityService
                .Setup(s => s.CreateApplicationUserAsync(
                    nurseModel.EmailAddress,
                    nurseModel.Password,
                    "Nurse"))
                .ThrowsAsync(new Exception("User creation failed."));

            // Act
            var result = await _nurseService.AddNurseAsync(nurseModel);

            // Assert
            Assert.IsFalse(result, "AddNurseAsync should return false when user creation fails.");
            _userEntityService.Verify(s => s.CreateApplicationUserAsync(
                nurseModel.EmailAddress,
                nurseModel.Password,
                "Nurse"), Times.Once);
            _nurseRepo.Verify(r => r.AddAsync(It.IsAny<Nurse>()), Times.Never, "AddAsync should not be called when user creation fails.");
        }

        [Test]
        public async Task AddNurseAsync_ThrowsException_WhenModelIsNull()
        {
            AddNurseViewModel nullModel = null;

            // Act
            var result = await _nurseService.AddNurseAsync(nullModel);

            // Assert
            Assert.IsFalse(result, "AddNurseAsync should return false when the model is null.");
        }

        [Test]
        public async Task GetEditNurseViewModelAsync_ReturnsViewModel_WhenNurseExists()
        {
            // Arrange
            var nurse = _nurseData.First();
            var nurseId = nurse.Id;

            _nurseRepo.Setup(r => r.GetAllAttcahed())
                .Returns(_nurseData.AsQueryable().BuildMock());

            _departmentRepo.Setup(r => r.GetAllAsync())
                .ReturnsAsync(_departmentData);

            // Act
            var result = await _nurseService.GetEditNurseViewModelAsync(nurseId);

            // Assert
            Assert.IsNotNull(result, "The result should not be null when the nurse exists.");
            Assert.AreEqual(nurse.Id, result.Id, "The nurse ID should match.");
            Assert.AreEqual(nurse.FirstName, result.FirstName, "The first name should match.");
            Assert.AreEqual(nurse.LastName, result.LastName, "The last name should match.");
            Assert.AreEqual(nurse.EmailAddress, result.EmailAddress, "The email address should match.");
            Assert.AreEqual(nurse.Salary, result.Salary, "The salary should match.");
            Assert.AreEqual(nurse.Department.Id, result.DepartmentId, "The department ID should match.");
            Assert.AreEqual(2, result.Departments.Count(), "The number of departments should match.");
        }

        [Test]
        public async Task GetEditNurseViewModelAsync_ReturnsNull_WhenNurseDoesNotExist()
        {
            // Arrange
            var nonexistentNurseId = Guid.NewGuid();

            _nurseRepo.Setup(r => r.GetAllAttcahed())
                .Returns(_nurseData.AsQueryable().BuildMock());

            // Act
            var result = await _nurseService.GetEditNurseViewModelAsync(nonexistentNurseId);

            // Assert
            Assert.IsNull(result, "The result should be null when the nurse does not exist.");
        }

        [Test]
        public async Task GetEditNurseViewModelAsync_ReturnsNull_WhenNurseIsDeleted()
        {
            // Arrange
            var deletedNurse = _nurseData.First(n => n.IsDeleted);

            _nurseRepo.Setup(r => r.GetAllAttcahed())
                .Returns(_nurseData.AsQueryable().BuildMock());

            // Act
            var result = await _nurseService.GetEditNurseViewModelAsync(deletedNurse.Id);

            // Assert
            Assert.IsNull(result, "The result should be null when the nurse is deleted.");
        }

        [Test]
        public async Task UpdateNurseAsync_ReturnsTrue_WhenNurseIsSuccessfullyUpdated()
        {
            // Arrange
            var nurseId = Guid.NewGuid();
            var nurse = new Nurse
            {
                Id = nurseId,
                FirstName = "John",
                LastName = "Doe",
                EmailAddress = "john.doe@example.com",
                Salary = 50000,
                DepartmentId = Guid.NewGuid()
            };

            var editModel = new EditNurseViewModel
            {
                FirstName = "Jane",
                LastName = "Smith",
                EmailAddress = "jane.smith@example.com",
                Salary = 60000,
                DepartmentId = Guid.NewGuid()
            };

            _nurseRepo.Setup(r => r.GetByIdAsync(nurseId)).ReturnsAsync(nurse);
            _nurseRepo.Setup(r => r.UpdateAsync(It.IsAny<Nurse>())).Returns(Task.FromResult(true));

            // Act
            var result = await _nurseService.UpdateNurseAsync(nurseId, editModel);

            // Assert
            Assert.IsTrue(result, "UpdateNurseAsync should return true when the nurse is successfully updated.");
            _nurseRepo.Verify(r => r.GetByIdAsync(nurseId), Times.Once);
            _nurseRepo.Verify(r => r.UpdateAsync(It.Is<Nurse>(n =>
                n.FirstName == editModel.FirstName &&
                n.LastName == editModel.LastName &&
                n.EmailAddress == editModel.EmailAddress &&
                n.Salary == editModel.Salary &&
                n.DepartmentId == editModel.DepartmentId)), Times.Once);
        }

        [Test]
        public async Task UpdateNurseAsync_ReturnsFalse_WhenNurseDoesNotExist()
        {
            // Arrange
            var nurseId = Guid.NewGuid();
            var editModel = new EditNurseViewModel
            {
                FirstName = "Jane",
                LastName = "Smith",
                EmailAddress = "jane.smith@example.com",
                Salary = 60000,
                DepartmentId = Guid.NewGuid()
            };

            _nurseRepo.Setup(r => r.GetByIdAsync(nurseId)).ReturnsAsync((Nurse)null);

            // Act
            var result = await _nurseService.UpdateNurseAsync(nurseId, editModel);

            // Assert
            Assert.IsFalse(result, "UpdateNurseAsync should return false when the nurse does not exist.");
            _nurseRepo.Verify(r => r.GetByIdAsync(nurseId), Times.Once);
            _nurseRepo.Verify(r => r.UpdateAsync(It.IsAny<Nurse>()), Times.Never);
        }

        [Test]
        public async Task GetDeleteNurseViewModelAsync_ReturnsViewModel_WhenNurseExists()
        {
            // Arrange
            var nurseId = Guid.NewGuid();
            var department = new Department
            {
                Id = Guid.NewGuid(),
                Name = "Neurology"
            };

            var nurse = new Nurse
            {
                Id = nurseId,
                FirstName = "John",
                LastName = "Doe",
                Department = department
            };

            var nurses = new[] { nurse }.AsQueryable();
            var mockNurses = nurses.BuildMock();

            _nurseRepo.Setup(r => r.GetAllAttcahed()).Returns(mockNurses);

            // Act
            var result = await _nurseService.GetDeleteNurseViewModelAsync(nurseId);

            // Assert
            Assert.IsNotNull(result, "The result should not be null when the nurse exists.");
            Assert.AreEqual(nurseId, result.Id, "The nurse ID should match.");
            Assert.AreEqual("John", result.FirstName, "The nurse's first name should match.");
            Assert.AreEqual("Doe", result.LastName, "The nurse's last name should match.");
            Assert.AreEqual("Neurology", result.DepartmentName, "The department name should match.");
        }

        [Test]
        public async Task GetDeleteNurseViewModelAsync_ReturnsNull_WhenNurseDoesNotExist()
        {
            // Arrange
            var nurseId = Guid.NewGuid();
            var nurses = new Nurse[0].AsQueryable();
            var mockNurses = nurses.BuildMock();

            _nurseRepo.Setup(r => r.GetAllAttcahed()).Returns(mockNurses);

            // Act
            var result = await _nurseService.GetDeleteNurseViewModelAsync(nurseId);

            // Assert
            Assert.IsNull(result, "The result should be null when the nurse does not exist.");
        }
        [Test]
        public async Task DeleteNurseAsync_ReturnsTrue_WhenNurseIsSuccessfullyDeleted()
        {
            // Arrange
            var nurseId = Guid.NewGuid();
            var nurse = new Nurse
            {
                Id = nurseId,
                IsDeleted = false
            };

            var nurses = new[] { nurse }.AsQueryable();
            var mockNurses = nurses.BuildMock();

            _nurseRepo.Setup(r => r.GetAllAttcahed()).Returns(mockNurses);
            _nurseRepo.Setup(r => r.UpdateAsync(It.IsAny<Nurse>())).Returns(Task.FromResult(true));

            // Act
            var result = await _nurseService.DeleteNurseAsync(nurseId);

            // Assert
            Assert.IsTrue(result, "DeleteNurseAsync should return true when the nurse is successfully deleted.");
            _nurseRepo.Verify(r => r.UpdateAsync(It.Is<Nurse>(n => n.Id == nurseId && n.IsDeleted)), Times.Once);
        }

        [Test]
        public async Task DeleteNurseAsync_ReturnsFalse_WhenNurseDoesNotExist()
        {
            // Arrange
            var nurseId = Guid.NewGuid();
            var nurses = new Nurse[0].AsQueryable();
            var mockNurses = nurses.BuildMock();

            _nurseRepo.Setup(r => r.GetAllAttcahed()).Returns(mockNurses);

            // Act
            var result = await _nurseService.DeleteNurseAsync(nurseId);

            // Assert
            Assert.IsFalse(result, "DeleteNurseAsync should return false when the nurse does not exist.");
            _nurseRepo.Verify(r => r.UpdateAsync(It.IsAny<Nurse>()), Times.Never);
        }

        [Test]
        public async Task GetAddNurseToDepartmentViewModelAsync_ReturnsViewModel_WhenDepartmentExists()
        {
            // Arrange
            var departmentId = Guid.NewGuid();
            var department = new Department
            {
                Id = departmentId,
                Name = "Neurology"
            };

            var nurses = new[]
            {
            new Nurse { Id = Guid.NewGuid(), FirstName = "Alice", LastName = "Smith", DepartmentId = Guid.NewGuid(), IsDeleted = false },
            new Nurse { Id = Guid.NewGuid(), FirstName = "Bob", LastName = "Johnson", DepartmentId = Guid.NewGuid(), IsDeleted = false }
        }.AsQueryable();

            var mockNurses = nurses.BuildMock();

            _departmentRepo.Setup(r => r.GetByIdAsync(departmentId)).ReturnsAsync(department);
            _nurseRepo.Setup(r => r.GetAllAttcahed()).Returns(mockNurses);

            // Act
            var result = await _nurseService.GetAddNurseToDepartmentViewModelAsync(departmentId);

            // Assert
            Assert.IsNotNull(result, "The result should not be null when the department exists.");
            Assert.AreEqual(departmentId, result.DepartmentId, "The department ID should match.");
            Assert.AreEqual("Neurology", result.DepartmentName, "The department name should match.");
            Assert.AreEqual(2, result.Nurses.Count, "The number of nurses should match.");
        }

        [Test]
        public async Task GetAddNurseToDepartmentViewModelAsync_ReturnsNull_WhenDepartmentDoesNotExist()
        {
            // Arrange
            var departmentId = Guid.NewGuid();

            _departmentRepo.Setup(r => r.GetByIdAsync(departmentId)).ReturnsAsync((Department)null);

            // Act
            var result = await _nurseService.GetAddNurseToDepartmentViewModelAsync(departmentId);

            // Assert
            Assert.IsNull(result, "The result should be null when the department does not exist.");
            _departmentRepo.Verify(r => r.GetByIdAsync(departmentId), Times.Once);
            _nurseRepo.Verify(r => r.GetAllAttcahed(), Times.Never, "Nurse repository should not be called if department does not exist.");
        }

        [Test]
        public async Task AddNurseToDepartmentAsync_ReturnsTrue_WhenNurseExists()
        {
            // Arrange
            var departmentId = Guid.NewGuid();
            var nurseId = Guid.NewGuid();
            var nurse = new Nurse
            {
                Id = nurseId,
                FirstName = "Alice",
                LastName = "Smith",
                DepartmentId = Guid.NewGuid()
            };

            _nurseRepo.Setup(r => r.GetByIdAsync(nurseId)).ReturnsAsync(nurse);
            _nurseRepo.Setup(r => r.UpdateAsync(nurse)).Returns(Task.FromResult(true));

            // Act
            var result = await _nurseService.AddNurseToDepartmentAsync(departmentId, nurseId);

            // Assert
            Assert.IsTrue(result, "AddNurseToDepartmentAsync should return true when the nurse exists and is updated.");
            Assert.AreEqual(departmentId, nurse.DepartmentId, "The nurse's department ID should be updated.");
            _nurseRepo.Verify(r => r.GetByIdAsync(nurseId), Times.Once);
            _nurseRepo.Verify(r => r.UpdateAsync(nurse), Times.Once);
        }

        [Test]
        public async Task AddNurseToDepartmentAsync_ReturnsFalse_WhenNurseDoesNotExist()
        {
            // Arrange
            var nurseId = Guid.NewGuid();
            _nurseRepo.Setup(r => r.GetByIdAsync(nurseId)).ReturnsAsync((Nurse)null);

            // Act
            var result = await _nurseService.AddNurseToDepartmentAsync(Guid.NewGuid(), nurseId);

            // Assert
            Assert.IsFalse(result, "AddNurseToDepartmentAsync should return false when the nurse does not exist.");
            _nurseRepo.Verify(r => r.GetByIdAsync(nurseId), Times.Once);
            _nurseRepo.Verify(r => r.UpdateAsync(It.IsAny<Nurse>()), Times.Never);
        }

    }
}
