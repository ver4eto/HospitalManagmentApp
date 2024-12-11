namespace HospitalManagment.ViewModels.Patient
{
    public  class PatientMedicalInfoViewModel
    {
        public Guid PatientId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string DepartmentName { get; set; } = null!;
        
        public List<string> Treatments { get; set; } = new List<string>();
    }
}
