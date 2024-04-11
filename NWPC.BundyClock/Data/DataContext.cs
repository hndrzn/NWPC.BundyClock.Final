using Microsoft.EntityFrameworkCore;
using NWPC.BundyClock.Entity;

namespace NWPC.BundyClock.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<EmployeeData> Employees { get; set; }
        public DbSet<BundyRecord> AllBundyRecords { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeData>()
                .Property(e => e.EmployeePhoto)
                .HasColumnType("varbinary(max)");
        }
    }
}
