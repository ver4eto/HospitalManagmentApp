namespace HospitalManagment.ViewModels.Manager
{
    public class ManagerIndexViewModel
    {
        public List<ReportButtonViewModel> ReportButtons { get; set; } = new List<ReportButtonViewModel>();
    }

    public class ReportButtonViewModel
    {
        public string Title { get; set; } = null!; // Button title (e.g., "Department Reports")
        public string ActionName { get; set; } = null!; // Corresponding action in the controller
        public string CssClass { get; set; } = "btn-primary btn-lg btn-block"; // Default CSS classes for styling
    }

    //public class ManagerIndexViewModel
    //{
    //    // Sector Overview
    //    public SectorOverviewViewModel PatientsOverview { get; set; } = null!;
    //    public SectorOverviewViewModel NursesOverview { get; set; }=null!;
    //    public SectorOverviewViewModel DepartmentsOverview { get; set; } = null!;

    //    // Departments Details
    //    public List<DepartmentDetailsViewModel> Departments { get; set; } = new List<DepartmentDetailsViewModel>();
    //}

    //public class SectorOverviewViewModel
    //{
    //    public string Name { get; set; } = null!;
    //    public int Count { get; set; }
    //}

    //public class DepartmentDetailsViewModel
    //{
    //    public string DepartmentName { get; set; } = null!;
    //    public int PatientCount { get; set; } // Total patients in the department
    //    public decimal TotalExpenses { get; set; } // Total salary + treatments cost
    //    public List<PatientDetailsViewModel> Patients { get; set; } = new List<PatientDetailsViewModel>();
    //}

    //public class PatientDetailsViewModel
    //{
    //    public Guid PatientId { get; set; }
    //    public string Name { get; set; } = null!;
    //    public decimal TreatmentCosts { get; set; } // Total treatment expenses for the patient
    //}

}
