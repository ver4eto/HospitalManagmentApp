using HospitalManagment.ViewModels.Room;
using HospitalManagmentApp.DataModels;

namespace HospitalManagmentApp.Services.Data.Interfaces
{
    public interface IRoomService
    {
        Task<List<IndexRoomViewModel>> GetAllRoomsAsync();
        Task<AddRoomViewModel> GetAddRoomViewModelAsync(Guid departmentId);
        Task<bool> AddRoomAsync(AddRoomViewModel model);
        Task<EditRoomViewModel> GetEditRoomViewModelAsync(Guid id);
        Task<bool> UpdateRoomAsync(Guid id, EditRoomViewModel model);
        Task<DeleteRoomViewModel> GetDeleteRoomViewModelAsync(Guid id);
        Task<bool> DeleteRoomAsync(Guid id);
        //Task<ICollection<Department>> GetAllDepartmentsAsync();
        //Task<bool> IsRoomNumberUniqueInDepartmentAsync(Guid departmentId, int roomNumber);
    }
}
