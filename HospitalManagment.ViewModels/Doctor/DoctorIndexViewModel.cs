using DoctorModel = HospitalManagmentApp.DataModels.Doctor;

using HospitalManagmentApp.Services.AutoMapper;

namespace HospitalManagment.ViewModels.Doctor
{
    public class DoctorIndexViewModel : IMapFrom<DoctorModel>
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string DepartmentName { get; set; } = null!;
        public string Specialty { get; set; } = null!;


    }
}
