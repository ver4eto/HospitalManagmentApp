

using AutoMapper;
using HospitalManagment.Infrastructure.Repositories.Contracts;
using HospitalManagment.ViewModels.Doctor;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data;
using HospitalManagmentApp.Services.Data.Interfaces;
using HospitalManagmentApp.Services.Mapping;
using MockQueryable;
using Moq;

namespace HospitalManagmentApp.Tests
{
    [TestFixture]
    public class DoctorServiceTests
    {
        private Mock<IRepository<Doctor, Guid>> _doctorRepoMock;
        private Mock<IRepository<Department, Guid>> _departmentRepoMock;
        private Mock<IUserEntityService> _userEntityService;
        private IDoctorService _doctorService;

        private readonly List<Doctor> _doctorsData = new()
{
    new Doctor
    {
        Id = Guid.NewGuid(),
        FirstName = "John",
        LastName = "Doe",
        EmailAddress = "johndoe@example.com",
        DepartmentId = Guid.NewGuid(),
        Salary = 100000,
        IsDeleted = false
    },
    new Doctor
    {
        Id = Guid.NewGuid(),
        FirstName = "Jane",
        LastName = "Smith",
        EmailAddress = "janesmith@example.com",
        DepartmentId = Guid.NewGuid(),
        Salary = 120000,
        IsDeleted = false
    }
};


        [SetUp]
        public void SetUp()
        {
            _doctorRepoMock = new Mock<IRepository<Doctor, Guid>>();
            _departmentRepoMock = new Mock<IRepository<Department, Guid>>();
            _userEntityService = new Mock<IUserEntityService>();
           
            _doctorService = new DoctorService(_doctorRepoMock.Object, _departmentRepoMock.Object, _userEntityService.Object);



        }

        [Test]
        public async Task IndexGetAllDoctorsAsync_ReturnsDoctors_WhenDoctorsExist()
        {
            
            var mockDoctorsData = new List<Doctor>
        {
            new Doctor
            {
                Id = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Doe",
                Specialty = "Cardiology",
                IsDeleted = false,
                Department = new Department { Name = "Cardiology" }
            },
            new Doctor
            {
                Id = Guid.NewGuid(),
                FirstName = "Jane",
                LastName = "Smith",
                Specialty = "Neurology",
                IsDeleted = false,
                Department = new Department { Name = "Neurology" }
            }
        };

            var mockQueryable = mockDoctorsData.AsQueryable().BuildMock();

            _doctorRepoMock
                .Setup(r => r.GetAllAttcahed())
                .Returns(mockQueryable);

            var result = await _doctorService.IndexGetAllDoctorsAsync();

            Assert.IsNotNull(result, "The result should not be null.");
            Assert.AreEqual(2, result.Count(), "The number of doctors should match the mock data count.");
            Assert.IsTrue(result.Any(d => d.FirstName == "John" && d.LastName == "Doe" && d.Specialty == "Cardiology"),
                "Doctor 'John Doe' with 'Cardiology' specialty should be in the result.");
            Assert.IsTrue(result.Any(d => d.FirstName == "Jane" && d.LastName == "Smith" && d.Specialty == "Neurology"),
                "Doctor 'Jane Smith' with 'Neurology' specialty should be in the result.");
        }

        [Test]
        public async Task IndexGetAllDoctorsAsync_ThrowsNullReferenceException_WhenNoDoctorsExist()
        {
            var emptyDoctorsQueryable = new List<Doctor>().BuildMock();
            _doctorRepoMock.Setup(r => r.GetAllAttcahed()).Returns(emptyDoctorsQueryable);

            var exception = Assert.ThrowsAsync<NullReferenceException>(async () =>
                await _doctorService.IndexGetAllDoctorsAsync());

            Assert.AreEqual("No doctors available!", exception.Message, "Exception message should match.");
            _doctorRepoMock.Verify(r => r.GetAllAttcahed(), Times.Once, "GetAllAttcahed should be called once.");
        }

       
        [Test]
        public async Task MenageDoctor_ReturnsViewModel_WhenDoctorExistsAndIsNotDeleted()
        {
            var doctorId = Guid.NewGuid();
            var department = new Department
            {
                Id = Guid.NewGuid(),
                Name = "Cardiology"
            };

            var doctor = new Doctor
            {
                Id = doctorId,
                FirstName = "John",
                LastName = "Doe",
                Specialty = "Cardiologist",
                EmailAddress = "john.doe@example.com",
                Salary = 120000,
                Department = department,
                IsDeleted = false,
                UserId = Guid.NewGuid().ToString()
            };

            var doctorsMockQueryable = new List<Doctor> { doctor }.AsQueryable().BuildMock();
            _doctorRepoMock.Setup(r => r.GetAllAttcahed()).Returns(doctorsMockQueryable);

            var result = await _doctorService.MenageDoctor(doctorId);

            Assert.IsNotNull(result, "Result should not be null when doctor exists.");
            Assert.AreEqual(doctor.Id, result!.Id, "Doctor ID should match.");
            Assert.AreEqual(doctor.FirstName, result.FirstName, "Doctor first name should match.");
            Assert.AreEqual(doctor.LastName, result.LastName, "Doctor last name should match.");
            Assert.AreEqual(doctor.Specialty, result.Specialty, "Doctor specialty should match.");
            Assert.AreEqual(doctor.EmailAddress, result.EmailAddress, "Doctor email address should match.");
            Assert.AreEqual(doctor.Salary, result.Salary, "Doctor salary should match.");
            Assert.AreEqual(doctor.Department.Name, result.DepartmentName, "Department name should match.");
        }

