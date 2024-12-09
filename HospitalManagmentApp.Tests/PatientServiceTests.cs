using HospitalManagment.Infrastructure.Repositories.Contracts;
using HospitalManagment.ViewModels.Patient;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data;
using HospitalManagmentApp.Services.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using MockQueryable;
using Moq;
using System.Linq.Expressions;
using System.Security.Claims;

namespace HospitalManagmentApp.Tests
{
    [TestFixture]
    public class PatientServiceTests
    {
        private Mock<IRepository<Patient, Guid>> _patientRepoMock;
        private Mock<IRepository<Department, Guid>> _departmentRepoMock;
        private Mock<IRepository<Room, Guid>> _roomRepoMock;
        private Mock<IRepository<PatientTreatment, object>> _patiientTreatmentRepoMock;
        private Mock<IUserEntityService> _userEntityMock;
        private Mock<IRepository<Doctor, Guid>> _doctorRepoMock;
        private Mock<IRepository<PatientDoctor, object>> _patientDoctorRepoMock;
        private Mock<IRepository<Treatment, Guid>> _treatmentRepoMock;
        private Mock<IHttpContextAccessor> _httpContextAccessorMock;
        private PatientService _patientService;


        [SetUp]
        public void SetUp()
        {
            _patientRepoMock = new Mock<IRepository<Patient, Guid>>();
            _departmentRepoMock = new Mock<IRepository<Department, Guid>>();
            _patiientTreatmentRepoMock = new Mock<IRepository<PatientTreatment, object>>();
            _roomRepoMock = new Mock<IRepository<Room, Guid>>();
            _userEntityMock = new Mock<IUserEntityService>();
            _doctorRepoMock = new Mock<IRepository<Doctor, Guid>>();
            _patientDoctorRepoMock = new Mock<IRepository<PatientDoctor, object>>();
            _httpContextAccessorMock = new Mock<IHttpContextAccessor>();
            _treatmentRepoMock = new Mock<IRepository<Treatment, Guid>>();


            _patientService = new PatientService(
            _patientRepoMock.Object,
            _departmentRepoMock.Object,
            _roomRepoMock.Object,
            _userEntityMock.Object,
            _httpContextAccessorMock.Object,
            _patientDoctorRepoMock.Object,
            _doctorRepoMock.Object,
            _treatmentRepoMock.Object,
            _patiientTreatmentRepoMock.Object
        );

                   }

        [Test]
        public async Task GetAllPatientsAsync_ReturnsPatients_WhenPatientsExist()
        {
            var patientData = new List<Patient>
        {
            new Patient
            {
                Id = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Doe",
                EGN = "1234567890",
                PhoneNumber = "123-456-7890",
                Address = "123 Main St",
                Department = new Department { Name = "Neurology" },
                Room = new Room { RoomNumber = 101 },
                HasMedicalInsurance = true,
                EmailAddress = "john.doe@example.com",
                IsDeleted = false
            },
            new Patient
            {
                Id = Guid.NewGuid(),
                FirstName = "Jane",
                LastName = "Smith",
                EGN = "9876543210",
                PhoneNumber = "987-654-3210",
                Address = "456 Elm St",
                Department = new Department { Name = "Cardiology" },
                Room = new Room { RoomNumber = 202 },
                HasMedicalInsurance = false,
                EmailAddress = "jane.smith@example.com",
                IsDeleted = false
            }
        };

            var patientsMockQueryable = patientData.AsQueryable().BuildMock();
            _patientRepoMock.Setup(r => r.GetAllAttcahed()).Returns(patientsMockQueryable);

            var result = await _patientService.GetAllPatientsAsync();

            Assert.IsNotNull(result, "Result should not be null.");
            Assert.AreEqual(2, result.Count, "The number of patients should match the mock data count.");
            Assert.IsTrue(result.Any(p => p.Name == "John Doe"), "Patient 'John Doe' should be in the result.");
            Assert.IsTrue(result.Any(p => p.Name == "Jane Smith"), "Patient 'Jane Smith' should be in the result.");
        }

        [Test]
        public async Task GetAllPatientsAsync_ReturnsEmptyList_WhenNoPatientsExist()
        {
            var emptyPatientsMockQueryable = new List<Patient>().AsQueryable().BuildMock();
            _patientRepoMock.Setup(r => r.GetAllAttcahed()).Returns(emptyPatientsMockQueryable);

            var result = await _patientService.GetAllPatientsAsync();

            Assert.IsNotNull(result, "Result should not be null.");
            Assert.IsEmpty(result, "Result should be an empty list when no patients exist.");
        }

