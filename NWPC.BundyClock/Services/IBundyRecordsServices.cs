using NWPC.BundyClock.Data;
using NWPC.BundyClock.Entity;

namespace NWPC.BundyClock.Services
{
    public interface IBundyRecordsService
    {
        Task<List<BundyRecord>> GetAllBundyRecordsAsync();
    }
}
