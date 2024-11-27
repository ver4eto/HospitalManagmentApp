

using DoctorModel= HospitalManagmentApp.DataModels.Doctor;
using HospitalManagmentApp.Services.Mapping;
using System.ComponentModel.DataAnnotations;
using static HospitalManagmentApp.Common.ApplicationConstants;
using static HospitalManagmentApp.Common.EntityValidationConstants.Doctor;
using AutoMapper;
using Microsoft.Extensions.Configuration;

namespace HospitalManagment.ViewModels.Doctor
{
    public class AddDoctorViewModel : IMapTo<DoctorModel>,IHaveCustomMappings
    {
        [Required(ErrorMessage =RequiredErrorMessage)]
        [Length(LastNameMinLenght,LastNameMaxLenght,ErrorMessage =LenghtErrorMessage)]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Length(FirstNameMinLenght, FirstNameMaxLenght, ErrorMessage = LenghtErrorMessage)]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Length(SpecialtyMinLenght,SpecialtyMaxLenght,ErrorMessage =LenghtErrorMessage)]
        public string Specialty { get; set; } = SpecialtyDefaultValue;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [EmailAddress]       
        public string EmailAddress { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(1.0d, double.MaxValue,ErrorMessage =SalaryMinValueErrorMessage)]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public Guid DepartmentId { get; set; }
        public ICollection<HospitalManagmentApp.DataModels.Department> Departents { get; set; }=new List<HospitalManagmentApp.DataModels.Department>();

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration
        .CreateMap<AddDoctorViewModel, DoctorModel>()
        .ForMember(d => d.DepartmentId, x => x.MapFrom(s => s.DepartmentId));
        }
    }
}