        [Test]
        public async Task GetAllPatientsAsync_HandlesNullsInDependencies()
        {
            var patientData = new List<Patient>
    {
        new Patient
        {
            Id = Guid.NewGuid(),
            FirstName = "John",
            LastName = "Doe",
            EGN = "1234567890",
            PhoneNumber = "123-456-7890",
            Address = "123 Main St",
            Department = null, 
            Room = null,       
            HasMedicalInsurance = true,
            EmailAddress = "john.doe@example.com",
            IsDeleted = false
        }
    };

            var patientsMockQueryable = patientData.AsQueryable().BuildMock();
            _patientRepoMock.Setup(r => r.GetAllAttcahed()).Returns(patientsMockQueryable);

            var result = await _patientService.GetAllPatientsAsync();

            Assert.IsNotNull(result, "Result should not be null.");
            Assert.AreEqual(1, result.Count, "The number of patients should match the mock data count.");
            Assert.AreEqual("Unknown", result.First().Department, "Department should be 'Unknown' when null.");
            Assert.AreEqual(0, result.First().Room, "Room should be 0 when null.");
        }

        [Test]
        public async Task GetDischargePatientViewModel_ReturnsViewModel_WhenPatientExists()
        {
            var patientId = Guid.NewGuid();
            var patient = new Patient
            {
                Id = patientId,
                FirstName = "John",
                LastName = "Doe"
            };

            _patientRepoMock
                .Setup(repo => repo.GetByIdAsync(patientId))
                .ReturnsAsync(patient);

            var result = await _patientService.GetDischargePatientViewModel(patientId);

            Assert.IsNotNull(result, "The result should not be null when the patient exists.");
            Assert.AreEqual(patientId, result.Id, "The patient ID should match.");
            Assert.AreEqual("John Doe", result.Name, "The patient's name should match.");
        }

        [Test]
        public async Task GetDischargePatientViewModel_ReturnsNull_WhenPatientDoesNotExist()
        {
            var patientId = Guid.NewGuid();

            _patientRepoMock
                .Setup(repo => repo.GetByIdAsync(patientId))
                .ReturnsAsync((Patient)null);

            var result = await _patientService.GetDischargePatientViewModel(patientId);

            Assert.IsNull(result, "The result should be null when the patient does not exist.");
        }

        [Test]
        public async Task DischargePatientAsync_ReturnsTrue_WhenPatientIsSuccessfullyDischarged()
        {
            
            var patientId = Guid.NewGuid();
            var patient = new Patient
            {
                Id = patientId,
                FirstName = "John",
                LastName = "Doe",
                IsDeleted = false
            };

            _patientRepoMock
                .Setup(repo => repo.GetAllAttcahed())
                .Returns(new List<Patient> { patient }.AsQueryable().BuildMock());

            _patientRepoMock
                .Setup(repo => repo.UpdateAsync(It.IsAny<Patient>()))
                .Returns(Task.FromResult(true));

            var dischargeModel = new DischargePatientViewModel
            {
                Id = patientId,
                Name = $"{patient.FirstName} {patient.LastName}"
            };

            var result = await _patientService.DischargePatientAsync(dischargeModel, patientId);

            Assert.IsTrue(result, "DischargePatientAsync should return true when the patient is successfully discharged.");
            Assert.IsTrue(patient.IsDeleted, "The patient's IsDeleted property should be set to true.");
            _patientRepoMock.Verify(repo => repo.UpdateAsync(It.Is<Patient>(p => p.Id == patientId && p.IsDeleted)), Times.Once);
        }

        [Test]
        public async Task DischargePatientAsync_ReturnsFalse_WhenPatientDoesNotExist()
        {
          
            var patientId = Guid.NewGuid();

            _patientRepoMock
                .Setup(repo => repo.GetAllAttcahed())
                .Returns(new List<Patient>().AsQueryable().BuildMock());

            var dischargeModel = new DischargePatientViewModel
            {
                Id = patientId,
                Name = "Non-existent Patient"
            };

            var result = await _patientService.DischargePatientAsync(dischargeModel, patientId);

            Assert.IsFalse(result, "DischargePatientAsync should return false when the patient does not exist.");
            _patientRepoMock.Verify(repo => repo.UpdateAsync(It.IsAny<Patient>()), Times.Never, "UpdateAsync should not be called when the patient does not exist.");
        }

