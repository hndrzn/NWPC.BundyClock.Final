using Microsoft.EntityFrameworkCore;
using NWPC.BundyClock.Data;
using NWPC.BundyClock.Entity;

namespace NWPC.BundyClock.Services
{
    public class EmployeeService : IEmployeeServices
    {
        private readonly DataContext _context;
        public EmployeeService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<EmployeeData>> GetAllEmployees()
        {
            var employees = await _context.Employees.ToListAsync();
            return employees;
        }

        public List<EmployeeData> SearchEmployee()
        {
            return _context.Employees.ToList();
        }
    }
}
