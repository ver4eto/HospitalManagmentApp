using HospitalManagment.Infrastructure.Repositories.Contracts;
using HospitalManagment.ViewModels.Room;
using HospitalManagmentApp.DataModels;
using HospitalManagmentApp.Services.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagmentApp.Services.Data
{
    public class RoomService : IRoomService
    {
        private readonly IRepository<Room,Guid> roomRepository;
        private readonly IRepository<Department, Guid> departmentRepository;

        public RoomService(IRepository<Room, Guid> roomRepository, IRepository<Department, Guid> departmentRepository)
        {
            this.roomRepository = roomRepository;
            this.departmentRepository = departmentRepository;
        }
        public async Task<bool> AddRoomAsync(AddRoomViewModel model)
        {
            if (await IsRoomNumberUniqueInDepartmentAsync(model.DepartmnetId, model.RoomNumber) == false)
            {
                return false; // Room number already exists in the department
            }

            var room = new Room
            {
                RoomNumber = model.RoomNumber,
                BedCount = model.BedCount,
                DepartmnetId = model.DepartmnetId
            };

            await roomRepository.AddAsync(room);
        
            return true;
        }

        public async Task<bool> DeleteRoomAsync(Guid id)
        {
            var room = await roomRepository.GetAllAttcahed()
           .Where(r => r.Id == id && !r.IsDeleted)
           .FirstOrDefaultAsync();

            if (room == null)
            {
                return false;
            }

            room.IsDeleted = true;
            await roomRepository.UpdateAsync(room);
            return true;
        }

        public async Task<AddRoomViewModel> GetAddRoomViewModelAsync(Guid departmentId)
        {
            var department = await departmentRepository.GetByIdAsync(departmentId);

            if (department == null)
            {
                return null;
            }

            return new AddRoomViewModel
            {
                DepartmnetId = departmentId,
                DepartmentName = department.Name,
            };
        }

       

        public async Task<List<IndexRoomViewModel>> GetAllRoomsAsync()
        {
            return await roomRepository.GetAllAttcahed()
            .Where(r => !r.IsDeleted)
            .Select(r => new IndexRoomViewModel
            {
                Id = r.Id,
                BedCount = r.BedCount,
                RoomNumber = r.RoomNumber,
                Departmnet = r.Department.Name,
                HasFreeBeds = r.HasFreeBeds ? "Yes!" : "No"
            })
            .ToListAsync();
        }

        public async Task<DeleteRoomViewModel> GetDeleteRoomViewModelAsync(Guid id)
        {
            var room = await roomRepository.GetByIdAsync(id);
            if (room == null)
            {
                return null;
            }

            return new DeleteRoomViewModel
            {
                Id = room.Id,
                RoomNumber = room.RoomNumber
            };
        }

        public async Task<EditRoomViewModel> GetEditRoomViewModelAsync(Guid id)
        {
            var room = await roomRepository.GetAllAttcahed()
            .Where(r => r.Id == id && !r.IsDeleted)
            .Include(r => r.Department)
            .FirstOrDefaultAsync();

            if (room == null)
            {
                return null;
            }

            return new EditRoomViewModel
            {
                Id = room.Id,
                RoomNumber = room.RoomNumber,
                BedCount = room.BedCount,
                DepartmnetId = room.DepartmnetId,
                Departments = await GetAllDepartmentsAsync()
            };
        }

        public async Task<bool> UpdateRoomAsync(Guid id, EditRoomViewModel model)
        {
            var room = await roomRepository.GetByIdAsync(id);
            if (room == null)
            {
                return false;
            }

            room.RoomNumber = model.RoomNumber;
            room.BedCount = model.BedCount;
            room.DepartmnetId = model.DepartmnetId;

            await roomRepository.UpdateAsync(room);
            return true;
        }

        private async Task<bool> IsRoomNumberUniqueInDepartmentAsync(Guid departmentId, int roomNumber)
        {
            
            var department = await departmentRepository.GetByIdAsync(departmentId);

            if(department == null)
            {
                
                return false;
            }
            if (department.Rooms.Any(d => d.RoomNumber == roomNumber))
            {
                return false;
            }
            return true;
        }

        private async Task<IEnumerable<Department>> GetAllDepartmentsAsync()
        {
            return await departmentRepository.GetAllAsync();
        }
        
    }
}
