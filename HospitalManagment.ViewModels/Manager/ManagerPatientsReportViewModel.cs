namespace HospitalManagment.ViewModels.Manager
{
    public class ManagerPatientsReportViewModel
    {
        public int TotalPatients { get; set; }
        public string AveragePatientsPerDepartment { get; set; } = null!;
        public List<DepartmentPatientsViewModel> Departments { get; set; } = new List<DepartmentPatientsViewModel>();

        public class DepartmentPatientsViewModel
        {
            public Guid DepartmentId { get; set; }
            public string DepartmentName { get; set; } = null!;
            public int PatientCount { get; set; }
        }
    }

   

}