        [Test]
        public async Task AddDoctorAsync_AddsDoctor_WhenValidModelIsProvided()
        {
            var doctorUserId = Guid.NewGuid().ToString();
            var doctorModel = new AddDoctorViewModel
            {
                FirstName = "John",
                LastName = "Doe",
                EmailAddress = "john.doe@example.com",
                Password = "SecurePassword123!",
                Salary = 100000,
                DepartmentId = Guid.NewGuid(),
                Specialty = "Cardiology"
            };

            _userEntityService
                .Setup(s => s.CreateApplicationUserAsync(doctorModel.EmailAddress, doctorModel.Password, "Doctor"))
                .ReturnsAsync(doctorUserId);

            _doctorRepoMock
                .Setup(r => r.AddAsync(It.IsAny<Doctor>()))
                .Returns(Task.CompletedTask);

            await _doctorService.AddDoctorAsync(doctorModel);

            _userEntityService.Verify(s => s.CreateApplicationUserAsync(doctorModel.EmailAddress, doctorModel.Password, "Doctor"), Times.Once);
            _doctorRepoMock.Verify(r => r.AddAsync(It.Is<Doctor>(d =>
                d.FirstName == doctorModel.FirstName &&
                d.LastName == doctorModel.LastName &&
                d.EmailAddress == doctorModel.EmailAddress &&
                d.Salary == doctorModel.Salary &&
                d.DepartmentId == doctorModel.DepartmentId &&
                d.UserId == doctorUserId &&
                d.Specialty == doctorModel.Specialty)), Times.Once);
        }

        [Test]
        public void AddDoctorAsync_ThrowsException_WhenUserCreationFails()
        {
            var doctorModel = new AddDoctorViewModel
            {
                FirstName = "John",
                LastName = "Doe",
                EmailAddress = "john.doe@example.com",
                Password = "SecurePassword123!",
                Salary = 100000,
                DepartmentId = Guid.NewGuid(),
                Specialty = "Cardiology"
            };

            _userEntityService
                .Setup(s => s.CreateApplicationUserAsync(doctorModel.EmailAddress, doctorModel.Password, "Doctor"))
                .ThrowsAsync(new Exception("User creation failed."));

            Assert.ThrowsAsync<Exception>(async () => await _doctorService.AddDoctorAsync(doctorModel));

            _doctorRepoMock.Verify(r => r.AddAsync(It.IsAny<Doctor>()), Times.Never);
        }

        [Test]
        public async Task DeleteDoctorAsync_ReturnsTrue_WhenDoctorExistsAndIsNotDeleted()
        {
           
            var doctorId = Guid.NewGuid();
            var doctor = new Doctor
            {
                Id = doctorId,
                IsDeleted = false
            };

            var doctorList = new List<Doctor> { doctor }.AsQueryable().BuildMock();
            _doctorRepoMock.Setup(r => r.GetAllAttcahed()).Returns(doctorList);
            _doctorRepoMock.Setup(r => r.UpdateAsync(It.IsAny<Doctor>())).Returns(Task.FromResult(true));

            var deleteDoctorViewModel = new DeleteDoctorViewModel();

            var result = await _doctorService.DeleteDoctorAsync(deleteDoctorViewModel, doctorId);

            Assert.IsTrue(result, "DeleteDoctorAsync should return true when the doctor exists and is not already deleted.");
            _doctorRepoMock.Verify(r => r.UpdateAsync(It.Is<Doctor>(d => d.Id == doctorId && d.IsDeleted)), Times.Once);
        }

