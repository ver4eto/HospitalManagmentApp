using AutoMapper;
using HospitalManagmentApp.Services.AutoMapper;
using HospitalManagmentApp.Services.Mapping;
using static HospitalManagmentApp.Common.EntityValidationConstants.Doctor;
using DoctorModel = HospitalManagmentApp.DataModels.Doctor;

namespace HospitalManagment.ViewModels.Doctor
{
    public class MenageDoctorViewModel: IMapFrom<DoctorModel>,IHaveCustomMappings
    {
        public Guid Id { get; set; }

       
        public string LastName { get; set; } = null!;

       
        public string FirstName { get; set; } = null!;

       
        public string Specialty { get; set; } = SpecialtyDefaultValue;

       
        public string EmailAddress { get; set; } = null!;

       
        public decimal Salary { get; set; }

       
        public string DepartmentName { get; set; } = null!;

        public string UserId { get; set; } = null!;

        public void CreateMappings(IProfileExpression configuartion)
        {
            configuartion
                 .CreateMap<DoctorModel, MenageDoctorViewModel>()
                 .ForMember(d => d.DepartmentName, x => x.MapFrom(s => s.Department.Name));
        }
    }
}
