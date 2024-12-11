using HospitalManagment.Infrastructure.Repositories.Contracts;
using HospitalManagment.ViewModels.Room;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data;
using MockQueryable;
using Moq;

namespace HospitalManagmentApp.Tests
{
    [TestFixture]
    public class RoomServiceTests
    {
        private Mock<IRepository<Department, Guid>> _departmentRepo;
        private Mock<IRepository<Room, Guid>> _roomRepo;
        private RoomService _roomService;

        [SetUp]
        public void SetUp()
        {
            _departmentRepo = new Mock<IRepository<Department, Guid>>();
            _roomRepo = new Mock<IRepository<Room, Guid>>();
            _roomService = new RoomService(_roomRepo.Object, _departmentRepo.Object);
        }




        [Test]
        public async Task GetAllRoomsAsync_ReturnsEmptyList_WhenNoNonDeletedRoomsExist()
        {
          
            var rooms = new List<Room>
        {
            new Room
            {
                Id = Guid.NewGuid(),
                BedCount = 3,
                RoomNumber = 103,
                HasFreeBeds = true,
                IsDeleted = true, // All rooms are deleted
                Department = new Department { Name = "Oncology" }
            }
        };

            var roomsMockQueryable = rooms.AsQueryable().BuildMock();

            _roomRepo.Setup(r => r.GetAllAttcahed())
                .Returns(roomsMockQueryable);
           
            var result = await _roomService.GetAllRoomsAsync();

            Assert.IsNotNull(result, "The result should not be null.");
            Assert.IsEmpty(result, "The result should be an empty list when no non-deleted rooms exist.");
        }

        [Test]
        public async Task GetAllRoomsAsync_ReturnsEmptyList_WhenNoRoomsExist()
        {
            var emptyRoomsMockQueryable = new List<Room>().AsQueryable().BuildMock();

            _roomRepo.Setup(r => r.GetAllAttcahed())
                .Returns(emptyRoomsMockQueryable);

            var result = await _roomService.GetAllRoomsAsync();

            Assert.IsNotNull(result, "The result should not be null.");
            Assert.IsEmpty(result, "The result should be an empty list when no rooms exist.");
        }

        [Test]
        public async Task DeleteRoomAsync_ReturnsTrue_WhenRoomIsDeletedSuccessfully()
        {
            var roomId = Guid.NewGuid();
            var room = new Room
            {
                Id = roomId,
                IsDeleted = false
            };

            var rooms = new List<Room> { room }.AsQueryable().BuildMock();

            _roomRepo.Setup(r => r.GetAllAttcahed())
                .Returns(rooms);

            _roomRepo.Setup(r => r.UpdateAsync(It.IsAny<Room>()))
                .Returns(Task.FromResult(true));

            var result = await _roomService.DeleteRoomAsync(roomId);

            Assert.IsTrue(result, "DeleteRoomAsync should return true when a room is successfully deleted.");
            _roomRepo.Verify(r => r.UpdateAsync(It.Is<Room>(r => r.Id == roomId && r.IsDeleted)), Times.Once);
        }

        [Test]
        public async Task DeleteRoomAsync_ReturnsFalse_WhenRoomDoesNotExist()
        {
            var roomId = Guid.NewGuid();

            var rooms = new List<Room>().AsQueryable().BuildMock(); // No rooms available

            _roomRepo.Setup(r => r.GetAllAttcahed())
                .Returns(rooms);

            var result = await _roomService.DeleteRoomAsync(roomId);

            Assert.IsFalse(result, "DeleteRoomAsync should return false when the room does not exist.");
            _roomRepo.Verify(r => r.UpdateAsync(It.IsAny<Room>()), Times.Never);
        }

        [Test]
        public async Task DeleteRoomAsync_ReturnsFalse_WhenRoomIsAlreadyDeleted()
        {
            var roomId = Guid.NewGuid();
            var room = new Room
            {
                Id = roomId,
                IsDeleted = true // Already deleted
            };

            var rooms = new List<Room> { room }.AsQueryable().BuildMock();

            _roomRepo.Setup(r => r.GetAllAttcahed())
                .Returns(rooms);

            var result = await _roomService.DeleteRoomAsync(roomId);

            Assert.IsFalse(result, "DeleteRoomAsync should return false when the room is already deleted.");
            _roomRepo.Verify(r => r.UpdateAsync(It.IsAny<Room>()), Times.Never);
        }