        [Test]
        public async Task DeleteDoctorAsync_ReturnsFalse_WhenDoctorDoesNotExist()
        {
            var doctorId = Guid.NewGuid();
            var doctorList = new List<Doctor>().AsQueryable().BuildMock();
            _doctorRepoMock.Setup(r => r.GetAllAttcahed()).Returns(doctorList);

            var deleteDoctorViewModel = new DeleteDoctorViewModel();

            var result = await _doctorService.DeleteDoctorAsync(deleteDoctorViewModel, doctorId);

            Assert.IsFalse(result, "DeleteDoctorAsync should return false when the doctor does not exist.");
            _doctorRepoMock.Verify(r => r.UpdateAsync(It.IsAny<Doctor>()), Times.Never);
        }

        [Test]
        public async Task DeleteDoctorAsync_ReturnsFalse_WhenDoctorIsAlreadyDeleted()
        {
            var doctorId = Guid.NewGuid();
            var doctor = new Doctor
            {
                Id = doctorId,
                IsDeleted = true
            };

            var doctorList = new List<Doctor> { doctor }.AsQueryable().BuildMock();
            _doctorRepoMock.Setup(r => r.GetAllAttcahed()).Returns(doctorList);

            var deleteDoctorViewModel = new DeleteDoctorViewModel();

            var result = await _doctorService.DeleteDoctorAsync(deleteDoctorViewModel, doctorId);

            Assert.IsFalse(result, "DeleteDoctorAsync should return false when the doctor is already deleted.");
            _doctorRepoMock.Verify(r => r.UpdateAsync(It.IsAny<Doctor>()), Times.Never);
        }

        [Test]
        public async Task GetAddDoctorToDepartmentAsync_ReturnsTrue_WhenDoctorAndDepartmentExist()
        {
            var departmentId = Guid.NewGuid();
            var doctorId = Guid.NewGuid();

            var department = new Department { Id = departmentId, Name = "Cardiology" };
            var doctor = new Doctor { Id = doctorId, FirstName = "John", LastName = "Doe" };

            var model = new AddDoctorToDepartmentViewModel
            {
                SelectedDoctorId = doctorId
            };

            _departmentRepoMock.Setup(r => r.GetByIdAsync(departmentId)).ReturnsAsync(department);
            _doctorRepoMock.Setup(r => r.GetByIdAsync(doctorId)).ReturnsAsync(doctor);
            _doctorRepoMock.Setup(r => r.UpdateAsync(It.IsAny<Doctor>())).Returns(Task.FromResult(true));

            var result = await _doctorService.GetAddDoctorToDepartmentAsync(model, departmentId);

            Assert.IsTrue(result, "Expected the method to return true when doctor and department exist.");
            Assert.AreEqual(departmentId, doctor.DepartmentId, "Doctor's department ID should be updated.");
            _departmentRepoMock.Verify(r => r.GetByIdAsync(departmentId), Times.Once);
            _doctorRepoMock.Verify(r => r.GetByIdAsync(doctorId), Times.Once);
            _doctorRepoMock.Verify(r => r.UpdateAsync(It.Is<Doctor>(d => d.Id == doctorId && d.DepartmentId == departmentId)), Times.Once);
        }

        [Test]
        public async Task GetAddDoctorToDepartmentAsync_ReturnsFalse_WhenDepartmentDoesNotExist()
        {
            var departmentId = Guid.NewGuid();
            var model = new AddDoctorToDepartmentViewModel { SelectedDoctorId = Guid.NewGuid() };

            _departmentRepoMock.Setup(r => r.GetByIdAsync(departmentId)).ReturnsAsync((Department)null);

            var result = await _doctorService.GetAddDoctorToDepartmentAsync(model, departmentId);

            Assert.IsFalse(result, "Expected the method to return false when department does not exist.");
            _departmentRepoMock.Verify(r => r.GetByIdAsync(departmentId), Times.Once);
            _doctorRepoMock.Verify(r => r.GetByIdAsync(It.IsAny<Guid>()), Times.Never);
            _doctorRepoMock.Verify(r => r.UpdateAsync(It.IsAny<Doctor>()), Times.Never);
        }

