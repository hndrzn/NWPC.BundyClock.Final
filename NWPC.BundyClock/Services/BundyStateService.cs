using NWPC.BundyClock.Services;
public class BundyStateService : IBundyStateService
{
    public string BundyType { get; set; }
    public string CurrentDate { get; set; }
    public string CurrentTime { get; set; }
    public string EmployeeName { get; set; }
    public int EmployeeID { get; set; }
    public byte[] EmployeePhoto { get; set; }
}