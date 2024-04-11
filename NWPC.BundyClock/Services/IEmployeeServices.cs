using NWPC.BundyClock.Entity;

namespace NWPC.BundyClock.Services
{
    public interface IEmployeeServices
    {
        Task<List<EmployeeData>> GetAllEmployees();
    }
}