        [Test]
        public async Task GetAddDoctorToDepartmentAsync_ReturnsFalse_WhenDoctorDoesNotExist()
        {
            var departmentId = Guid.NewGuid();
            var doctorId = Guid.NewGuid();

            var department = new Department { Id = departmentId, Name = "Cardiology" };
            var model = new AddDoctorToDepartmentViewModel { SelectedDoctorId = doctorId };

            _departmentRepoMock.Setup(r => r.GetByIdAsync(departmentId)).ReturnsAsync(department);
            _doctorRepoMock.Setup(r => r.GetByIdAsync(doctorId)).ReturnsAsync((Doctor)null);

            var result = await _doctorService.GetAddDoctorToDepartmentAsync(model, departmentId);

            Assert.IsFalse(result, "Expected the method to return false when doctor does not exist.");
            _departmentRepoMock.Verify(r => r.GetByIdAsync(departmentId), Times.Once);
            _doctorRepoMock.Verify(r => r.GetByIdAsync(doctorId), Times.Once);
            _doctorRepoMock.Verify(r => r.UpdateAsync(It.IsAny<Doctor>()), Times.Never);
        }

        [Test]
        public async Task GetAddDoctorToDepartmentViewModel_ReturnsViewModel_WhenDepartmentExists()
        {
            var departmentId = Guid.NewGuid();
            var department = new Department
            {
                Id = departmentId,
                Name = "Cardiology"
            };

            var doctors = new List<Doctor>
        {
            new Doctor { Id = Guid.NewGuid(), FirstName = "John", LastName = "Doe", DepartmentId = Guid.NewGuid(), IsDeleted = false },
            new Doctor { Id = Guid.NewGuid(), FirstName = "Jane", LastName = "Smith", DepartmentId = Guid.NewGuid(), IsDeleted = false }
        };

            _departmentRepoMock.Setup(r => r.GetByIdAsync(departmentId)).ReturnsAsync(department);
            _doctorRepoMock.Setup(r => r.GetAllAttcahed()).Returns(doctors.AsQueryable().BuildMock());

            var result = await _doctorService.GetAddDoctorToDepartmentViewModel(departmentId);

            Assert.IsNotNull(result, "The result should not be null when the department exists.");
            Assert.AreEqual(departmentId, result.DepartmentId, "The department ID should match.");
            Assert.AreEqual("Cardiology", result.DepartmentName, "The department name should match.");
            Assert.AreEqual(2, result.Doctors.Count, "The number of doctors should match the mock data count.");
        }

        [Test]
        public void GetAddDoctorToDepartmentViewModel_ThrowsArgumentException_WhenDepartmentDoesNotExist()
        {
            var departmentId = Guid.NewGuid();
            _departmentRepoMock.Setup(r => r.GetByIdAsync(departmentId)).ReturnsAsync((Department)null);

            var exception = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _doctorService.GetAddDoctorToDepartmentViewModel(departmentId));

            Assert.AreEqual("Department not found", exception.Message);
        }

        [Test]
        public async Task GetAddDoctorToDepartmentViewModel_ReturnsEmptyDoctors_WhenNoDoctorsAvailable()
        {
            var departmentId = Guid.NewGuid();
            var department = new Department
            {
                Id = departmentId,
                Name = "Neurology"
            };

            _departmentRepoMock.Setup(r => r.GetByIdAsync(departmentId)).ReturnsAsync(department);
            _doctorRepoMock.Setup(r => r.GetAllAttcahed()).Returns(new List<Doctor>().AsQueryable().BuildMock());

            var result = await _doctorService.GetAddDoctorToDepartmentViewModel(departmentId);

            Assert.IsNotNull(result, "The result should not be null.");
            Assert.AreEqual(0, result.Doctors.Count, "The doctors list should be empty when no doctors are available.");
        }

        [Test]
        public async Task GetDeleteDoctorViewModel_ReturnsModel_WhenDoctorExists()
        {
            var doctorId = Guid.NewGuid();
            var department = new Department { Id = Guid.NewGuid(), Name = "Neurology" };
            var doctor = new Doctor
            {
                Id = doctorId,
                FirstName = "John",
                LastName = "Doe",
                Specialty = "Cardiology",
                IsDeleted = false,
                Department = department
            };

            var doctorsMockQueryable = new List<Doctor> { doctor }.AsQueryable().BuildMock();
            _doctorRepoMock.Setup(r => r.GetAllAttcahed()).Returns(doctorsMockQueryable);

            var result = await _doctorService.GetDeleteDoctorViewModel(doctorId);

            Assert.IsNotNull(result, "The result should not be null for an existing doctor.");
            Assert.AreEqual(doctorId, result.Id, "The doctor ID should match.");
            Assert.AreEqual("John", result.FirstName, "The doctor's first name should match.");
            Assert.AreEqual("Doe", result.LastName, "The doctor's last name should match.");
            Assert.AreEqual("Cardiology", result.Specialty, "The doctor's specialty should match.");
        }

