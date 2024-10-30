
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentApp.Common
{
    public static class EntityValidationConstants
    {
        public static class Patient
        {
            public const int FirstNameMinLenght = 2;
            public const int FirstNameMaxLenght = 50;

            public const int LastNameMinLenght = 4;
            public const int LastNameMaxLenght = 50;

            public const int AdressMinLength = 10;
            public const int AdressMaxLength = 100;

            public const int PhoneMinLenght = 5;
            public const int PhoneMaxLenght = 15;
            public const string PhoneDefaultValue = "No phone";

            public const int EGNLenght = 10;
            public const string EGNDefault = "1111111111";


        }

        public static class Doctor
        {
            public const int FirstNameMaxLenght = 50;
            public const int FirstNameMinLenght = 2;

            public const int SpecialtyMaxLenght = 50;
            public const int SpecialtyMinLenght = 5;


            public const string SpecialtyDefaultValue = "Resident";

        }

        public static class Room
        {
            public const int MinBedCount = 1;
            public const int MaxBedCount = 4;
        }

        public static class Department
        {

            public const int DepartmentMinLength = 5;
            public const int DepartmentMaxLength = 60;
        }

        public static class Nurse
        {
            public const int NurseFirstNameMinLength = 2;
            public const int NurseFirstNameMaxLength = 50;

            public const int NurseLastNameMinLength = 2;
            public const int NurseLastNameMaxLength = 50;
        }

        public static class Treatment
        {
            public const int TreatmentMinLength = 2;
            public const int TreatmentMaxLength = 30;
        }
    }
}
