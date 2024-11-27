using AutoMapper;
using HospitalManagmentApp.Services.Mapping;
using System.ComponentModel.DataAnnotations;
using static HospitalManagmentApp.Common.ApplicationConstants;
using static HospitalManagmentApp.Common.EntityValidationConstants.Doctor;
using DoctorModel = HospitalManagmentApp.DataModels.Doctor;

namespace HospitalManagment.ViewModels.Doctor
{
    public class EditDoctorViewModel : IMapTo<DoctorModel>,IHaveCustomMappings
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Length(LastNameMinLenght, LastNameMaxLenght, ErrorMessage = LenghtErrorMessage)]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Length(FirstNameMinLenght, FirstNameMaxLenght, ErrorMessage = LenghtErrorMessage)]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Length(SpecialtyMinLenght, SpecialtyMaxLenght, ErrorMessage = LenghtErrorMessage)]
        public string Specialty { get; set; } = SpecialtyDefaultValue;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [EmailAddress]
        public string EmailAddress { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(1.0d, double.MaxValue, ErrorMessage = SalaryMinValueErrorMessage)]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public IEnumerable<HospitalManagmentApp.DataModels.Department> Departments { get; set; } =new List<HospitalManagmentApp.DataModels.Department>();

        [Required(ErrorMessage = RequiredErrorMessage)]
        public Guid DepartmentId { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        public void CreateMappings(IProfileExpression configuartion)
        {
            configuartion
                 .CreateMap<EditDoctorViewModel, DoctorModel>()
                 .ForMember(d => d.DepartmentId, x => x.MapFrom(s => s.DepartmentId));

            //configuartion
            //     .CreateMap<EditDoctorViewModel, DoctorModel>()
            //     .ForMember(d => d.UserId, x => x.MapFrom(s => s.EmailAddress));

        }
    }
}
