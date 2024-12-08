using HospitalManagment.Infrastructure.Repositories.Contracts;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data;
using HospitalManagmentApp.Services.Data.Interfaces;
using MockQueryable;
using Moq;

namespace HospitalManagmentApp.Tests
{
    [TestFixture]
    public class ManagerServiceTests
    {
        private Mock<IRepository<Patient, Guid>> _patientRepo;
        private Mock<IRepository<Nurse, Guid>> _nurseRepo;
        private Mock<IRepository<Doctor, Guid>> _doctorRepo;
        private Mock<IRepository<Department, Guid>> _departmentRepo;
        private Mock<IRepository<Room, Guid>> _roomRepo;
        private Mock<IRepository<Manager, Guid>> _managerRepo;

        private ManagerService _managerService;

        private IList<Manager> _managersData = new List<Manager>
    {
        new Manager
        {
            Id = Guid.Parse("1f64c3e6-524b-4e6a-88e3-99d0e93f5094"),
            FullName = "Alice Johnson",

            EmailAddress = "alice.johnson@example.com",
            IsDeleted = false
        },
        new Manager
        {
            Id = Guid.Parse("5c36af45-94c1-4a8c-b10a-3123f3f3b1f2"),
            FullName = "Bob Smith",

            EmailAddress = "bob.smith@example.com",
            IsDeleted = true // Deleted manager
        },
        new Manager
        {
            Id = Guid.Parse("7baf675e-f3df-4a3a-a987-b5c6c6b9e920"),
            FullName = "Charlie Brown",

            EmailAddress = "charlie.brown@example.com",
            IsDeleted = false
        }
    };

        [SetUp]
        public void SetUp()
        {
            _managerRepo = new Mock<IRepository<Manager, Guid>>();
            _patientRepo = new Mock<IRepository<Patient, Guid>>();
            _nurseRepo = new Mock<IRepository<Nurse, Guid>>();
            _doctorRepo = new Mock<IRepository<Doctor, Guid>>();
            _departmentRepo = new Mock<IRepository<Department, Guid>>();
            _roomRepo = new Mock<IRepository<Room, Guid>>();
            _managerRepo = new Mock<IRepository<Manager, Guid>>();

            _managerService = new ManagerService(
                _patientRepo.Object,
                _nurseRepo.Object,
                _doctorRepo.Object,
                _departmentRepo.Object,
                _roomRepo.Object,
                _managerRepo.Object
            );
        }

        [Test]
        public async Task GetAllManagersAsync_ReturnsNonDeletedManagers()
        {
            // Arrange
            var managersMockQueryable = _managersData.BuildMock();
            _managerRepo.Setup(r => r.GetAllAttcahed()).Returns(managersMockQueryable);

            // Act
            var result = await _managerService.GetAllManagersASync();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count(), "Only non-deleted managers should be returned.");
            Assert.IsTrue(result.Any(m => m.FullName == "Charlie Brown"), "Alice Johnson should be included in the result.");
            Assert.IsTrue(result.Any(m => m.FullName == "Charlie Brown"), "Charlie Brown should be included in the result.");
        }

        [Test]
        public async Task GetAllManagersAsync_ReturnsEmptyList_WhenNoManagersAvailable()
        {
            // Arrange
            var emptyManagersMockQueryable = new List<Manager>().BuildMock();
            _managerRepo.Setup(r => r.GetAllAttcahed()).Returns(emptyManagersMockQueryable);

            // Act
            var result = await _managerService.GetAllManagersASync();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsEmpty(result, "If no managers are available, the result should be an empty list.");
        }

        [Test]
        public async Task GetAllManagersAsync_ExcludesDeletedManagers()
        {
            // Arrange
            var managersMockQueryable = _managersData.BuildMock();
            _managerRepo.Setup(r => r.GetAllAttcahed()).Returns(managersMockQueryable);

            // Act
            var result = await _managerService.GetAllManagersASync();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsFalse(result.Any(m => m.FullName == "Bob Smith"), "Deleted managers should not be included in the result.");
        }

        [Test]
        public async Task GetGeneralReportViewModel_CalculatesCorrectValues()
        {
            var nurses = new List<Nurse>
        {
            new Nurse { Salary = 50000 },
            new Nurse { Salary = 60000 }
        };

            var doctors = new List<Doctor>
        {
            new Doctor { Salary = 80000 },
            new Doctor { Salary = 90000 }
        };

            _nurseRepo.Setup(r => r.GetAllAttcahed()).Returns(nurses.AsQueryable().BuildMock());
            _doctorRepo.Setup(r => r.GetAllAttcahed()).Returns(doctors.AsQueryable().BuildMock());

            // Act
            var result = await _managerService.GetGeneralReportViewModel();

            // Assert
            Assert.AreEqual(4, result.TotalEmployees, "TotalEmployees should be the sum of nurses and doctors.");
            Assert.AreEqual("280000.00", result.TotalExpenses, "TotalExpenses should sum all salaries.");
            Assert.AreEqual("70000.00", result.AverageExpensePerEmployee, "AverageExpensePerEmployee should be calculated correctly.");
        }