        [Test]
        public async Task GetMovePatientModelAsync_ReturnsViewModel_WhenPatientExists()
        {
            var patientId = Guid.NewGuid();
            var departmentId = Guid.NewGuid();
            var roomId = Guid.NewGuid();

            var patient = new Patient
            {
                Id = patientId,
                FirstName = "John",
                LastName = "Doe",
                EGN = "1234567890",
                IsDeleted = false,
                Room = new Room { Id = roomId, RoomNumber = 101 },
                Department = new Department { Id = departmentId, Name = "Cardiology" }
            };

            var departments = new List<Department>
        {
            new Department { Id = departmentId, Name = "Cardiology" },
            new Department { Id = Guid.NewGuid(), Name = "Neurology" }
        };

            _patientRepoMock
                .Setup(repo => repo.GetAllAttcahed())
                .Returns(new List<Patient> { patient }.AsQueryable().BuildMock());

            _departmentRepoMock
                .Setup(repo => repo.GetAllAsync())
                .ReturnsAsync(departments);

            var result = await _patientService.GetMovePatientModelAsync(patientId);

            Assert.IsNotNull(result, "The result should not be null when the patient exists.");
            Assert.AreEqual(patientId, result.PatientId, "The patient ID should match.");
            Assert.AreEqual("John Doe", result.Name, "The patient name should match.");
            Assert.AreEqual("1234567890", result.EGN, "The EGN should match.");
            Assert.AreEqual(101, result.CurrentRoom, "The room number should match.");
            Assert.AreEqual("Cardiology", result.CurrentDepartment, "The department name should match.");
            Assert.AreEqual(2, result.Departments.Count(), "The number of departments should match.");
        }

        [Test]
        public async Task GetMovePatientModelAsync_ReturnsNull_WhenPatientDoesNotExist()
        {
            var patientId = Guid.NewGuid();

            _patientRepoMock
                .Setup(repo => repo.GetAllAttcahed())
                .Returns(new List<Patient>().AsQueryable().BuildMock());

            var result = await _patientService.GetMovePatientModelAsync(patientId);

            Assert.IsNull(result, "The result should be null when the patient does not exist.");
        }

        [Test]
        public async Task MovePatientAsync_ReturnsTrue_WhenPatientExistsAndIsMoved()
        {
            var patientId = Guid.NewGuid();
            var newDepartmentId = Guid.NewGuid();
            var newRoomId = Guid.NewGuid();

            var patient = new Patient
            {
                Id = patientId,
                DepartmentId = Guid.NewGuid(),
                RoomId = Guid.NewGuid(),
                IsDeleted = false
            };

            var model = new MovePatientToDepartmentViewModel
            {
                PatientId = patientId,
                NewDepartmentId = newDepartmentId,
                NewRoomId = newRoomId
            };

            _patientRepoMock
                .Setup(repo => repo.GetByIdAsync(patientId))
                .ReturnsAsync(patient);

            _patientRepoMock
                .Setup(repo => repo.UpdateAsync(It.IsAny<Patient>()))
                .Returns(Task.FromResult(true));

            var result = await _patientService.MovePatientAsync(model);

            Assert.IsTrue(result, "MovePatientAsync should return true when the patient is successfully moved.");
            Assert.AreEqual(newDepartmentId, patient.DepartmentId, "The patient's department ID should be updated.");
            Assert.AreEqual(newRoomId, patient.RoomId, "The patient's room ID should be updated.");
            _patientRepoMock.Verify(repo => repo.UpdateAsync(patient), Times.Once, "UpdateAsync should be called once.");
        }

