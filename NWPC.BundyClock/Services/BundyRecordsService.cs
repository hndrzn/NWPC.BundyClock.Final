using Microsoft.EntityFrameworkCore;
using NWPC.BundyClock.Data;
using NWPC.BundyClock.Entity;

namespace NWPC.BundyClock.Services
{
    public class BundyRecordsService : IBundyRecordsService
    {
        private readonly DataContext _context;

        public BundyRecordsService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<BundyRecord>> GetAllBundyRecordsAsync()
        {
            var records = await _context.AllBundyRecords.ToListAsync();
            return records;
        }
    }
}