        [Test]
        public async Task GetGeneralReportViewModel_ReturnsZeroValues_WhenNoEmployees()
        {
            var nurses = new List<Nurse>();
            var doctors = new List<Doctor>();

            _nurseRepo.Setup(r => r.GetAllAttcahed()).Returns(new List<Nurse>().AsQueryable().BuildMock());
            _doctorRepo.Setup(r => r.GetAllAttcahed()).Returns(new List<Doctor>().AsQueryable().BuildMock());

            // Act
            var result = await _managerService.GetGeneralReportViewModel();

            // Assert
            Assert.AreEqual(0, result.TotalEmployees, "TotalEmployees should be zero when there are no employees.");
            Assert.AreEqual("0.00", result.TotalExpenses, "TotalExpenses should be zero when there are no employees.");
            Assert.AreEqual("0.00", result.AverageExpensePerEmployee, "AverageExpensePerEmployee should be zero when there are no employees.");
        }

        [Test]
        public async Task GetIndexManagerViewModel_ReturnsCorrectTotals()
        {
            // Arrange: Mock data
            var patients = new List<Patient>
        {
            new Patient
            {
                Id = Guid.NewGuid(),
                DepartmentId = Guid.Parse("43f9018c-2a02-448d-b26e-bc832bc097d3"),
                PatientTreatments = new List<PatientTreatment>
                {
                    new PatientTreatment { Treatment = new Treatment { Price = 200 } },
                    new PatientTreatment { Treatment = new Treatment { Price = 300 } }
                }
            }
        };

            var nurses = new List<Nurse>
        {
            new Nurse { DepartmentId = Guid.Parse("43f9018c-2a02-448d-b26e-bc832bc097d3"), Salary = 50000 }
        };

            var doctors = new List<Doctor>
        {
            new Doctor { DepartmentId = Guid.Parse("43f9018c-2a02-448d-b26e-bc832bc097d3"), Salary = 80000 }
        };

            var departments = new List<Department>
        {
            new Department { Id = Guid.Parse("43f9018c-2a02-448d-b26e-bc832bc097d3"), Name = "Cardiology" }
        };

            // Mock repository calls
            _patientRepo.Setup(r => r.GetAllAttcahed()).Returns(patients.AsQueryable().BuildMock());
            _nurseRepo.Setup(r => r.GetAllAttcahed()).Returns(nurses.AsQueryable().BuildMock());
            _doctorRepo.Setup(r => r.GetAllAttcahed()).Returns(doctors.AsQueryable().BuildMock());
            _departmentRepo.Setup(r => r.GetAllAttcahed()).Returns(departments.AsQueryable().BuildMock());

            // Act
            var result = await _managerService.GetIndexManagerViewModel();

            // Assert
            Assert.IsNotNull(result, "The result should not be null.");
            // Add assertions to validate that all calculations are correct.
        }

        [Test]
        public async Task GetIndexManagerViewModel_ReturnsEmptyModel_WhenNoDataExists()
        {
            // Arrange: Empty lists
            _patientRepo.Setup(r => r.GetAllAttcahed()).Returns(new List<Patient>().AsQueryable().BuildMock());
            _nurseRepo.Setup(r => r.GetAllAttcahed()).Returns(new List<Nurse>().AsQueryable().BuildMock());
            _doctorRepo.Setup(r => r.GetAllAttcahed()).Returns(new List<Doctor>().AsQueryable().BuildMock());
            _departmentRepo.Setup(r => r.GetAllAttcahed()).Returns(new List<Department>().AsQueryable().BuildMock());

            // Act
            var result = await _managerService.GetIndexManagerViewModel();

            // Assert
            Assert.IsNotNull(result, "The result should not be null.");
            // Add additional assertions to verify that totals and expenses are zero.
        }