        [Test]
        public async Task MovePatientAsync_ReturnsFalse_WhenPatientDoesNotExist()
        {
            var patientId = Guid.NewGuid();
            var model = new MovePatientToDepartmentViewModel
            {
                PatientId = patientId,
                NewDepartmentId = Guid.NewGuid(),
                NewRoomId = Guid.NewGuid()
            };

            _patientRepoMock
                .Setup(repo => repo.GetByIdAsync(patientId))
                .ReturnsAsync((Patient)null); // Simulate no patient found.

            var result = await _patientService.MovePatientAsync(model);

            Assert.IsFalse(result, "MovePatientAsync should return false when the patient does not exist.");
            _patientRepoMock.Verify(repo => repo.UpdateAsync(It.IsAny<Patient>()), Times.Never, "UpdateAsync should not be called when the patient does not exist.");
        }
        [Test]
        public async Task Menage_ReturnsPatients_WhenPatientsExist()
        {
            var patients = new List<Patient>
        {
            new Patient
            {
                Id = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Doe",
                EGN = "1234567890",
                PhoneNumber = "555-1234",
                Address = "123 Main St",
                IsDeleted = false,
                Department = new Department { Name = "Cardiology" },
                Room = new Room { RoomNumber = 101 },
                HasMedicalInsurance = true,
                EmailAddress = "john.doe@example.com"
            },
            new Patient
            {
                Id = Guid.NewGuid(),
                FirstName = "Jane",
                LastName = "Smith",
                EGN = "0987654321",
                PhoneNumber = "555-5678",
                Address = "456 Elm St",
                IsDeleted = false,
                Department = new Department { Name = "Neurology" },
                Room = new Room { RoomNumber = 102 },
                HasMedicalInsurance = false,
                EmailAddress = "jane.smith@example.com"
            }
        };

            _patientRepoMock
                .Setup(repo => repo.GetAllAttcahed())
                .Returns(patients.AsQueryable().BuildMock());

            var result = await _patientService.Menage();

            Assert.IsNotNull(result, "Result should not be null.");
            Assert.AreEqual(2, result.Count, "The number of patients should match the mock data count.");
            Assert.IsTrue(result.Any(p => p.Name == "John Doe"), "Patient 'John Doe' should be in the result.");
            Assert.IsTrue(result.Any(p => p.Name == "Jane Smith"), "Patient 'Jane Smith' should be in the result.");
        }

        [Test]
        public async Task Menage_ReturnsEmptyList_WhenNoPatientsExist()
        {
            
            _patientRepoMock
                .Setup(repo => repo.GetAllAttcahed())
                .Returns(Enumerable.Empty<Patient>().AsQueryable().BuildMock());

            var result = await _patientService.Menage();

            Assert.IsNotNull(result, "Result should not be null.");
            Assert.IsEmpty(result, "Result should be an empty list when no patients exist.");
        }

        [Test]
        public async Task Menage_HandlesNullDependenciesGracefully()
        {
            var patients = new List<Patient>
    {
        new Patient
        {
            Id = Guid.NewGuid(),
            FirstName = "John",
            LastName = "Doe",
            EGN = "1234567890",
            PhoneNumber = "555-1234",
            Address = "123 Main St",
            IsDeleted = false,
            Department = null, // Null dependency
            Room = null,       // Null dependency
            HasMedicalInsurance = true,
            EmailAddress = "john.doe@example.com"
        }
    };

            _patientRepoMock
                .Setup(repo => repo.GetAllAttcahed())
                .Returns(patients.AsQueryable().BuildMock());

            var result = await _patientService.Menage();

            Assert.IsNotNull(result, "Result should not be null.");
            Assert.AreEqual(1, result.Count, "The number of patients should match the mock data count.");
            Assert.AreEqual("N/A", result.First().Department, "Department should be 'N/A' when not available.");
            Assert.AreEqual(0, result.First().Room, "Room should be 0 when not available.");
        }

        [Test]
        public async Task SeePatientMedicalInfo_ReturnsModel_WhenPatientExists()
        {
            var patientId = Guid.NewGuid();
            var patient = new Patient
            {
                Id = patientId,
                FirstName = "John",
                LastName = "Doe",
                Department = new Department { Name = "Neurology" },
                PatientTreatments = new List<PatientTreatment>
            {
                new PatientTreatment
                {
                    PatientId = patientId,
                    Treatment = new Treatment { Name = "Physical Therapy" }
                }
            }
            };

            _patientRepoMock.Setup(r => r.GetAllAttcahed())
                .Returns(new List<Patient> { patient }.AsQueryable().BuildMock());

            var result = await _patientService.SeePatientMedicalInfo(patientId);

            Assert.IsNotNull(result, "The result should not be null for an existing patient.");
            Assert.AreEqual(patientId, result.PatientId, "The patient ID should match.");
            Assert.AreEqual("John", result.FirstName, "The patient's first name should match.");
            Assert.AreEqual("Neurology", result.DepartmentName, "The department name should match.");
            Assert.Contains("Physical Therapy", result.Treatments, "The treatment list should contain the correct treatments.");
        }

