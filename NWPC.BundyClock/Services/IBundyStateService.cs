namespace NWPC.BundyClock.Services
{
    public interface IBundyStateService
    {
        string BundyType { get; set; }
        string CurrentDate { get; set; }
        string CurrentTime { get; set; }
        string EmployeeName { get; set; }
        int EmployeeID { get; set; }
        byte[] EmployeePhoto { get; set; }
    }

}