        [Test]
        public async Task GetDepartmentReportsViewModel_ReturnsCorrectDepartmentStats()
        {
            // Arrange: Mock data
            var departments = new List<Department>
        {
            new Department
            {
                Id = Guid.Parse("d1b3e7fd-9f72-4e12-bf7c-3f7dfd5f3c36"),
                Name = "Cardiology",
                Nurses = new List<Nurse>
                {
                    new Nurse { Salary = 50000 }
                },
                DepartmentDoctors = new List<Doctor>
                {
                    new Doctor { Salary = 80000 }
                },
                Patients = new List<Patient>
                {
                    new Patient
                    {
                        PatientTreatments = new List<PatientTreatment>
                        {
                            new PatientTreatment
                            {
                                Treatment = new Treatment { Price = 300 }
                            }
                        }
                    }
                }
            }
        };

            var doctors = new List<Doctor>
        {
            new Doctor { DepartmentId = Guid.Parse("d1b3e7fd-9f72-4e12-bf7c-3f7dfd5f3c36"), Salary = 80000 }
        };

            var nurses = new List<Nurse>
        {
            new Nurse { DepartmentId = Guid.Parse("d1b3e7fd-9f72-4e12-bf7c-3f7dfd5f3c36"), Salary = 50000 }
        };

            var patients = new List<Patient>
        {
            new Patient
            {
                DepartmentId = Guid.Parse("d1b3e7fd-9f72-4e12-bf7c-3f7dfd5f3c36"),
                PatientTreatments = new List<PatientTreatment>
                {
                    new PatientTreatment { Treatment = new Treatment { Price = 300 } }
                }
            }
        };

            var rooms = new List<Room>
        {
            new Room { DepartmnetId = Guid.Parse("d1b3e7fd-9f72-4e12-bf7c-3f7dfd5f3c36") }
        };

            // Mock repositories
            _departmentRepo.Setup(r => r.GetAllAttcahed()).Returns(departments.AsQueryable().BuildMock());
            _doctorRepo.Setup(r => r.GetAllAttcahed()).Returns(doctors.AsQueryable().BuildMock());
            _nurseRepo.Setup(r => r.GetAllAttcahed()).Returns(nurses.AsQueryable().BuildMock());
            _patientRepo.Setup(r => r.GetAllAttcahed()).Returns(patients.AsQueryable().BuildMock());
            _roomRepo.Setup(r => r.GetAllAttcahed()).Returns(rooms.AsQueryable().BuildMock());

            // Act
            var result = await _managerService.GetDepartmentReportsViewModel();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Departments.Count, "There should be one department in the report.");

