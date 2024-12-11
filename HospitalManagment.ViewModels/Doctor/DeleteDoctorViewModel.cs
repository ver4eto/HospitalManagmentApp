using HospitalManagmentApp.Services.AutoMapper;
using DoctorModel = HospitalManagmentApp.DataModels.Doctor;

namespace HospitalManagment.ViewModels.Doctor
{
    public class DeleteDoctorViewModel : IMapFrom<DoctorModel>
    {
        public Guid Id { get; set; }
            
        public string LastName { get; set; } = null!;

       
        public string FirstName { get; set; } = null!;

       
        public string Specialty { get; set; } =null!;

        public string? DepartmentName { get; set; }
        public string UserId { get; set; } = null!;
    }
}
