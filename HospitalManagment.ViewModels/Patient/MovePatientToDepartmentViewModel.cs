using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using static HospitalManagmentApp.Common.ApplicationConstants;

namespace HospitalManagment.ViewModels.Patient
{
    public class MovePatientToDepartmentViewModel
    {
        public Guid PatientId { get; set; }

        public string Name { get; set; } = null!;

        public string EGN { get; set; } = null!;

        public string CurrentDepartment { get; set; } = null!;
        public Guid CurrentDepartmentId { get; set; }
        public int CurrentRoom { get; set; }
        public Guid CurrentRoomId { get; set; }

        [Required(ErrorMessage = "Please select a department.")]
        public Guid NewDepartmentId { get; set; }

        
        public IEnumerable<HospitalManagmentApp.DataModels.Department> Departments { get; set; } = new List<HospitalManagmentApp.DataModels.Department>();

        [Required(ErrorMessage = "Please select a room.")]
        public Guid NewRoomId { get; set; }

       
        public List<SelectListItem> Rooms { get; set; } = new List<SelectListItem>();


    }
}