        [Test]
        public async Task GetDeleteDoctorViewModel_ReturnsNull_WhenDoctorDoesNotExist()
        {
            var doctorId = Guid.NewGuid();

            var doctorsMockQueryable = new List<Doctor>().AsQueryable().BuildMock();
            _doctorRepoMock.Setup(r => r.GetAllAttcahed()).Returns(doctorsMockQueryable);

            var result = await _doctorService.GetDeleteDoctorViewModel(doctorId);

            Assert.IsNull(result, "The result should be null when the doctor does not exist.");
        }

        [Test]
        public async Task GetDeleteDoctorViewModel_ReturnsNull_WhenDoctorIsDeleted()
        {
            var doctorId = Guid.NewGuid();
            var doctor = new Doctor
            {
                Id = doctorId,
                IsDeleted = true
            };

            var doctorsMockQueryable = new List<Doctor> { doctor }.AsQueryable().BuildMock();
            _doctorRepoMock.Setup(r => r.GetAllAttcahed()).Returns(doctorsMockQueryable);

            var result = await _doctorService.GetDeleteDoctorViewModel(doctorId);

            Assert.IsNull(result, "The result should be null when the doctor is deleted.");
        }

        [Test]
        public async Task GetEditDoctorViewModel_ReturnsViewModel_WhenDoctorExists()
        {
            var doctorId = Guid.NewGuid();
            var departmentId = Guid.NewGuid();

            var department = new Department
            {
                Id = departmentId,
                Name = "Neurology"
            };

            var doctor = new Doctor
            {
                Id = doctorId,
                FirstName = "John",
                LastName = "Doe",
                Specialty = "Cardiology",
                EmailAddress = "john.doe@example.com",
                Salary = 90000,
                IsDeleted = false,
                Department = department,
                DepartmentId = departmentId
            };

            var departments = new List<Department>
    {
        department,
        new Department { Id = Guid.NewGuid(), Name = "Surgery" }
    };

            var doctorQueryable = new List<Doctor> { doctor }.AsQueryable().BuildMock();
            var departmentQueryable = departments.AsQueryable().BuildMock();

            _doctorRepoMock.Setup(r => r.GetAllAttcahed()).Returns(doctorQueryable);
            _departmentRepoMock.Setup(r => r.GetAllAttcahed()).Returns(departmentQueryable);

            var result = await _doctorService.GetEditDoctorViewModel(doctorId);

            Assert.IsNotNull(result, "The result should not be null when the doctor exists.");
            Assert.AreEqual(doctorId, result.Id, "The doctor ID should match.");
            Assert.AreEqual("John", result.FirstName, "The doctor's first name should match.");
            Assert.AreEqual("Doe", result.LastName, "The doctor's last name should match.");
            Assert.AreEqual("Cardiology", result.Specialty, "The doctor's specialty should match.");
            
        }

        [Test]
        public async Task GetEditDoctorViewModel_ReturnsNull_WhenDoctorDoesNotExist()
        {
            var doctorId = Guid.NewGuid();
            var doctorQueryable = new List<Doctor>().AsQueryable().BuildMock();

            _doctorRepoMock.Setup(r => r.GetAllAttcahed()).Returns(doctorQueryable);

            var result = await _doctorService.GetEditDoctorViewModel(doctorId);

            Assert.IsNull(result, "The result should be null when the doctor does not exist.");
        }

        [Test]
        public async Task GetEditDoctorViewModel_ReturnsNull_WhenDoctorIsDeleted()
        {
            var doctorId = Guid.NewGuid();
            var doctor = new Doctor
            {
                Id = doctorId,
                IsDeleted = true
            };

            var doctorQueryable = new List<Doctor> { doctor }.AsQueryable().BuildMock();
            _doctorRepoMock.Setup(r => r.GetAllAttcahed()).Returns(doctorQueryable);

            var result = await _doctorService.GetEditDoctorViewModel(doctorId);

            Assert.IsNull(result, "The result should be null when the doctor is deleted.");
        }

