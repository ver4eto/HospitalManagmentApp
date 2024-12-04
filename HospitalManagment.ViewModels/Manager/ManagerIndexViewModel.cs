namespace HospitalManagment.ViewModels.Manager
{
    public class ManagerIndexViewModel
    {
        public List<ReportButtonViewModel> ReportButtons { get; set; } = new List<ReportButtonViewModel>();
    }

    public class ReportButtonViewModel
    {
        public string Title { get; set; } = null!; 
        public string ActionName { get; set; } = null!;
        public string CssClass { get; set; } = "btn-primary btn-lg btn-block"; 
    }

   

}