        [Test]
        public async Task UpdateRoomAsync_ReturnsTrue_WhenRoomIsUpdatedSuccessfully()
        {
            var roomId = Guid.NewGuid();
            var existingRoom = new Room
            {
                Id = roomId,
                RoomNumber = 101,
                BedCount = 2,
                DepartmnetId = Guid.NewGuid()
            };

            var updatedRoomModel = new EditRoomViewModel
            {
                RoomNumber = 202,
                BedCount = 4,
                DepartmnetId = Guid.NewGuid()
            };

            _roomRepo.Setup(r => r.GetByIdAsync(It.Is<Guid>(id => id == roomId)))
                .ReturnsAsync(existingRoom);

            _roomRepo.Setup(r => r.UpdateAsync(It.IsAny<Room>()))
                .Returns(Task.FromResult(true));

            var result = await _roomService.UpdateRoomAsync(roomId, updatedRoomModel);

            Assert.IsTrue(result, "UpdateRoomAsync should return true when the room is successfully updated.");
            _roomRepo.Verify(r => r.GetByIdAsync(It.Is<Guid>(id => id == roomId)), Times.Once, "GetByIdAsync should be called once.");
            _roomRepo.Verify(r => r.UpdateAsync(It.Is<Room>(r =>
                r.Id == roomId &&
                r.RoomNumber == updatedRoomModel.RoomNumber &&
                r.BedCount == updatedRoomModel.BedCount &&
                r.DepartmnetId == updatedRoomModel.DepartmnetId
            )), Times.Once, "UpdateAsync should be called with the updated room.");
        }

        [Test]
        public async Task UpdateRoomAsync_ReturnsFalse_WhenRoomDoesNotExist()
        {
            var roomId = Guid.NewGuid();
            var updatedRoomModel = new EditRoomViewModel
            {
                RoomNumber = 202,
                BedCount = 4,
                DepartmnetId = Guid.NewGuid()
            };

            _roomRepo.Setup(r => r.GetByIdAsync(It.Is<Guid>(id => id == roomId)))
                .ReturnsAsync((Room)null); // room not found

            var result = await _roomService.UpdateRoomAsync(roomId, updatedRoomModel);

            Assert.IsFalse(result, "UpdateRoomAsync should return false when the room does not exist.");
            _roomRepo.Verify(r => r.GetByIdAsync(It.Is<Guid>(id => id == roomId)), Times.Once, "GetByIdAsync should be called once.");
            _roomRepo.Verify(r => r.UpdateAsync(It.IsAny<Room>()), Times.Never, "UpdateAsync should not be called when the room does not exist.");
        }

        [Test]
        public async Task AddRoomAsync_ReturnsTrue_WhenRoomIsAddedSuccessfully()
        {
          
            var departmentId = Guid.NewGuid();
            var roomNumber = 101;
            var addRoomModel = new AddRoomViewModel
            {
                DepartmnetId = departmentId,
                RoomNumber = roomNumber,
                BedCount = 2
            };

            var department = new Department
            {
                Id = departmentId,
                Rooms = new List<Room>() // No rooms with the same number
            };

            _departmentRepo.Setup(r => r.GetByIdAsync(It.Is<Guid>(id => id == departmentId)))
                .ReturnsAsync(department);

            _roomRepo.Setup(r => r.AddAsync(It.IsAny<Room>()))
                .Returns(Task.CompletedTask);

            var result = await _roomService.AddRoomAsync(addRoomModel);

            Assert.IsTrue(result, "AddRoomAsync should return true when the room is added successfully.");
            _roomRepo.Verify(r => r.AddAsync(It.Is<Room>(room =>
                room.RoomNumber == roomNumber &&
                room.BedCount == addRoomModel.BedCount &&
                room.DepartmnetId == addRoomModel.DepartmnetId
            )), Times.Once, "AddAsync should be called with the correct room.");
        }

        [Test]
        public async Task AddRoomAsync_ReturnsFalse_WhenRoomNumberIsNotUnique()
        {
            var departmentId = Guid.NewGuid();
            var roomNumber = 101;
            var addRoomModel = new AddRoomViewModel
            {
                DepartmnetId = departmentId,
                RoomNumber = roomNumber,
                BedCount = 2
            };

            var department = new Department
            {
                Id = departmentId,
                Rooms = new List<Room>
            {
                new Room { RoomNumber = roomNumber } // Duplicate room number
            }
            };

            _departmentRepo.Setup(r => r.GetByIdAsync(It.Is<Guid>(id => id == departmentId)))
                .ReturnsAsync(department);

            var result = await _roomService.AddRoomAsync(addRoomModel);

            Assert.IsFalse(result, "AddRoomAsync should return false when the room number is not unique.");
            _roomRepo.Verify(r => r.AddAsync(It.IsAny<Room>()), Times.Never, "AddAsync should not be called for duplicate room numbers.");
        }