        [Test]
        public async Task EditDoctorAsync_ReturnsTrue_WhenDoctorIsSuccessfullyEdited()
        {
            var doctorId = Guid.NewGuid();
            var departmentId = Guid.NewGuid();

            var existingDoctor = new Doctor
            {
                Id = doctorId,
                FirstName = "John",
                LastName = "Doe",
                Specialty = "Cardiology",
                EmailAddress = "john.doe@example.com",
                Salary = 90000,
                DepartmentId = departmentId,
                IsDeleted = false
            };

            var model = new EditDoctorViewModel
            {
                Id = doctorId,
                FirstName = "Jane",
                LastName = "Smith",
                Specialty = "Neurology",
                EmailAddress = "jane.smith@example.com",
                Salary = 100000,
                DepartmentId = departmentId
            };

            _doctorRepoMock.Setup(r => r.GetByIdAsync(doctorId))
                .ReturnsAsync(existingDoctor);

            _doctorRepoMock.Setup(r => r.UpdateAsync(It.IsAny<Doctor>())).ReturnsAsync(true);

            var result = await _doctorService.EditDoctorAsync(model);

            Assert.IsTrue(result, "EditDoctorAsync should return true when the doctor is successfully edited.");
            _doctorRepoMock.Verify(r => r.UpdateAsync(It.Is<Doctor>(d =>
                d.Id == model.Id &&
                d.FirstName == model.FirstName &&
                d.LastName == model.LastName &&
                d.Specialty == model.Specialty &&
                d.EmailAddress == model.EmailAddress &&
                d.Salary == model.Salary &&
                d.DepartmentId == model.DepartmentId
            )), Times.Once, "UpdateAsync should be called once with the correct doctor.");
        }

        [Test]
        public async Task EditDoctorAsync_ReturnsFalse_WhenDoctorIsNull()
        {
            var doctorId = Guid.NewGuid();
            var model = new EditDoctorViewModel
            {
                Id = doctorId,
                FirstName = "Jane",
                LastName = "Smith",
                Specialty = "Neurology",
                EmailAddress = "jane.smith@example.com",
                Salary = 100000,
                DepartmentId = Guid.NewGuid()
            };

            _doctorRepoMock.Setup(r => r.GetByIdAsync(doctorId)).ReturnsAsync((Doctor)null);

            var result = await _doctorService.EditDoctorAsync(model);

            Assert.IsFalse(result, "EditDoctorAsync should return false when the doctor does not exist.");
            _doctorRepoMock.Verify(r => r.GetByIdAsync(doctorId), Times.Once, "GetByIdAsync should be called once with the correct doctor ID.");
            _doctorRepoMock.Verify(r => r.UpdateAsync(It.IsAny<Doctor>()), Times.Never, "UpdateAsync should not be called when the doctor is null.");
        }

        [Test]
        public async Task EditDoctorAsync_ReturnsFalse_WhenUpdateFails()
        {
            var doctorId = Guid.NewGuid();
            var departmentId = Guid.NewGuid();

            var existingDoctor = new Doctor
            {
                Id = doctorId,
                FirstName = "John",
                LastName = "Doe",
                Specialty = "Cardiology",
                EmailAddress = "john.doe@example.com",
                Salary = 90000,
                DepartmentId = departmentId,
                IsDeleted = false
            };

            var model = new EditDoctorViewModel
            {
                Id = doctorId,
                FirstName = "Jane",
                LastName = "Smith",
                Specialty = "Neurology",
                EmailAddress = "jane.smith@example.com",
                Salary = 100000,
                DepartmentId = departmentId
            };

            _doctorRepoMock.Setup(r => r.GetByIdAsync(doctorId))
                .ReturnsAsync(existingDoctor);

            _doctorRepoMock.Setup(r => r.UpdateAsync(It.IsAny<Doctor>())).ReturnsAsync(false);

            var result = await _doctorService.EditDoctorAsync(model);

            Assert.IsFalse(result, "EditDoctorAsync should return false when the update fails.");
            _doctorRepoMock.Verify(r => r.GetByIdAsync(doctorId), Times.Once, "GetByIdAsync should be called once with the correct doctor ID.");
            _doctorRepoMock.Verify(r => r.UpdateAsync(It.Is<Doctor>(d =>
                d.Id == model.Id &&
                d.FirstName == model.FirstName &&
                d.LastName == model.LastName &&
                d.Specialty == model.Specialty &&
                d.EmailAddress == model.EmailAddress &&
                d.Salary == model.Salary &&
                d.DepartmentId == model.DepartmentId
            )), Times.Once, "UpdateAsync should be called once with the updated doctor.");
        }


    }
}
