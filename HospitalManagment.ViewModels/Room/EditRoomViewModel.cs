using HospitalManagmentApp.DataModels;
using System.ComponentModel.DataAnnotations;
using static HospitalManagmentApp.Common.ApplicationConstants;
using static HospitalManagmentApp.Common.EntityValidationConstants.Room;


namespace HospitalManagment.ViewModels.Room
{
    public class EditRoomViewModel
    {       
        public Guid Id { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        //range???
        public int RoomNumber { get; set; }

        [Required(ErrorMessage =RequiredErrorMessage)]
        [Range(MinBedCount, MaxBedCount)]        
        public int BedCount { get; set; }

        //[Required(ErrorMessage = RequiredErrorMessage)]
        //[Comment("Does room has free beds?")]
        //public bool HasFreeBeds { get; set; } = true;
      
        
        public Guid DepartmnetId { get; set; }    
        public IEnumerable<HospitalManagmentApp.DataModels.Department> Departments { get; set; } = new List<HospitalManagmentApp.DataModels.Department>();
    }
}