        [Test]
        public async Task SeePatientMedicalInfo_ReturnsNull_WhenPatientDoesNotExist()
        {
            var patientId = Guid.NewGuid();
            _patientRepoMock.Setup(r => r.GetAllAttcahed())
                .Returns(new List<Patient>().AsQueryable().BuildMock());

            var result = await _patientService.SeePatientMedicalInfo(patientId);

            Assert.AreEqual(result.LastName, null);
            Assert.AreEqual(result.FirstName, null);
            Assert.AreEqual(result.DepartmentName, null);
            
        }

        [Test]
        public async Task SeePatientMedicalInfo_ReturnsDefaultTreatmentMessage_WhenNoTreatmentsExist()
        {
            var patientId = Guid.NewGuid();
            var patient = new Patient
            {
                Id = patientId,
                FirstName = "John",
                LastName = "Doe",
                Department = new Department { Name = "Neurology" },
                PatientTreatments = new List<PatientTreatment>() // No treatments
            };

            _patientRepoMock.Setup(r => r.GetAllAttcahed())
                .Returns(new List<Patient> { patient }.AsQueryable().BuildMock());

            var result = await _patientService.SeePatientMedicalInfo(patientId);

            Assert.IsNotNull(result, "The result should not be null for an existing patient.");
            Assert.AreEqual(patientId, result.PatientId, "The patient ID should match.");
            Assert.AreEqual("No treatments available", result.Treatments.First(), "The default message should be returned when no treatments exist.");
        }

        [Test]
        public async Task GetAddTreatmentToPatientViewModel_ReturnsViewModel_WhenPatientExists()
        {
            var patientId = Guid.NewGuid();

            var patient = new Patient
            {
                Id = patientId,
                FirstName = "John",
                LastName = "Doe",
                Department = new Department
                {
                    Name = "Cardiology"
                },
                PatientTreatments = new List<PatientTreatment>
        {
            new PatientTreatment
            {
                Treatment = new Treatment
                {
                    Id = Guid.NewGuid(),
                    Name = "Treatment A"
                }
            }
        }
            };

            var treatments = new List<Treatment>
    {
        new Treatment
        {
            Id = Guid.NewGuid(),
            Name = "Treatment B"
        },
        new Treatment
        {
            Id = Guid.NewGuid(),
            Name = "Treatment C"
        }
    };

            var patientRepoMock = new Mock<IRepository<Patient, Guid>>();
            patientRepoMock.Setup(r => r.GetAllAttcahed())
                           .Returns(new List<Patient> { patient }.AsQueryable().BuildMock());

            var treatmentRepoMock = new Mock<IRepository<Treatment, Guid>>();
            treatmentRepoMock.Setup(r => r.GetAllAsync())
                             .ReturnsAsync(treatments.AsQueryable());

            var service = new PatientService(
                patientRepoMock.Object,
                null,
                null,
                null,
                null,
                null,
                null,
                treatmentRepoMock.Object,
                null
            );

            var result = await service.GetAddTreatmentToPatientViewModel(patientId);

            Assert.IsNotNull(result, "The result should not be null when the patient exists.");
            Assert.AreEqual(patientId, result.PatientId, "The patient ID should match.");
            Assert.AreEqual("John", result.FirstName, "The patient's first name should match.");
            Assert.AreEqual("Doe", result.LastName, "The patient's last name should match.");
            Assert.AreEqual("Cardiology", result.DepartmentName, "The department name should match.");
            Assert.IsTrue(result.AvailableTreatments.Any(t => t.Text == "Treatment B"), "Available treatments should include 'Treatment B'.");
            Assert.IsTrue(result.AvailableTreatments.Any(t => t.Text == "Treatment C"), "Available treatments should include 'Treatment C'.");
            Assert.IsFalse(result.AvailableTreatments.Any(t => t.Text == "Treatment A"), "Available treatments should not include already assigned treatments.");
        }