        [Test]
        public async Task AddRoomAsync_ReturnsFalse_WhenDepartmentDoesNotExist()
        {
            var departmentId = Guid.NewGuid();
            var roomModel = new AddRoomViewModel
            {
                DepartmnetId = departmentId,
                RoomNumber = 101,
                BedCount = 2
            };

            // Mock GetByIdAsync to return null
            _departmentRepo.Setup(r => r.GetByIdAsync(It.Is<Guid>(id => id == departmentId)))
                .ReturnsAsync((Department)null);

            var result = await _roomService.AddRoomAsync(roomModel);

            Assert.IsFalse(result, "AddRoomAsync should return false when the department does not exist.");
            _departmentRepo.Verify(r => r.GetByIdAsync(It.Is<Guid>(id => id == departmentId)), Times.Once, "GetByIdAsync should be called once with the correct ID.");
            _roomRepo.Verify(r => r.AddAsync(It.IsAny<Room>()), Times.Never, "AddAsync should not be called when the department does not exist.");
        }

        [Test]
        public async Task GetAddRoomViewModelAsync_ReturnsViewModel_WhenDepartmentExists()
        {
            var departmentId = Guid.NewGuid();
            var department = new Department
            {
                Id = departmentId,
                Name = "Neurology",
                IsDeleted = false
            };

            _departmentRepo.Setup(r => r.GetByIdAsync(departmentId))
                .ReturnsAsync(department);

            var result = await _roomService.GetAddRoomViewModelAsync(departmentId);

            Assert.IsNotNull(result, "The result should not be null when the department exists.");
            Assert.AreEqual(departmentId, result.DepartmnetId, "The department ID should match.");
            Assert.AreEqual("Neurology", result.DepartmentName, "The department name should match.");
        }

        [Test]
        public async Task GetAddRoomViewModelAsync_ReturnsNull_WhenDepartmentDoesNotExist()
        {
            var departmentId = Guid.NewGuid();

            _departmentRepo.Setup(r => r.GetByIdAsync(departmentId))
                .ReturnsAsync((Department)null); // Simulate department not found

            var result = await _roomService.GetAddRoomViewModelAsync(departmentId);

            Assert.IsNull(result, "The result should be null when the department does not exist.");
            _departmentRepo.Verify(r => r.GetByIdAsync(It.IsAny<Guid>()), Times.Once, "GetByIdAsync should be called once.");
        }

        [Test]
        public async Task GetDeleteRoomViewModelAsync_ReturnsViewModel_WhenRoomExists()
        {
            var roomId = Guid.NewGuid();
            var room = new Room
            {
                Id = roomId,
                RoomNumber = 101,
                IsDeleted = false
            };

            _roomRepo.Setup(r => r.GetByIdAsync(roomId))
                .ReturnsAsync(room);

            var result = await _roomService.GetDeleteRoomViewModelAsync(roomId);

            Assert.IsNotNull(result, "The result should not be null when the room exists.");
            Assert.AreEqual(roomId, result.Id, "The room ID should match.");
            Assert.AreEqual(101, result.RoomNumber, "The room number should match.");
            _roomRepo.Verify(r => r.GetByIdAsync(It.Is<Guid>(id => id == roomId)), Times.Once, "GetByIdAsync should be called once with the correct ID.");
        }

        [Test]
        public async Task GetDeleteRoomViewModelAsync_ReturnsNull_WhenRoomDoesNotExist()
        {
            var roomId = Guid.NewGuid();

            _roomRepo.Setup(r => r.GetByIdAsync(roomId))
                .ReturnsAsync((Room)null); // Simulate room not found

            var result = await _roomService.GetDeleteRoomViewModelAsync(roomId);

            Assert.IsNull(result, "The result should be null when the room does not exist.");
            _roomRepo.Verify(r => r.GetByIdAsync(It.Is<Guid>(id => id == roomId)), Times.Once, "GetByIdAsync should be called once with the correct ID.");
        }

       

        [Test]
        public async Task GetEditRoomViewModelAsync_ReturnsNull_WhenRoomDoesNotExist()
        {
            var roomId = Guid.NewGuid();

            _roomRepo.Setup(r => r.GetAllAttcahed())
                .Returns(new List<Room>().AsQueryable().BuildMock());

            var result = await _roomService.GetEditRoomViewModelAsync(roomId);

            Assert.IsNull(result, "The result should be null when the room does not exist.");
            _roomRepo.Verify(r => r.GetAllAttcahed(), Times.Once, "GetAllAttcahed should be called once.");
        }

    }
}


