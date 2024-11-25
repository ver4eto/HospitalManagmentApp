using AutoMapper;

namespace HospitalManagmentApp.Services.Mapping
{
    public  interface IHaveCustomMappings
    { 
        void CreateMappings(IProfileExpression configuartion);
    }
}