        [Test]
        public async Task GetAddTreatmentToPatientViewModel_ReturnsNull_WhenPatientDoesNotExist()
        {
            var patientId = Guid.NewGuid();

            var patientRepoMock = new Mock<IRepository<Patient, Guid>>();
            patientRepoMock.Setup(r => r.GetAllAttcahed())
                           .Returns(new List<Patient>().AsQueryable().BuildMock());

            var treatmentRepoMock = new Mock<IRepository<Treatment, Guid>>();

            var service = new PatientService(
                patientRepoMock.Object,
                null,
                null,
                null,
                null,
                null,
                null,
                treatmentRepoMock.Object,
                null
            );

            var result = await service.GetAddTreatmentToPatientViewModel(patientId);

            Assert.AreEqual(result.FirstName, null);
            Assert.AreEqual(result.LastName, null);
            Assert.AreEqual(result.DepartmentName, null);
          
            Assert.IsEmpty(result.SelectedTreatmentIds);
            Assert.IsEmpty(result.SelectedTreatmentIds);
        }

        [Test]
        public async Task AddTreatmentToPatientAsync_ReturnsTrue_WhenTreatmentsAreAdded()
        {
            var patientId = Guid.NewGuid();
            var existingTreatments = new List<PatientTreatment>
        {
            new PatientTreatment { PatientId = patientId, TreatmentId = Guid.NewGuid() }
        };
            var newTreatmentIds = new List<Guid> { Guid.NewGuid(), Guid.NewGuid() };

            var model = new AddTreatmentToPatientViewModel
            {
                PatientId = patientId,
                SelectedTreatmentIds = newTreatmentIds
            };

            _patientRepoMock.Setup(r => r.GetByIdAsync(patientId))
                .ReturnsAsync(new Patient { Id = patientId });

            _patiientTreatmentRepoMock.Setup(r => r.GetAllAttcahed())
                .Returns(existingTreatments.AsQueryable().BuildMock());

            _patiientTreatmentRepoMock.Setup(r => r.AddAsync(It.IsAny<PatientTreatment>()))
                .Returns(Task.CompletedTask);

            var result = await _patientService.AddTreatmentToPatientAsync(model);

            Assert.IsTrue(result, "AddTreatmentToPatientAsync should return true when treatments are added.");
            _patiientTreatmentRepoMock.Verify(r => r.AddAsync(It.Is<PatientTreatment>(pt =>
                pt.PatientId == patientId &&
                newTreatmentIds.Contains(pt.TreatmentId))), Times.Exactly(newTreatmentIds.Count));
        }

        [Test]
        public async Task AddTreatmentToPatientAsync_ReturnsFalse_WhenPatientDoesNotExist()
        {
            var patientId = Guid.NewGuid();
            var model = new AddTreatmentToPatientViewModel
            {
                PatientId = patientId,
                SelectedTreatmentIds = new List<Guid> { Guid.NewGuid() }
            };

            _patientRepoMock.Setup(r => r.GetByIdAsync(patientId))
                .ReturnsAsync((Patient)null);

            var result = await _patientService.AddTreatmentToPatientAsync(model);

            Assert.IsFalse(result, "AddTreatmentToPatientAsync should return false when the patient does not exist.");
            _patiientTreatmentRepoMock.Verify(r => r.AddAsync(It.IsAny<PatientTreatment>()), Times.Never);
        }

        [Test]
        public async Task AddTreatmentToPatientAsync_OnlyAddsNewTreatments()
        {
            var patientId = Guid.NewGuid();
            var existingTreatmentId = Guid.NewGuid();
            var newTreatmentId = Guid.NewGuid();

            var existingTreatments = new List<PatientTreatment>
        {
            new PatientTreatment { PatientId = patientId, TreatmentId = existingTreatmentId }
        };

            var model = new AddTreatmentToPatientViewModel
            {
                PatientId = patientId,
                SelectedTreatmentIds = new List<Guid> { existingTreatmentId, newTreatmentId }
            };

            _patientRepoMock.Setup(r => r.GetByIdAsync(patientId))
                .ReturnsAsync(new Patient { Id = patientId });

            _patiientTreatmentRepoMock.Setup(r => r.GetAllAttcahed())
                .Returns(existingTreatments.AsQueryable().BuildMock());

            _patiientTreatmentRepoMock.Setup(r => r.AddAsync(It.IsAny<PatientTreatment>()))
                .Returns(Task.CompletedTask);

            var result = await _patientService.AddTreatmentToPatientAsync(model);

            Assert.IsTrue(result, "AddTreatmentToPatientAsync should return true when treatments are added.");
            _patiientTreatmentRepoMock.Verify(r => r.AddAsync(It.Is<PatientTreatment>(pt =>
                pt.PatientId == patientId &&
                pt.TreatmentId == newTreatmentId)), Times.Once);
            _patiientTreatmentRepoMock.Verify(r => r.AddAsync(It.Is<PatientTreatment>(pt =>
                pt.TreatmentId == existingTreatmentId)), Times.Never);
        }