            var departmentStats = result.Departments.First();
            Assert.AreEqual("Cardiology", departmentStats.DepartmentName);
            Assert.AreEqual(1, departmentStats.DoctorCount);
            Assert.AreEqual(1, departmentStats.NurseCount);
            Assert.AreEqual(1, departmentStats.PatientCount);
            Assert.AreEqual(1, departmentStats.RoomCount);
            Assert.AreEqual(130300, departmentStats.TotalExpenses, "TotalExpenses should be the sum of doctor, nurse salaries and patient treatment costs.");
        }

        [Test]
        public async Task GetDepartmentReportsViewModel_ReturnsEmptyModel_WhenNoDataExists()
        {
            // Arrange: Empty lists
            _departmentRepo.Setup(r => r.GetAllAttcahed()).Returns(new List<Department>().AsQueryable().BuildMock());
            _doctorRepo.Setup(r => r.GetAllAttcahed()).Returns(new List<Doctor>().AsQueryable().BuildMock());
            _nurseRepo.Setup(r => r.GetAllAttcahed()).Returns(new List<Nurse>().AsQueryable().BuildMock());
            _patientRepo.Setup(r => r.GetAllAttcahed()).Returns(new List<Patient>().AsQueryable().BuildMock());
            _roomRepo.Setup(r => r.GetAllAttcahed()).Returns(new List<Room>().AsQueryable().BuildMock());

            // Act
            var result = await _managerService.GetDepartmentReportsViewModel();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsEmpty(result.Departments, "The department list should be empty when no data exists.");
            Assert.AreEqual(0, result.TotalDoctors, "TotalDoctors should be zero when no data exists.");
            Assert.AreEqual(0, result.TotalNurses, "TotalNurses should be zero when no data exists.");
            Assert.AreEqual(0, result.TotalPatients, "TotalPatients should be zero when no data exists.");
            Assert.AreEqual(0, result.TotalRooms, "TotalRooms should be zero when no data exists.");
            Assert.AreEqual(0, result.TotalExpenses, "TotalExpenses should be zero when no data exists.");
        }

        [Test]
        public async Task GetDoctorsReportViewModel_ReturnsCorrectTotals()
        {
            // Arrange: Mock data
            var doctors = new List<Doctor>
        {
            new Doctor { Salary = 100000 },
            new Doctor { Salary = 120000 }
        };

            var patients = new List<Patient>
        {
            new Patient(),
            new Patient(),
            new Patient()
        };

            // Mock repository calls
            _doctorRepo.Setup(r => r.GetAllAttcahed()).Returns(doctors.AsQueryable().BuildMock());
            _patientRepo.Setup(r => r.GetAllAttcahed()).Returns(patients.AsQueryable().BuildMock());

            // Act
            var result = await _managerService.GetDoctorsReportViewModel();

            // Assert
            Assert.IsNotNull(result, "The result should not be null.");
            Assert.AreEqual(2, result.TotalDoctors, "TotalDoctors should match the count of doctors.");
            Assert.AreEqual(3, result.TotalPatients, "TotalPatients should match the count of patients.");
            Assert.AreEqual("220000.00", result.TotalExpenses, "TotalExpenses should sum the salaries of all doctors.");
            Assert.AreEqual("73333.33", result.AverageSalary, "AverageSalary should divide total salaries by the number of patients.");
        }

        [Test]
        public async Task GetDoctorsReportViewModel_ReturnsZeroValues_WhenNoDataExists()
        {
            // Arrange: Empty data
            _doctorRepo.Setup(r => r.GetAllAttcahed()).Returns(new List<Doctor>().AsQueryable().BuildMock());
            _patientRepo.Setup(r => r.GetAllAttcahed()).Returns(new List<Patient>().AsQueryable().BuildMock());

            // Act
            var result = await _managerService.GetDoctorsReportViewModel();

            // Assert
            Assert.IsNotNull(result, "The result should not be null.");
            Assert.AreEqual(0, result.TotalDoctors, "TotalDoctors should be zero when no data exists.");
            Assert.AreEqual(0, result.TotalPatients, "TotalPatients should be zero when no data exists.");
            Assert.AreEqual("0.00", result.TotalExpenses, "TotalExpenses should be zero when no data exists.");
            Assert.AreEqual("0.00", result.AverageSalary, "AverageSalary should be zero when no data exists.");
        }

        [Test]
        public async Task GetPatientsReportViewModel_ReturnsCorrectTotals()
        {
            // Arrange: Mock data
            var departments = new List<Department>
        {
            new Department { Id = Guid.NewGuid(), Name = "Cardiology" },
            new Department { Id = Guid.NewGuid(), Name = "Neurology" }
        };

            var patients = new List<Patient>
        {
            new Patient { DepartmentId = departments[0].Id },
            new Patient { DepartmentId = departments[0].Id },
            new Patient { DepartmentId = departments[1].Id }
        };

            // Mock repository calls
            _departmentRepo.Setup(r => r.GetAllAttcahed()).Returns(departments.AsQueryable().BuildMock());
            _patientRepo.Setup(r => r.GetAllAttcahed()).Returns(patients.AsQueryable().BuildMock());

            // Act
            var result = await _managerService.GetPatientsReportViewModel();

            // Assert
            Assert.IsNotNull(result, "The result should not be null.");
            Assert.AreEqual(3, result.TotalPatients, "TotalPatients should match the total count of patients.");
            Assert.AreEqual("1.50", result.AveragePatientsPerDepartment, "AveragePatientsPerDepartment should be calculated correctly.");
            Assert.AreEqual(2, result.Departments.Count, "The number of departments in the report should match the number of departments.");

            var cardiology = result.Departments.First(dp => dp.DepartmentName == "Cardiology");
            Assert.AreEqual(2, cardiology.PatientCount, "Cardiology should have 2 patients.");

            var neurology = result.Departments.First(dp => dp.DepartmentName == "Neurology");
            Assert.AreEqual(1, neurology.PatientCount, "Neurology should have 1 patient.");
        }

        [Test]
        public async Task GetPatientsReportViewModel_ReturnsZeroValues_WhenNoDataExists()
        {
            // Arrange: Empty data
            _departmentRepo.Setup(r => r.GetAllAttcahed()).Returns(new List<Department>().AsQueryable().BuildMock());
            _patientRepo.Setup(r => r.GetAllAttcahed()).Returns(new List<Patient>().AsQueryable().BuildMock());

            // Act
            var result = await _managerService.GetPatientsReportViewModel();

            // Assert
            Assert.IsNotNull(result, "The result should not be null.");
            Assert.AreEqual(0, result.TotalPatients, "TotalPatients should be zero when no data exists.");
            Assert.AreEqual("0.00", result.AveragePatientsPerDepartment, "AveragePatientsPerDepartment should be zero when no data exists.");
            Assert.IsEmpty(result.Departments, "Departments list should be empty when no data exists.");
        }
    }




}


