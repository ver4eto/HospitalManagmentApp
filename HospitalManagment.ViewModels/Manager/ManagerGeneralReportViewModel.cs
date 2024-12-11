namespace HospitalManagment.ViewModels.Manager
{
    public class ManagerGeneralReportViewModel
    {
        public int TotalEmployees { get; set; } 
        public string TotalExpenses { get; set; } = null!; 
        public string AverageExpensePerEmployee { get; set; } = null!; 
    }
}