        [Test]
        public async Task GetChangeTreatmentViewModel_ReturnsModel_WhenPatientExists()
        {
            var patientId = Guid.NewGuid();
            var treatmentId1 = Guid.NewGuid();
            var treatmentId2 = Guid.NewGuid();

            var patient = new Patient
            {
                Id = patientId,
                FirstName = "John",
                LastName = "Doe",
                Department = new Department { Name = "Cardiology" },
                PatientTreatments = new List<PatientTreatment>
            {
                new PatientTreatment
                {
                    TreatmentId = treatmentId1,
                    Treatment = new Treatment { Id = treatmentId1, Name = "Treatment A" }
                }
            }
            };

            var unassignedTreatments = new List<Treatment>
        {
            new Treatment { Id = treatmentId2, Name = "Treatment B" }
        };

            _patientRepoMock.Setup(r => r.GetAllAttcahed())
                .Returns(new List<Patient> { patient }.AsQueryable().BuildMock());

            _treatmentRepoMock.Setup(r => r.GetAllAttcahed())
                .Returns(unassignedTreatments.AsQueryable().BuildMock());

            var result = await _patientService.GetChangeTreatmentViewModel(patientId);

            Assert.IsNotNull(result, "The result should not be null.");
            Assert.AreEqual(patientId, result.PatientId, "The patient ID should match.");
            Assert.AreEqual("John", result.FirstName, "The first name should match.");
            Assert.AreEqual("Doe", result.LastName, "The last name should match.");
            Assert.AreEqual("Cardiology", result.DepartmentName, "The department name should match.");
            Assert.AreEqual(1, result.AssignedTreatments.Count, "There should be one assigned treatment.");
            Assert.AreEqual("Treatment A", result.AssignedTreatments.First().Text, "The assigned treatment name should match.");
            
        }

        [Test]
        public async Task GetChangeTreatmentViewModel_ReturnsEmptyModel_WhenPatientDoesNotExist()
        {
            var patientId = Guid.NewGuid();
            _patientRepoMock.Setup(r => r.GetAllAttcahed())
                .Returns(new List<Patient>().AsQueryable().BuildMock());

            var result = await _patientService.GetChangeTreatmentViewModel(patientId);

            Assert.IsNotNull(result, "The result should not be null.");
            Assert.AreEqual(Guid.Empty, result.PatientId, "The patient ID should be empty.");
            Assert.IsEmpty(result.AssignedTreatments, "Assigned treatments should be empty.");
            Assert.IsEmpty(result.AvailableTreatments, "Available treatments should be empty.");
        }

        [Test]
        public async Task ChangeTreatmentsAsync_ReturnsFalse_WhenPatientDoesNotExist()
        {
            var model = new ChangeTreatmentsViewModel { PatientId = Guid.NewGuid() };

            _patientRepoMock.Setup(r => r.GetAllAttcahed())
                .Returns(new List<Patient>().AsQueryable().BuildMock());

            var result = await _patientService.ChangeTreatmentsAsync(model);

            Assert.IsFalse(result, "The method should return false when the patient does not exist.");
        }

        [Test]
        public async Task ChangeTreatmentsAsync_ReturnsFalse_WhenInvalidNewTreatmentIdProvided()
        {
            var patientId = Guid.NewGuid();
            var invalidTreatmentId = Guid.NewGuid();

            var model = new ChangeTreatmentsViewModel
            {
                PatientId = patientId,
                NewTreatmentIds = new List<Guid> { invalidTreatmentId }
            };

            var patient = new Patient
            {
                Id = patientId,
                PatientTreatments = new List<PatientTreatment>()
            };

            _patientRepoMock.Setup(r => r.GetAllAttcahed())
                .Returns(new List<Patient> { patient }.AsQueryable().BuildMock());

            _treatmentRepoMock.Setup(r => r.GetByIdAsync(invalidTreatmentId))
                .ReturnsAsync((Treatment)null);

            var result = await _patientService.ChangeTreatmentsAsync(model);

            Assert.IsFalse(result, "The method should return false when an invalid new treatment ID is provided.");
        }

        [Test]
        public async Task ChangeTreatmentsAsync_ReturnsFalse_WhenInvalidRemovedTreatmentIdProvided()
        {
            var patientId = Guid.NewGuid();
            var invalidTreatmentId = Guid.NewGuid();

            var model = new ChangeTreatmentsViewModel
            {
                PatientId = patientId,
                RemovedTreatmentIds = new List<Guid> { invalidTreatmentId }
            };

            var patient = new Patient
            {
                Id = patientId,
                PatientTreatments = new List<PatientTreatment>()
            };

            _patientRepoMock.Setup(r => r.GetAllAttcahed())
                .Returns(new List<Patient> { patient }.AsQueryable().BuildMock());

            _treatmentRepoMock.Setup(r => r.GetByIdAsync(invalidTreatmentId))
                .ReturnsAsync((Treatment)null);

            var result = await _patientService.ChangeTreatmentsAsync(model);

            Assert.IsFalse(result, "The method should return false when an invalid removed treatment ID is provided.");
        }

        [Test]
        public async Task ChangeTreatmentsAsync_AddsNewTreatments_WhenValidTreatmentIdsProvided()
        {
            var patientId = Guid.NewGuid();
            var newTreatmentId = Guid.NewGuid();

            var model = new ChangeTreatmentsViewModel
            {
                PatientId = patientId,
                NewTreatmentIds = new List<Guid> { newTreatmentId }
            };

            var patient = new Patient
            {
                Id = patientId,
                PatientTreatments = new List<PatientTreatment>()
            };

            _patientRepoMock.Setup(r => r.GetAllAttcahed())
                .Returns(new List<Patient> { patient }.AsQueryable().BuildMock());

            _treatmentRepoMock.Setup(r => r.GetByIdAsync(newTreatmentId))
                .ReturnsAsync(new Treatment { Id = newTreatmentId });

            _patiientTreatmentRepoMock.Setup(r => r.AnyAsync(It.IsAny<Expression<Func<PatientTreatment, bool>>>()))
                .ReturnsAsync(false);

            var result = await _patientService.ChangeTreatmentsAsync(model);

            Assert.IsTrue(result, "The method should return true when valid treatment IDs are provided.");
            _patiientTreatmentRepoMock.Verify(r => r.AddAsync(It.IsAny<PatientTreatment>()), Times.Once, "AddAsync should be called once for the new treatment.");
        }

        [Test]
        public async Task ChangeTreatmentsAsync_RemovesTreatments_WhenValidTreatmentIdsProvided()
        {
            var patientId = Guid.NewGuid();
            var removedTreatmentId = Guid.NewGuid();

            var model = new ChangeTreatmentsViewModel
            {
                PatientId = patientId,
                RemovedTreatmentIds = new List<Guid> { removedTreatmentId }
            };

            var patient = new Patient
            {
                Id = patientId,
                PatientTreatments = new List<PatientTreatment>
            {
                new PatientTreatment
                {
                    PatientId = patientId,
                    TreatmentId = removedTreatmentId
                }
            }
            };

            _patientRepoMock.Setup(r => r.GetAllAttcahed())
                .Returns(new List<Patient> { patient }.AsQueryable().BuildMock());

            _treatmentRepoMock.Setup(r => r.GetByIdAsync(removedTreatmentId))
                .ReturnsAsync(new Treatment { Id = removedTreatmentId });

            _patiientTreatmentRepoMock.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<PatientTreatment, bool>>>()))
                .ReturnsAsync(patient.PatientTreatments.First());

            var result = await _patientService.ChangeTreatmentsAsync(model);

            Assert.IsTrue(result, "The method should return true when valid treatment IDs are provided for removal.");
            _patiientTreatmentRepoMock.Verify(r => r.DeleteAsync(It.IsAny<PatientTreatment>()), Times.Once, "DeleteAsync should be called once for the removed treatment.");
        }
    }
}

